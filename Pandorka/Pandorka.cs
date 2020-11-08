using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandorka
{
    public partial class Pandorka : Form
    {
        public Pandorka()
        {
            InitializeComponent();
        }

        private void FolderWithGamesTextBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderWithGamesTextBox.Text = fbd.SelectedPath;
            }
        }

        private void DestinationFolderTextBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DestinationFolderTextBox.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FolderWithGamesTextBox.Text) || string.IsNullOrEmpty(DestinationFolderTextBox.Text)) {
                MessageBox.Show("Choose all path!");
                return;
            }

        }
    }
}
