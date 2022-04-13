using iText.Kernel.Pdf;
using iText.Kernel.XMP;
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

// Jesse : Use object / class for Record?  I don't think I need to keep the file open & plan to lock and verify prior to writing changes from the grid.

          if (openPdfFile.ShowDialog() == DialogResult.OK)
         {
            #region Variables
            // Stick these into an object class ?
            string _fileId;
            string _fileName;
            string _title;

            string _yearPublished;
            string _yearStart;
            string _yearEnd;
            string _author;
            string _recordSeries;
            string _filePath;

            PdfDocument _pdfRecord;
            PdfReader _pdfReader;

            //Add : string _keywords;
            // Add: documentID is included instandard PDF.info object
            int count = 0;

            #endregion Variables

            foreach (string Name in openPdfFile.FileNames){
               _fileName = openPdfFile.SafeFileNames[count];
               _filePath = openPdfFile.FileNames[count];

               // GetPdfMetadata(_filePath);
               PdfDocument pdfRecord = new PdfDocument(new PdfReader(_filePath));
               PdfDocumentInfo info = pdfRecord.GetDocumentInfo();

               //IDictionary<string, iText.Forms.Fields.PdfFormField> pdfFields = GetPdfFields();

               _title = info.GetTitle();
               _author = info.GetAuthor();
               _yearPublished = info.GetMoreInfo("YearPublished");
               _yearStart = info.GetMoreInfo("YearStart");
               _yearEnd = info.GetMoreInfo("YearEnd");
               _recordSeries = info.GetMoreInfo("RecordSeries");


               // File Name | Title | Year Published | Start Year | End Year| Author | Record Series | File Path
               dataGridMain.Rows.Add(_fileName,_title,_yearPublished, _yearStart, _yearEnd, _author, _recordSeries,_filePath);

               count++;
            }  
            // end foreach loop on Names from Open File Dialog

            dataGridMain.Refresh();
            dataGridMain.Show();
         }
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
