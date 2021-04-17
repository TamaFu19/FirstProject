using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAMAFUV0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CompressImage(Image sourceImage, int imageQuality, string savePath)
        {
            try
            {
                //Codec bilgileri için boş bir ImageCodecInfo nesnesi oluşturuyoruz
                ImageCodecInfo jpegCodec = null;

                //Sıkıştırma için kalite  Ayarlıyoruz
                EncoderParameter imageQualitysParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, imageQuality);

                //Mevcut tüm kodekleri listeliyoruz(sistem genelinde)
                ImageCodecInfo[] allCodecs = ImageCodecInfo.GetImageEncoders();

                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;

                //JPEG codec bileşenini bulun ve seçiyoruz
                for (int i = 0; i < allCodecs.Length; i++)
                {
                    if (allCodecs[i].MimeType == "image/jpeg")
                    {
                        jpegCodec = allCodecs[i];
                        break;
                    }
                }

                //Sıkıştırılmış görüntüyü kaydediyoruz
                sourceImage.Save(savePath, jpegCodec, codecParameter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void btnyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçiniz.";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Png Images(*.png)|*.png";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";
            ofd.Filter += "|All(*.JPG, *.PNG, *.bmp)| *.JPG; *.PNG; *.bmp";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fotoUrltxt.Text = ofd.FileName;
                Image img = Image.FromFile(fotoUrltxt.Text);
                fotoPic.Image = img;
                fotoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (fotoUrltxt.Text == "")
            {
                MessageBox.Show("İlk önce Fotoraf Yükleyiniz!");
            }
            else if (fotoUrltxt.Text.Contains(".jpg"))
            {
                CompressImage(Image.FromFile(fotoUrltxt.Text), 30, fotoUrltxt.Text.Insert(fotoUrltxt.Text.Length - 4, " JPEG Sıkıştırılmış Resim"));
                MessageBox.Show("Fotorğraf Sıkıştırıldı!");
            }
            else
            {
                string x = fotoUrltxt.Text.Insert(fotoUrltxt.Text.Length - 4, " JPEG Sıkıştırılmış Resim");
                CompressImage(Image.FromFile(fotoUrltxt.Text), 30, fotoUrltxt.Text.Insert(fotoUrltxt.Text.Length - 4, " JPEG Sıkıştırılmış Resim").Substring(0, x.Length - 4) + ".jpg");
                MessageBox.Show("Fotorğraf Sıkıştırıldı!");
            }
        }
    }
}
