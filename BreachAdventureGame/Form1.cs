using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace BreachAdventureGame
{
    public partial class Form1 : Form
    {
        int scene = 0;

        SoundPlayer sceneSound;
 
        public Form1()
        {
            InitializeComponent();
            sceneSound = new SoundPlayer(Properties.Resources.alarm2);
            sceneSound.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 1; }             
                else if (scene == 2)
                {
                    //70% of scene 7, 30% of scene 2
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 7) { scene = 5; }
                    else { scene = 6; }
                }
                else if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 6)  { scene = 9; }
                else if (scene == 7) { scene = 0; }
                else if (scene == 8)  { scene = 11; }
                else if (scene == 9)  { scene = 12; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 20) { scene = 0; }
                else if (scene == 21) { scene = 0; }       
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)  { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 1; }
                else if (scene == 3) { scene = 8; }
                else if (scene == 4) { scene = 99; }
                else if (scene == 5) { scene = 99; }
                else if (scene == 6) { scene = 10; }
                else if (scene == 7) { scene = 99; }
                else if (scene == 8) { scene = 14; }
                else if (scene == 9) { scene = 13; }
                else if (scene == 11) { scene = 99; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 15) { scene = 99; }
               else if (scene == 14)
                {                
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 5) { scene = 17; }
                    else { scene = 18; }
                }
                else if (scene == 20) { scene = 99; }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 21) { scene = 99; }          
            }
            else if (e.KeyCode == Keys.Space)  //green button press
            {
                if (scene == 10) { scene = 14; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 19) { scene = 21; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  

                      sceneSound = new SoundPlayer(Properties.Resources.alarm2);
                      sceneSound.Play();

                    sceneImage.BackgroundImage = Properties.Resources.Start;
                    outputLabel.Text = "You are a test subject in an underground facility. The facility is currently having a containment breach. You must escape!";
                    redLabel.Text = "Left wing";
                    blueLabel.Text = "Right wing";
                    greenLabel.Text = "";
                    break;
                case 1:
                    sceneImage.BackgroundImage = Properties.Resources.storeroomCloset2;
                    sceneSound = new SoundPlayer(Properties.Resources.footsteps);
                    sceneSound.Play();
                    outputLabel.Text = "You walk into a room to see items on the shelves. You find a gas mask with a broken leds and a level two keycard. Which way you want to go?";
                    redLabel.Text = "Lockroom";
                    blueLabel.Text = "Checkpoint";
                    greenLabel.Text = "";
                    break;
                case 2:
                    sceneImage.BackgroundImage = Properties.Resources.lczTeslaGate;
                    outputLabel.Text = "You walk into a hallway with a weird looking gate. Its making electric sounds.";
                    redLabel.Text = "Take the risk to run though";
                    blueLabel.Text = "Go back to the other wing";
                    greenLabel.Text = "";
                    break;
                case 3:
                    sceneImage.BackgroundImage = Properties.Resources.lockroomInside;
                    sceneSound = new SoundPlayer(Properties.Resources.airLeaking);
                    sceneSound.Play();
                    sceneSound = new SoundPlayer(Properties.Resources.death);
                    sceneSound.Play();
                    outputLabel.Text = "You see that this room has a gas leak, but you hear crying at the corner of the room. You have to go though this room";
                    redLabel.Text = "Wear the broken gas mask";
                    blueLabel.Text = "Do not wear the broken gas mask";
                    greenLabel.Text = "";
                    break;
                case 4:
                    sceneImage.BackgroundImage = Properties.Resources.checkpointFlashingScreen;
                    sceneSound = new SoundPlayer(Properties.Resources.p90);
                    sceneSound.Play();
                    outputLabel.Text = "You go to see that the checkpoint is on lockdown. You can't open it with your keycard. Unfortunately a guard spotted you, shooting till you are dead. \"Agent G. to control. Eliminated a Class D escapee\" Do you want to try again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 5:
                    sceneImage.BackgroundImage = Properties.Resources.teslaShock;
                    outputLabel.Text = "You're not fast enough. You get shock and die instantly to the tesla gate. \"Subject D-9341 killed by the Tesla Gate at [REDACTED].\" Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 6:
                    sceneImage.BackgroundImage = Properties.Resources.storeroomCloset;
                    outputLabel.Text = "You made it past the tesla gate. That was a close one. You find yourself in room with items on the shelves.";
                    redLabel.Text = "Take the time to look for better loot";
                    blueLabel.Text = "Grab one item and go";
                    greenLabel.Text = "";
                    break;
                case 7:
                    sceneImage.BackgroundImage = Properties.Resources.scp096;
                    outputLabel.Text = "You put on the gas mask protecting you from the smoke. You walk in, and see the face of the crying creature. It become enrage and kills you. \"A large amount of blood found in [DATA REDACTED]. DNA identified as Subject D-9341. Most likely [DATA REDACTED] by SCP-096.\" Do you want to try again ? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 8:
                    sceneImage.BackgroundImage = Properties.Resources.smoke;
                    outputLabel.Text = "You hold your breath in, and blindly run in the room. The smoke is preventing you from opening your eyes. You run past the crying creature safe and sound. Where do you want to go next?";
                    redLabel.Text = "Checkpoint";
                    blueLabel.Text = "Room SCP 914";
                    greenLabel.Text = "";
                    break;
                case 9:
                    sceneImage.BackgroundImage = Properties.Resources.scp173;
                    outputLabel.Text = "Looks like taking the time to look pay off. You grab a level 2, and a document about SCP 914, but all of a sudden a peanut shape statue blocks your way. What do you do?";
                    redLabel.Text = "Blink";
                    blueLabel.Text = "Stare";
                    greenLabel.Text = "";
                    break;
                case 10:
                    sceneImage.BackgroundImage = Properties.Resources.levelTwo;
                    outputLabel.Text = "You grab a level 2 keycard and continue on not wanting to be caught.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Continue";
                    break;
                case 11:
                    sceneImage.BackgroundImage = Properties.Resources.checkpointFlashingScreen;
                    outputLabel.Text = "You go to see that the checkpoint is on lockdown. You can't open it with your keycard. Unfortunately a guard spotted you, shooting till you are dead. \"Agent G. to control. Eliminated a Class D escapee\" Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 12:
                    sceneImage.BackgroundImage = Properties.Resources.scp173Death;
                    outputLabel.Text = "You blink and the statue snaps your neck without realizing what happen. \"Subject D-9341: Fatal cervical fracture. Assumed to be attacked by SCP-173.\" Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 13:
                    sceneImage.BackgroundImage = Properties.Resources.doorClose;
                    outputLabel.Text = "You stare at the statue, walk past it and shut the door on it. You move on.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Continue";
                    break;
                case 14:
                    sceneImage.BackgroundImage = Properties.Resources.scp914;
                    outputLabel.Text = "As you continue to explore the facility you find a room label SCP - 914. It has a intake and output. You decide to place your keycard inside the machine. Which setting do you want it to set too?";
                    redLabel.Text = "Rough";
                    blueLabel.Text = "Very Fine";
                    greenLabel.Text = "Fine";
                    break;
                case 15:
                    sceneImage.BackgroundImage = Properties.Resources.dust;
                    outputLabel.Text = "Your keycard become to dust. You feel so disbelief. You didn't notices the statue snaps your neck behind you. \"Subject D-9341: Fatal cervical fracture. Assumed to be attacked by SCP-173.\" Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 16:
                    sceneImage.BackgroundImage = Properties.Resources.seniorScientist;
                    outputLabel.Text = "Your keycard becomes a level 3 keycard. You now feel competent to move past the checkpoint. To be continued. Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 17:
                    sceneImage.BackgroundImage = Properties.Resources.omniCard;
                    outputLabel.Text = "Your keycard become an Omni keycard! You can open any door in the facility! Do you want to nuke the facility, or escape? ";
                    redLabel.Text = "Nuke";
                    blueLabel.Text = "Escape";
                    greenLabel.Text = "";
                    break;
                case 18:
                    sceneImage.BackgroundImage = Properties.Resources.playingCard;
                    outputLabel.Text = "Your keycard becomes a playing card. You feel so disbelief, you didn't notices the statue snaps your neck behind you. \"Subject D-9341: Fatal cervical fracture. Assumed to be attacked by SCP-173.\" Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 19:
                    sceneImage.BackgroundImage = Properties.Resources.warhead;
                    outputLabel.Text = "A countdown starts as soon as you give access to active the nuke with your Omni keycard.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Continue";
                //    Thread.Sleep(2000);
                    break;
                case 20:
                    sceneImage.BackgroundImage = Properties.Resources.gateA;
                    outputLabel.Text = "You use your Omni keycard to grand items/firearms/scp objects to aid your escape. After some time you finally make it to the surface breathing in the fresh air. Nice job! Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 21:
                    sceneImage.BackgroundImage = Properties.Resources.nuke;
                    outputLabel.Text = "You died...The fate of the SCPS are unknown. Do you want to try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";

                    Refresh();

                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

    }
}
