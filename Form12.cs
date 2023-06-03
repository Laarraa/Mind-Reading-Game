using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindReadingGame
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }



        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void avsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
