using System;
using System.IO;
using System.Windows.Forms;

namespace SPTBackgroundManager
{
    public partial class BackgroundManager : Form
    {
        private readonly string _launcherBgPath = $@"{AppContext.BaseDirectory}Aki_Data\Launcher\Image_Cache";
        private readonly string _serverBgPath = $@"{AppContext.BaseDirectory}Aki_Data\Server\images\launcher";
        
        public BackgroundManager()
        {
            InitializeComponent();
        }

        private void btn_setLauncher_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "PNG Files (*.png) |*.png";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo newPic = new FileInfo(ofd.FileName);
                if (!File.Exists($@"{_launcherBgPath}\bg.png.default"))
                {
                    FileInfo oldPic = new FileInfo($@"{_launcherBgPath}\bg.png");
                    oldPic.CopyTo($@"{_launcherBgPath}\bg.png.default");
                }

                if (File.Exists($@"{_launcherBgPath}\bg.png"))
                {
                    File.Delete($@"{_launcherBgPath}\bg.png");
                }

                newPic.CopyTo($@"{_launcherBgPath}\bg.png");

                MessageBox.Show($"Set new launcher background to `{newPic.Name}`!", "Successful!", MessageBoxButtons.OK);
            }
        }

        private void btn_setServer_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "PNG Files (*.png) |*.png";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo newPic = new FileInfo(ofd.FileName);
                if (!File.Exists($@"{_serverBgPath}\bg.png.default"))
                {
                    FileInfo oldPic = new FileInfo($@"{_serverBgPath}\bg.png");
                    oldPic.CopyTo($@"{_serverBgPath}\bg.png.default");
                }

                if (File.Exists($@"{_serverBgPath}\bg.png"))
                {
                    File.Delete($@"{_serverBgPath}\bg.png");
                }

                newPic.CopyTo($@"{_serverBgPath}\bg.png");

                MessageBox.Show($"Set new server background to `{newPic.Name}`!", "Successful!", MessageBoxButtons.OK);
            }
        }

        private void btn_revert_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"{_launcherBgPath}\bg.png")) 
            {
                File.Delete($@"{_launcherBgPath}\bg.png");
            }

            if (File.Exists($@"{_serverBgPath}\bg.png")) 
            {
                File.Delete($@"{_serverBgPath}\bg.png");
            }
            
            if (!File.Exists($@"{_serverBgPath}\bg.png.default") || !File.Exists($@"{_launcherBgPath}\bg.png.default"))
            {
                MessageBox.Show($"Stoopid.", "GG Idiot", MessageBoxButtons.OK);
            }
            
            FileInfo oldLauncher = new FileInfo($@"{_launcherBgPath}\bg.png.default");
            oldLauncher.CopyTo($@"{_launcherBgPath}\bg.png");
            FileInfo oldServer = new FileInfo($@"{_serverBgPath}\bg.png.default");
            oldServer.CopyTo($@"{_serverBgPath}\bg.png");

            MessageBox.Show($"Set backgrounds to the default!", "Successful!", MessageBoxButtons.OK);
        }
    }
}