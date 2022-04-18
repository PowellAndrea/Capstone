/* Andrea Powell, Spring 2022
 * Capstone project
 
 */

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

// Jesse : Use object / class for Record?  keep the file open & plan to lock and verify prior to writing changes from the grid.

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

            PdfDocumentInfo info;

            //Add : string _keywords;
            // Add: documentID is included instandard PDF.info object
            int count = 0;
            
            #endregion Variables

            foreach (string Name in openPdfFile.FileNames){
               // Only deal with .pdf files from Open Dialog

               // Move headers to buildTable function

               _fileName = openPdfFile.SafeFileNames[count];
               _filePath = openPdfFile.FileNames[count];
               
               PdfDocument PdfRecord = new PdfDocument(new PdfReader(_filePath), new PdfWriter(_fileName));
               
               //PdfDocumentInfo info = PdfRecord.GetDocumentInfo();
               info = PdfRecord.GetDocumentInfo();

               _title = info.GetTitle();
               _author = info.GetAuthor();
               _yearPublished = info.GetMoreInfo("YearPublished");
               _yearStart = info.GetMoreInfo("YearStart");
               _yearEnd = info.GetMoreInfo("YearEnd");
               _recordSeries = info.GetMoreInfo("RecordSeries");

               // File Name | Title | Year Published | Start Year | End Year| Author | Record Series | File Path
               dataGridMain.Rows.Add(_fileName,_title,_yearPublished, _yearStart, _yearEnd, _author, _recordSeries,_filePath);

               count++;

               PdfRecord.Close();
            }  
            // end foreach loop on Names from Open File Dialog

            dataGridMain.Refresh();
            dataGridMain.Show();
         }
      }

      private void menuItemExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void dataGridMain_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
      {
         string filePath = dataGridMain.CurrentRow.Cells[7].Value.ToString();

         // Open source document
         PdfDocument sourceDoc = new PdfDocument(new PdfReader(filePath));

         // Create new empty destination document
         PdfDocument destDoc = new PdfDocument(new PdfWriter("./TestMe.pdf"));
         sourceDoc.CopyPagesTo(1,3,destDoc);

         var ab = sourceDoc.GetCatalog();
         var abc = sourceDoc.GetXmpMetadata();

         XMPMeta myMeta = XMPMetaFactory.Create();
         myMeta.SetProperty("http://ns.adobe.com/pdfx/1.3/", "Author", "myApp");

         var one = destDoc.GetDocumentInfo();
         var two = destDoc.GetXmpMetadata();

         //destDoc.SetXmpMetadata(myMeta);
         destDoc.SetXmpMetadata(XMPMetaFactory.Create());

         var three = destDoc.GetXmpMetadata();
         var four = destDoc.GetCatalog();

         destDoc.Close();


      }
   }
}
