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
          if (openPdfFile.ShowDialog() == DialogResult.OK)
         {

            dataGridMain.Rows.Add(openPdfFile.SafeFileName, openPdfFile.FileName, openPdfFile.Title);

            lbl_fileName.Text = openPdfFile.FileName;
            lbl_FilePath.Text = openPdfFile.SafeFileName;

            dataGridMain.Refresh();


            dataGridMain.Show();
            // Load metdata from files
            // File Name
            // File name with Path

            // Create a record with data

            // Add row to grid
         }
      }

      private void menuItemExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void dataGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void lbl_FilePath_Click(object sender, EventArgs e)
      {

      }
   }
}
