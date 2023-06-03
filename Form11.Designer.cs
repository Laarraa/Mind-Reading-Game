
namespace MindReadingGame
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.start = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.buttonJellyfish = new System.Windows.Forms.Button();
            this.Fråga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(146, 268);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 80);
            this.start.TabIndex = 44;
            this.start.Text = "Starta";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // avsluta
            // 
            this.avsluta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.avsluta.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsluta.Location = new System.Drawing.Point(374, 268);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(190, 80);
            this.avsluta.TabIndex = 43;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = false;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // buttonJellyfish
            // 
            this.buttonJellyfish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonJellyfish.BackgroundImage")));
            this.buttonJellyfish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJellyfish.Location = new System.Drawing.Point(238, 22);
            this.buttonJellyfish.Name = "buttonJellyfish";
            this.buttonJellyfish.Size = new System.Drawing.Size(230, 230);
            this.buttonJellyfish.TabIndex = 42;
            this.buttonJellyfish.UseVisualStyleBackColor = true;
            // 
            // Fråga
            // 
            this.Fråga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fråga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fråga.Location = new System.Drawing.Point(-11, 359);
            this.Fråga.Name = "Fråga";
            this.Fråga.Size = new System.Drawing.Size(822, 60);
            this.Fråga.TabIndex = 41;
            this.Fråga.Text = "Detta är din bild!";
            this.Fråga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.buttonJellyfish);
            this.Controls.Add(this.Fråga);
            this.Name = "Form11";
            this.Text = "Detta är din bild!";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.Button buttonJellyfish;
        private System.Windows.Forms.Label Fråga;
    }
}