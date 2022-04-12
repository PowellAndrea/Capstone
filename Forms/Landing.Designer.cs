namespace Metadata_Manager.Forms
{
   partial class Landing
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.menuMain = new System.Windows.Forms.MenuStrip();
         this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemOpenPdf = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
         this.openPdfFile = new System.Windows.Forms.OpenFileDialog();
         this.dataGridMain = new System.Windows.Forms.DataGridView();
         this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.RecordTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.FP_ReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.RecordSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.menuMain.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
         this.SuspendLayout();
         // 
         // menuMain
         // 
         this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
         this.menuMain.Location = new System.Drawing.Point(0, 0);
         this.menuMain.Name = "menuMain";
         this.menuMain.Size = new System.Drawing.Size(800, 24);
         this.menuMain.TabIndex = 0;
         this.menuMain.Text = "Main Menu";
         // 
         // menuItemFile
         // 
         this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenPdf,
            this.menuItemExit});
         this.menuItemFile.Name = "menuItemFile";
         this.menuItemFile.Size = new System.Drawing.Size(37, 20);
         this.menuItemFile.Text = "File";
         // 
         // menuItemOpenPdf
         // 
         this.menuItemOpenPdf.Name = "menuItemOpenPdf";
         this.menuItemOpenPdf.Size = new System.Drawing.Size(137, 22);
         this.menuItemOpenPdf.Text = "Open pdf(s)";
         this.menuItemOpenPdf.Click += new System.EventHandler(this.openPdfsToolStripMenuItem_Click);
         // 
         // menuItemExit
         // 
         this.menuItemExit.Name = "menuItemExit";
         this.menuItemExit.Size = new System.Drawing.Size(137, 22);
         this.menuItemExit.Text = "Exit";
         this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
         // 
         // openPdfFile
         // 
         this.openPdfFile.DefaultExt = "pdf";
         this.openPdfFile.Multiselect = true;
         // 
         // dataGridMain
         // 
         this.dataGridMain.AllowUserToAddRows = false;
         this.dataGridMain.AllowUserToDeleteRows = false;
         this.dataGridMain.AllowUserToOrderColumns = true;
         this.dataGridMain.AllowUserToResizeRows = false;
         this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.RecordTitle,
            this.FP_ReferenceNumber,
            this.RecordSeries,
            this.FilePath});
         this.dataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridMain.Location = new System.Drawing.Point(0, 24);
         this.dataGridMain.Name = "dataGridMain";
         this.dataGridMain.ReadOnly = true;
         this.dataGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
         this.dataGridMain.RowTemplate.Height = 25;
         this.dataGridMain.Size = new System.Drawing.Size(800, 426);
         this.dataGridMain.TabIndex = 5;
         // 
         // FileName
         // 
         this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.FileName.Frozen = true;
         this.FileName.HeaderText = "File Name";
         this.FileName.Name = "FileName";
         this.FileName.ReadOnly = true;
         this.FileName.Width = 85;
         // 
         // RecordTitle
         // 
         this.RecordTitle.HeaderText = "Title";
         this.RecordTitle.Name = "RecordTitle";
         this.RecordTitle.ReadOnly = true;
         // 
         // FP_ReferenceNumber
         // 
         this.FP_ReferenceNumber.HeaderText = "FP Ref. #";
         this.FP_ReferenceNumber.Name = "FP_ReferenceNumber";
         this.FP_ReferenceNumber.ReadOnly = true;
         // 
         // RecordSeries
         // 
         this.RecordSeries.HeaderText = "Record Series";
         this.RecordSeries.Name = "RecordSeries";
         this.RecordSeries.ReadOnly = true;
         // 
         // FilePath
         // 
         this.FilePath.HeaderText = "Path";
         this.FilePath.Name = "FilePath";
         this.FilePath.ReadOnly = true;
         this.FilePath.Width = 692;
         // 
         // Landing
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dataGridMain);
         this.Controls.Add(this.menuMain);
         this.MainMenuStrip = this.menuMain;
         this.Name = "Landing";
         this.Text = "Landing";
         this.menuMain.ResumeLayout(false);
         this.menuMain.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private MenuStrip menuMain;
      private ToolStripMenuItem menuItemFile;
      private ToolStripMenuItem menuItemOpenPdf;
      private ToolStripMenuItem menuItemExit;
      private OpenFileDialog openPdfFile;
      private DataGridView dataGridMain;
      private DataGridViewTextBoxColumn FileName;
      private DataGridViewTextBoxColumn RecordTitle;
      private DataGridViewTextBoxColumn FP_ReferenceNumber;
      private DataGridViewTextBoxColumn RecordSeries;
      private DataGridViewTextBoxColumn FilePath;
   }
}