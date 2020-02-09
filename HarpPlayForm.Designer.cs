namespace HarpMeNow
{
    partial class HarpPlayForm
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
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblKey = new System.Windows.Forms.Label();
            this.hsPlay = new SeControlsLib.HotSpot();
            this.hsPausePlaying = new SeControlsLib.HotSpot();
            this.hsCancel = new SeControlsLib.HotSpot();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.gbPlainNotes = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUpper.SuspendLayout();
            this.gbPlainNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUpper.Controls.Add(this.lblKey);
            this.pnlUpper.Controls.Add(this.hsPlay);
            this.pnlUpper.Controls.Add(this.hsPausePlaying);
            this.pnlUpper.Controls.Add(this.hsCancel);
            this.pnlUpper.Controls.Add(this.hsCloseApp);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1437, 57);
            this.pnlUpper.TabIndex = 31;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(460, 25);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(51, 19);
            this.lblKey.TabIndex = 35;
            this.lblKey.Text = "C-DUR";
            // 
            // hsPlay
            // 
            this.hsPlay.BackColor = System.Drawing.Color.Transparent;
            this.hsPlay.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPlay.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPlay.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPlay.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPlay.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPlay.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsPlay.FlatAppearance.BorderSize = 0;
            this.hsPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPlay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPlay.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPlay.Image = global::HarpMeNow.Properties.Resources.achtel_note_black_24px1;
            this.hsPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPlay.ImageHover = global::HarpMeNow.Properties.Resources.sechzehntel_note_black_24px;
            this.hsPlay.ImageToggleOnSelect = true;
            this.hsPlay.Location = new System.Drawing.Point(317, 0);
            this.hsPlay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hsPlay.Marked = false;
            this.hsPlay.MarkedColor = System.Drawing.Color.Teal;
            this.hsPlay.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPlay.MarkedText = "";
            this.hsPlay.MarkMode = false;
            this.hsPlay.Name = "hsPlay";
            this.hsPlay.NonMarkedText = "";
            this.hsPlay.Size = new System.Drawing.Size(100, 57);
            this.hsPlay.TabIndex = 34;
            this.hsPlay.Text = "Play";
            this.hsPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPlay.ToolTipActive = false;
            this.hsPlay.ToolTipAutomaticDelay = 500;
            this.hsPlay.ToolTipAutoPopDelay = 5000;
            this.hsPlay.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPlay.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPlay.ToolTipFor4ContextMenu = true;
            this.hsPlay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPlay.ToolTipInitialDelay = 500;
            this.hsPlay.ToolTipIsBallon = false;
            this.hsPlay.ToolTipOwnerDraw = false;
            this.hsPlay.ToolTipReshowDelay = 100;
            this.hsPlay.ToolTipShowAlways = false;
            this.hsPlay.ToolTipText = "";
            this.hsPlay.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPlay.ToolTipTitle = "";
            this.hsPlay.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPlay.UseVisualStyleBackColor = false;
            this.hsPlay.Click += new System.EventHandler(this.hsPlay_Click);
            // 
            // hsPausePlaying
            // 
            this.hsPausePlaying.BackColor = System.Drawing.Color.Transparent;
            this.hsPausePlaying.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPausePlaying.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPausePlaying.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPausePlaying.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPausePlaying.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPausePlaying.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPausePlaying.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsPausePlaying.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsPausePlaying.FlatAppearance.BorderSize = 0;
            this.hsPausePlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPausePlaying.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPausePlaying.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPausePlaying.Image = global::HarpMeNow.Properties.Resources.help_about_blue_x32;
            this.hsPausePlaying.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsPausePlaying.ImageHover = global::HarpMeNow.Properties.Resources.help_about_gn_x32;
            this.hsPausePlaying.ImageToggleOnSelect = true;
            this.hsPausePlaying.Location = new System.Drawing.Point(219, 0);
            this.hsPausePlaying.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hsPausePlaying.Marked = false;
            this.hsPausePlaying.MarkedColor = System.Drawing.Color.Teal;
            this.hsPausePlaying.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPausePlaying.MarkedText = "Continue playing";
            this.hsPausePlaying.MarkMode = true;
            this.hsPausePlaying.Name = "hsPausePlaying";
            this.hsPausePlaying.NonMarkedText = "Pause Playing";
            this.hsPausePlaying.Size = new System.Drawing.Size(98, 57);
            this.hsPausePlaying.TabIndex = 31;
            this.hsPausePlaying.Text = "Pause playing";
            this.hsPausePlaying.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsPausePlaying.ToolTipActive = false;
            this.hsPausePlaying.ToolTipAutomaticDelay = 500;
            this.hsPausePlaying.ToolTipAutoPopDelay = 5000;
            this.hsPausePlaying.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPausePlaying.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPausePlaying.ToolTipFor4ContextMenu = true;
            this.hsPausePlaying.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPausePlaying.ToolTipInitialDelay = 500;
            this.hsPausePlaying.ToolTipIsBallon = false;
            this.hsPausePlaying.ToolTipOwnerDraw = false;
            this.hsPausePlaying.ToolTipReshowDelay = 100;
            this.hsPausePlaying.ToolTipShowAlways = false;
            this.hsPausePlaying.ToolTipText = "";
            this.hsPausePlaying.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPausePlaying.ToolTipTitle = "";
            this.hsPausePlaying.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPausePlaying.UseVisualStyleBackColor = false;
            this.hsPausePlaying.Click += new System.EventHandler(this.hsPausePlaying_Click);
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
            this.hsCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCancel.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCancel.Image = global::HarpMeNow.Properties.Resources.cross_red_x32;
            this.hsCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsCancel.ImageHover = global::HarpMeNow.Properties.Resources.cross_blue_x32;
            this.hsCancel.ImageToggleOnSelect = true;
            this.hsCancel.Location = new System.Drawing.Point(119, 0);
            this.hsCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hsCancel.Marked = false;
            this.hsCancel.MarkedColor = System.Drawing.Color.Teal;
            this.hsCancel.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCancel.MarkedText = "";
            this.hsCancel.MarkMode = false;
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.NonMarkedText = "";
            this.hsCancel.Size = new System.Drawing.Size(100, 57);
            this.hsCancel.TabIndex = 30;
            this.hsCancel.Text = "Cancel playing";
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
            this.hsCancel.Click += new System.EventHandler(this.hsCancel_Click);
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
            this.hsCloseApp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.hsCloseApp.Size = new System.Drawing.Size(119, 57);
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
            // gbPlainNotes
            // 
            this.gbPlainNotes.Controls.Add(this.flowLayoutPanel1);
            this.gbPlainNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlainNotes.Location = new System.Drawing.Point(0, 57);
            this.gbPlainNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlainNotes.Name = "gbPlainNotes";
            this.gbPlainNotes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlainNotes.Size = new System.Drawing.Size(1437, 731);
            this.gbPlainNotes.TabIndex = 30;
            this.gbPlainNotes.TabStop = false;
            this.gbPlainNotes.Text = "Plain Notes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1431, 708);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // HarpPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 788);
            this.Controls.Add(this.gbPlainNotes);
            this.Controls.Add(this.pnlUpper);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HarpPlayForm";
            this.Text = "HarpPlayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HarpPlayForm_FormClosing);
            this.Load += new System.EventHandler(this.HarpPlayForm_Load);
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.gbPlainNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private SeControlsLib.HotSpot hsCloseApp;
        private System.Windows.Forms.GroupBox gbPlainNotes;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SeControlsLib.HotSpot hsPausePlaying;
        private SeControlsLib.HotSpot hsCancel;
        private SeControlsLib.HotSpot hsPlay;
        private System.Windows.Forms.Label lblKey;
    }
}