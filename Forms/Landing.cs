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
            string _fileName = new string(" ");
            string _filePath = new string(" ");
            int count = 0;
           
            foreach (string Name in openPdfFile.FileNames){

               //_selected = new DataGridViewCheckBoxCell();
               _fileName = openPdfFile.SafeFileNames[count];
               _filePath = openPdfFile.FileNames[count];
               dataGridMain.Rows.Add(_fileName,_filePath);
               count++;
            }

            dataGridMain.Refresh();
            dataGridMain.Show();
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

      private void dataGridMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
