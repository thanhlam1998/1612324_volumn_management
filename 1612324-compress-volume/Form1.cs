using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.C1Zip;

namespace _1612324_compress_volume
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            _zipFile.OverwriteHidden = true;
            _zipFile.OverwriteReadOnly = true;
            _zipFile.OverwriteSystem = false;
            //_zipFile.Progress += new C1.C1Zip.ZipProgressEventHandler(this.zip_Progress);
            UpdateUI();
        }

        // private Fields
        C1ZipFile _zipFile = new C1ZipFile();
        string _appTitle = "1612324 Volume Control";
        bool _escape = false;
        bool _cancel = false;



        // create new zip file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show dialog
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "zip";
            sf.Filter = "Zip files (*.zip)|*.zip";
            if (sf.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // create a new empty zip file
            _zipFile.Create(sf.FileName);

            // update user interface
            UpdateUI();
        }

        // open an existing zip file
        private void mnuOpenZip_Click(object sender, EventArgs e)
        {
            // select zip file
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = "zip";
            of.Filter = "Zip files (*.zip)|*.zip";
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // open zip file
            OpenZip(of.FileName);
        }

        // open zip file to
        private void OpenZip(string fn)
        {
            // make sure this is a valid zip file
            if (!File.Exists(fn)) return;
            if (Path.GetExtension(fn).ToLower() != ".zip") return;

            // open zip file
            try
            {
                _zipFile.Open(fn);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Open Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // update user interface
            UpdateUI();
        }

        // close current zip file
        private void mnuCloseZip_Click(object sender, EventArgs e)
        {
            _zipFile.Close();
            UpdateUI();
        }

        // exit program
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // select all file in current vol 
        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                lvi.Selected = true;
            }
        }

        // unselect all files in current vol
        private void mnuUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                lvi.Selected = false;
            }
        }

        bool CheckUserCancel()
        {
            Application.DoEvents();
            if (_escape)
            {
                _escape = false;
                var dr = MessageBox.Show("Do you want to Cancel the current operation?", "Cancel");
                _cancel = (dr == DialogResult.Yes);
            }
            return _cancel;
        }

        // extract file out of vol
        private void mnuExtract_Click(object sender, EventArgs e)
        {
            string defFolder = Path.GetDirectoryName(_zipFile.FileName);
            string folder;

            while (true)
            {
                // show dialog
                var dlg = new UserInputDialog();
                folder = dlg.GetString("Choose a destination folder", defFolder);

                // if cancel, we've done
                if (folder == null)
                {
                    return;
                }

                // if folder is enpty, use default
                if (folder == string.Empty)
                {
                    folder = defFolder;
                }

                // if folder is valid, break out of the loop
                if (Directory.Exists(folder))
                {
                    break;
                }

                // warn user about invalid folder
                var dr = MessageBox.Show("This is not a valid folder.", "Extract Folder", MessageBoxButtons.RetryCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            // make sure folder name ends with a directory separator char
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder = folder + Path.DirectorySeparatorChar;
            }

            // extract
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                try
                {
                    if ((ze.Attributes & FileAttributes.Directory) != 0)
                    {
                        var newFolder = Path.Combine(folder, ze.FileName);
                        Directory.CreateDirectory(newFolder);
                    }
                    else
                    {
                        var dstFileName = Path.Combine(folder, Path.GetFileName(ze.FileName));
                        _zipFile.Entries.Extract(ze.FileName, dstFileName);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Can't Extract File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // delete File
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            // build an array of string containing in the selected file names
            var files = new ArrayList();
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                files.Add(ze.FileName);
            }

            // remove file from the zip
            var arr = (string[])files.ToArray(typeof(string));
            _zipFile.Entries.Remove(arr);

            // update user interface
            UpdateUI();
        }

        // add File to our vol
        private void mnuAddFile_Click(object sender, EventArgs e)
        {
            // show dialog
            var of = new OpenFileDialog();
            of.Multiselect = true;
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // warn user of encryption
            if (_zipFile.Password.Length > 0)
            {
                string msg = "File(s) will be encrypted!\n\r" + "Current password: " + _zipFile.Password;
                var dr = MessageBox.Show(msg, "Add Files", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            // add the files
            AddFileList(of.FileNames, 0);
        }

        // add a folder to the current zip file
        private void mnuAddFolder_Click(object sender, EventArgs e)
        {
            var defFolder = Path.GetDirectoryName(_zipFile.FileName);
            var folder = string.Empty;

            // get a folder name from user
            while (true)
            {
                // show dialog
                var dlg = new UserInputDialog();
                folder = dlg.GetString("Add Folder", defFolder);

                // if cancel, we'er done
                if (folder == null)
                {
                    return;
                }

                // if folder is valid, break out loop
                if (Directory.Exists(folder))
                {
                    break;
                }

                // warn invalid folder
                var dr = MessageBox.Show("This folder is invalid.", "Add folder", MessageBoxButtons.RetryCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            // warn user of encryption
            if (_zipFile.Password.Length > 0)
            {
                var msg = "File(s) will be encrypted!\n\r" +
                             "Current password: " + _zipFile.Password;
                var dr = MessageBox.Show(msg, "Add Folder", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
            }

            // freeze display while adding folders
            _freezeList = true;

            // add folder
            _cancel = _escape = false;
            AddFolder(folder);

            // display list
            _freezeList = false;
            UpdateUI();
        }

        // add folder to vol
        private void AddFolder(string folderName)
        {
            AddFolder(folderName, 0);
        }

        // add folder to vol
        private void AddFolder(string folderName, int pathLevels)
        {
            if (!folderName.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folderName = folderName + Path.DirectorySeparatorChar;
            }

            // increase path Level to keep the folder name
            pathLevels++;

            // user canceled?
            if (_cancel) return;

            // create an empty entry with the folder name
            _zipFile.Entries.Add(folderName, pathLevels);

            // user canceled
            if (_cancel) return;

            // add files within this folder
            var files = Directory.GetFiles(folderName);
            AddFileList(files, pathLevels);

            // user canceled?
            if (_cancel) return;

            //add sub folder
            var subfolders = Directory.GetDirectories(folderName);
            for (int i=0; i<subfolders.Length; i++)
            {
                AddFolder(subfolders[i], pathLevels);
            }
        }

        private void AddFileList(string[] files, int pathLevels)
        {
            // keep track error and time
            var err = string.Empty;
            var start = DateTime.Now.Ticks;

            // add files
            foreach (string file in files)
            {
                // update UI
                UpdateStatusBar("Adding file " + file);
                if (CheckUserCancel()) break;

                // add the file
                try
                {
                    _zipFile.Entries.Add(file, pathLevels);
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    err += "\r\n" + ex.Message;
                }
            }

            if (_cancel) return;

            // warn user of any problem
            if (err.Length > 0)
            {
                MessageBox.Show(err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // update user interface
            UpdateUI();

            // show how long it took
            string msg = null;
            double sec = (DateTime.Now.Ticks - start) / (double)TimeSpan.TicksPerSecond;
            double meg = 0;
            if (sec > 1)
            {
                foreach (string file in files)
                {
                    var ze = _zipFile.Entries[Path.GetFileName(file)];
                    if (ze != null)
                    {
                        meg += ze.SizeUncompressedLong;
                    }
                }
                meg /= (1024.0 * 1024.0);
                msg = string.Format("Compressed in {0:0.00} seconds, {1:0.00} meg/second", sec, meg / sec);
            }
            UpdateStatusBar(msg);
        }

        private void UpdateUI()
        {
            UpdateList();
            UpdateStatusBar();
            UpdateMenus();
        }

        // update File List
        bool _freezeList = false;
        private void UpdateList()
        {
            // If the list is frozen, bail now
            if (_freezeList)
            {
                return;
            }

            //clear list
            listView.Items.Clear();

            // if no zip file, we are done
            if (_zipFile.FileName == string.Empty)
            {
                UpdateStatusBar();
                UpdateMenus();
                return;
            }

            // fill out list 
            var zec = _zipFile.Entries;
            listView.BeginUpdate();
            foreach (C1ZipEntry ze in zec)
            {
                var fa = ze.Attributes;
                var entry = new String[]
                {
                    FileName(ze.FileName),                      // file name, no extension
                    FileExtension(ze.FileName),                 // file extension, no dot
                    ze.Date.ToString("dd/MM/yy HH:mm"),         // mod date, time
                    ze.SizeUncompressedLong.ToString("#,##0"),  // original size
                    ze.SizeCompressedLong.ToString("#,##0"),    // compressed size
                    AttribString(ze.Attributes),                // encode as "rahs"
                    ((uint)ze.CRC32).ToString(),                // CR32 (unsign look better)
                    ze.Comment,                                 // user comment
                };
                var lvi = new ListViewItem(entry);
                lvi.Tag = ze;
                lvi.ImageIndex = ((ze.Attributes & FileAttributes.Directory) != 0) ? 0 : 1;
                if (ze.IsEncrypted) lvi.ImageIndex = 3;
                listView.Items.Add(lvi);
            }
            listView.EndUpdate();
        }

        void UpdateStatusBar()
        {
            UpdateStatusBar(string.Empty);
        }

        void UpdateStatusBar(string msg)
        {
            // build status string
            if (!string.IsNullOrEmpty(msg))
            {
                // get counts
                long nCtn = listView.Items.Count;
                long nSel = listView.SelectedItems.Count;
                long nSize = 0;

                // calculate total Size
                foreach (ListViewItem lvi in listView.SelectedItems)
                {
                    var ze = (C1ZipEntry)lvi.Tag;
                    nSize += ze.SizeUncompressedLong;
                }

                // build statistics string 
                msg = (nCtn == 0)
                    ? "Ready" : (nSize >= 3 * 1024 * 1024)
                        ? string.Format("{0} files, {1} selected, {2:#,###}k byes", nCtn, nSel, nSize / 1024)
                        : string.Format("{0} files, {1} selected, {2:#,##0} bytes", nCtn, nSel, nSize);
            }

            // show text, hide progress bar
            _lblStatus.Text = msg;
            _progressBar.Visible = false;
        }


        private void UpdateMenus()
        {
            // check if there is file open
            bool bZip = (_zipFile.FileName.Length > 0) ? true : false;
            mnuCloseZip.Enabled = bZip;
            mnuAddFolder.Enabled = bZip;
            mnuAddFile.Enabled = bZip;
            mnuEditComment.Enabled = bZip;
            mnuPassword.Enabled = bZip;
            mnuLevel.Enabled = bZip;

            bool bEntries = (listView.Items.Count > 0) ? true : false;
            mnuSelectAll.Enabled = bEntries;
            mnuUnselectAll.Enabled = bEntries;

            bool bSelected = (listView.SelectedItems.Count > 0) ? true : false;
            mnuExtract.Enabled = bSelected;
            mnuDelete.Enabled = bSelected;
            mnuViewEntry.Enabled = bSelected;

            // update title bar
            string str = _appTitle;
            if (_zipFile.FileName != string.Empty)
            {
                str = str + " - " + _zipFile.FileName;
            }
            Text = str;
        }

        // utitlities
        internal static string FileName(string fn)
        {
            int extLen = Path.GetExtension(fn).Length;
            return fn.Remove(fn.Length - extLen, extLen);
        }

        internal static string FileExtension(string fn)
        {
            string ext = Path.GetExtension(fn).ToLower();
            return ext.Replace(".", string.Empty);
        }

        internal static string AttribString(FileAttributes fa)
        {
            if ((fa & FileAttributes.Directory) != 0)
            {
                return "<dir>";
            }
            var atts = string.Empty;
            atts += ((fa & FileAttributes.ReadOnly) != 0) ? "r" : "-";
            atts += ((fa & FileAttributes.Archive) != 0) ? "a" : "-";
            atts += ((fa & FileAttributes.Hidden) != 0) ? "h" : "-";
            atts += ((fa & FileAttributes.System) != 0) ? "s" : "-";
            return atts;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
            UpdateMenus();
        }
        private void mnuPassword_Click(object sender, EventArgs e)
        {
            // show dialog
            var dlg = new UserInputDialog();
            var new_password = dlg.GetString("Choose a password", _zipFile.Password);

            // if user provided a new password, use it
            if (new_password != null)
            {
                _zipFile.Password = new_password;
            }
        }

        private void mnuEditComment_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }

            var ze = (C1ZipEntry)listView.SelectedItems[0].Tag;
            var comment = ze.Comment;

            var dlg = new UserInputDialog();
            comment = dlg.GetString("Enter comment", comment);
            if (comment == null)
            {
                return;
            }

            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                ze = (C1ZipEntry)lvi.Tag;
                ze.Comment = comment;
            }

            UpdateUI();
        }
    }
}
