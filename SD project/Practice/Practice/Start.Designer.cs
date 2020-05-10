namespace Practice
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureLogIn = new System.Windows.Forms.PictureBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.signUp);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureLogIn);
            this.panel1.Controls.Add(this.LogIn);
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 591);
            this.panel1.TabIndex = 9;
            // 
            // signUp
            // 
            this.signUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUp.BackgroundImage")));
            this.signUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUp.Location = new System.Drawing.Point(593, 336);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(140, 43);
            this.signUp.TabIndex = 9;
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(593, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 121);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(328, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 80);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureLogIn
            // 
            this.pictureLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogIn.BackgroundImage")));
            this.pictureLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLogIn.Location = new System.Drawing.Point(206, 168);
            this.pictureLogIn.Name = "pictureLogIn";
            this.pictureLogIn.Size = new System.Drawing.Size(140, 121);
            this.pictureLogIn.TabIndex = 6;
            this.pictureLogIn.TabStop = false;
            // 
            // LogIn
            // 
            this.LogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogIn.BackgroundImage")));
            this.LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogIn.Location = new System.Drawing.Point(206, 335);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(140, 44);
            this.LogIn.TabIndex = 5;
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 631);
            this.Controls.Add(this.panel1);
            this.Name = "Start";
            this.Text = "Start";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureLogIn;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button signUp;
    }
}