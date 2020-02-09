namespace HarpMeNow
{
    partial class HarpSlotsForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsSongNotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLoadSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTranslateNotationToHarpSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTranslatoToHarpAndPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSong = new System.Windows.Forms.OpenFileDialog();
            this.cmsHarpSongNotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLoadHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPlayHarpSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayHarpSongDelayed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlaySelectedHarpText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTranslateHarpSequeceToSongNotation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTranslateToPlainHarpNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdHarpSong = new System.Windows.Forms.SaveFileDialog();
            this.ofdHarpSong = new System.Windows.Forms.OpenFileDialog();
            this.sfdSong = new System.Windows.Forms.SaveFileDialog();
            this.pnlSlots = new System.Windows.Forms.Panel();
            this.cmsPlainHarpSequence = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.cmsSongNotation.SuspendLayout();
            this.cmsHarpSongNotation.SuspendLayout();
            this.cmsPlainHarpSequence.SuspendLayout();
            this.cmsInsertNotes.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsSongNotation
            // 
            this.cmsSongNotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadSong,
            this.tsmiSaveSong,
            this.toolStripSeparator2,
            this.tsmiEditMode,
            this.toolStripSeparator6,
            this.tsmiTranslateNotationToHarpSequence,
            this.tsmiTranslatoToHarpAndPlay});
            this.cmsSongNotation.Name = "cmsSongNotation";
            this.cmsSongNotation.Size = new System.Drawing.Size(267, 126);
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
            // ofdSong
            // 
            this.ofdSong.DefaultExt = "*.not";
            this.ofdSong.FileName = "openFileDialog1";
            this.ofdSong.Filter = "Song Notation|*.not|All|*.*";
            this.ofdSong.Title = "Open Song Notation";
            // 
            // cmsHarpSongNotation
            // 
            this.cmsHarpSongNotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadHarpSong,
            this.tsmiSaveHarpSong,
            this.toolStripSeparator1,
            this.tsmiPlayHarpSong,
            this.tsmiPlayHarpSongDelayed,
            this.tsmiPlaySelectedHarpText,
            this.toolStripSeparator3,
            this.tsmiTranslateHarpSequeceToSongNotation,
            this.tsmiTranslateToPlainHarpNotes});
            this.cmsHarpSongNotation.Name = "cmsSongNotation";
            this.cmsHarpSongNotation.Size = new System.Drawing.Size(295, 170);
            // 
            // tsmiLoadHarpSong
            // 
            this.tsmiLoadHarpSong.Image = global::HarpMeNow.Properties.Resources.folder_open_document_22x;
            this.tsmiLoadHarpSong.Name = "tsmiLoadHarpSong";
            this.tsmiLoadHarpSong.Size = new System.Drawing.Size(294, 22);
            this.tsmiLoadHarpSong.Text = "Load harp notation";
            // 
            // tsmiSaveHarpSong
            // 
            this.tsmiSaveHarpSong.Image = global::HarpMeNow.Properties.Resources.floppy_x24;
            this.tsmiSaveHarpSong.Name = "tsmiSaveHarpSong";
            this.tsmiSaveHarpSong.Size = new System.Drawing.Size(294, 22);
            this.tsmiSaveHarpSong.Text = "Save harp notation";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // tsmiPlayHarpSong
            // 
            this.tsmiPlayHarpSong.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.tsmiPlayHarpSong.Name = "tsmiPlayHarpSong";
            this.tsmiPlayHarpSong.Size = new System.Drawing.Size(294, 22);
            this.tsmiPlayHarpSong.Text = "Play complete harp sequence";
            // 
            // tsmiPlayHarpSongDelayed
            // 
            this.tsmiPlayHarpSongDelayed.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.tsmiPlayHarpSongDelayed.Name = "tsmiPlayHarpSongDelayed";
            this.tsmiPlayHarpSongDelayed.Size = new System.Drawing.Size(294, 22);
            this.tsmiPlayHarpSongDelayed.Text = "Play complete harp sequence delayed";
            // 
            // tsmiPlaySelectedHarpText
            // 
            this.tsmiPlaySelectedHarpText.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px;
            this.tsmiPlaySelectedHarpText.Name = "tsmiPlaySelectedHarpText";
            this.tsmiPlaySelectedHarpText.Size = new System.Drawing.Size(294, 22);
            this.tsmiPlaySelectedHarpText.Text = "Play selected harp sequence";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(291, 6);
            // 
            // tsmiTranslateHarpSequeceToSongNotation
            // 
            this.tsmiTranslateHarpSequeceToSongNotation.Image = global::HarpMeNow.Properties.Resources.media_playlist_shuffle_blue_x22;
            this.tsmiTranslateHarpSequeceToSongNotation.Name = "tsmiTranslateHarpSequeceToSongNotation";
            this.tsmiTranslateHarpSequeceToSongNotation.Size = new System.Drawing.Size(294, 22);
            this.tsmiTranslateHarpSequeceToSongNotation.Text = "Translate Harp sequence to Song notation";
            // 
            // tsmiTranslateToPlainHarpNotes
            // 
            this.tsmiTranslateToPlainHarpNotes.Image = global::HarpMeNow.Properties.Resources.media_playlist_shuffle_blue_x22;
            this.tsmiTranslateToPlainHarpNotes.Name = "tsmiTranslateToPlainHarpNotes";
            this.tsmiTranslateToPlainHarpNotes.Size = new System.Drawing.Size(294, 22);
            this.tsmiTranslateToPlainHarpNotes.Text = "Translate to plain Harp notes";
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
            // sfdSong
            // 
            this.sfdSong.DefaultExt = "*.not";
            this.sfdSong.Filter = "Notenfile|*.not|Alle|*.*";
            this.sfdSong.Title = "Save Song Notation";
            // 
            // pnlSlots
            // 
            this.pnlSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSlots.Location = new System.Drawing.Point(0, 52);
            this.pnlSlots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSlots.Name = "pnlSlots";
            this.pnlSlots.Size = new System.Drawing.Size(780, 244);
            this.pnlSlots.TabIndex = 28;
            // 
            // cmsPlainHarpSequence
            // 
            this.cmsPlainHarpSequence.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsPlainHarpSequence.Name = "cmsPlainHarpSequence";
            this.cmsPlainHarpSequence.Size = new System.Drawing.Size(102, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::HarpMeNow.Properties.Resources.trash_remove_24x;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "Clear";
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
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpper.Controls.Add(this.hsCloseApp);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(780, 52);
            this.pnlUpper.TabIndex = 29;
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
            this.hsCloseApp.Size = new System.Drawing.Size(74, 52);
            this.hsCloseApp.TabIndex = 9;
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
            // HarpSlotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 296);
            this.Controls.Add(this.pnlSlots);
            this.Controls.Add(this.pnlUpper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "HarpSlotsForm";
            this.Text = "2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsSongNotation.ResumeLayout(false);
            this.cmsHarpSongNotation.ResumeLayout(false);
            this.cmsPlainHarpSequence.ResumeLayout(false);
            this.cmsInsertNotes.ResumeLayout(false);
            this.pnlUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdSong;
        private System.Windows.Forms.SaveFileDialog sfdHarpSong;
        private System.Windows.Forms.OpenFileDialog ofdHarpSong;
        private System.Windows.Forms.SaveFileDialog sfdSong;
        private System.Windows.Forms.ContextMenuStrip cmsSongNotation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveSong;
        private System.Windows.Forms.ContextMenuStrip cmsHarpSongNotation;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadHarpSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveHarpSong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayHarpSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayHarpSongDelayed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslateNotationToHarpSequence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslateHarpSequeceToSongNotation;
        public System.Windows.Forms.Panel pnlSlots;
        private System.Windows.Forms.ContextMenuStrip cmsInsertNotes;
        private System.Windows.Forms.ToolStripMenuItem tsmiGanzNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiHalbeNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiViertelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiAchtelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechzehntelNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiDreiViertelNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiDreiAchtelNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiEndEditMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsCloseApp;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslateToPlainHarpNotes;
        private System.Windows.Forms.ContextMenuStrip cmsPlainHarpSequence;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslatoToHarpAndPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlaySelectedHarpText;
    }
}

