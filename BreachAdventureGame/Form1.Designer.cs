namespace BreachAdventureGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.greenImage = new System.Windows.Forms.PictureBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 74);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You are a test subject in an underground facility. The facility is currently havi" +
    "ng a containment breach. You must escape!";
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::BreachAdventureGame.Properties.Resources.Start;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sceneImage.Location = new System.Drawing.Point(15, 86);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(773, 239);
            this.sceneImage.TabIndex = 1;
            this.sceneImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = ((System.Drawing.Image)(resources.GetObject("redImage.Image")));
            this.redImage.InitialImage = null;
            this.redImage.Location = new System.Drawing.Point(15, 331);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(49, 51);
            this.redImage.TabIndex = 2;
            this.redImage.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.Image = ((System.Drawing.Image)(resources.GetObject("blueImage.Image")));
            this.blueImage.InitialImage = null;
            this.blueImage.Location = new System.Drawing.Point(15, 388);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(49, 51);
            this.blueImage.TabIndex = 3;
            this.blueImage.TabStop = false;
            // 
            // greenImage
            // 
            this.greenImage.Image = ((System.Drawing.Image)(resources.GetObject("greenImage.Image")));
            this.greenImage.InitialImage = null;
            this.greenImage.Location = new System.Drawing.Point(388, 352);
            this.greenImage.Name = "greenImage";
            this.greenImage.Size = new System.Drawing.Size(49, 51);
            this.greenImage.TabIndex = 4;
            this.greenImage.TabStop = false;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.redLabel.Location = new System.Drawing.Point(70, 352);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(293, 28);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Left wing";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.blueLabel.Location = new System.Drawing.Point(70, 407);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(312, 32);
            this.blueLabel.TabIndex = 6;
            this.blueLabel.Text = "Right wing";
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.greenLabel.Location = new System.Drawing.Point(443, 367);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(236, 26);
            this.greenLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.greenImage);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Breach";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.PictureBox greenImage;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
    }
}

