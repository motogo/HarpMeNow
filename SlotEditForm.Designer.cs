namespace HarpMeNow
{
    partial class SlotEditForm
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
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsSave = new SeControlsLib.HotSpot();
            this.hsCancel = new SeControlsLib.HotSpot();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gbKey = new System.Windows.Forms.GroupBox();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.gbName.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.gbDescription.SuspendLayout();
            this.gbKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtNote);
            this.gbName.Location = new System.Drawing.Point(12, 68);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(499, 43);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(3, 16);
            this.txtNote.Name = "txtName";
            this.txtNote.Size = new System.Drawing.Size(493, 20);
            this.txtNote.TabIndex = 0;
            // 
            // pnlUpper
            // 
            this.pnlUpper.Controls.Add(this.hsSave);
            this.pnlUpper.Controls.Add(this.hsCancel);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(578, 62);
            this.pnlUpper.TabIndex = 4;
            // 
            // hsSave
            // 
            this.hsSave.BackColor = System.Drawing.Color.Transparent;
            this.hsSave.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSave.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSave.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSave.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSave.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSave.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSave.FlatAppearance.BorderSize = 0;
            this.hsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSave.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSave.Image = global::HarpMeNow.Properties.Resources.ok_gn32x;
            this.hsSave.ImageHover = global::HarpMeNow.Properties.Resources.ok_blue32x;
            this.hsSave.ImageToggleOnSelect = true;
            this.hsSave.Location = new System.Drawing.Point(55, 0);
            this.hsSave.Marked = false;
            this.hsSave.MarkedColor = System.Drawing.Color.Teal;
            this.hsSave.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSave.MarkedText = "";
            this.hsSave.MarkMode = false;
            this.hsSave.Name = "hsSave";
            this.hsSave.NonMarkedText = "";
            this.hsSave.Size = new System.Drawing.Size(55, 62);
            this.hsSave.TabIndex = 3;
            this.hsSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSave.ToolTipActive = false;
            this.hsSave.ToolTipAutomaticDelay = 500;
            this.hsSave.ToolTipAutoPopDelay = 5000;
            this.hsSave.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSave.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSave.ToolTipFor4ContextMenu = true;
            this.hsSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSave.ToolTipInitialDelay = 500;
            this.hsSave.ToolTipIsBallon = false;
            this.hsSave.ToolTipOwnerDraw = false;
            this.hsSave.ToolTipReshowDelay = 100;
            this.hsSave.ToolTipShowAlways = false;
            this.hsSave.ToolTipText = "";
            this.hsSave.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSave.ToolTipTitle = "";
            this.hsSave.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSave.UseVisualStyleBackColor = false;
            this.hsSave.Click += new System.EventHandler(this.hsSave_Click);
            // 
            // hsCancel
            // 
            this.hsCancel.BackColor = System.Drawing.Color.Transparent;
            this.hsCancel.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCancel.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCancel.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCancel.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCancel.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCancel.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsCancel.FlatAppearance.BorderSize = 0;
            this.hsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCancel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancel.Image = global::HarpMeNow.Properties.Resources.cross_red_x32;
            this.hsCancel.ImageHover = global::HarpMeNow.Properties.Resources.cross_blue_x32;
            this.hsCancel.ImageToggleOnSelect = true;
            this.hsCancel.Location = new System.Drawing.Point(0, 0);
            this.hsCancel.Marked = false;
            this.hsCancel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancel.MarkedText = "";
            this.hsCancel.MarkMode = false;
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.NonMarkedText = "";
            this.hsCancel.Size = new System.Drawing.Size(55, 62);
            this.hsCancel.TabIndex = 1;
            this.hsCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCancel.ToolTipActive = false;
            this.hsCancel.ToolTipAutomaticDelay = 500;
            this.hsCancel.ToolTipAutoPopDelay = 5000;
            this.hsCancel.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCancel.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCancel.ToolTipFor4ContextMenu = true;
            this.hsCancel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCancel.ToolTipInitialDelay = 500;
            this.hsCancel.ToolTipIsBallon = false;
            this.hsCancel.ToolTipOwnerDraw = false;
            this.hsCancel.ToolTipReshowDelay = 100;
            this.hsCancel.ToolTipShowAlways = false;
            this.hsCancel.ToolTipText = "";
            this.hsCancel.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCancel.ToolTipTitle = "";
            this.hsCancel.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCancel.UseVisualStyleBackColor = false;
            this.hsCancel.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.txtDescription);
            this.gbDescription.Location = new System.Drawing.Point(12, 117);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(499, 43);
            this.gbDescription.TabIndex = 5;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 16);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(493, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // gbKey
            // 
            this.gbKey.Controls.Add(this.cbKey);
            this.gbKey.Location = new System.Drawing.Point(12, 179);
            this.gbKey.Name = "gbKey";
            this.gbKey.Size = new System.Drawing.Size(205, 43);
            this.gbKey.TabIndex = 6;
            this.gbKey.TabStop = false;
            this.gbKey.Text = "Key";
            // 
            // cbKey
            // 
            this.cbKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Location = new System.Drawing.Point(3, 16);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(199, 21);
            this.cbKey.TabIndex = 0;
            // 
            // SlotEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 279);
            this.Controls.Add(this.gbKey);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.pnlUpper);
            this.Controls.Add(this.gbName);
            this.Name = "SlotEditForm";
            this.Text = "SlotEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlotEditForm_FormClosing);
            this.Load += new System.EventHandler(this.SlotEditForm_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.gbKey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsSave;
        private SeControlsLib.HotSpot hsCancel;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox gbKey;
        private System.Windows.Forms.ComboBox cbKey;
    }
}