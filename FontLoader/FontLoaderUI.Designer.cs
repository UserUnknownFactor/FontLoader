namespace FontLoader
{
    partial class FontLoaderUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontLoaderUI));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.biuttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ttfFilesSelect = new System.Windows.Forms.OpenFileDialog();
            this.listPreviews = new System.Windows.Forms.ImageList(this.components);
            this.listFonts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Image = global::FontLoader.Properties.Resources.FontLoader_Add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(12, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 58);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add &Fonts";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // biuttonRemove
            // 
            this.biuttonRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biuttonRemove.Image = global::FontLoader.Properties.Resources.FontLoader_Remove;
            this.biuttonRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.biuttonRemove.Location = new System.Drawing.Point(121, 15);
            this.biuttonRemove.Name = "biuttonRemove";
            this.biuttonRemove.Size = new System.Drawing.Size(98, 58);
            this.biuttonRemove.TabIndex = 1;
            this.biuttonRemove.Text = "&Remove Fonts";
            this.biuttonRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.biuttonRemove.UseVisualStyleBackColor = true;
            this.biuttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button2
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Image = global::FontLoader.Properties.Resources.FontLoader_Clear;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClear.Location = new System.Drawing.Point(230, 15);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 58);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "&Clear Fonts";
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Image = global::FontLoader.Properties.Resources.FontLoader_Unload;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(448, 15);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(98, 58);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "&Unload Fonts";
            this.buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // button4
            // 
            this.buttonUnload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUnload.Image = global::FontLoader.Properties.Resources.FontLoader_Load;
            this.buttonUnload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUnload.Location = new System.Drawing.Point(339, 15);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(98, 58);
            this.buttonUnload.TabIndex = 3;
            this.buttonUnload.Text = "&Load Fonts";
            this.buttonUnload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Image = global::FontLoader.Properties.Resources.FontLoader_Exit;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(557, 15);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 58);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // ttfFilesSelect
            // 
            this.ttfFilesSelect.Title = "Select font(s)";
            this.ttfFilesSelect.Multiselect = true;
            this.ttfFilesSelect.Filter = "Font files (*.ttf,*.otf)|*.ttf;*.otf";
            // 
            // listPreviews
            // 
            this.listPreviews.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.listPreviews.ImageSize = new System.Drawing.Size(16, 16);
            this.listPreviews.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listFonts
            // 
            this.listFonts.AllowDrop = true;
            this.listFonts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listFonts.LargeImageList = this.listPreviews;
            this.listFonts.Location = new System.Drawing.Point(12, 85);
            this.listFonts.Name = "listFonts";
            this.listFonts.ShowGroups = false;
            this.listFonts.Size = new System.Drawing.Size(643, 353);
            this.listFonts.SmallImageList = this.listPreviews;
            this.listFonts.TabIndex = 6;
            this.listFonts.UseCompatibleStateImageBehavior = false;
            this.listFonts.View = System.Windows.Forms.View.List;
            // 
            // FontLoaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.listFonts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUnload);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.biuttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontLoaderUI";
            this.Text = "Font Loader .NET";
            this.Load += new System.EventHandler(this.FontLoaderUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAdd;
        private Button biuttonRemove;
        private Button buttonClear;
        private Button buttonLoad;
        private Button buttonUnload;
        private Button buttonExit;
        private OpenFileDialog ttfFilesSelect;
        private ImageList listPreviews;
        private ListView listFonts;
    }
}