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
         this.lbl_Title = new System.Windows.Forms.Label();
         this.menuMain.SuspendLayout();
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
         this.menuItemOpenPdf.Size = new System.Drawing.Size(180, 22);
         this.menuItemOpenPdf.Text = "Open pdf(s)";
         this.menuItemOpenPdf.Click += new System.EventHandler(this.openPdfsToolStripMenuItem_Click);
         // 
         // menuItemExit
         // 
         this.menuItemExit.Name = "menuItemExit";
         this.menuItemExit.Size = new System.Drawing.Size(180, 22);
         this.menuItemExit.Text = "Exit";
         this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
         // 
         // openPdfFile
         // 
         this.openPdfFile.DefaultExt = "pdf";
         this.openPdfFile.FileName = "openPdfFile";
         // 
         // lbl_fileName
         // 
         this.lbl_fileName.AutoSize = true;
         this.lbl_fileName.Location = new System.Drawing.Point(83, 215);
         this.lbl_fileName.Name = "lbl_fileName";
         this.lbl_fileName.Size = new System.Drawing.Size(60, 15);
         this.lbl_fileName.TabIndex = 2;
         this.lbl_fileName.Text = "File Name";
         // 
         // lbl_FilePath
         // 
         this.lbl_FilePath.AutoSize = true;
         this.lbl_FilePath.Location = new System.Drawing.Point(83, 252);
         this.lbl_FilePath.Name = "lbl_FilePath";
         this.lbl_FilePath.Size = new System.Drawing.Size(52, 15);
         this.lbl_FilePath.TabIndex = 4;
         this.lbl_FilePath.Text = "File Path";
         // 
         // lbl_Title
         // 
         this.lbl_Title.AutoSize = true;
         this.lbl_Title.Location = new System.Drawing.Point(83, 298);
         this.lbl_Title.Name = "lbl_Title";
         this.lbl_Title.Size = new System.Drawing.Size(50, 15);
         this.lbl_Title.TabIndex = 5;
         this.lbl_Title.Text = "File Title";
         // 
         // Landing
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.lbl_Title);
         this.Controls.Add(this.lbl_FilePath);
         this.Controls.Add(this.lbl_fileName);
         this.Controls.Add(this.menuMain);
         this.MainMenuStrip = this.menuMain;
         this.Name = "Landing";
         this.Text = "Landing";
         this.menuMain.ResumeLayout(false);
         this.menuMain.PerformLayout();
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
      private Label lbl_Title;
   }
}