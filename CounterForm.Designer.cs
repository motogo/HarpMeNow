namespace HarpMeNow
{
    partial class CounterForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hsCounter = new SeControlsLib.HotSpot();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hsCounter
            // 
            this.hsCounter.BackColor = System.Drawing.Color.Transparent;
            this.hsCounter.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCounter.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCounter.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCounter.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCounter.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCounter.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hsCounter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCounter.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCounter.HoverStyle = SeControlsLib.frameStyle.filled;
            this.hsCounter.Image = null;
            this.hsCounter.ImageHover = null;
            this.hsCounter.ImageToggleOnSelect = false;
            this.hsCounter.Location = new System.Drawing.Point(0, 0);
            this.hsCounter.Marked = false;
            this.hsCounter.MarkedColor = System.Drawing.Color.Teal;
            this.hsCounter.MarkedStyle = SeControlsLib.frameStyle.thickRectangle;
            this.hsCounter.MarkedText = "";
            this.hsCounter.MarkMode = false;
            this.hsCounter.Name = "hsCounter";
            this.hsCounter.NonMarkedText = "";
            this.hsCounter.Size = new System.Drawing.Size(225, 160);
            this.hsCounter.TabIndex = 0;
            this.hsCounter.Text = "0";
            this.hsCounter.ToolTipActive = false;
            this.hsCounter.ToolTipAutomaticDelay = 500;
            this.hsCounter.ToolTipAutoPopDelay = 5000;
            this.hsCounter.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCounter.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCounter.ToolTipFor4ContextMenu = true;
            this.hsCounter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCounter.ToolTipInitialDelay = 500;
            this.hsCounter.ToolTipIsBallon = false;
            this.hsCounter.ToolTipOwnerDraw = false;
            this.hsCounter.ToolTipReshowDelay = 100;
            this.hsCounter.ToolTipShowAlways = false;
            this.hsCounter.ToolTipText = "";
            this.hsCounter.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCounter.ToolTipTitle = "";
            this.hsCounter.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCounter.UseVisualStyleBackColor = false;
            this.hsCounter.Click += new System.EventHandler(this.hsCounter_Click);
            this.hsCounter.MouseEnter += new System.EventHandler(this.hsCounter_MouseEnter);
            this.hsCounter.MouseLeave += new System.EventHandler(this.hsCounter_MouseLeave);
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 160);
            this.ControlBox = false;
            this.Controls.Add(this.hsCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private SeControlsLib.HotSpot hsCounter;
    }
}