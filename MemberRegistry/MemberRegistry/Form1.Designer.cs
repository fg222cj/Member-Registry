namespace MemberRegistry
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonEditMember = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRegistryToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newRegistryToolStripMenuItem
            // 
            this.newRegistryToolStripMenuItem.Name = "newRegistryToolStripMenuItem";
            this.newRegistryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newRegistryToolStripMenuItem.Text = "New";
            this.newRegistryToolStripMenuItem.Click += new System.EventHandler(this.newRegistryToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.Location = new System.Drawing.Point(12, 27);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(165, 251);
            this.listBoxMembers.TabIndex = 1;
            this.listBoxMembers.Visible = false;
            this.listBoxMembers.SelectedIndexChanged += new System.EventHandler(this.listBoxMembers_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(12, 284);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(111, 23);
            this.buttonAddMember.TabIndex = 2;
            this.buttonAddMember.Text = "Lägg till medlem...";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Visible = false;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.Enabled = false;
            this.buttonShowDetails.Location = new System.Drawing.Point(183, 27);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDetails.TabIndex = 3;
            this.buttonShowDetails.Text = "Detaljer";
            this.buttonShowDetails.UseVisualStyleBackColor = true;
            this.buttonShowDetails.Visible = false;
            this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Enabled = false;
            this.buttonDeleteMember.Location = new System.Drawing.Point(182, 85);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMember.TabIndex = 4;
            this.buttonDeleteMember.Text = "Ta bort";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Visible = false;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonEditMember
            // 
            this.buttonEditMember.Enabled = false;
            this.buttonEditMember.Location = new System.Drawing.Point(183, 56);
            this.buttonEditMember.Name = "buttonEditMember";
            this.buttonEditMember.Size = new System.Drawing.Size(75, 23);
            this.buttonEditMember.TabIndex = 5;
            this.buttonEditMember.Text = "Ändra";
            this.buttonEditMember.UseVisualStyleBackColor = true;
            this.buttonEditMember.Visible = false;
            this.buttonEditMember.Click += new System.EventHandler(this.buttonEditMember_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 321);
            this.Controls.Add(this.buttonEditMember);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.buttonShowDetails);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Medlemregister";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonShowDetails;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Button buttonEditMember;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

