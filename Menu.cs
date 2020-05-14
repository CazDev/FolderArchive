using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderArchive
{
    public partial class Menu : Form
    {
        private List<DirectoryInfo> archiveDirList = new List<DirectoryInfo>();

        public Menu()
        {
            InitializeComponent();
        }

        // Get root folder
        // Find oldest x amount files up to date xx/xx/xx
        // Move x files to ArchiveFolder

        private void fileOpenRoot_Click(object sender, EventArgs e)
        {
            txtRootFolderDir.Text = SelectFolderDir("Select the root folder to archive folders from");
            UpdateArchivePreview();
        }

        private void dateLatestArchive_ValueChanged(object sender, EventArgs e)
        {
            UpdateArchivePreview();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            string archivePath = SelectFolderDir("Select the folder you would like to archive to");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to move all selected folders?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ArchiveFolders(archivePath);
            }
        }

        private void ArchiveFolders(string archivePath)
        {
            foreach (DirectoryInfo dir in archiveDirList)
            {
                if (Directory.Exists(dir.Name))
                {
                    foreach (var file in new DirectoryInfo(dir.FullName).GetFiles())
                    {
                        file.MoveTo($@"{archivePath}\{file.Name}");
                    }
                }
            }
        }

        private string SelectFolderDir(string desc)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = desc;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }
            return "";
        }

        private void UpdateArchivePreview()
        {
            lstFolderPreview.Items.Clear();
            archiveDirList.Clear();

            if (txtRootFolderDir.Text != "")
            {
                foreach (DirectoryInfo dir in GetOldestSortedFolders(txtRootFolderDir.Text))
                {
                    // LastWriteTime is ealier than set latest date
                    if (dir.LastWriteTime.CompareTo(dateLatestArchive.Value) < 0)
                    {
                        lstFolderPreview.Items.Add(dir.Name + " :: " + dir.LastWriteTime);
                        archiveDirList.Add(dir);
                    }
                }
            }
            else
            {
                //Root folder is not selected
                MessageBox.Show("Please select a valid root folder first");
            }
        }

        private static List<DirectoryInfo> GetOldestSortedFolders(string location)
        {
            var di = new DirectoryInfo(location);
            var directories = di.EnumerateDirectories()
                                .OrderBy(d => d.LastWriteTime)
                                .Select(d => d)
                                .ToList();
            return directories;
        }
    }
}