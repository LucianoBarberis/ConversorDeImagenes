using ImageMagick;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        private string loadedImagePath = string.Empty;
        private string imageExtension = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.ico",
                Title = "Selecciona una imagen..."
            };
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadedImagePath = openFileDialog.FileName;
                    lblImgName.Text = Path.GetFileName(loadedImagePath);
                    pictureBox1.Image = Image.FromFile(loadedImagePath);
                    imageExtension = Path.GetExtension(loadedImagePath).ToLower();
                    btnConvertir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                loadedImagePath = string.Empty;
                lblImgName.Text = string.Empty;
                btnConvertir.Enabled = false;
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbOrigen.Enabled = false;
            switch (imageExtension.ToLower())
            {
                case ".png":
                    cbOrigen.SelectedIndex = 0;
                    break;
                case ".jpg":
                case ".jpeg":
                    cbOrigen.SelectedIndex = 1;
                    break;
                case ".gif":
                    cbOrigen.SelectedIndex = 3;
                    break;
                case ".ico":
                    cbOrigen.SelectedIndex = 4;
                    break;
                default:
                    cbOrigen.SelectedIndex = -1;
                    break;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedImagePath))
            {
                MessageBox.Show("Por favor, selecciona una imagen primero.");
                return;
            }

            if (cbFinal.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un formato de destino.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            string carpetaDestino = Path.Combine(rutaBase, "ImagenesConvertidas");

            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            string nombreArchivo = Path.GetFileNameWithoutExtension(loadedImagePath) + "." + cbFinal.Text.ToLower();

            string rutaFinalCompleta = Path.Combine(carpetaDestino, nombreArchivo);
            try
            {
                using (var image = new MagickImage(loadedImagePath))
                {
                    image.Write(rutaFinalCompleta);
                }

                MessageBox.Show("Imagen guardada en: " + rutaFinalCompleta, "Convercion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir: " + ex.Message);
            }

            cbOrigen.SelectedIndex = -1;
            cbFinal.SelectedIndex = -1;
            lblImgName.Text = string.Empty;
            pictureBox1.Image = null;
            loadedImagePath = string.Empty;
        }
    }
}
