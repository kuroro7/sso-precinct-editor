namespace SSOPrecinctEditor {
    partial class FMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openMenu = new ToolStripMenuItem();
            saveMenu = new ToolStripMenuItem();
            exitMenu = new ToolStripMenuItem();
            panelHeader = new Panel();
            edtBuildTime = new TextBox();
            lbBuildTime = new Label();
            edtZoneCount = new TextBox();
            lbZoneCount = new Label();
            edtVersion = new TextBox();
            lbVersion = new Label();
            statusStrip = new StatusStrip();
            lbStatus = new ToolStripStatusLabel();
            panelTable = new Panel();
            mainGridPanel = new Panel();
            grid = new DataGridView();
            columnIndex = new DataGridViewTextBoxColumn();
            columnCoordinates = new DataGridViewTextBoxColumn();
            columnPriority = new DataGridViewTextBoxColumn();
            columnDstInstance = new DataGridViewTextBoxColumn();
            columnSrcInstance = new DataGridViewTextBoxColumn();
            columnDomainId = new DataGridViewTextBoxColumn();
            gridOptionsPanel = new Panel();
            flowButtonPanel = new FlowLayoutPanel();
            btAdd = new Button();
            btEdit = new Button();
            btRemove = new Button();
            menuStrip1.SuspendLayout();
            panelHeader.SuspendLayout();
            statusStrip.SuspendLayout();
            panelTable.SuspendLayout();
            mainGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            gridOptionsPanel.SuspendLayout();
            flowButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenu, saveMenu, exitMenu });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMenu
            // 
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(103, 22);
            openMenu.Text = "Open";
            openMenu.Click += openMenu_Click;
            // 
            // saveMenu
            // 
            saveMenu.Name = "saveMenu";
            saveMenu.Size = new Size(103, 22);
            saveMenu.Text = "Save";
            saveMenu.Click += saveMenu_Click;
            // 
            // exitMenu
            // 
            exitMenu.Name = "exitMenu";
            exitMenu.Size = new Size(103, 22);
            exitMenu.Text = "Exit";
            exitMenu.Click += exitMenu_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(edtBuildTime);
            panelHeader.Controls.Add(lbBuildTime);
            panelHeader.Controls.Add(edtZoneCount);
            panelHeader.Controls.Add(lbZoneCount);
            panelHeader.Controls.Add(edtVersion);
            panelHeader.Controls.Add(lbVersion);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 24);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 71);
            panelHeader.TabIndex = 1;
            // 
            // edtBuildTime
            // 
            edtBuildTime.Enabled = false;
            edtBuildTime.Location = new Point(226, 29);
            edtBuildTime.Margin = new Padding(3, 2, 3, 2);
            edtBuildTime.Name = "edtBuildTime";
            edtBuildTime.ReadOnly = true;
            edtBuildTime.Size = new Size(168, 23);
            edtBuildTime.TabIndex = 5;
            // 
            // lbBuildTime
            // 
            lbBuildTime.AutoSize = true;
            lbBuildTime.Location = new Point(224, 11);
            lbBuildTime.Name = "lbBuildTime";
            lbBuildTime.Size = new Size(63, 15);
            lbBuildTime.TabIndex = 4;
            lbBuildTime.Text = "Build Time";
            // 
            // edtZoneCount
            // 
            edtZoneCount.Enabled = false;
            edtZoneCount.Location = new Point(120, 29);
            edtZoneCount.Margin = new Padding(3, 2, 3, 2);
            edtZoneCount.Name = "edtZoneCount";
            edtZoneCount.ReadOnly = true;
            edtZoneCount.Size = new Size(100, 23);
            edtZoneCount.TabIndex = 3;
            // 
            // lbZoneCount
            // 
            lbZoneCount.AutoSize = true;
            lbZoneCount.Location = new Point(118, 11);
            lbZoneCount.Name = "lbZoneCount";
            lbZoneCount.Size = new Size(39, 15);
            lbZoneCount.TabIndex = 2;
            lbZoneCount.Text = "Zones";
            // 
            // edtVersion
            // 
            edtVersion.Enabled = false;
            edtVersion.Location = new Point(12, 29);
            edtVersion.Margin = new Padding(3, 2, 3, 2);
            edtVersion.Name = "edtVersion";
            edtVersion.ReadOnly = true;
            edtVersion.Size = new Size(100, 23);
            edtVersion.TabIndex = 1;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(10, 11);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(45, 15);
            lbVersion.TabIndex = 0;
            lbVersion.Text = "Version";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lbStatus });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(60, 17);
            lbStatus.Text = "File: None";
            // 
            // panelTable
            // 
            panelTable.Controls.Add(mainGridPanel);
            panelTable.Controls.Add(gridOptionsPanel);
            panelTable.Dock = DockStyle.Fill;
            panelTable.Location = new Point(0, 95);
            panelTable.Margin = new Padding(3, 2, 3, 2);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(800, 333);
            panelTable.TabIndex = 2;
            // 
            // mainGridPanel
            // 
            mainGridPanel.Controls.Add(grid);
            mainGridPanel.Dock = DockStyle.Fill;
            mainGridPanel.Location = new Point(0, 0);
            mainGridPanel.Margin = new Padding(3, 2, 3, 2);
            mainGridPanel.Name = "mainGridPanel";
            mainGridPanel.Padding = new Padding(5, 5, 5, 5);
            mainGridPanel.Size = new Size(800, 284);
            mainGridPanel.TabIndex = 0;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { columnIndex, columnCoordinates, columnPriority, columnDstInstance, columnSrcInstance, columnDomainId });
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(5, 5);
            grid.Margin = new Padding(3, 2, 3, 2);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(790, 274);
            grid.TabIndex = 0;
            // 
            // columnIndex
            // 
            columnIndex.HeaderText = "Index";
            columnIndex.Name = "columnIndex";
            columnIndex.ReadOnly = true;
            // 
            // columnCoordinates
            // 
            columnCoordinates.HeaderText = "Coordinates";
            columnCoordinates.Name = "columnCoordinates";
            columnCoordinates.ReadOnly = true;
            // 
            // columnPriority
            // 
            columnPriority.HeaderText = "Priority";
            columnPriority.Name = "columnPriority";
            columnPriority.ReadOnly = true;
            // 
            // columnDstInstance
            // 
            columnDstInstance.HeaderText = "Dst Instance";
            columnDstInstance.Name = "columnDstInstance";
            columnDstInstance.ReadOnly = true;
            // 
            // columnSrcInstance
            // 
            columnSrcInstance.HeaderText = "Src Instance";
            columnSrcInstance.Name = "columnSrcInstance";
            columnSrcInstance.ReadOnly = true;
            // 
            // columnDomainId
            // 
            columnDomainId.HeaderText = "Domain ID";
            columnDomainId.Name = "columnDomainId";
            columnDomainId.ReadOnly = true;
            // 
            // gridOptionsPanel
            // 
            gridOptionsPanel.Controls.Add(flowButtonPanel);
            gridOptionsPanel.Dock = DockStyle.Bottom;
            gridOptionsPanel.Location = new Point(0, 284);
            gridOptionsPanel.Margin = new Padding(3, 2, 3, 2);
            gridOptionsPanel.Name = "gridOptionsPanel";
            gridOptionsPanel.Size = new Size(800, 49);
            gridOptionsPanel.TabIndex = 1;
            // 
            // flowButtonPanel
            // 
            flowButtonPanel.Controls.Add(btAdd);
            flowButtonPanel.Controls.Add(btEdit);
            flowButtonPanel.Controls.Add(btRemove);
            flowButtonPanel.Dock = DockStyle.Right;
            flowButtonPanel.Location = new Point(555, 0);
            flowButtonPanel.Margin = new Padding(3, 2, 3, 2);
            flowButtonPanel.Name = "flowButtonPanel";
            flowButtonPanel.Size = new Size(245, 49);
            flowButtonPanel.TabIndex = 0;
            // 
            // btAdd
            // 
            btAdd.Enabled = false;
            btAdd.Location = new Point(3, 2);
            btAdd.Margin = new Padding(3, 2, 3, 2);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 44);
            btAdd.TabIndex = 0;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btEdit
            // 
            btEdit.Enabled = false;
            btEdit.Location = new Point(84, 2);
            btEdit.Margin = new Padding(3, 2, 3, 2);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 44);
            btEdit.TabIndex = 1;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btRemove
            // 
            btRemove.Enabled = false;
            btRemove.Location = new Point(165, 2);
            btRemove.Margin = new Padding(3, 2, 3, 2);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(75, 44);
            btRemove.TabIndex = 2;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTable);
            Controls.Add(panelHeader);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSO Precinct Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelTable.ResumeLayout(false);
            mainGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            gridOptionsPanel.ResumeLayout(false);
            flowButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openMenu;
        private ToolStripMenuItem saveMenu;
        private ToolStripMenuItem exitMenu;
        private Panel panelHeader;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lbStatus;
        private Panel panelTable;
        private TextBox edtVersion;
        private Label lbVersion;
        private TextBox edtZoneCount;
        private Label lbZoneCount;
        private TextBox edtBuildTime;
        private Label lbBuildTime;
        private Panel mainGridPanel;
        private Panel gridOptionsPanel;
        private FlowLayoutPanel flowButtonPanel;
        private Button btAdd;
        private Button btEdit;
        private Button btRemove;
        private DataGridView grid;
        private DataGridViewTextBoxColumn columnIndex;
        private DataGridViewTextBoxColumn columnCoordinates;
        private DataGridViewTextBoxColumn columnPriority;
        private DataGridViewTextBoxColumn columnDstInstance;
        private DataGridViewTextBoxColumn columnSrcInstance;
        private DataGridViewTextBoxColumn columnDomainId;
    }
}
