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
            lbl_fileName.Text = openPdfFile.SafeFileName;
            lbl_FilePath.Text = openPdfFile.FileName;
            lbl_Title.Text = openPdfFile.Title;

            


         }
      }

      private void menuItemExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
