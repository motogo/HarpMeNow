namespace HarpMeNow
{
    partial class InstrumentsForm
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
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.cmsHarp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHarpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.ckAutosizeColumns = new System.Windows.Forms.CheckBox();
            this.dgvSLOTS = new System.Windows.Forms.DataGridView();
            this.cmsSlots = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sfvSaveDB = new System.Windows.Forms.SaveFileDialog();
            this.hsLoad = new SeControlsLib.HotSpot();
            this.hsSaveInit = new SeControlsLib.HotSpot();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.cmsHarp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLOTS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDATA
            // 
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.ContextMenuStrip = this.cmsHarp;
            this.dgvDATA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDATA.Location = new System.Drawing.Point(0, 56);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDATA.Size = new System.Drawing.Size(577, 394);
            this.dgvDATA.TabIndex = 5;
            this.dgvDATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellContentClick);
            this.dgvDATA.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellContentDoubleClick);
            this.dgvDATA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellDoubleClick);
            // 
            // cmsHarp
            // 
            this.cmsHarp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHarpEdit});
            this.cmsHarp.Name = "cmsHarp";
            this.cmsHarp.Size = new System.Drawing.Size(95, 26);
            this.cmsHarp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsHarp_ItemClicked);
            // 
            // tsmiHarpEdit
            // 
            this.tsmiHarpEdit.Name = "tsmiHarpEdit";
            this.tsmiHarpEdit.Size = new System.Drawing.Size(94, 22);
            this.tsmiHarpEdit.Text = "Edit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(66, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCount
            // 
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(49, 17);
            this.tsslCount.Text = "Count 0";
            // 
            // pnlUpper
            // 
            this.pnlUpper.Controls.Add(this.hsLoad);
            this.pnlUpper.Controls.Add(this.hsSaveInit);
            this.pnlUpper.Controls.Add(this.ckAutosizeColumns);
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1382, 56);
            this.pnlUpper.TabIndex = 3;
            // 
            // ckAutosizeColumns
            // 
            this.ckAutosizeColumns.AutoSize = true;
            this.ckAutosizeColumns.Checked = true;
            this.ckAutosizeColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAutosizeColumns.Location = new System.Drawing.Point(311, 24);
            this.ckAutosizeColumns.Name = "ckAutosizeColumns";
            this.ckAutosizeColumns.Size = new System.Drawing.Size(109, 17);
            this.ckAutosizeColumns.TabIndex = 14;
            this.ckAutosizeColumns.Text = "Autosize Columns";
            this.ckAutosizeColumns.UseVisualStyleBackColor = true;
            // 
            // dgvSLOTS
            // 
            this.dgvSLOTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSLOTS.ContextMenuStrip = this.cmsSlots;
            this.dgvSLOTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSLOTS.Location = new System.Drawing.Point(577, 56);
            this.dgvSLOTS.Name = "dgvSLOTS";
            this.dgvSLOTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSLOTS.Size = new System.Drawing.Size(805, 394);
            this.dgvSLOTS.TabIndex = 6;
            // 
            // cmsSlots
            // 
            this.cmsSlots.Name = "cmsHarp";
            this.cmsSlots.Size = new System.Drawing.Size(61, 4);
            // 
            // hsLoad
            // 
            this.hsLoad.BackColor = System.Drawing.Color.Transparent;
            this.hsLoad.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoad.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoad.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoad.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoad.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsLoad.FlatAppearance.BorderSize = 0;
            this.hsLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoad.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoad.Image = global::HarpMeNow.Properties.Resources.database_arrow_l_x32;
            this.hsLoad.ImageHover = global::HarpMeNow.Properties.Resources.database_arrow_l_blue_x32;
            this.hsLoad.ImageToggleOnSelect = true;
            this.hsLoad.Location = new System.Drawing.Point(185, 0);
            this.hsLoad.Marked = false;
            this.hsLoad.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoad.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoad.MarkedText = "";
            this.hsLoad.MarkMode = false;
            this.hsLoad.Name = "hsLoad";
            this.hsLoad.NonMarkedText = "";
            this.hsLoad.Size = new System.Drawing.Size(82, 56);
            this.hsLoad.TabIndex = 16;
            this.hsLoad.Text = "Load";
            this.hsLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoad.ToolTipActive = false;
            this.hsLoad.ToolTipAutomaticDelay = 500;
            this.hsLoad.ToolTipAutoPopDelay = 5000;
            this.hsLoad.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoad.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoad.ToolTipFor4ContextMenu = true;
            this.hsLoad.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoad.ToolTipInitialDelay = 500;
            this.hsLoad.ToolTipIsBallon = false;
            this.hsLoad.ToolTipOwnerDraw = false;
            this.hsLoad.ToolTipReshowDelay = 100;
            this.hsLoad.ToolTipShowAlways = false;
            this.hsLoad.ToolTipText = "";
            this.hsLoad.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoad.ToolTipTitle = "";
            this.hsLoad.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoad.UseVisualStyleBackColor = false;
            this.hsLoad.Click += new System.EventHandler(this.hsLoad_Click);
            // 
            // hsSaveInit
            // 
            this.hsSaveInit.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveInit.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveInit.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveInit.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveInit.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveInit.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveInit.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveInit.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSaveInit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveInit.FlatAppearance.BorderSize = 0;
            this.hsSaveInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveInit.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveInit.Image = global::HarpMeNow.Properties.Resources.database_arrow_r_x32;
            this.hsSaveInit.ImageHover = global::HarpMeNow.Properties.Resources.database_arrow_r_blue_x32;
            this.hsSaveInit.ImageToggleOnSelect = true;
            this.hsSaveInit.Location = new System.Drawing.Point(105, 0);
            this.hsSaveInit.Marked = false;
            this.hsSaveInit.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveInit.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveInit.MarkedText = "";
            this.hsSaveInit.MarkMode = false;
            this.hsSaveInit.Name = "hsSaveInit";
            this.hsSaveInit.NonMarkedText = "";
            this.hsSaveInit.Size = new System.Drawing.Size(80, 56);
            this.hsSaveInit.TabIndex = 15;
            this.hsSaveInit.Text = "Save INIT";
            this.hsSaveInit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveInit.ToolTipActive = false;
            this.hsSaveInit.ToolTipAutomaticDelay = 500;
            this.hsSaveInit.ToolTipAutoPopDelay = 5000;
            this.hsSaveInit.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveInit.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveInit.ToolTipFor4ContextMenu = true;
            this.hsSaveInit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveInit.ToolTipInitialDelay = 500;
            this.hsSaveInit.ToolTipIsBallon = false;
            this.hsSaveInit.ToolTipOwnerDraw = false;
            this.hsSaveInit.ToolTipReshowDelay = 100;
            this.hsSaveInit.ToolTipShowAlways = false;
            this.hsSaveInit.ToolTipText = "";
            this.hsSaveInit.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveInit.ToolTipTitle = "";
            this.hsSaveInit.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveInit.UseVisualStyleBackColor = false;
            this.hsSaveInit.Click += new System.EventHandler(this.hsSaveInit_Click);
            // 
            // hsRefresh
            // 
            this.hsRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRefresh.FlatAppearance.BorderSize = 0;
            this.hsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::HarpMeNow.Properties.Resources.view_refresh32x;
            this.hsRefresh.ImageHover = null;
            this.hsRefresh.ImageToggleOnSelect = true;
            this.hsRefresh.Location = new System.Drawing.Point(49, 0);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Size = new System.Drawing.Size(56, 56);
            this.hsRefresh.TabIndex = 2;
            this.hsRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRefresh.ToolTipActive = false;
            this.hsRefresh.ToolTipAutomaticDelay = 500;
            this.hsRefresh.ToolTipAutoPopDelay = 5000;
            this.hsRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefresh.ToolTipFor4ContextMenu = true;
            this.hsRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefresh.ToolTipInitialDelay = 500;
            this.hsRefresh.ToolTipIsBallon = false;
            this.hsRefresh.ToolTipOwnerDraw = false;
            this.hsRefresh.ToolTipReshowDelay = 100;
            this.hsRefresh.ToolTipShowAlways = false;
            this.hsRefresh.ToolTipText = "";
            this.hsRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefresh.ToolTipTitle = "";
            this.hsRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefresh.UseVisualStyleBackColor = false;
            this.hsRefresh.Click += new System.EventHandler(this.hsRefresh_Click);
            // 
            // hsClose
            // 
            this.hsClose.BackColor = System.Drawing.Color.Transparent;
            this.hsClose.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClose.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClose.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClose.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClose.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClose.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::HarpMeNow.Properties.Resources.go_previous32x;
            this.hsClose.ImageHover = null;
            this.hsClose.ImageToggleOnSelect = true;
            this.hsClose.Location = new System.Drawing.Point(0, 0);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Size = new System.Drawing.Size(49, 56);
            this.hsClose.TabIndex = 1;
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsClose.ToolTipActive = false;
            this.hsClose.ToolTipAutomaticDelay = 500;
            this.hsClose.ToolTipAutoPopDelay = 5000;
            this.hsClose.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClose.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClose.ToolTipFor4ContextMenu = true;
            this.hsClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClose.ToolTipInitialDelay = 500;
            this.hsClose.ToolTipIsBallon = false;
            this.hsClose.ToolTipOwnerDraw = false;
            this.hsClose.ToolTipReshowDelay = 100;
            this.hsClose.ToolTipShowAlways = false;
            this.hsClose.ToolTipText = "";
            this.hsClose.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClose.ToolTipTitle = "";
            this.hsClose.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClose.UseVisualStyleBackColor = false;
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdLoadDB";
            // 
            // InstrumentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 450);
            this.Controls.Add(this.dgvSLOTS);
            this.Controls.Add(this.dgvDATA);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlUpper);
            this.Name = "InstrumentsForm";
            this.Text = "InstrumentsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstrumentsForm_FormClosing);
            this.Load += new System.EventHandler(this.InstrumentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.cmsHarp.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLOTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.CheckBox ckAutosizeColumns;
        private SeControlsLib.HotSpot hsRefresh;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.DataGridView dgvSLOTS;
        private System.Windows.Forms.ContextMenuStrip cmsHarp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHarpEdit;
        private System.Windows.Forms.ContextMenuStrip cmsSlots;
        private System.Windows.Forms.SaveFileDialog sfvSaveDB;
        private SeControlsLib.HotSpot hsSaveInit;
        private SeControlsLib.HotSpot hsLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}