namespace FolderArchive
{
    partial class Menu
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileOpenRoot = new System.Windows.Forms.Button();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.txtRootFolderDir = new System.Windows.Forms.TextBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.dateLatestArchive = new System.Windows.Forms.DateTimePicker();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lstFolderPreview = new System.Windows.Forms.ListBox();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.lblTip1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            // 
            // fileOpenRoot
            // 
            this.fileOpenRoot.BackColor = System.Drawing.SystemColors.Control;
            this.fileOpenRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileOpenRoot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fileOpenRoot.ForeColor = System.Drawing.Color.Black;
            this.fileOpenRoot.Location = new System.Drawing.Point(30, 34);
            this.fileOpenRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileOpenRoot.Name = "fileOpenRoot";
            this.fileOpenRoot.Size = new System.Drawing.Size(87, 30);
            this.fileOpenRoot.TabIndex = 2;
            this.fileOpenRoot.Text = "Select Folder";
            this.fileOpenRoot.UseVisualStyleBackColor = false;
            this.fileOpenRoot.Click += new System.EventHandler(this.fileOpenRoot_Click);
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblStep1.Location = new System.Drawing.Point(12, 7);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(154, 17);
            this.lblStep1.TabIndex = 3;
            this.lblStep1.Text = "Step 1: Select root folder";
            // 
            // txtRootFolderDir
            // 
            this.txtRootFolderDir.BackColor = System.Drawing.SystemColors.Control;
            this.txtRootFolderDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRootFolderDir.ForeColor = System.Drawing.Color.Black;
            this.txtRootFolderDir.Location = new System.Drawing.Point(14, 38);
            this.txtRootFolderDir.Name = "txtRootFolderDir";
            this.txtRootFolderDir.ReadOnly = true;
            this.txtRootFolderDir.Size = new System.Drawing.Size(263, 22);
            this.txtRootFolderDir.TabIndex = 4;
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblStep2.Location = new System.Drawing.Point(12, 99);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(219, 17);
            this.lblStep2.TabIndex = 5;
            this.lblStep2.Text = "Step 2: Specify latest date to archive";
            // 
            // dateLatestArchive
            // 
            this.dateLatestArchive.Location = new System.Drawing.Point(12, 129);
            this.dateLatestArchive.Name = "dateLatestArchive";
            this.dateLatestArchive.Size = new System.Drawing.Size(226, 25);
            this.dateLatestArchive.TabIndex = 6;
            this.dateLatestArchive.ValueChanged += new System.EventHandler(this.dateLatestArchive_ValueChanged);
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblStep3.Location = new System.Drawing.Point(12, 194);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(141, 17);
            this.lblStep3.TabIndex = 7;
            this.lblStep3.Text = "Step 3: Archive Folders";
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.SystemColors.Control;
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArchive.ForeColor = System.Drawing.Color.Black;
            this.btnArchive.Location = new System.Drawing.Point(30, 228);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(87, 30);
            this.btnArchive.TabIndex = 8;
            this.btnArchive.Text = "Archive all";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lstFolderPreview
            // 
            this.lstFolderPreview.BackColor = System.Drawing.SystemColors.Control;
            this.lstFolderPreview.ForeColor = System.Drawing.Color.Black;
            this.lstFolderPreview.FormattingEnabled = true;
            this.lstFolderPreview.ItemHeight = 17;
            this.lstFolderPreview.Location = new System.Drawing.Point(14, 126);
            this.lstFolderPreview.Name = "lstFolderPreview";
            this.lstFolderPreview.Size = new System.Drawing.Size(263, 140);
            this.lstFolderPreview.TabIndex = 9;
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTip2.Location = new System.Drawing.Point(94, 99);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(99, 17);
            this.lblTip2.TabIndex = 10;
            this.lblTip2.Text = "Archive preview";
            // 
            // lblTip1
            // 
            this.lblTip1.AutoSize = true;
            this.lblTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblTip1.Location = new System.Drawing.Point(92, 13);
            this.lblTip1.Name = "lblTip1";
            this.lblTip1.Size = new System.Drawing.Size(105, 17);
            this.lblTip1.TabIndex = 11;
            this.lblTip1.Text = "Root folder path";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblTip1);
            this.panel1.Controls.Add(this.txtRootFolderDir);
            this.panel1.Controls.Add(this.lblTip2);
            this.panel1.Controls.Add(this.lstFolderPreview);
            this.panel1.Location = new System.Drawing.Point(253, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 282);
            this.panel1.TabIndex = 12;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(541, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.dateLatestArchive);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.fileOpenRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "FolderArchive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileOpenRoot;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.TextBox txtRootFolderDir;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.DateTimePicker dateLatestArchive;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.ListBox lstFolderPreview;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lblTip1;
        private System.Windows.Forms.Panel panel1;
    }
}

