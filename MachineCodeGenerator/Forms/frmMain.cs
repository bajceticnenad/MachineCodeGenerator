using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QRCoder;

namespace MachineCodeGenerator.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnGenerisanje_Click(object sender, EventArgs e)
        {
            frmLoading frmLoading = new frmLoading();
            string poruka = null;
            try
            {
                if (cbDisk.Checked)
                {                  
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            frmLoading.Show();
                            this.Enabled = false;
                            // Part 1: the input string.
                            string data = txtData.Text;

                            // Part 2: split string on spaces (this will separate all the words).
                            string[] words = Regex.Split(data, txtSeparator.Text.Trim());

                            // Part 3: loop over result array.
                            foreach (string word in words)
                            {
                                string s_word = word.Trim();
                                string fileName = s_word;

                                GetImage(s_word);

                                int newLineIndex = fileName.IndexOf("\r\n");
                                if (newLineIndex != -1)
                                {
                                    fileName = fileName.Substring(0, newLineIndex);
                                }

                                Regex reg = new Regex("[*'\",_&#^@:;]");
                                fileName = reg.Replace(fileName, string.Empty);

                                string files = fbd.SelectedPath;
                                files = $"{files}\\{fileName}";
                                ExportImageToFile(files);

                            }
                            poruka = $"Kreirano {words.Count()} fajla/ova na lokaciji: {fbd.SelectedPath}";
                        }
                    }

                    frmLoading.Close();
                    this.Enabled = true;
                    MessageBox.Show(poruka, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetImage(txtData.Text);
                }
            }
            catch(Exception ex)
            {
                frmLoading.Close();
                this.Enabled = true;
                MessageBox.Show(ex.Message, "Greška");
            }
        }

        private void BtnUcitajFajl_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream, Encoding.Default, true))
                        {
                            txtData.Text = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška");
            }
        }


        private void GetImage(string img)
        {
            var QG = new QRCodeGenerator();
            var MyData = QG.CreateQrCode(img, QRCodeGenerator.ECCLevel.H, true, true, QRCodeGenerator.EciMode.Iso8859_1);
            var code = new QRCode(MyData);
            pbBarCode.Image = code.GetGraphic(4);
        }
        public void ExportImageToFile(string path)
        {
            using (var bitmap = new Bitmap(pbBarCode.Width, pbBarCode.Height))
            {
                pbBarCode.DrawToBitmap(bitmap, pbBarCode.ClientRectangle);
                ImageFormat imageFormat = null;

                RadioButton radioBtn = this.gbFormat.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "rbBmp":
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case "rbPng":
                            imageFormat = ImageFormat.Png;
                            break;
                        case "rbJpeg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case "rbGif":
                            imageFormat = ImageFormat.Gif;
                            break;
                        default:
                            throw new NotSupportedException("File extension is not supported");
                    }
                }

                path = $"{path}.{imageFormat.ToString()}";
                bitmap.Save(path, imageFormat);
            }
        }
    }
}
