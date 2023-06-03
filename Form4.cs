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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().ShowDialog();
        }

        private void Nej_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6().ShowDialog();
        }
    }
}
