namespace SSOPrecinctEditor {
    partial class FZone {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panelHeader = new Panel();
            edtDomainId = new NumericUpDown();
            lbDomainId = new Label();
            edtSrcInstance = new NumericUpDown();
            lbSrcInstance = new Label();
            edtDstInstance = new NumericUpDown();
            lbDstInstance = new Label();
            edtPriority = new NumericUpDown();
            lbPriority = new Label();
            edtCoordsCount = new TextBox();
            lbCoordsCount = new Label();
            mainPanel = new Panel();
            panelCoordinates = new Panel();
            gridCoordinates = new DataGridView();
            columnCoordX = new DataGridViewTextBoxColumn();
            columnCoordY = new DataGridViewTextBoxColumn();
            columnCoordZ = new DataGridViewTextBoxColumn();
            panelCoordButtons = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btAddCoord = new Button();
            btRemoveCoord = new Button();
            panel1 = new Panel();
            lbCoordinates = new Label();
            panelCityPos = new Panel();
            gridCityPos = new DataGridView();
            columnFactionMask = new DataGridViewTextBoxColumn();
            columnMapId = new DataGridViewTextBoxColumn();
            columnX = new DataGridViewTextBoxColumn();
            columnY = new DataGridViewTextBoxColumn();
            columnZ = new DataGridViewTextBoxColumn();
            lbCenterPanel = new Panel();
            lbCityPos = new Label();
            panelButtons = new Panel();
            flowButtons = new FlowLayoutPanel();
            btSave = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edtDomainId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtSrcInstance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtDstInstance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtPriority).BeginInit();
            mainPanel.SuspendLayout();
            panelCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCoordinates).BeginInit();
            panelCoordButtons.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panelCityPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCityPos).BeginInit();
            lbCenterPanel.SuspendLayout();
            panelButtons.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(edtDomainId);
            panelHeader.Controls.Add(lbDomainId);
            panelHeader.Controls.Add(edtSrcInstance);
            panelHeader.Controls.Add(lbSrcInstance);
            panelHeader.Controls.Add(edtDstInstance);
            panelHeader.Controls.Add(lbDstInstance);
            panelHeader.Controls.Add(edtPriority);
            panelHeader.Controls.Add(lbPriority);
            panelHeader.Controls.Add(edtCoordsCount);
            panelHeader.Controls.Add(lbCoordsCount);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(732, 68);
            panelHeader.TabIndex = 0;
            // 
            // edtDomainId
            // 
            edtDomainId.Location = new Point(500, 29);
            edtDomainId.Margin = new Padding(3, 2, 3, 2);
            edtDomainId.Name = "edtDomainId";
            edtDomainId.Size = new Size(120, 23);
            edtDomainId.TabIndex = 9;
            // 
            // lbDomainId
            // 
            lbDomainId.AutoSize = true;
            lbDomainId.Location = new Point(500, 11);
            lbDomainId.Name = "lbDomainId";
            lbDomainId.Size = new Size(63, 15);
            lbDomainId.TabIndex = 8;
            lbDomainId.Text = "Domain ID";
            // 
            // edtSrcInstance
            // 
            edtSrcInstance.Location = new Point(374, 29);
            edtSrcInstance.Margin = new Padding(3, 2, 3, 2);
            edtSrcInstance.Name = "edtSrcInstance";
            edtSrcInstance.Size = new Size(120, 23);
            edtSrcInstance.TabIndex = 7;
            // 
            // lbSrcInstance
            // 
            lbSrcInstance.AutoSize = true;
            lbSrcInstance.Location = new Point(374, 11);
            lbSrcInstance.Name = "lbSrcInstance";
            lbSrcInstance.Size = new Size(70, 15);
            lbSrcInstance.TabIndex = 6;
            lbSrcInstance.Text = "Src Instance";
            // 
            // edtDstInstance
            // 
            edtDstInstance.Location = new Point(248, 29);
            edtDstInstance.Margin = new Padding(3, 2, 3, 2);
            edtDstInstance.Name = "edtDstInstance";
            edtDstInstance.Size = new Size(120, 23);
            edtDstInstance.TabIndex = 5;
            // 
            // lbDstInstance
            // 
            lbDstInstance.AutoSize = true;
            lbDstInstance.Location = new Point(248, 11);
            lbDstInstance.Name = "lbDstInstance";
            lbDstInstance.Size = new Size(71, 15);
            lbDstInstance.TabIndex = 4;
            lbDstInstance.Text = "Dst Instance";
            // 
            // edtPriority
            // 
            edtPriority.Location = new Point(122, 29);
            edtPriority.Margin = new Padding(3, 2, 3, 2);
            edtPriority.Name = "edtPriority";
            edtPriority.Size = new Size(120, 23);
            edtPriority.TabIndex = 3;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(122, 11);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 2;
            lbPriority.Text = "Priority";
            // 
            // edtCoordsCount
            // 
            edtCoordsCount.Enabled = false;
            edtCoordsCount.Location = new Point(12, 29);
            edtCoordsCount.Margin = new Padding(3, 2, 3, 2);
            edtCoordsCount.Name = "edtCoordsCount";
            edtCoordsCount.Size = new Size(104, 23);
            edtCoordsCount.TabIndex = 1;
            // 
            // lbCoordsCount
            // 
            lbCoordsCount.AutoSize = true;
            lbCoordsCount.Location = new Point(9, 11);
            lbCoordsCount.Name = "lbCoordsCount";
            lbCoordsCount.Size = new Size(107, 15);
            lbCoordsCount.TabIndex = 0;
            lbCoordsCount.Text = "Coordinates Count";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panelCoordinates);
            mainPanel.Controls.Add(panelCityPos);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 68);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(732, 419);
            mainPanel.TabIndex = 3;
            // 
            // panelCoordinates
            // 
            panelCoordinates.Controls.Add(gridCoordinates);
            panelCoordinates.Controls.Add(panelCoordButtons);
            panelCoordinates.Controls.Add(panel1);
            panelCoordinates.Dock = DockStyle.Fill;
            panelCoordinates.Location = new Point(0, 200);
            panelCoordinates.Margin = new Padding(3, 2, 3, 2);
            panelCoordinates.Name = "panelCoordinates";
            panelCoordinates.Padding = new Padding(5);
            panelCoordinates.Size = new Size(732, 219);
            panelCoordinates.TabIndex = 3;
            // 
            // gridCoordinates
            // 
            gridCoordinates.AllowUserToAddRows = false;
            gridCoordinates.AllowUserToDeleteRows = false;
            gridCoordinates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCoordinates.Columns.AddRange(new DataGridViewColumn[] { columnCoordX, columnCoordY, columnCoordZ });
            gridCoordinates.Dock = DockStyle.Fill;
            gridCoordinates.Location = new Point(5, 33);
            gridCoordinates.Margin = new Padding(3, 2, 3, 2);
            gridCoordinates.Name = "gridCoordinates";
            gridCoordinates.Size = new Size(722, 145);
            gridCoordinates.TabIndex = 2;
            // 
            // columnCoordX
            // 
            columnCoordX.HeaderText = "X";
            columnCoordX.Name = "columnCoordX";
            // 
            // columnCoordY
            // 
            columnCoordY.HeaderText = "Y";
            columnCoordY.Name = "columnCoordY";
            // 
            // columnCoordZ
            // 
            columnCoordZ.HeaderText = "Z";
            columnCoordZ.Name = "columnCoordZ";
            // 
            // panelCoordButtons
            // 
            panelCoordButtons.Controls.Add(flowLayoutPanel1);
            panelCoordButtons.Dock = DockStyle.Bottom;
            panelCoordButtons.Location = new Point(5, 178);
            panelCoordButtons.Margin = new Padding(3, 2, 3, 2);
            panelCoordButtons.Name = "panelCoordButtons";
            panelCoordButtons.Size = new Size(722, 36);
            panelCoordButtons.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btAddCoord);
            flowLayoutPanel1.Controls.Add(btRemoveCoord);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(253, 36);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btAddCoord
            // 
            btAddCoord.Location = new Point(3, 2);
            btAddCoord.Margin = new Padding(3, 2, 3, 2);
            btAddCoord.Name = "btAddCoord";
            btAddCoord.Size = new Size(94, 22);
            btAddCoord.TabIndex = 0;
            btAddCoord.Text = "Add Coord";
            btAddCoord.UseVisualStyleBackColor = true;
            btAddCoord.Click += btAddCoord_Click;
            // 
            // btRemoveCoord
            // 
            btRemoveCoord.Location = new Point(103, 2);
            btRemoveCoord.Margin = new Padding(3, 2, 3, 2);
            btRemoveCoord.Name = "btRemoveCoord";
            btRemoveCoord.Size = new Size(97, 22);
            btRemoveCoord.TabIndex = 1;
            btRemoveCoord.Text = "Remove Coord";
            btRemoveCoord.UseVisualStyleBackColor = true;
            btRemoveCoord.Click += btRemoveCoord_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCoordinates);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 28);
            panel1.TabIndex = 1;
            // 
            // lbCoordinates
            // 
            lbCoordinates.AutoSize = true;
            lbCoordinates.Location = new Point(10, 9);
            lbCoordinates.Name = "lbCoordinates";
            lbCoordinates.Size = new Size(71, 15);
            lbCoordinates.TabIndex = 0;
            lbCoordinates.Text = "Coordinates";
            // 
            // panelCityPos
            // 
            panelCityPos.Controls.Add(gridCityPos);
            panelCityPos.Controls.Add(lbCenterPanel);
            panelCityPos.Dock = DockStyle.Top;
            panelCityPos.Location = new Point(0, 0);
            panelCityPos.Margin = new Padding(3, 2, 3, 2);
            panelCityPos.Name = "panelCityPos";
            panelCityPos.Padding = new Padding(5);
            panelCityPos.Size = new Size(732, 200);
            panelCityPos.TabIndex = 2;
            // 
            // gridCityPos
            // 
            gridCityPos.AllowUserToAddRows = false;
            gridCityPos.AllowUserToDeleteRows = false;
            gridCityPos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCityPos.Columns.AddRange(new DataGridViewColumn[] { columnFactionMask, columnMapId, columnX, columnY, columnZ });
            gridCityPos.Dock = DockStyle.Fill;
            gridCityPos.Location = new Point(5, 33);
            gridCityPos.Margin = new Padding(3, 2, 3, 2);
            gridCityPos.Name = "gridCityPos";
            gridCityPos.Size = new Size(722, 162);
            gridCityPos.TabIndex = 1;
            // 
            // columnFactionMask
            // 
            columnFactionMask.HeaderText = "Faction Mask";
            columnFactionMask.Name = "columnFactionMask";
            // 
            // columnMapId
            // 
            columnMapId.HeaderText = "Map ID";
            columnMapId.Name = "columnMapId";
            // 
            // columnX
            // 
            columnX.HeaderText = "X";
            columnX.Name = "columnX";
            // 
            // columnY
            // 
            columnY.HeaderText = "Y";
            columnY.Name = "columnY";
            // 
            // columnZ
            // 
            columnZ.HeaderText = "Z";
            columnZ.Name = "columnZ";
            // 
            // lbCenterPanel
            // 
            lbCenterPanel.Controls.Add(lbCityPos);
            lbCenterPanel.Dock = DockStyle.Top;
            lbCenterPanel.Location = new Point(5, 5);
            lbCenterPanel.Margin = new Padding(3, 2, 3, 2);
            lbCenterPanel.Name = "lbCenterPanel";
            lbCenterPanel.Size = new Size(722, 28);
            lbCenterPanel.TabIndex = 0;
            // 
            // lbCityPos
            // 
            lbCityPos.AutoSize = true;
            lbCityPos.Location = new Point(10, 9);
            lbCityPos.Name = "lbCityPos";
            lbCityPos.Size = new Size(79, 15);
            lbCityPos.TabIndex = 0;
            lbCityPos.Text = "City Positions";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(flowButtons);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 487);
            panelButtons.Margin = new Padding(3, 2, 3, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(5);
            panelButtons.Size = new Size(732, 58);
            panelButtons.TabIndex = 5;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btSave);
            flowButtons.Dock = DockStyle.Right;
            flowButtons.Location = new Point(641, 5);
            flowButtons.Margin = new Padding(3, 2, 3, 2);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(86, 48);
            flowButtons.TabIndex = 0;
            // 
            // btSave
            // 
            btSave.Location = new Point(3, 2);
            btSave.Margin = new Padding(3, 2, 3, 2);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 41);
            btSave.TabIndex = 0;
            btSave.Text = "Close";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // FZone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 545);
            Controls.Add(mainPanel);
            Controls.Add(panelButtons);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FZone";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zone Edit";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edtDomainId).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtSrcInstance).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtDstInstance).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtPriority).EndInit();
            mainPanel.ResumeLayout(false);
            panelCoordinates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCoordinates).EndInit();
            panelCoordButtons.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCityPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCityPos).EndInit();
            lbCenterPanel.ResumeLayout(false);
            lbCenterPanel.PerformLayout();
            panelButtons.ResumeLayout(false);
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel mainPanel;
        private Panel panelCoordinates;
        private Panel panelCityPos;
        private Panel panelButtons;
        private FlowLayoutPanel flowButtons;
        private Button btSave;
        private TextBox edtCoordsCount;
        private Label lbCoordsCount;
        private Label lbPriority;
        private NumericUpDown edtPriority;
        private NumericUpDown edtDstInstance;
        private Label lbDstInstance;
        private NumericUpDown edtDomainId;
        private Label lbDomainId;
        private NumericUpDown edtSrcInstance;
        private Label lbSrcInstance;
        private Panel panel1;
        private Label lbCoordinates;
        private Panel lbCenterPanel;
        private Label lbCityPos;
        private DataGridView gridCityPos;
        private DataGridViewTextBoxColumn columnFactionMask;
        private DataGridViewTextBoxColumn columnMapId;
        private DataGridViewTextBoxColumn columnX;
        private DataGridViewTextBoxColumn columnY;
        private DataGridViewTextBoxColumn columnZ;
        private DataGridView gridCoordinates;
        private DataGridViewTextBoxColumn columnCoordX;
        private DataGridViewTextBoxColumn columnCoordY;
        private DataGridViewTextBoxColumn columnCoordZ;
        private Panel panelCoordButtons;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btAddCoord;
        private Button btRemoveCoord;
    }
}