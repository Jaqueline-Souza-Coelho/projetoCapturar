using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintScreenCSharp
{
    public partial class frmCaptura : Form
    {
        public frmCaptura()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            var path = "C:\\PrintScreen";

            var resultado = CapturarTela(path);

            if (resultado != "")
                MessageBox.Show("Tela capturada em " + resultado);
            else
                MessageBox.Show("Não foi possível capturar a tela");
        }

        private string CapturarTela(string path)
        {
            try
            {
                var computadorTela = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                var arquivoDestino = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                var arq = Graphics.FromImage(arquivoDestino);

                arq.CopyFromScreen(new Point(0, 0), new Point(0, 0), computadorTela);

                var nomeArquivo = path + "\\" + DateTime.Now.ToString().Replace(" ", "_").Replace("/", "").Replace(":", "") + ".png";
                arquivoDestino.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Png);

                return nomeArquivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);

                return "";
            }

        }

        private void btnCapturarForm_Click(object sender, EventArgs e)
        {
            var path = "C:\\PrintScreen";

            var resultado = CapturarForm(path, this);

            if (resultado != "")
                MessageBox.Show("Formulário capturada em " + resultado);
            else
                MessageBox.Show("Não foi possível capturar o formulário");
        }

        private string CapturarForm(string path, frmCaptura form)
        {
            try
            {
                var nomeArquivo = path + "\\" + DateTime.Now.ToString().Replace(" ", "_").Replace("/", "").Replace(":", "") + ".png";
                
                using (var bmp = new Bitmap(form.Width,form.Height))
                {
                    form.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(nomeArquivo);
                }
                return nomeArquivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
                return "";
            }

        }
    }
}
