using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace NeonQRGenerator
{
    public partial class Form1 : Form
    {
        Bitmap qrImage;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Neon QR Generator";
            this.BackColor = Color.FromArgb(3, 19, 42);

            buttonGenerate.BackColor = Color.FromArgb(57, 255, 20);
            buttonGenerate.ForeColor = Color.FromArgb(0, 17, 34);

            buttonSave.BackColor = Color.FromArgb(7, 32, 58);
            buttonSave.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            textBoxInput.BackColor = Color.FromArgb(7, 32, 58);
            textBoxInput.ForeColor = Color.White;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string data = textBoxInput.Text.Trim();
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Bitte gib Text oder eine URL ein.");
                return;
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrImage = qrCode.GetGraphic(10, Color.FromArgb(57, 255, 20), Color.FromArgb(3, 19, 42), true);
            pictureBoxPreview.Image = qrImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (qrImage == null)
            {
                MessageBox.Show("Erzeuge zuerst einen QR-Code.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG (*.png)|*.png|JPEG (*.jpg)|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    qrImage.Save(sfd.FileName);
                    MessageBox.Show("QR-Code gespeichert:\n" + sfd.FileName);
                }
            }
        }
    }
}
