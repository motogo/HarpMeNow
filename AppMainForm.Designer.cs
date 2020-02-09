namespace HarpMeNow
{
    partial class AppMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            this.cmsWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCloseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascadeWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHarpSlotsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSoundAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSequenceForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCloseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDivider1 = new System.Windows.Forms.ToolStripMenuItem();
            this.songAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harpSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harpSlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInstruments = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWindows.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsWindows
            // 
            this.cmsWindows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCloseApplication,
            this.tsmiCascadeWindows,
            this.toolStripSeparator1,
            this.tsmiHarpSlotsForm,
            this.tsmiPlayForm,
            this.tsmiSoundAttributes,
            this.tsmiSequenceForm,
            this.tsmiInstruments});
            this.cmsWindows.Name = "cmsPlainHarpSequence";
            this.cmsWindows.Size = new System.Drawing.Size(197, 298);
            this.cmsWindows.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsWindows_ItemClicked);
            // 
            // tsmiCloseApplication
            // 
            this.tsmiCloseApplication.Image = global::HarpMeNow.Properties.Resources.go_previous32x;
            this.tsmiCloseApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCloseApplication.Name = "tsmiCloseApplication";
            this.tsmiCloseApplication.Size = new System.Drawing.Size(196, 38);
            this.tsmiCloseApplication.Text = "Close Application";
            // 
            // tsmiCascadeWindows
            // 
            this.tsmiCascadeWindows.Image = global::HarpMeNow.Properties.Resources.arrange_forms_24x;
            this.tsmiCascadeWindows.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCascadeWindows.Name = "tsmiCascadeWindows";
            this.tsmiCascadeWindows.Size = new System.Drawing.Size(196, 38);
            this.tsmiCascadeWindows.Text = "Cascade Windows";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmiHarpSlotsForm
            // 
            this.tsmiHarpSlotsForm.Image = global::HarpMeNow.Properties.Resources.harp_24;
            this.tsmiHarpSlotsForm.Name = "tsmiHarpSlotsForm";
            this.tsmiHarpSlotsForm.Size = new System.Drawing.Size(196, 38);
            this.tsmiHarpSlotsForm.Text = "Harp Slots";
            // 
            // tsmiPlayForm
            // 
            this.tsmiPlayForm.Image = global::HarpMeNow.Properties.Resources.media_playlist_repeat_blue_x22;
            this.tsmiPlayForm.Name = "tsmiPlayForm";
            this.tsmiPlayForm.Size = new System.Drawing.Size(196, 38);
            this.tsmiPlayForm.Text = "Play Form";
            // 
            // tsmiSoundAttributes
            // 
            this.tsmiSoundAttributes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSoundAttributes.Image")));
            this.tsmiSoundAttributes.Name = "tsmiSoundAttributes";
            this.tsmiSoundAttributes.Size = new System.Drawing.Size(196, 38);
            this.tsmiSoundAttributes.Text = "Sound Attributes";
            // 
            // tsmiSequenceForm
            // 
            this.tsmiSequenceForm.Image = global::HarpMeNow.Properties.Resources.font_x24;
            this.tsmiSequenceForm.Name = "tsmiSequenceForm";
            this.tsmiSequenceForm.Size = new System.Drawing.Size(196, 38);
            this.tsmiSequenceForm.Text = "Sequence Form";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.cmsWindows;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWindows,
            this.toolStripMenuItemLanguage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemWindows
            // 
            this.toolStripMenuItemWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCloseApplication,
            this.toolStripMenuItemDivider1,
            this.songAttributesToolStripMenuItem,
            this.songSequenceToolStripMenuItem,
            this.harpSequenceToolStripMenuItem,
            this.harpSlotsToolStripMenuItem,
            this.playSotsToolStripMenuItem,
            this.instrumentsToolStripMenuItem});
            this.toolStripMenuItemWindows.Name = "toolStripMenuItemWindows";
            this.toolStripMenuItemWindows.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItemWindows.Text = "Windows";
            // 
            // toolStripMenuItemCloseApplication
            // 
            this.toolStripMenuItemCloseApplication.Image = global::HarpMeNow.Properties.Resources.go_previous32x;
            this.toolStripMenuItemCloseApplication.Name = "toolStripMenuItemCloseApplication";
            this.toolStripMenuItemCloseApplication.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCloseApplication.Text = "Close Application";
            this.toolStripMenuItemCloseApplication.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // toolStripMenuItemDivider1
            // 
            this.toolStripMenuItemDivider1.Name = "toolStripMenuItemDivider1";
            this.toolStripMenuItemDivider1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDivider1.Text = "---";
            // 
            // songAttributesToolStripMenuItem
            // 
            this.songAttributesToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.snd_on_24x;
            this.songAttributesToolStripMenuItem.Name = "songAttributesToolStripMenuItem";
            this.songAttributesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.songAttributesToolStripMenuItem.Text = "Song Attributes";
            this.songAttributesToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // songSequenceToolStripMenuItem
            // 
            this.songSequenceToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.font_x24;
            this.songSequenceToolStripMenuItem.Name = "songSequenceToolStripMenuItem";
            this.songSequenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.songSequenceToolStripMenuItem.Text = "Song Sequence";
            this.songSequenceToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // harpSequenceToolStripMenuItem
            // 
            this.harpSequenceToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.font2_x24;
            this.harpSequenceToolStripMenuItem.Name = "harpSequenceToolStripMenuItem";
            this.harpSequenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.harpSequenceToolStripMenuItem.Text = "Harp Sequence";
            this.harpSequenceToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // harpSlotsToolStripMenuItem
            // 
            this.harpSlotsToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.harp_24;
            this.harpSlotsToolStripMenuItem.Name = "harpSlotsToolStripMenuItem";
            this.harpSlotsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.harpSlotsToolStripMenuItem.Text = "Harp Slots";
            this.harpSlotsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // playSotsToolStripMenuItem
            // 
            this.playSotsToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.playSotsToolStripMenuItem.Name = "playSotsToolStripMenuItem";
            this.playSotsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playSotsToolStripMenuItem.Text = "Play Sots";
            this.playSotsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // instrumentsToolStripMenuItem
            // 
            this.instrumentsToolStripMenuItem.Image = global::HarpMeNow.Properties.Resources.harp_24;
            this.instrumentsToolStripMenuItem.Name = "instrumentsToolStripMenuItem";
            this.instrumentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instrumentsToolStripMenuItem.Text = "Instruments";
            this.instrumentsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // toolStripMenuItemLanguage
            // 
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem});
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            this.toolStripMenuItemLanguage.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItemLanguage.Text = "Language";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.ChangeLanguage_click);
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.englischToolStripMenuItem.Text = "Englisch";
            this.englischToolStripMenuItem.Click += new System.EventHandler(this.ChangeLanguage_click);
            // 
            // tsmiInstruments
            // 
            this.tsmiInstruments.Image = global::HarpMeNow.Properties.Resources.harp_24;
            this.tsmiInstruments.Name = "tsmiInstruments";
            this.tsmiInstruments.Size = new System.Drawing.Size(196, 38);
            this.tsmiInstruments.Text = "Instruments";
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.ContextMenuStrip = this.cmsWindows;
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppMainForm";
            this.Text = "HarpMeNow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppMainForm_FormClosing);
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            this.cmsWindows.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsWindows;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascadeWindows;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiSoundAttributes;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiHarpSlotsForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiSequenceForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCloseApplication;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDivider1;
        private System.Windows.Forms.ToolStripMenuItem songAttributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harpSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harpSlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem instrumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInstruments;
    }
}