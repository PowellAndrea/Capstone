using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metadata_Manager.Forms
{
   public partial class Landing : Form
   {
      public Landing()
      {
         InitializeComponent();
      }

      private void openPdfsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         dataGridMain.Rows.Clear();

          if (openPdfFile.ShowDialog() == DialogResult.OK)
         {
            //DataGridViewCheckBoxCell _selected = new DataGridViewCheckBoxCell();
            // Stick these into an object class
            string _fileName;
            string _filePath;
            string _author;
            string _title;
            string _keywords;

            int count = 0;
           
            foreach (string Name in openPdfFile.FileNames){

               //_selected = new DataGridViewCheckBoxCell();
               _fileName = openPdfFile.SafeFileNames[count];
               _filePath = openPdfFile.FileNames[count];

               // GetPdfMetadata(_filePath);
               PdfDocument pdfRecord = new PdfDocument(new PdfReader(_filePath));
               PdfDocumentInfo info = pdfRecord.GetDocumentInfo();

               _author = info.GetAuthor();
               _title = info.GetTitle();
               _keywords = info.GetKeywords();

               dataGridMain.Rows.Add(_fileName, _title, _author, _keywords, _filePath);

               count++;
            }

            dataGridMain.Refresh();
            dataGridMain.Show();
         }
      }

      private void GetPdfMetadata(string filePath)
      {
         return;
      }

      #region Menu Items
      private void menuItemExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      #endregion

      private void dataGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void lbl_FilePath_Click(object sender, EventArgs e)
      {

      }
   }
}
