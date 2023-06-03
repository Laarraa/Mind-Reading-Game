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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
        }

        private void Nej_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form7().ShowDialog();
        }
    }
}
