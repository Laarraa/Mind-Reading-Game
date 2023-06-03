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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().ShowDialog();
        }
        private void Nej_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form9().ShowDialog();
        }

        private void Fråga_Click(object sender, EventArgs e)
        {

        }


        private void buttonFlowers_Click(object sender, EventArgs e)
        {

        }
    }
}
