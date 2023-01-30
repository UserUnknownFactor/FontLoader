using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;

namespace FontLoader
{
    public partial class FontLoaderUI : Form
    {
        public FontLoaderUI()
        {
            InitializeComponent();
        }

        private static NativeMethods.SHFILEINFO SHFI = new NativeMethods.SHFILEINFO();
        private static IntPtr hSysImgList = NativeMethods.SHGetFileInfo(
            "",
            0,
            ref SHFI,
            (uint)Marshal.SizeOf(SHFI),
            NativeMethods.SHGFI_SYSICONINDEX | NativeMethods.SHGFI_SMALLICON
        );

        [DllImport("gdi32.dll")]
        static extern bool RemoveFontResource(string lpFileName);

        [DllImport("gdi32.dll")]
        static extern int AddFontResource(string lpszFilename);

        private static bool loadedEmptyConfig = true;


        private void addFileToList(string fullName)
        {
            if (listFonts.Items.ContainsKey(fullName))
                return;

            //string fileName = System.IO.Path.GetFileName(fullName);
            IntPtr himl = NativeMethods.SHGetFileInfo(
                fullName,
                0,
                ref SHFI,
                (uint)Marshal.SizeOf(SHFI),
                NativeMethods.SHGFI_DISPLAYNAME | NativeMethods.SHGFI_SYSICONINDEX | NativeMethods.SHGFI_SMALLICON
            );
            listFonts.Items.Add(fullName, SHFI.iIcon);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ttfFilesSelect.ShowDialog() == DialogResult.OK)
            {
                string[] files = ttfFilesSelect.FileNames;
                if (files.Count() > 0 && files[0] != "")
                    Properties.Settings.Default.LastFolder = Path.GetDirectoryName(files[0]);
                foreach (string file in files)
                {
                    addFileToList(file);
                    Properties.Settings.Default.FontsList.Add(file);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFonts.SelectedItems)
            {
                listFonts.Items.Remove(item);
                Properties.Settings.Default.FontsList.Remove(item.Text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure you want to remove all fonts from the list?\nIt will not unload them.",
                    "Confirmation",
                    MessageBoxButtons.OKCancel
                    ) == DialogResult.Cancel
                )
                return;
            listFonts.Clear();
            Properties.Settings.Default.FontsList.Clear();
            Properties.Settings.Default.Save();
        }

        private bool AddFont(string lpszFilename)
        {
            bool ret = AddFontResource(lpszFilename) != 0;
            if (!ret)
            {
                RemoveFontResource(lpszFilename);
                Debug.Print("AddFontResource error code:" + Marshal.GetLastWin32Error().ToString());
            }
            return ret;
        }

        private bool RemoveFont(string lpszFilename)
        {
            bool ret = RemoveFontResource(lpszFilename);
            if (!ret)
            {
                Debug.Print("RemoveFontResource error code:" + Marshal.GetLastWin32Error().ToString());
            }
            return ret;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            bool result = true;
            for (int i = 1; i < listFonts.Items.Count; ++i)
            {
                var r = AddFont((string)listFonts.Items[i].Text);
                if (!r) listFonts.Items[i].BackColor = Color.IndianRed;
                result &= r;
            }
            if (result)
                MessageBox.Show("All fonts loaded successfully.");
            else
                MessageBox.Show("Some fonts failed to load.");
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            bool result = true;
            for (int i = 1; i < listFonts.Items.Count; ++i)
            {
                var r = RemoveFont((string)(string)listFonts.Items[i].Text);
                if (!r) listFonts.Items[i].BackColor = Color.Red;
                result &= r;
            }
            if (result)
                MessageBox.Show("All fonts unloaded successfully.");
            else
                MessageBox.Show("Some fonts failed to unload.");
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FontsList.Count > 0 || !loadedEmptyConfig)
                Properties.Settings.Default.Save();
            Close();
        }

        private void FontLoaderUI_Load(object sender, EventArgs e)
        {
            Debug.Assert(hSysImgList != IntPtr.Zero);
            IntPtr hOldImgList = NativeMethods.SendMessage(listFonts.Handle,
                                                           NativeMethods.LVM_SETIMAGELIST,
                                                           NativeMethods.LVSIL_SMALL,
                                                           hSysImgList);
            if (hOldImgList != IntPtr.Zero)
                NativeMethods.ImageList_Destroy(hOldImgList);
            NativeMethods.SetWindowTheme(listFonts.Handle, "Explorer", null);

            if (Properties.Settings.Default.FontsList != null)
            {
                foreach (string? file in Properties.Settings.Default.FontsList)
                {
                    if (file == null) continue;
                    addFileToList(file);
                }
                loadedEmptyConfig = false;
            }
            else
            {
                Properties.Settings.Default.FontsList = 
                    new System.Collections.Specialized.StringCollection();
            }
            if (Properties.Settings.Default.LastFolder == null)
                Properties.Settings.Default.LastFolder = Directory.GetCurrentDirectory();
            else
                ttfFilesSelect.InitialDirectory = Properties.Settings.Default.LastFolder;
        }
    }
}