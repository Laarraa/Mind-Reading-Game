
namespace MindReadingGame
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.start = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.Fråga = new System.Windows.Forms.Label();
            this.buttonSmiley = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(168, 275);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 80);
            this.start.TabIndex = 33;
            this.start.Text = "Starta";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // avsluta
            // 
            this.avsluta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.avsluta.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsluta.Location = new System.Drawing.Point(396, 275);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(190, 80);
            this.avsluta.TabIndex = 32;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = false;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // Fråga
            // 
            this.Fråga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fråga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fråga.Location = new System.Drawing.Point(-11, 368);
            this.Fråga.Name = "Fråga";
            this.Fråga.Size = new System.Drawing.Size(822, 60);
            this.Fråga.TabIndex = 31;
            this.Fråga.Text = "Detta är din bild!";
            this.Fråga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSmiley
            // 
            this.buttonSmiley.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSmiley.BackgroundImage")));
            this.buttonSmiley.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSmiley.Location = new System.Drawing.Point(265, 22);
            this.buttonSmiley.Name = "buttonSmiley";
            this.buttonSmiley.Size = new System.Drawing.Size(230, 230);
            this.buttonSmiley.TabIndex = 30;
            this.buttonSmiley.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.Fråga);
            this.Controls.Add(this.buttonSmiley);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.Label Fråga;
        private System.Windows.Forms.Button buttonSmiley;
    }
}