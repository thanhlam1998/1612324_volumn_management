namespace _1612324_compress_volume
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.listView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSizeCompr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCRC32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewZip = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenZip = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseZip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevelDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevelBest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevelFast = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevelNone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chExtension,
            this.chDate,
            this.chSize,
            this.chSizeCompr,
            this.chAttr,
            this.chCRC32,
            this.chComment});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 451);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chExtension
            // 
            this.chExtension.Text = "Extension";
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 80;
            // 
            // chSizeCompr
            // 
            this.chSizeCompr.Text = "Size Compress";
            // 
            // chAttr
            // 
            this.chAttr.Text = "Attr";
            // 
            // chCRC32
            // 
            this.chCRC32.Text = "CRC32";
            // 
            // chComment
            // 
            this.chComment.Text = "Comment";
            this.chComment.Width = 500;
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(683, 17);
            this._lblStatus.Spring = true;
            this._lblStatus.Text = "Ready";
            this._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _progressBar
            // 
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus,
            this._progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewZip,
            this.mnuOpenZip,
            this.mnuCloseZip,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fIleToolStripMenuItem.Text = "&File";
            // 
            // mnuNewZip
            // 
            this.mnuNewZip.Name = "mnuNewZip";
            this.mnuNewZip.Size = new System.Drawing.Size(119, 22);
            this.mnuNewZip.Text = "&New...";
            this.mnuNewZip.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // mnuOpenZip
            // 
            this.mnuOpenZip.Name = "mnuOpenZip";
            this.mnuOpenZip.Size = new System.Drawing.Size(119, 22);
            this.mnuOpenZip.Text = "&Open...";
            this.mnuOpenZip.Click += new System.EventHandler(this.mnuOpenZip_Click);
            // 
            // mnuCloseZip
            // 
            this.mnuCloseZip.Name = "mnuCloseZip";
            this.mnuCloseZip.Size = new System.Drawing.Size(119, 22);
            this.mnuCloseZip.Text = "&Close...";
            this.mnuCloseZip.Click += new System.EventHandler(this.mnuCloseZip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(119, 22);
            this.mnuExit.Text = "&Exit...";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSelect
            // 
            this.mnuSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelectAll,
            this.mnuUnselectAll});
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(55, 20);
            this.mnuSelect.Text = "&Select";
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(154, 22);
            this.mnuSelectAll.Text = "Select &All...";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuUnselectAll
            // 
            this.mnuUnselectAll.Name = "mnuUnselectAll";
            this.mnuUnselectAll.Size = new System.Drawing.Size(154, 22);
            this.mnuUnselectAll.Text = "&Unselect All...";
            this.mnuUnselectAll.Click += new System.EventHandler(this.mnuUnselectAll_Click);
            // 
            // mnuCommand
            // 
            this.mnuCommand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExtract,
            this.mnuDelete,
            this.mnuAddFile,
            this.mnuAddFolder,
            this.mnuEditComment,
            this.mnuLevel,
            this.mnuPassword});
            this.mnuCommand.Name = "mnuCommand";
            this.mnuCommand.Size = new System.Drawing.Size(78, 20);
            this.mnuCommand.Text = "&Command";
            // 
            // mnuExtract
            // 
            this.mnuExtract.Name = "mnuExtract";
            this.mnuExtract.Size = new System.Drawing.Size(183, 22);
            this.mnuExtract.Text = "&Extract";
            this.mnuExtract.Click += new System.EventHandler(this.mnuExtract_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(183, 22);
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuAddFile
            // 
            this.mnuAddFile.Name = "mnuAddFile";
            this.mnuAddFile.Size = new System.Drawing.Size(183, 22);
            this.mnuAddFile.Text = "&Add Files...";
            this.mnuAddFile.Click += new System.EventHandler(this.mnuAddFile_Click);
            // 
            // mnuAddFolder
            // 
            this.mnuAddFolder.Name = "mnuAddFolder";
            this.mnuAddFolder.Size = new System.Drawing.Size(183, 22);
            this.mnuAddFolder.Text = "Add &Folder...";
            this.mnuAddFolder.Click += new System.EventHandler(this.mnuAddFolder_Click);
            // 
            // mnuEditComment
            // 
            this.mnuEditComment.Name = "mnuEditComment";
            this.mnuEditComment.Size = new System.Drawing.Size(183, 22);
            this.mnuEditComment.Text = "&Edit Comment";
            this.mnuEditComment.Click += new System.EventHandler(this.mnuEditComment_Click);
            // 
            // mnuLevel
            // 
            this.mnuLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLevelDefault,
            this.mnuLevelBest,
            this.mnuLevelFast,
            this.mnuLevelNone});
            this.mnuLevel.Name = "mnuLevel";
            this.mnuLevel.Size = new System.Drawing.Size(183, 22);
            this.mnuLevel.Text = "Compression Level";
            // 
            // mnuLevelDefault
            // 
            this.mnuLevelDefault.Checked = true;
            this.mnuLevelDefault.CheckOnClick = true;
            this.mnuLevelDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuLevelDefault.Name = "mnuLevelDefault";
            this.mnuLevelDefault.Size = new System.Drawing.Size(180, 22);
            this.mnuLevelDefault.Text = "&Default";
            this.mnuLevelDefault.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelBest
            // 
            this.mnuLevelBest.CheckOnClick = true;
            this.mnuLevelBest.Name = "mnuLevelBest";
            this.mnuLevelBest.Size = new System.Drawing.Size(180, 22);
            this.mnuLevelBest.Text = "Best &Compression";
            this.mnuLevelBest.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelFast
            // 
            this.mnuLevelFast.CheckOnClick = true;
            this.mnuLevelFast.Name = "mnuLevelFast";
            this.mnuLevelFast.Size = new System.Drawing.Size(180, 22);
            this.mnuLevelFast.Text = "Best &Speed";
            this.mnuLevelFast.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelNone
            // 
            this.mnuLevelNone.CheckOnClick = true;
            this.mnuLevelNone.Name = "mnuLevelNone";
            this.mnuLevelNone.Size = new System.Drawing.Size(180, 22);
            this.mnuLevelNone.Text = "&No Compression";
            this.mnuLevelNone.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuPassword
            // 
            this.mnuPassword.Name = "mnuPassword";
            this.mnuPassword.Size = new System.Drawing.Size(183, 22);
            this.mnuPassword.Text = "Password";
            this.mnuPassword.Click += new System.EventHandler(this.mnuPassword_Click);
            // 
            // mnuViewLarge
            // 
            this.mnuViewLarge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewEntry});
            this.mnuViewLarge.Name = "mnuViewLarge";
            this.mnuViewLarge.Size = new System.Drawing.Size(48, 20);
            this.mnuViewLarge.Text = "&View";
            // 
            // mnuViewEntry
            // 
            this.mnuViewEntry.Name = "mnuViewEntry";
            this.mnuViewEntry.Size = new System.Drawing.Size(156, 22);
            this.mnuViewEntry.Text = "File Content...";
            this.mnuViewEntry.Click += new System.EventHandler(this.mnuViewEntry_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.mnuSelect,
            this.mnuCommand,
            this.mnuViewLarge});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Red;
            this.imageListLarge.Images.SetKeyName(0, "System.Drawing.Bitmap");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Red;
            this.imageListSmall.Images.SetKeyName(0, "System.Drawing,Bitmap");
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "1612324 - Zip";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chExtension;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chSizeCompr;
        private System.Windows.Forms.ColumnHeader chAttr;
        private System.Windows.Forms.ColumnHeader chCRC32;
        private System.Windows.Forms.ColumnHeader chComment;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private System.Windows.Forms.ToolStripProgressBar _progressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewZip;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenZip;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseZip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuUnselectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuCommand;
        private System.Windows.Forms.ToolStripMenuItem mnuExtract;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuAddFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAddFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuEditComment;
        private System.Windows.Forms.ToolStripMenuItem mnuLevel;
        private System.Windows.Forms.ToolStripMenuItem mnuLevelDefault;
        private System.Windows.Forms.ToolStripMenuItem mnuLevelBest;
        private System.Windows.Forms.ToolStripMenuItem mnuLevelFast;
        private System.Windows.Forms.ToolStripMenuItem mnuLevelNone;
        private System.Windows.Forms.ToolStripMenuItem mnuPassword;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLarge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuViewEntry;
    }
}

