
namespace MindReadingGame
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.buttonClouds = new System.Windows.Forms.Button();
            this.buttonJellyfish = new System.Windows.Forms.Button();
            this.Fråga = new System.Windows.Forms.Label();
            this.Nej = new System.Windows.Forms.Button();
            this.Ja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClouds
            // 
            this.buttonClouds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClouds.BackgroundImage")));
            this.buttonClouds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClouds.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClouds.Location = new System.Drawing.Point(452, 34);
            this.buttonClouds.Name = "buttonClouds";
            this.buttonClouds.Size = new System.Drawing.Size(200, 200);
            this.buttonClouds.TabIndex = 30;
            this.buttonClouds.UseVisualStyleBackColor = true;
            // 
            // buttonJellyfish
            // 
            this.buttonJellyfish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonJellyfish.BackgroundImage")));
            this.buttonJellyfish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJellyfish.Location = new System.Drawing.Point(137, 34);
            this.buttonJellyfish.Name = "buttonJellyfish";
            this.buttonJellyfish.Size = new System.Drawing.Size(200, 200);
            this.buttonJellyfish.TabIndex = 29;
            this.buttonJellyfish.UseVisualStyleBackColor = true;
            // 
            // Fråga
            // 
            this.Fråga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fråga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fråga.Location = new System.Drawing.Point(-11, 350);
            this.Fråga.Name = "Fråga";
            this.Fråga.Size = new System.Drawing.Size(822, 60);
            this.Fråga.TabIndex = 28;
            this.Fråga.Text = "Finns bilden här?";
            this.Fråga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fråga.Click += new System.EventHandler(this.Fråga_Click);
            // 
            // Nej
            // 
            this.Nej.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Nej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nej.Location = new System.Drawing.Point(452, 269);
            this.Nej.Name = "Nej";
            this.Nej.Size = new System.Drawing.Size(190, 60);
            this.Nej.TabIndex = 27;
            this.Nej.Text = "Nej";
            this.Nej.UseVisualStyleBackColor = false;
            this.Nej.Click += new System.EventHandler(this.Nej_Click);
            // 
            // Ja
            // 
            this.Ja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ja.Location = new System.Drawing.Point(137, 269);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(190, 60);
            this.Ja.TabIndex = 26;
            this.Ja.Text = "Ja";
            this.Ja.UseVisualStyleBackColor = false;
            this.Ja.Click += new System.EventHandler(this.Ja_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClouds);
            this.Controls.Add(this.buttonJellyfish);
            this.Controls.Add(this.Fråga);
            this.Controls.Add(this.Nej);
            this.Controls.Add(this.Ja);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClouds;
        private System.Windows.Forms.Button buttonJellyfish;
        private System.Windows.Forms.Label Fråga;
        private System.Windows.Forms.Button Nej;
        private System.Windows.Forms.Button Ja;
    }
}