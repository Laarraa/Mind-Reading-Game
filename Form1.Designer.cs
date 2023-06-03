
namespace MindReadingGame
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
            this.start = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.avsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(185, 285);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 115);
            this.start.TabIndex = 12;
            this.start.Text = "Starta";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // textInfo
            // 
            this.textInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInfo.Location = new System.Drawing.Point(145, 109);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(510, 161);
            this.textInfo.TabIndex = 11;
            this.textInfo.Text = "Välkommen till mitt tankeläsningsspel! \r\nEfter du har tryckt på start knappen kom" +
    "mer du få välja ett kort. \r\nEfter det kommer mitt spel komma på vilket kort du v" +
    "alt.\r\n\r\nHa så roligt! :-)\r\n\r\n";
            this.textInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(278, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(250, 42);
            this.title.TabIndex = 10;
            this.title.Text = "Tankeläsningsspel";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // avsluta
            // 
            this.avsluta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.avsluta.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avsluta.Location = new System.Drawing.Point(425, 285);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(190, 115);
            this.avsluta.TabIndex = 9;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = false;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.avsluta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label textInfo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button avsluta;
    }
}

