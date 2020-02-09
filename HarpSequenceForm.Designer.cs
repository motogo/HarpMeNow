namespace HarpMeNow
{
    partial class HarpSequenceForm
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
            this.gbNotation = new System.Windows.Forms.GroupBox();
            this.gbHarpSequence = new System.Windows.Forms.GroupBox();
            this.rtbSongHarp = new System.Windows.Forms.RichTextBox();
            this.cmsHarpSongNotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLoadHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPlayHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayHarpSongDelayed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlaySelectedHarpText = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHarpSequenceUpper = new System.Windows.Forms.Panel();
            this.gbPlaySingleNote = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hsPlaySingleNote = new SeControlsLib.HotSpot();
            this.txtHarpSlotNr = new System.Windows.Forms.TextBox();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.sfdHarpSong = new System.Windows.Forms.SaveFileDialog();
            this.ofdHarpSong = new System.Windows.Forms.OpenFileDialog();
            this.gbNotation.SuspendLayout();
            this.gbHarpSequence.SuspendLayout();
            this.cmsHarpSongNotation.SuspendLayout();
            this.pnlHarpSequenceUpper.SuspendLayout();
            this.gbPlaySingleNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNotation
            // 
            this.gbNotation.Controls.Add(this.gbHarpSequence);
            this.gbNotation.Controls.Add(this.pnlHarpSequenceUpper);
            this.gbNotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNotation.Location = new System.Drawing.Point(0, 0);
            this.gbNotation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNotation.Name = "gbNotation";
            this.gbNotation.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNotation.Size = new System.Drawing.Size(689, 461);
            this.gbNotation.TabIndex = 15;
            this.gbNotation.TabStop = false;
            // 
            // gbHarpSequence
            // 
            this.gbHarpSequence.Controls.Add(this.rtbSongHarp);
            this.gbHarpSequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHarpSequence.Location = new System.Drawing.Point(2, 73);
            this.gbHarpSequence.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbHarpSequence.Name = "gbHarpSequence";
            this.gbHarpSequence.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbHarpSequence.Size = new System.Drawing.Size(685, 385);
            this.gbHarpSequence.TabIndex = 15;
            this.gbHarpSequence.TabStop = false;
            this.gbHarpSequence.Text = "Harp Sequence";
            // 
            // rtbSongHarp
            // 
            this.rtbSongHarp.ContextMenuStrip = this.cmsHarpSongNotation;
            this.rtbSongHarp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSongHarp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSongHarp.Location = new System.Drawing.Point(2, 17);
            this.rtbSongHarp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbSongHarp.Name = "rtbSongHarp";
            this.rtbSongHarp.Size = new System.Drawing.Size(681, 365);
            this.rtbSongHarp.TabIndex = 13;
            this.rtbSongHarp.Text = "";
            // 
            // cmsHarpSongNotation
            // 
            this.cmsHarpSongNotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadHarpSong,
            this.tsmiSaveHarpSong,
            this.toolStripSeparator1,
            this.tsmiPlayHarpSong,
            this.tsmiPlayHarpSongDelayed,
            this.tsmiPlaySelectedHarpText});
            this.cmsHarpSongNotation.Name = "cmsSongNotation";
            this.cmsHarpSongNotation.Size = new System.Drawing.Size(274, 120);
            this.cmsHarpSongNotation.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsHarpSongNotation_ItemClicked);
            // 
            // tsmiLoadHarpSong
            // 
            this.tsmiLoadHarpSong.Image = global::HarpMeNow.Properties.Resources.folder_open_document_22x;
            this.tsmiLoadHarpSong.Name = "tsmiLoadHarpSong";
            this.tsmiLoadHarpSong.Size = new System.Drawing.Size(273, 22);
            this.tsmiLoadHarpSong.Text = "Load harp notation";
            // 
            // tsmiSaveHarpSong
            // 
            this.tsmiSaveHarpSong.Image = global::HarpMeNow.Properties.Resources.floppy_x24;
            this.tsmiSaveHarpSong.Name = "tsmiSaveHarpSong";
            this.tsmiSaveHarpSong.Size = new System.Drawing.Size(273, 22);
            this.tsmiSaveHarpSong.Text = "Save harp notation";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // tsmiPlayHarpSong
            // 
            this.tsmiPlayHarpSong.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.tsmiPlayHarpSong.Name = "tsmiPlayHarpSong";
            this.tsmiPlayHarpSong.Size = new System.Drawing.Size(273, 22);
            this.tsmiPlayHarpSong.Text = "Play complete harp sequence";
            // 
            // tsmiPlayHarpSongDelayed
            // 
            this.tsmiPlayHarpSongDelayed.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.tsmiPlayHarpSongDelayed.Name = "tsmiPlayHarpSongDelayed";
            this.tsmiPlayHarpSongDelayed.Size = new System.Drawing.Size(273, 22);
            this.tsmiPlayHarpSongDelayed.Text = "Play complete harp sequence delayed";
            // 
            // tsmiPlaySelectedHarpText
            // 
            this.tsmiPlaySelectedHarpText.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px;
            this.tsmiPlaySelectedHarpText.Name = "tsmiPlaySelectedHarpText";
            this.tsmiPlaySelectedHarpText.Size = new System.Drawing.Size(273, 22);
            this.tsmiPlaySelectedHarpText.Text = "Play selected harp sequence";
            // 
            // pnlHarpSequenceUpper
            // 
            this.pnlHarpSequenceUpper.Controls.Add(this.gbPlaySingleNote);
            this.pnlHarpSequenceUpper.Controls.Add(this.hsCloseApp);
            this.pnlHarpSequenceUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHarpSequenceUpper.Location = new System.Drawing.Point(2, 17);
            this.pnlHarpSequenceUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHarpSequenceUpper.Name = "pnlHarpSequenceUpper";
            this.pnlHarpSequenceUpper.Size = new System.Drawing.Size(685, 56);
            this.pnlHarpSequenceUpper.TabIndex = 14;
            // 
            // gbPlaySingleNote
            // 
            this.gbPlaySingleNote.Controls.Add(this.label1);
            this.gbPlaySingleNote.Controls.Add(this.hsPlaySingleNote);
            this.gbPlaySingleNote.Controls.Add(this.txtHarpSlotNr);
            this.gbPlaySingleNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlaySingleNote.Location = new System.Drawing.Point(74, 0);
            this.gbPlaySingleNote.Margin = new System.Windows.Forms.Padding(2);
            this.gbPlaySingleNote.Name = "gbPlaySingleNote";
            this.gbPlaySingleNote.Padding = new System.Windows.Forms.Padding(2);
            this.gbPlaySingleNote.Size = new System.Drawing.Size(126, 56);
            this.gbPlaySingleNote.TabIndex = 31;
            this.gbPlaySingleNote.TabStop = false;
            this.gbPlaySingleNote.Text = "Play single note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Note:";
            // 
            // hsPlaySingleNote
            // 
            this.hsPlaySingleNote.BackColor = System.Drawing.Color.Transparent;
            this.hsPlaySingleNote.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPlaySingleNote.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPlaySingleNote.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPlaySingleNote.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPlaySingleNote.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPlaySingleNote.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPlaySingleNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsPlaySingleNote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsPlaySingleNote.FlatAppearance.BorderSize = 0;
            this.hsPlaySingleNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPlaySingleNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPlaySingleNote.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPlaySingleNote.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.hsPlaySingleNote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsPlaySingleNote.ImageHover = global::HarpMeNow.Properties.Resources.sechzehntel_note_black_24px;
            this.hsPlaySingleNote.ImageToggleOnSelect = false;
            this.hsPlaySingleNote.Location = new System.Drawing.Point(2, 16);
            this.hsPlaySingleNote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hsPlaySingleNote.Marked = false;
            this.hsPlaySingleNote.MarkedColor = System.Drawing.Color.Teal;
            this.hsPlaySingleNote.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPlaySingleNote.MarkedText = "";
            this.hsPlaySingleNote.MarkMode = false;
            this.hsPlaySingleNote.Name = "hsPlaySingleNote";
            this.hsPlaySingleNote.NonMarkedText = "";
            this.hsPlaySingleNote.Size = new System.Drawing.Size(30, 38);
            this.hsPlaySingleNote.TabIndex = 27;
            this.hsPlaySingleNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsPlaySingleNote.ToolTipActive = false;
            this.hsPlaySingleNote.ToolTipAutomaticDelay = 500;
            this.hsPlaySingleNote.ToolTipAutoPopDelay = 5000;
            this.hsPlaySingleNote.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPlaySingleNote.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPlaySingleNote.ToolTipFor4ContextMenu = true;
            this.hsPlaySingleNote.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPlaySingleNote.ToolTipInitialDelay = 500;
            this.hsPlaySingleNote.ToolTipIsBallon = false;
            this.hsPlaySingleNote.ToolTipOwnerDraw = false;
            this.hsPlaySingleNote.ToolTipReshowDelay = 100;
            this.hsPlaySingleNote.ToolTipShowAlways = false;
            this.hsPlaySingleNote.ToolTipText = "";
            this.hsPlaySingleNote.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPlaySingleNote.ToolTipTitle = "";
            this.hsPlaySingleNote.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPlaySingleNote.UseVisualStyleBackColor = false;
            this.hsPlaySingleNote.Click += new System.EventHandler(this.hsPlaySingleNote_Click_1);
            // 
            // txtHarpSlotNr
            // 
            this.txtHarpSlotNr.Location = new System.Drawing.Point(85, 19);
            this.txtHarpSlotNr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHarpSlotNr.Name = "txtHarpSlotNr";
            this.txtHarpSlotNr.Size = new System.Drawing.Size(30, 21);
            this.txtHarpSlotNr.TabIndex = 22;
            this.txtHarpSlotNr.Text = "5";
            // 
            // hsCloseApp
            // 
            this.hsCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.hsCloseApp.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCloseApp.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCloseApp.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCloseApp.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCloseApp.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCloseApp.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCloseApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsCloseApp.FlatAppearance.BorderSize = 0;
            this.hsCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCloseApp.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCloseApp.Image = global::HarpMeNow.Properties.Resources.go_previous32x;
            this.hsCloseApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCloseApp.ImageHover = global::HarpMeNow.Properties.Resources.go_left_blue32x;
            this.hsCloseApp.ImageToggleOnSelect = true;
            this.hsCloseApp.Location = new System.Drawing.Point(0, 0);
            this.hsCloseApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hsCloseApp.Marked = false;
            this.hsCloseApp.MarkedColor = System.Drawing.Color.Teal;
            this.hsCloseApp.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCloseApp.MarkedText = "";
            this.hsCloseApp.MarkMode = false;
            this.hsCloseApp.Name = "hsCloseApp";
            this.hsCloseApp.NonMarkedText = "";
            this.hsCloseApp.Size = new System.Drawing.Size(74, 56);
            this.hsCloseApp.TabIndex = 32;
            this.hsCloseApp.Text = "Close";
            this.hsCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsCloseApp.ToolTipActive = false;
            this.hsCloseApp.ToolTipAutomaticDelay = 500;
            this.hsCloseApp.ToolTipAutoPopDelay = 5000;
            this.hsCloseApp.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCloseApp.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCloseApp.ToolTipFor4ContextMenu = true;
            this.hsCloseApp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCloseApp.ToolTipInitialDelay = 500;
            this.hsCloseApp.ToolTipIsBallon = false;
            this.hsCloseApp.ToolTipOwnerDraw = false;
            this.hsCloseApp.ToolTipReshowDelay = 100;
            this.hsCloseApp.ToolTipShowAlways = false;
            this.hsCloseApp.ToolTipText = "";
            this.hsCloseApp.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCloseApp.ToolTipTitle = "";
            this.hsCloseApp.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCloseApp.UseVisualStyleBackColor = false;
            this.hsCloseApp.Click += new System.EventHandler(this.hsCloseApp_Click);
            // 
            // sfdHarpSong
            // 
            this.sfdHarpSong.DefaultExt = "*.hrp";
            this.sfdHarpSong.Filter = "Harp File|*.hrp|All|*.*";
            this.sfdHarpSong.Title = "Save Harp NOtation";
            // 
            // ofdHarpSong
            // 
            this.ofdHarpSong.DefaultExt = "*.hrp";
            this.ofdHarpSong.FileName = "openFileDialog1";
            this.ofdHarpSong.Filter = "Harp Norification|*.hrp|All|*.*";
            this.ofdHarpSong.Title = "Open Harp Norofication";
            // 
            // HarpSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 461);
            this.Controls.Add(this.gbNotation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HarpSequenceForm";
            this.Text = "HarpSequenceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HarpSequenceForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNotation.ResumeLayout(false);
            this.gbHarpSequence.ResumeLayout(false);
            this.cmsHarpSongNotation.ResumeLayout(false);
            this.pnlHarpSequenceUpper.ResumeLayout(false);
            this.gbPlaySingleNote.ResumeLayout(false);
            this.gbPlaySingleNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNotation;
        private System.Windows.Forms.GroupBox gbHarpSequence;
        public System.Windows.Forms.RichTextBox rtbSongHarp;
        private System.Windows.Forms.Panel pnlHarpSequenceUpper;
        private System.Windows.Forms.GroupBox gbPlaySingleNote;
        private System.Windows.Forms.Label label1;
        private SeControlsLib.HotSpot hsPlaySingleNote;
        private System.Windows.Forms.TextBox txtHarpSlotNr;
        private System.Windows.Forms.ContextMenuStrip cmsHarpSongNotation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadHarpSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveHarpSong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayHarpSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayHarpSongDelayed;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlaySelectedHarpText;
        private System.Windows.Forms.SaveFileDialog sfdHarpSong;
        private System.Windows.Forms.OpenFileDialog ofdHarpSong;
        private SeControlsLib.HotSpot hsCloseApp;
    }
}