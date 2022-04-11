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
         this.lbl_fileName = new System.Windows.Forms.Label();
         this.lbl_FilePath = new System.Windows.Forms.Label();
         this.dataGridMain = new System.Windows.Forms.DataGridView();
         this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.RecordTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Box1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
         // lbl_fileName
         // 
         this.lbl_fileName.AutoSize = true;
         this.lbl_fileName.Location = new System.Drawing.Point(458, 145);
         this.lbl_fileName.Name = "lbl_fileName";
         this.lbl_fileName.Size = new System.Drawing.Size(60, 15);
         this.lbl_fileName.TabIndex = 2;
         this.lbl_fileName.Text = "File Name";
         // 
         // lbl_FilePath
         // 
         this.lbl_FilePath.AutoSize = true;
         this.lbl_FilePath.Location = new System.Drawing.Point(458, 82);
         this.lbl_FilePath.Name = "lbl_FilePath";
         this.lbl_FilePath.Size = new System.Drawing.Size(52, 15);
         this.lbl_FilePath.TabIndex = 4;
         this.lbl_FilePath.Text = "File Path";
         this.lbl_FilePath.Click += new System.EventHandler(this.lbl_FilePath_Click);
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
            this.FilePath,
            this.Box1});
         this.dataGridMain.Location = new System.Drawing.Point(12, 45);
         this.dataGridMain.Name = "dataGridMain";
         this.dataGridMain.ReadOnly = true;
         this.dataGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
         this.dataGridMain.RowTemplate.Height = 25;
         this.dataGridMain.Size = new System.Drawing.Size(392, 393);
         this.dataGridMain.TabIndex = 5;
         // 
         // FileName
         // 
         this.FileName.HeaderText = "File Name";
         this.FileName.Name = "FileName";
         this.FileName.ReadOnly = true;
         // 
         // RecordTitle
         // 
         this.RecordTitle.HeaderText = "Title";
         this.RecordTitle.Name = "RecordTitle";
         this.RecordTitle.ReadOnly = true;
         // 
         // FilePath
         // 
         this.FilePath.HeaderText = "File Path";
         this.FilePath.Name = "FilePath";
         this.FilePath.ReadOnly = true;
         // 
         // Box1
         // 
         this.Box1.HeaderText = "Box1";
         this.Box1.Name = "Box1";
         this.Box1.ReadOnly = true;
         // 
         // Landing
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dataGridMain);
         this.Controls.Add(this.lbl_FilePath);
         this.Controls.Add(this.lbl_fileName);
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
      private Label lbl_fileName;
      private Label lbl_FilePath;
      private DataGridView dataGridMain;
      private DataGridViewTextBoxColumn FileName;
      private DataGridViewTextBoxColumn RecordTitle;
      private DataGridViewTextBoxColumn FilePath;
      private DataGridViewCheckBoxColumn Box1;
   }
}