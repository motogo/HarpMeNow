namespace HarpMeNow
{
    partial class SongSequenceForm
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
            this.pnlNotationUpper = new System.Windows.Forms.Panel();
            this.gbTranslateType = new System.Windows.Forms.GroupBox();
            this.cbTranslateType = new System.Windows.Forms.ComboBox();
            this.gbShift = new System.Windows.Forms.GroupBox();
            this.trkShift = new System.Windows.Forms.TrackBar();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.gbRowSize = new System.Windows.Forms.GroupBox();
            this.txtRowOffset = new System.Windows.Forms.TextBox();
            this.gbAppendNoteToText = new System.Windows.Forms.GroupBox();
            this.lblFullNoteMS = new System.Windows.Forms.Label();
            this.txtFullNoteMS = new System.Windows.Forms.TextBox();
            this.cbPlayedNoteAppendToText = new System.Windows.Forms.CheckBox();
            this.cmsInsertNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEndEditMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGanzNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHalbeNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViertelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAchtelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSechzehntelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDreiViertelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDreiAchtelNote = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSongNotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLoadSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTranslateNotationToHarpSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTranslatoToHarpAndPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTranspose = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSong = new System.Windows.Forms.OpenFileDialog();
            this.sfdSong = new System.Windows.Forms.SaveFileDialog();
            this.gbSongNotation = new System.Windows.Forms.GroupBox();
            this.rtbSong = new System.Windows.Forms.RichTextBox();
            this.tsmiNewSong = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNotationUpper.SuspendLayout();
            this.gbTranslateType.SuspendLayout();
            this.gbShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkShift)).BeginInit();
            this.gbRowSize.SuspendLayout();
            this.gbAppendNoteToText.SuspendLayout();
            this.cmsInsertNotes.SuspendLayout();
            this.cmsSongNotation.SuspendLayout();
            this.gbSongNotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotationUpper
            // 
            this.pnlNotationUpper.Controls.Add(this.gbTranslateType);
            this.pnlNotationUpper.Controls.Add(this.gbShift);
            this.pnlNotationUpper.Controls.Add(this.hsCloseApp);
            this.pnlNotationUpper.Controls.Add(this.gbRowSize);
            this.pnlNotationUpper.Controls.Add(this.gbAppendNoteToText);
            this.pnlNotationUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotationUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlNotationUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlNotationUpper.Name = "pnlNotationUpper";
            this.pnlNotationUpper.Size = new System.Drawing.Size(921, 50);
            this.pnlNotationUpper.TabIndex = 7;
            // 
            // gbTranslateType
            // 
            this.gbTranslateType.Controls.Add(this.cbTranslateType);
            this.gbTranslateType.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTranslateType.Location = new System.Drawing.Point(74, 0);
            this.gbTranslateType.Name = "gbTranslateType";
            this.gbTranslateType.Size = new System.Drawing.Size(256, 50);
            this.gbTranslateType.TabIndex = 6;
            this.gbTranslateType.TabStop = false;
            this.gbTranslateType.Text = "Translate Type";
            // 
            // cbTranslateType
            // 
            this.cbTranslateType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTranslateType.FormattingEnabled = true;
            this.cbTranslateType.Location = new System.Drawing.Point(3, 18);
            this.cbTranslateType.Name = "cbTranslateType";
            this.cbTranslateType.Size = new System.Drawing.Size(250, 22);
            this.cbTranslateType.TabIndex = 6;
            // 
            // gbShift
            // 
            this.gbShift.Controls.Add(this.trkShift);
            this.gbShift.Location = new System.Drawing.Point(354, 3);
            this.gbShift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbShift.Name = "gbShift";
            this.gbShift.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbShift.Size = new System.Drawing.Size(271, 53);
            this.gbShift.TabIndex = 42;
            this.gbShift.TabStop = false;
            this.gbShift.Text = "Shift (0)";
            // 
            // trkShift
            // 
            this.trkShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkShift.Location = new System.Drawing.Point(2, 18);
            this.trkShift.Maximum = 12;
            this.trkShift.Minimum = -12;
            this.trkShift.Name = "trkShift";
            this.trkShift.Size = new System.Drawing.Size(267, 32);
            this.trkShift.TabIndex = 30;
            this.trkShift.Scroll += new System.EventHandler(this.trkShift_Scroll);
            this.trkShift.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trkShift_KeyUp);
            this.trkShift.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkShift_MouseUp);
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
            this.hsCloseApp.Size = new System.Drawing.Size(74, 50);
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
            // gbRowSize
            // 
            this.gbRowSize.Controls.Add(this.txtRowOffset);
            this.gbRowSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbRowSize.Location = new System.Drawing.Point(629, 0);
            this.gbRowSize.Margin = new System.Windows.Forms.Padding(2);
            this.gbRowSize.Name = "gbRowSize";
            this.gbRowSize.Padding = new System.Windows.Forms.Padding(2);
            this.gbRowSize.Size = new System.Drawing.Size(92, 50);
            this.gbRowSize.TabIndex = 15;
            this.gbRowSize.TabStop = false;
            this.gbRowSize.Text = "Rowoffset";
            // 
            // txtRowOffset
            // 
            this.txtRowOffset.Location = new System.Drawing.Point(18, 22);
            this.txtRowOffset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRowOffset.Name = "txtRowOffset";
            this.txtRowOffset.Size = new System.Drawing.Size(37, 22);
            this.txtRowOffset.TabIndex = 10;
            this.txtRowOffset.Text = "0";
            // 
            // gbAppendNoteToText
            // 
            this.gbAppendNoteToText.Controls.Add(this.lblFullNoteMS);
            this.gbAppendNoteToText.Controls.Add(this.txtFullNoteMS);
            this.gbAppendNoteToText.Controls.Add(this.cbPlayedNoteAppendToText);
            this.gbAppendNoteToText.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbAppendNoteToText.Location = new System.Drawing.Point(721, 0);
            this.gbAppendNoteToText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAppendNoteToText.Name = "gbAppendNoteToText";
            this.gbAppendNoteToText.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAppendNoteToText.Size = new System.Drawing.Size(200, 50);
            this.gbAppendNoteToText.TabIndex = 28;
            this.gbAppendNoteToText.TabStop = false;
            this.gbAppendNoteToText.Text = "Insert note to text";
            // 
            // lblFullNoteMS
            // 
            this.lblFullNoteMS.AutoSize = true;
            this.lblFullNoteMS.Location = new System.Drawing.Point(169, 26);
            this.lblFullNoteMS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullNoteMS.Name = "lblFullNoteMS";
            this.lblFullNoteMS.Size = new System.Drawing.Size(23, 14);
            this.lblFullNoteMS.TabIndex = 12;
            this.lblFullNoteMS.Text = "ms";
            // 
            // txtFullNoteMS
            // 
            this.txtFullNoteMS.Location = new System.Drawing.Point(116, 22);
            this.txtFullNoteMS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullNoteMS.Name = "txtFullNoteMS";
            this.txtFullNoteMS.Size = new System.Drawing.Size(49, 22);
            this.txtFullNoteMS.TabIndex = 11;
            this.txtFullNoteMS.Text = "1000";
            // 
            // cbPlayedNoteAppendToText
            // 
            this.cbPlayedNoteAppendToText.AutoSize = true;
            this.cbPlayedNoteAppendToText.Location = new System.Drawing.Point(9, 25);
            this.cbPlayedNoteAppendToText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPlayedNoteAppendToText.Name = "cbPlayedNoteAppendToText";
            this.cbPlayedNoteAppendToText.Size = new System.Drawing.Size(105, 18);
            this.cbPlayedNoteAppendToText.TabIndex = 0;
            this.cbPlayedNoteAppendToText.Text = "Append to text";
            this.cbPlayedNoteAppendToText.UseVisualStyleBackColor = true;
            // 
            // cmsInsertNotes
            // 
            this.cmsInsertNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEndEditMode,
            this.toolStripSeparator5,
            this.tsmiGanzNote,
            this.tsmiHalbeNote,
            this.tsmiViertelNote,
            this.tsmiAchtelNote,
            this.tsmiSechzehntelNote,
            this.toolStripSeparator4,
            this.tsmiDreiViertelNote,
            this.tsmiDreiAchtelNote});
            this.cmsInsertNotes.Name = "cmsSongNotation";
            this.cmsInsertNotes.Size = new System.Drawing.Size(152, 192);
            // 
            // tsmiEndEditMode
            // 
            this.tsmiEndEditMode.Image = global::HarpMeNow.Properties.Resources.edn_edit_px24;
            this.tsmiEndEditMode.Name = "tsmiEndEditMode";
            this.tsmiEndEditMode.Size = new System.Drawing.Size(151, 22);
            this.tsmiEndEditMode.Text = "End edit mode";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiGanzNote
            // 
            this.tsmiGanzNote.Image = global::HarpMeNow.Properties.Resources.ganze_note_black_24px;
            this.tsmiGanzNote.Name = "tsmiGanzNote";
            this.tsmiGanzNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiGanzNote.Text = "1";
            // 
            // tsmiHalbeNote
            // 
            this.tsmiHalbeNote.Image = global::HarpMeNow.Properties.Resources.halbe_note_black_24px;
            this.tsmiHalbeNote.Name = "tsmiHalbeNote";
            this.tsmiHalbeNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiHalbeNote.Text = "1/2";
            // 
            // tsmiViertelNote
            // 
            this.tsmiViertelNote.Image = global::HarpMeNow.Properties.Resources.viertel_note_black_24px;
            this.tsmiViertelNote.Name = "tsmiViertelNote";
            this.tsmiViertelNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiViertelNote.Text = "1/4";
            // 
            // tsmiAchtelNote
            // 
            this.tsmiAchtelNote.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.tsmiAchtelNote.Name = "tsmiAchtelNote";
            this.tsmiAchtelNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiAchtelNote.Text = "1/8";
            // 
            // tsmiSechzehntelNote
            // 
            this.tsmiSechzehntelNote.Name = "tsmiSechzehntelNote";
            this.tsmiSechzehntelNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiSechzehntelNote.Text = "1/16";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // tsmiDreiViertelNote
            // 
            this.tsmiDreiViertelNote.Image = global::HarpMeNow.Properties.Resources.dreiviertel_note_black_24px;
            this.tsmiDreiViertelNote.Name = "tsmiDreiViertelNote";
            this.tsmiDreiViertelNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiDreiViertelNote.Text = "3/4";
            // 
            // tsmiDreiAchtelNote
            // 
            this.tsmiDreiAchtelNote.Image = global::HarpMeNow.Properties.Resources.dreiachtel_note_black_px24;
            this.tsmiDreiAchtelNote.Name = "tsmiDreiAchtelNote";
            this.tsmiDreiAchtelNote.Size = new System.Drawing.Size(151, 22);
            this.tsmiDreiAchtelNote.Text = "3/8";
            // 
            // cmsSongNotation
            // 
            this.cmsSongNotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSong,
            this.tsmiLoadSong,
            this.tsmiSaveSong,
            this.toolStripSeparator2,
            this.tsmiEditMode,
            this.toolStripSeparator6,
            this.tsmiTranslateNotationToHarpSequence,
            this.tsmiTranslatoToHarpAndPlay,
            this.tsmiTranspose});
            this.cmsSongNotation.Name = "cmsSongNotation";
            this.cmsSongNotation.Size = new System.Drawing.Size(267, 192);
            this.cmsSongNotation.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSongNotation_ItemClicked);
            // 
            // tsmiLoadSong
            // 
            this.tsmiLoadSong.Image = global::HarpMeNow.Properties.Resources.folder_open_document_22x;
            this.tsmiLoadSong.Name = "tsmiLoadSong";
            this.tsmiLoadSong.Size = new System.Drawing.Size(266, 22);
            this.tsmiLoadSong.Text = "Load Song Notation";
            // 
            // tsmiSaveSong
            // 
            this.tsmiSaveSong.Image = global::HarpMeNow.Properties.Resources.floppy_x24;
            this.tsmiSaveSong.Name = "tsmiSaveSong";
            this.tsmiSaveSong.Size = new System.Drawing.Size(266, 22);
            this.tsmiSaveSong.Text = "Save Song Notation";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // tsmiEditMode
            // 
            this.tsmiEditMode.Image = global::HarpMeNow.Properties.Resources.edit_mode_px24;
            this.tsmiEditMode.Name = "tsmiEditMode";
            this.tsmiEditMode.Size = new System.Drawing.Size(266, 22);
            this.tsmiEditMode.Text = "Edit mode";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(263, 6);
            // 
            // tsmiTranslateNotationToHarpSequence
            // 
            this.tsmiTranslateNotationToHarpSequence.Image = global::HarpMeNow.Properties.Resources.media_playlist_shuffle_blue_x22;
            this.tsmiTranslateNotationToHarpSequence.Name = "tsmiTranslateNotationToHarpSequence";
            this.tsmiTranslateNotationToHarpSequence.Size = new System.Drawing.Size(266, 22);
            this.tsmiTranslateNotationToHarpSequence.Text = "Translate Notation to Harp sequence";
            // 
            // tsmiTranslatoToHarpAndPlay
            // 
            this.tsmiTranslatoToHarpAndPlay.Image = global::HarpMeNow.Properties.Resources.translate_and_play_x32;
            this.tsmiTranslatoToHarpAndPlay.Name = "tsmiTranslatoToHarpAndPlay";
            this.tsmiTranslatoToHarpAndPlay.Size = new System.Drawing.Size(266, 22);
            this.tsmiTranslatoToHarpAndPlay.Text = "Translate to Harp and Play";
            // 
            // tsmiTranspose
            // 
            this.tsmiTranspose.Name = "tsmiTranspose";
            this.tsmiTranspose.Size = new System.Drawing.Size(266, 22);
            this.tsmiTranspose.Text = "Transpose";
            // 
            // ofdSong
            // 
            this.ofdSong.DefaultExt = "*.not";
            this.ofdSong.FileName = "openFileDialog1";
            this.ofdSong.Filter = "Song Notation|*.not|All|*.*";
            this.ofdSong.Title = "Open Song Notation";
            // 
            // sfdSong
            // 
            this.sfdSong.DefaultExt = "*.not";
            this.sfdSong.Filter = "Notenfile|*.not|Alle|*.*";
            this.sfdSong.Title = "Save Song Notation";
            // 
            // gbSongNotation
            // 
            this.gbSongNotation.Controls.Add(this.rtbSong);
            this.gbSongNotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSongNotation.Location = new System.Drawing.Point(0, 50);
            this.gbSongNotation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSongNotation.Name = "gbSongNotation";
            this.gbSongNotation.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSongNotation.Size = new System.Drawing.Size(921, 446);
            this.gbSongNotation.TabIndex = 10;
            this.gbSongNotation.TabStop = false;
            this.gbSongNotation.Text = "Song Notation";
            // 
            // rtbSong
            // 
            this.rtbSong.ContextMenuStrip = this.cmsSongNotation;
            this.rtbSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSong.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSong.Location = new System.Drawing.Point(2, 18);
            this.rtbSong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbSong.Name = "rtbSong";
            this.rtbSong.Size = new System.Drawing.Size(917, 425);
            this.rtbSong.TabIndex = 5;
            this.rtbSong.Text = "";
            // 
            // tsmiNewSong
            // 
            this.tsmiNewSong.Image = global::HarpMeNow.Properties.Resources.document_blue_x24;
            this.tsmiNewSong.Name = "tsmiNewSong";
            this.tsmiNewSong.Size = new System.Drawing.Size(266, 22);
            this.tsmiNewSong.Text = "New Song Notation";
            // 
            // SongSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.gbSongNotation);
            this.Controls.Add(this.pnlNotationUpper);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SongSequenceForm";
            this.Text = "SongSequenceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongSequenceForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNotationUpper.ResumeLayout(false);
            this.gbTranslateType.ResumeLayout(false);
            this.gbShift.ResumeLayout(false);
            this.gbShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkShift)).EndInit();
            this.gbRowSize.ResumeLayout(false);
            this.gbRowSize.PerformLayout();
            this.gbAppendNoteToText.ResumeLayout(false);
            this.gbAppendNoteToText.PerformLayout();
            this.cmsInsertNotes.ResumeLayout(false);
            this.cmsSongNotation.ResumeLayout(false);
            this.gbSongNotation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotationUpper;
        private SeControlsLib.HotSpot hsCloseApp;
        private System.Windows.Forms.GroupBox gbRowSize;
        private System.Windows.Forms.TextBox txtRowOffset;
        private System.Windows.Forms.GroupBox gbAppendNoteToText;
        private System.Windows.Forms.Label lblFullNoteMS;
        private System.Windows.Forms.TextBox txtFullNoteMS;
        private System.Windows.Forms.CheckBox cbPlayedNoteAppendToText;
        private System.Windows.Forms.ContextMenuStrip cmsInsertNotes;
        private System.Windows.Forms.ToolStripMenuItem tsmiEndEditMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiGanzNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiHalbeNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiViertelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiAchtelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechzehntelNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiDreiViertelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiDreiAchtelNote;
        private System.Windows.Forms.ContextMenuStrip cmsSongNotation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveSong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslateNotationToHarpSequence;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslatoToHarpAndPlay;
        private System.Windows.Forms.OpenFileDialog ofdSong;
        private System.Windows.Forms.SaveFileDialog sfdSong;
        private System.Windows.Forms.GroupBox gbSongNotation;
        public System.Windows.Forms.RichTextBox rtbSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranspose;
        private System.Windows.Forms.GroupBox gbShift;
        private System.Windows.Forms.TrackBar trkShift;
        private System.Windows.Forms.GroupBox gbTranslateType;
        private System.Windows.Forms.ComboBox cbTranslateType;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSong;
    }
}