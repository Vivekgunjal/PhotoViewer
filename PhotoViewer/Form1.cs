using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoViewer
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentImageIndex;
        private Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imageFiles = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".gif") || s.EndsWith(".bmp"))
                    .ToArray();
                currentImageIndex = 0;
                LoadImage(currentImageIndex);
            }
        }
        private void LoadImage(int index)
        {
            try
            {
                originalImage = new Bitmap(Image.FromFile(imageFiles[index]));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Image.FromFile(imageFiles[index]);
                this.Text = "Photo Viewer - " + Path.GetFileName(imageFiles[index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }


        private void Previous_Click(object sender, EventArgs e)
        {
            if (imageFiles == null)
            {
                MessageBox.Show("Please select a folder of images first.");
                return;
            }
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                LoadImage(currentImageIndex);
                Next.Enabled = true;
            }
            if (currentImageIndex == 0)
            {
                Previous.Enabled = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (imageFiles == null)
            {
                MessageBox.Show("Please select a folder of images first.");
                return;
            }

            if (currentImageIndex < imageFiles.Length - 1)
            {
                currentImageIndex++;
                LoadImage(currentImageIndex);
                Previous.Enabled = true;
            }
            if (currentImageIndex == imageFiles.Length - 1)
            {
                Next.Enabled = false;
            }
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            imageFiles = null;
            currentImageIndex = 0;
            this.Text = "Photo Viewer";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RotateRight_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No image loaded.");
                return;
            }

            originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Image = originalImage;
        }

        private void RotateLeft_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No image loaded.");
                return;
            }

            originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Image = originalImage;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No image loaded.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|BMP files (*.bmp)|*.bmp";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;
                switch (Path.GetExtension(saveFileDialog.FileName).ToLower())
                {
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        MessageBox.Show("Invalid file type selected.");
                        return;
                }

                originalImage.Save(saveFileDialog.FileName, format);
                MessageBox.Show("Image saved successfully.");
            }
        }

    }
}
