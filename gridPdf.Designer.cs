namespace Metadata_Manager
{
   partial class gridPdf
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.FileName,
            this.FilePath});
         this.dataGridView1.Location = new System.Drawing.Point(3, 0);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 25;
         this.dataGridView1.Size = new System.Drawing.Size(550, 378);
         this.dataGridView1.TabIndex = 0;
         // 
         // Selected
         // 
         this.Selected.HeaderText = "";
         this.Selected.Name = "Selected";
         // 
         // FileName
         // 
         this.FileName.HeaderText = "File Name";
         this.FileName.Name = "FileName";
         this.FileName.ReadOnly = true;
         // 
         // FilePath
         // 
         this.FilePath.HeaderText = "File Path";
         this.FilePath.Name = "FilePath";
         this.FilePath.ReadOnly = true;
         // 
         // gridPdf
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.dataGridView1);
         this.Name = "gridPdf";
         this.Size = new System.Drawing.Size(553, 378);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DataGridView dataGridView1;
      private DataGridViewCheckBoxColumn Selected;
      private DataGridViewTextBoxColumn FileName;
      private DataGridViewTextBoxColumn FilePath;
   }
}
