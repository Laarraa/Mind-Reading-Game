
namespace MindReadingGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Fråga = new System.Windows.Forms.Label();
            this.Nej = new System.Windows.Forms.Button();
            this.Ja = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonSmiley = new System.Windows.Forms.Button();
            this.buttonStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fråga
            // 
            this.Fråga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fråga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fråga.Location = new System.Drawing.Point(-11, 358);
            this.Fråga.Name = "Fråga";
            this.Fråga.Size = new System.Drawing.Size(822, 60);
            this.Fråga.TabIndex = 22;
            this.Fråga.Text = "Finns bilden här?";
            this.Fråga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nej
            // 
            this.Nej.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Nej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nej.Location = new System.Drawing.Point(452, 277);
            this.Nej.Name = "Nej";
            this.Nej.Size = new System.Drawing.Size(190, 60);
            this.Nej.TabIndex = 21;
            this.Nej.Text = "Nej";
            this.Nej.UseVisualStyleBackColor = false;
            this.Nej.Click += new System.EventHandler(this.Nej_Click);
            // 
            // Ja
            // 
            this.Ja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ja.Location = new System.Drawing.Point(137, 277);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(190, 60);
            this.Ja.TabIndex = 20;
            this.Ja.Text = "Ja";
            this.Ja.UseVisualStyleBackColor = false;
            this.Ja.Click += new System.EventHandler(this.Ja_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPurple.BackgroundImage")));
            this.buttonPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPurple.Location = new System.Drawing.Point(527, 32);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(200, 200);
            this.buttonPurple.TabIndex = 19;
            this.buttonPurple.UseVisualStyleBackColor = true;
            // 
            // buttonSmiley
            // 
            this.buttonSmiley.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSmiley.BackgroundImage")));
            this.buttonSmiley.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSmiley.Location = new System.Drawing.Point(288, 32);
            this.buttonSmiley.Name = "buttonSmiley";
            this.buttonSmiley.Size = new System.Drawing.Size(200, 200);
            this.buttonSmiley.TabIndex = 18;
            this.buttonSmiley.UseVisualStyleBackColor = true;
            // 
            // buttonStation
            // 
            this.buttonStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStation.BackgroundImage")));
            this.buttonStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStation.Location = new System.Drawing.Point(57, 32);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.Size = new System.Drawing.Size(200, 200);
            this.buttonStation.TabIndex = 17;
            this.buttonStation.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fråga);
            this.Controls.Add(this.Nej);
            this.Controls.Add(this.Ja);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonSmiley);
            this.Controls.Add(this.buttonStation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Fråga;
        private System.Windows.Forms.Button Nej;
        private System.Windows.Forms.Button Ja;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonSmiley;
        private System.Windows.Forms.Button buttonStation;
    }
}