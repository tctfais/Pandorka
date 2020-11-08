using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandorka
{
    public partial class Pandorka : Form
    {
        readonly string Template = @"<game emulator={type}>
<information>
<description>{description}</description>
<genre>1</genre>
</information>
<file>
<rom name ={romName}/>
</file>
<translation>
<string language={language}>
<name>{gameName}</name>
</string>
</translation>
<config>
<load_time>0</load_time>
<free_play>1</free_play>
<save_state>1</save_state>
<start_directly>1</start_directly>
</config>
</game>";

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
            DoButton.Enabled = false;
            if (string.IsNullOrEmpty(FolderWithGamesTextBox.Text) || string.IsNullOrEmpty(DestinationFolderTextBox.Text)
                    || string.IsNullOrEmpty(GameTypeComboBox.Text)) {
                MessageBox.Show("Choose all path!", "Error application execute!");
                DoButton.Enabled = true;
                return;
            }

            string masterGameFolder = DestinationFolderTextBox.Text + @"\mcgames";
            
            Directory.CreateDirectory(masterGameFolder);

            var folderWithGames = new DirectoryInfo(FolderWithGamesTextBox.Text);

            foreach (FileInfo gameFile in folderWithGames.GetFiles())
            {
                var templateXml = Template;
                string fileNameClear = Path.GetFileNameWithoutExtension(gameFile.Name.Replace(" ", ""));
                string fileName = Path.GetFileNameWithoutExtension(gameFile.Name);
                string pathGame = masterGameFolder + @"\" + fileNameClear;
                string fileGameFull = pathGame + @"\" + fileNameClear;
                Directory.CreateDirectory(pathGame);
                File.Copy(gameFile.FullName, pathGame + @"\" + gameFile.Name.Replace(" ", ""), true);
                templateXml = templateXml.Replace("{description}", "\"" + fileName + "\"");
                templateXml = templateXml.Replace("{romName}", "\"" + gameFile.Name.Replace(" ","") + "\"");
                templateXml = templateXml.Replace("{type}", "\"15\"");
                templateXml = templateXml.Replace("{language}", "\"en\"");
                templateXml = templateXml.Replace("{gameName}", "\"" + fileName + "\"");
                

                using (StreamWriter swXml = new StreamWriter(fileGameFull + ".xml", false, System.Text.Encoding.Default))
                {
                    swXml.WriteLine(templateXml);
                }
                
                using (StreamWriter swXml = new StreamWriter(masterGameFolder + @"\" + "install.txt", true, System.Text.Encoding.Default))
                {
                    swXml.WriteLine(fileNameClear);
                }

            }
            MessageBox.Show("Finish! And now you must convert usb-flash to exFat (32kb) and copy msgames directory!", "Done!");
            DoButton.Enabled = true;
        }
    }
}
