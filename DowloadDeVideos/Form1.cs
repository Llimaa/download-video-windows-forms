using System.IO;
using VideoLibrary;
using System.Windows.Forms;

namespace DowloadDeVideos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndownload_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var video = YouTube.Default.GetVideo(txtUrl.Text);
                LblStatus.Visible = true;
                LblStatus.Text = "Baixando...";

                LblStatus.Visible = true;
                LblStatus.Text = "Baixando....";
                File.WriteAllBytes(dialog.SelectedPath + "/" + video.FullName, video.GetBytes());
                Path.ChangeExtension(dialog.SelectedPath + video.FullName, ".mp4");
                 LblStatus.Text = "Concluido";

                ltbArquivos.Items.Add(dialog.SelectedPath + "/" + video.FullName);
            }
         
        }
    }
}
