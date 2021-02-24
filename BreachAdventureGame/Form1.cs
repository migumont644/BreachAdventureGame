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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) {scene = 1;}
                else if (scene == 1) {scene = 3;}
                if (scene == 2)
                {
                    //70% of scene 7, 30% of scene 2
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 7) { scene = 5; }
                    else { scene = 6; }
                }
                 else if (scene == 6) { scene = 9; }
                 else if (scene == 3) {scene = 7;}
                 else if (scene == 8) {scene = 11;}
                 else if (scene == 9) {scene = 12;}
                // else if (scene == 6) {scene = 0;}
                // else if (scene == 7) { }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) {scene = 2;}
                else if (scene == 1) {scene = 4;}
                else if (scene == 2) {scene = 1;}
                else if (scene == 6) {scene = 10;}
                else if (scene == 3) {scene = 8;}
                else if (scene == 8) {scene = 14;}
                else if (scene == 9) {scene = 13;}
               // else if (scene == 7) {scene = 99;}
            }
            else if (e.KeyCode == Keys.Space)  //green button press
            {
               // if (scene == 0) { scene = 2; }
               // else if (scene == 1) { scene = 4; }
              //  else if (scene == 2) { scene = 1; }
              //  else if (scene == 6) { scene = 10; }
              //  else if (scene == 3) { scene = 8; }
              //  else if (scene == 8) { scene = 14; }
              //  else if (scene == 9) { scene = 13; }
                // else if (scene == 7) {scene = 99;}
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                  //  sceneImage.BackgroundImage = Properties.Resources.deepBrush;
                  //  sceneSound = new SoundPlayer(Properties.Resources.jungle);
                  //  sceneSound.Play();

                    outputLabel.Text = "You are a test subject in an underground facility. The facility is currently having a containment breach. You must escape!";
                    redLabel.Text = "Left wing";
                    blueLabel.Text = "Right wing";
                    greenLabel.Text = "";
                    break;
                case 1:
                  //  sceneImage.BackgroundImage = Properties.Resources.forestLake;
                  //  sceneSound = new SoundPlayer(Properties.Resources.brook);
                  //  sceneSound.Play();

                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "";
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
