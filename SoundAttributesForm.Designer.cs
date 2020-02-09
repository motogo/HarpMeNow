namespace HarpMeNow
{
    partial class SoundAttributesForm
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
            this.gbVelocity = new System.Windows.Forms.GroupBox();
            this.trkVelocity = new System.Windows.Forms.TrackBar();
            this.gbVolume = new System.Windows.Forms.GroupBox();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.gbSound = new System.Windows.Forms.GroupBox();
            this.cbHarpSoundInstrument = new System.Windows.Forms.ComboBox();
            this.gbReferenceHarp = new System.Windows.Forms.GroupBox();
            this.cbReferenzHarpInstruments = new System.Windows.Forms.ComboBox();
            this.gbHarpInstrument = new System.Windows.Forms.GroupBox();
            this.cbHarpInstrument = new System.Windows.Forms.ComboBox();
            this.gbTranspose = new System.Windows.Forms.GroupBox();
            this.txtTranspose = new System.Windows.Forms.TextBox();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.gbVelocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocity)).BeginInit();
            this.gbVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.gbSound.SuspendLayout();
            this.gbReferenceHarp.SuspendLayout();
            this.gbHarpInstrument.SuspendLayout();
            this.gbTranspose.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVelocity
            // 
            this.gbVelocity.Controls.Add(this.trkVelocity);
            this.gbVelocity.Location = new System.Drawing.Point(8, 123);
            this.gbVelocity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVelocity.Name = "gbVelocity";
            this.gbVelocity.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVelocity.Size = new System.Drawing.Size(229, 53);
            this.gbVelocity.TabIndex = 36;
            this.gbVelocity.TabStop = false;
            this.gbVelocity.Text = "Velocity";
            // 
            // trkVelocity
            // 
            this.trkVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkVelocity.Location = new System.Drawing.Point(2, 16);
            this.trkVelocity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trkVelocity.Maximum = 250;
            this.trkVelocity.Minimum = 10;
            this.trkVelocity.Name = "trkVelocity";
            this.trkVelocity.Size = new System.Drawing.Size(225, 34);
            this.trkVelocity.TabIndex = 29;
            this.trkVelocity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkVelocity.Value = 50;
         
            this.trkVelocity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trkVelocity_KeyUp);
            this.trkVelocity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkVelocity_MouseUp);
            // 
            // gbVolume
            // 
            this.gbVolume.Controls.Add(this.trkVolume);
            this.gbVolume.Location = new System.Drawing.Point(253, 124);
            this.gbVolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVolume.Name = "gbVolume";
            this.gbVolume.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVolume.Size = new System.Drawing.Size(229, 53);
            this.gbVolume.TabIndex = 35;
            this.gbVolume.TabStop = false;
            this.gbVolume.Text = "Volume";
            // 
            // trkVolume
            // 
            this.trkVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkVolume.Location = new System.Drawing.Point(2, 16);
            this.trkVolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(225, 34);
            this.trkVolume.TabIndex = 29;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trkVolume.Value = 50;
            
            this.trkVolume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trkVolume_KeyUp);
            this.trkVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkVolume_MouseUp);
            // 
            // gbSound
            // 
            this.gbSound.Controls.Add(this.cbHarpSoundInstrument);
            this.gbSound.Location = new System.Drawing.Point(253, 68);
            this.gbSound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSound.Name = "gbSound";
            this.gbSound.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSound.Size = new System.Drawing.Size(229, 49);
            this.gbSound.TabIndex = 34;
            this.gbSound.TabStop = false;
            this.gbSound.Text = "Sound";
            // 
            // cbHarpSoundInstrument
            // 
            this.cbHarpSoundInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHarpSoundInstrument.FormattingEnabled = true;
            this.cbHarpSoundInstrument.Location = new System.Drawing.Point(3, 17);
            this.cbHarpSoundInstrument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHarpSoundInstrument.Name = "cbHarpSoundInstrument";
            this.cbHarpSoundInstrument.Size = new System.Drawing.Size(223, 21);
            this.cbHarpSoundInstrument.TabIndex = 7;
            this.cbHarpSoundInstrument.SelectedIndexChanged += new System.EventHandler(this.cbHarpSoundInstrument_SelectedIndexChanged);
            // 
            // gbReferenceHarp
            // 
            this.gbReferenceHarp.Controls.Add(this.cbReferenzHarpInstruments);
            this.gbReferenceHarp.Location = new System.Drawing.Point(132, 4);
            this.gbReferenceHarp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReferenceHarp.Name = "gbReferenceHarp";
            this.gbReferenceHarp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReferenceHarp.Size = new System.Drawing.Size(227, 44);
            this.gbReferenceHarp.TabIndex = 37;
            this.gbReferenceHarp.TabStop = false;
            this.gbReferenceHarp.Text = "Reference Harp";
            this.gbReferenceHarp.Visible = false;
            // 
            // cbReferenzHarpInstruments
            // 
            this.cbReferenzHarpInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbReferenzHarpInstruments.FormattingEnabled = true;
            this.cbReferenzHarpInstruments.Location = new System.Drawing.Point(3, 17);
            this.cbReferenzHarpInstruments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbReferenzHarpInstruments.Name = "cbReferenzHarpInstruments";
            this.cbReferenzHarpInstruments.Size = new System.Drawing.Size(221, 21);
            this.cbReferenzHarpInstruments.TabIndex = 19;
            this.cbReferenzHarpInstruments.SelectedIndexChanged += new System.EventHandler(this.cbReferenzHarpInstruments_SelectedIndexChanged);
            // 
            // gbHarpInstrument
            // 
            this.gbHarpInstrument.Controls.Add(this.cbHarpInstrument);
            this.gbHarpInstrument.Location = new System.Drawing.Point(8, 65);
            this.gbHarpInstrument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHarpInstrument.Name = "gbHarpInstrument";
            this.gbHarpInstrument.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHarpInstrument.Size = new System.Drawing.Size(229, 51);
            this.gbHarpInstrument.TabIndex = 38;
            this.gbHarpInstrument.TabStop = false;
            this.gbHarpInstrument.Text = "Harp Instrument to play";
            // 
            // cbHarpInstrument
            // 
            this.cbHarpInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHarpInstrument.FormattingEnabled = true;
            this.cbHarpInstrument.Location = new System.Drawing.Point(3, 17);
            this.cbHarpInstrument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHarpInstrument.Name = "cbHarpInstrument";
            this.cbHarpInstrument.Size = new System.Drawing.Size(223, 21);
            this.cbHarpInstrument.TabIndex = 18;
            this.cbHarpInstrument.SelectedIndexChanged += new System.EventHandler(this.cbHarpInstrument_SelectedIndexChanged);
            // 
            // gbTranspose
            // 
            this.gbTranspose.Controls.Add(this.txtTranspose);
            this.gbTranspose.Location = new System.Drawing.Point(8, 182);
            this.gbTranspose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTranspose.Name = "gbTranspose";
            this.gbTranspose.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTranspose.Size = new System.Drawing.Size(106, 49);
            this.gbTranspose.TabIndex = 40;
            this.gbTranspose.TabStop = false;
            this.gbTranspose.Text = "Transpose";
            // 
            // txtTranspose
            // 
            this.txtTranspose.Location = new System.Drawing.Point(5, 20);
            this.txtTranspose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTranspose.Name = "txtTranspose";
            this.txtTranspose.Size = new System.Drawing.Size(43, 20);
            this.txtTranspose.TabIndex = 29;
            this.txtTranspose.Text = "0";
            this.txtTranspose.TextChanged += new System.EventHandler(this.txtTranspose_TextChanged);
            // 
            // pnlUpper
            // 
            this.pnlUpper.Controls.Add(this.hsCloseApp);
            this.pnlUpper.Controls.Add(this.gbReferenceHarp);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(490, 52);
            this.pnlUpper.TabIndex = 41;
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
            this.hsCloseApp.Size = new System.Drawing.Size(67, 52);
            this.hsCloseApp.TabIndex = 10;
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
            // SoundAttributesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 238);
            this.Controls.Add(this.pnlUpper);
            this.Controls.Add(this.gbTranspose);
            this.Controls.Add(this.gbHarpInstrument);
            this.Controls.Add(this.gbVelocity);
            this.Controls.Add(this.gbVolume);
            this.Controls.Add(this.gbSound);
            this.Name = "SoundAttributesForm";
            this.Text = "SoundAttributesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundAttributesForm_FormClosing);
            this.Load += new System.EventHandler(this.SoundAttributesForm_Load);
            this.gbVelocity.ResumeLayout(false);
            this.gbVelocity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocity)).EndInit();
            this.gbVolume.ResumeLayout(false);
            this.gbVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.gbSound.ResumeLayout(false);
            this.gbReferenceHarp.ResumeLayout(false);
            this.gbHarpInstrument.ResumeLayout(false);
            this.gbTranspose.ResumeLayout(false);
            this.gbTranspose.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVelocity;
        private System.Windows.Forms.TrackBar trkVelocity;
        private System.Windows.Forms.GroupBox gbVolume;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.GroupBox gbSound;
        private System.Windows.Forms.ComboBox cbHarpSoundInstrument;
        private System.Windows.Forms.GroupBox gbReferenceHarp;
        private System.Windows.Forms.ComboBox cbReferenzHarpInstruments;
        private System.Windows.Forms.GroupBox gbHarpInstrument;
        private System.Windows.Forms.ComboBox cbHarpInstrument;
        private SeControlsLib.HotSpot hsCloseApp;
        private System.Windows.Forms.GroupBox gbTranspose;
        private System.Windows.Forms.TextBox txtTranspose;
        private System.Windows.Forms.Panel pnlUpper;
    }
}