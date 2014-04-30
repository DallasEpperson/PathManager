namespace PathManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.lblUserDrag = new System.Windows.Forms.Label();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tabPageSystem = new System.Windows.Forms.TabPage();
            this.btnSystemSave = new System.Windows.Forms.Button();
            this.lblSystemDrag = new System.Windows.Forms.Label();
            this.btnSystemAdd = new System.Windows.Forms.Button();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.dgvSystem = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabPageSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageSystem);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.AllowDrop = true;
            this.tabPageUser.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUser.Controls.Add(this.btnUserSave);
            this.tabPageUser.Controls.Add(this.lblUserDrag);
            this.tabPageUser.Controls.Add(this.btnUserAdd);
            this.tabPageUser.Controls.Add(this.txtUser);
            this.tabPageUser.Controls.Add(this.dgvUser);
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(341, 270);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User";
            this.tabPageUser.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDragDrop);
            this.tabPageUser.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDragEnter);
            // 
            // btnUserSave
            // 
            this.btnUserSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSave.Location = new System.Drawing.Point(258, 244);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 9;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // lblUserDrag
            // 
            this.lblUserDrag.AllowDrop = true;
            this.lblUserDrag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDrag.Location = new System.Drawing.Point(7, 241);
            this.lblUserDrag.Name = "lblUserDrag";
            this.lblUserDrag.Size = new System.Drawing.Size(245, 23);
            this.lblUserDrag.TabIndex = 8;
            this.lblUserDrag.Text = "Or Drag and Drop to add a folder";
            this.lblUserDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDragDrop);
            this.lblUserDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDragEnter);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.AllowDrop = true;
            this.btnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserAdd.Location = new System.Drawing.Point(258, 215);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 2;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            this.btnUserAdd.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDragDrop);
            this.btnUserAdd.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDragEnter);
            // 
            // txtUser
            // 
            this.txtUser.AllowDrop = true;
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(7, 216);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(245, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDragDrop);
            this.txtUser.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDragEnter);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowDrop = true;
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(7, 7);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(328, 202);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            this.dgvUser.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDragDrop);
            this.dgvUser.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDragEnter);
            this.dgvUser.MouseEnter += new System.EventHandler(this.dgvUser_MouseEnter);
            // 
            // tabPageSystem
            // 
            this.tabPageSystem.Controls.Add(this.btnSystemSave);
            this.tabPageSystem.Controls.Add(this.lblSystemDrag);
            this.tabPageSystem.Controls.Add(this.btnSystemAdd);
            this.tabPageSystem.Controls.Add(this.txtSystem);
            this.tabPageSystem.Controls.Add(this.dgvSystem);
            this.tabPageSystem.Location = new System.Drawing.Point(4, 25);
            this.tabPageSystem.Name = "tabPageSystem";
            this.tabPageSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSystem.Size = new System.Drawing.Size(341, 270);
            this.tabPageSystem.TabIndex = 1;
            this.tabPageSystem.Text = "System";
            this.tabPageSystem.DragDrop += new System.Windows.Forms.DragEventHandler(this.systemDragDrop);
            this.tabPageSystem.DragEnter += new System.Windows.Forms.DragEventHandler(this.systemDragEnter);
            // 
            // btnSystemSave
            // 
            this.btnSystemSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemSave.Location = new System.Drawing.Point(258, 244);
            this.btnSystemSave.Name = "btnSystemSave";
            this.btnSystemSave.Size = new System.Drawing.Size(75, 23);
            this.btnSystemSave.TabIndex = 14;
            this.btnSystemSave.Text = "Save";
            this.btnSystemSave.UseVisualStyleBackColor = true;
            this.btnSystemSave.Click += new System.EventHandler(this.btnSystemSave_Click);
            // 
            // lblSystemDrag
            // 
            this.lblSystemDrag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemDrag.Location = new System.Drawing.Point(7, 241);
            this.lblSystemDrag.Name = "lblSystemDrag";
            this.lblSystemDrag.Size = new System.Drawing.Size(245, 23);
            this.lblSystemDrag.TabIndex = 13;
            this.lblSystemDrag.Text = "Or Drag and Drop to add a folder";
            this.lblSystemDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSystemDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.systemDragDrop);
            this.lblSystemDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.systemDragEnter);
            // 
            // btnSystemAdd
            // 
            this.btnSystemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemAdd.Location = new System.Drawing.Point(258, 215);
            this.btnSystemAdd.Name = "btnSystemAdd";
            this.btnSystemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSystemAdd.TabIndex = 12;
            this.btnSystemAdd.Text = "Add";
            this.btnSystemAdd.UseVisualStyleBackColor = true;
            this.btnSystemAdd.Click += new System.EventHandler(this.btnSystemAdd_Click);
            this.btnSystemAdd.DragDrop += new System.Windows.Forms.DragEventHandler(this.systemDragDrop);
            this.btnSystemAdd.DragEnter += new System.Windows.Forms.DragEventHandler(this.systemDragEnter);
            // 
            // txtSystem
            // 
            this.txtSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSystem.Location = new System.Drawing.Point(7, 216);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(245, 22);
            this.txtSystem.TabIndex = 11;
            this.txtSystem.DragDrop += new System.Windows.Forms.DragEventHandler(this.systemDragDrop);
            this.txtSystem.DragEnter += new System.Windows.Forms.DragEventHandler(this.systemDragEnter);
            // 
            // dgvSystem
            // 
            this.dgvSystem.AllowUserToAddRows = false;
            this.dgvSystem.AllowUserToDeleteRows = false;
            this.dgvSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystem.Location = new System.Drawing.Point(7, 7);
            this.dgvSystem.Name = "dgvSystem";
            this.dgvSystem.ReadOnly = true;
            this.dgvSystem.RowTemplate.Height = 24;
            this.dgvSystem.Size = new System.Drawing.Size(328, 202);
            this.dgvSystem.TabIndex = 10;
            this.dgvSystem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystem_CellContentClick);
            this.dgvSystem.DragDrop += new System.Windows.Forms.DragEventHandler(this.systemDragDrop);
            this.dgvSystem.DragEnter += new System.Windows.Forms.DragEventHandler(this.systemDragEnter);
            this.dgvSystem.MouseEnter += new System.EventHandler(this.dgvSystem_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 324);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(392, 369);
            this.Name = "Form1";
            this.Text = "PATH Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabPageSystem.ResumeLayout(false);
            this.tabPageSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageSystem;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Label lblUserDrag;
        private System.Windows.Forms.Button btnSystemSave;
        private System.Windows.Forms.Label lblSystemDrag;
        private System.Windows.Forms.Button btnSystemAdd;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.DataGridView dgvSystem;
    }
}

