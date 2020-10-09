
using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace watermark
{
    public partial class MainForm : Form
    {

        static string prPath    = Directory.GetCurrentDirectory();
        string localGhostscriptDll = prPath + "\\gsdll32.dll";

        static string tmpPath = Path.GetTempPath();
        string fileNameWatermark = tmpPath + "watermark.bmp";

        DateTime nowDate;

        public MainForm()
        {
            InitializeComponent();
        }

        public void DrawWatermark(string watermarkImagePath, System.Drawing.Image image, string fileName, int countFile)
        {
            using (System.Drawing.Image watermarkImage = System.Drawing.Image.FromFile(watermarkImagePath))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
            {

                if (image.Width < watermarkImage.Width || image.Height < watermarkImage.Height)
                    return;
                int x = 35, y = 0;
                while (y < image.Height)
                {
                    while (x < image.Width)
                    {
                        watermarkBrush.TranslateTransform(x, y);
                        imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                        x += watermarkImage.Width;
                    }
                    x = 0;
                    y += watermarkImage.Height;
                }

                image.Save(tbCatalog.Text + "\\" +
                       tbClient.Text.Replace(" ", "") + "_" +
                       tbNumAuction.Text + "_" +
                       nowDate.ToString().Replace(":", "").Replace(".", "").Replace(" ", "") + "_" +
                       countFile + ".jpg");

                watermarkImage.Dispose();
                imageGraphics.Dispose();
                watermarkBrush.Dispose();
            }                           
            
        }

        public Bitmap getWatermark(string text)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, 400, 150);

            // Создаём битмап с нужными размерами и форматом пикселей.
            Bitmap watermark = new Bitmap(400, 150, PixelFormat.Format64bppArgb);
            watermark.MakeTransparent();

            SolidBrush brush = new SolidBrush(Color.Red); //.FromArgb(100, 0, 0, 0));

            using (Graphics g = Graphics.FromImage(watermark))
            using (System.Drawing.Font font = new System.Drawing.Font("Arial", 20))
            {
                // Выводим текст.
                g.DrawString(
                    text,
                    font,
                    brush, // цвет текста
                    rect, // текст будет вписан в указанный прямоугольник
                    StringFormat.GenericTypographic
                    );

            }

            watermark.Save(fileNameWatermark);
            watermark.Dispose();
            
            return watermark;
            
        }

        public List<string> ConvertPdfJpg()
        {
            Guid guid = Guid.NewGuid();
            string oldFileName = tbFileName.Text;
            string newFileName = tmpPath + "tmp_watermake_" + guid + ".pdf";

            File.Copy(oldFileName, newFileName);

            string outFileName = Path.GetFileName(newFileName);
            List<string> outFiles = new List<string>();


            GhostscriptVersionInfo gvi = new GhostscriptVersionInfo(localGhostscriptDll);

            using (GhostscriptRasterizer rasterizer = new GhostscriptRasterizer())
            {
                /*rasterizer.CustomSwitches.Add("-r200x300");
                rasterizer.CustomSwitches.Add("-dAutoRotatePages =/ None");*/

                rasterizer.Open(newFileName, gvi, false);

                for (int pageNumber = 1; pageNumber <= rasterizer.PageCount; pageNumber++)
                {
                    string outNameFile = tmpPath + outFileName.Replace(".pdf", "") + "_" + pageNumber.ToString() + ".jpeg";
                    outFiles.Add(outNameFile);

                    Image img = rasterizer.GetPage(300, 300, pageNumber);
                    img.Save(outNameFile, ImageFormat.Jpeg);

                }

                rasterizer.Close();
            }

            return outFiles;

        }

        private bool checkField()
        {
            labelFileName.ForeColor = System.Drawing.Color.Black;
            labelCatalog.ForeColor = System.Drawing.Color.Black;
            labelClient.ForeColor = System.Drawing.Color.Black;
            labelINN.ForeColor = System.Drawing.Color.Black;
            labelNumAuction.ForeColor = System.Drawing.Color.Black;

            bool Error = false;

            if (string.IsNullOrEmpty(tbFileName.Text))
            {
                labelFileName.ForeColor = System.Drawing.Color.Red;
                Error = true;
            }

            if (string.IsNullOrEmpty(tbCatalog.Text))
            {
                labelCatalog.ForeColor = System.Drawing.Color.Red;
                Error = true;
            }

            if (string.IsNullOrEmpty(tbClient.Text))
            {
                labelClient.ForeColor = System.Drawing.Color.Red;
                Error = true;
            }

            if (string.IsNullOrEmpty(tbINN.Text))
            {
                labelINN.ForeColor = System.Drawing.Color.Red;
                Error = true;
            }

            if (string.IsNullOrEmpty(tbNumAuction.Text))
            {
                labelNumAuction.ForeColor = System.Drawing.Color.Red;
                Error = true;
            }

            return Error;

        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "PDF-файлы(*.pdf)|*.pdf" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbFileName.Text = openFileDialog1.FileName;
        }

        private void btSelCatalog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
                tbCatalog.Text = browserDialog.SelectedPath;

        }

        private void btDrawWatermark_Click(object sender, EventArgs e)
        {         

            bool Error = checkField();

            if (Error)
            {
                return;
            }

            nowDate = DateTime.Now;

            string textWatermark = "Для аукциона № " + tbNumAuction.Text + "\n";
            textWatermark += "Выдан " + tbClient.Text + "\n";
            textWatermark += "ИНН " + tbINN.Text + "\n";
            textWatermark += "Без права передачи\n";
            textWatermark += "Дата выдачи " + nowDate + "";

            getWatermark(textWatermark);            

            List<string> outFiles = ConvertPdfJpg();
                        
            int countFile = 0;

            foreach (string fileName in outFiles)
            {
                if(fileName == null)
                {
                    continue;
                }

                countFile += 1;
                Image img = Image.FromFile(fileName);
                string fileWithoutDir = Path.GetFileName(fileName);
                DrawWatermark(fileNameWatermark, img, fileWithoutDir, countFile);                
            }            

            DialogResult result = MessageBox.Show("Файлы сфомрированы, открыть каталог с их расположением???", "Файлы свомированы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer", tbCatalog.Text);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbFileName.Text = "C:\\Users\\shegy\\Downloads\\test.pdf";
            tbCatalog.Text = "C:\\out";

            tbClient.Text = "ПРОВЕРКА";
            tbINN.Text = "524802321321";
            tbNumAuction.Text = "5614312131";

        }
    }
}
