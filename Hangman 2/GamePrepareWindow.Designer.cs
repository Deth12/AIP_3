namespace hangman2
{
    partial class GamePrepareWindow
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
            this.GamePrepareWindowDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.GameStartTimer = new System.Windows.Forms.Timer(this.components);
            this.PrepareText = new System.Windows.Forms.Label();
            this.PrepareTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GamePrepareWindowDock
            // 
            this.GamePrepareWindowDock.AllowFormDragging = true;
            this.GamePrepareWindowDock.AllowFormDropShadow = true;
            this.GamePrepareWindowDock.AllowFormResizing = true;
            this.GamePrepareWindowDock.AllowHidingBottomRegion = true;
            this.GamePrepareWindowDock.AllowOpacityChangesWhileDragging = false;
            this.GamePrepareWindowDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.GamePrepareWindowDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.GamePrepareWindowDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.GamePrepareWindowDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.GamePrepareWindowDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.GamePrepareWindowDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.GamePrepareWindowDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.GamePrepareWindowDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.GamePrepareWindowDock.BorderOptions.RightBorder.ShowBorder = true;
            this.GamePrepareWindowDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.GamePrepareWindowDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.GamePrepareWindowDock.BorderOptions.TopBorder.ShowBorder = true;
            this.GamePrepareWindowDock.ContainerControl = this;
            this.GamePrepareWindowDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.GamePrepareWindowDock.DockingIndicatorsOpacity = 0.5D;
            this.GamePrepareWindowDock.DockingOptions.DockAll = true;
            this.GamePrepareWindowDock.DockingOptions.DockBottomLeft = true;
            this.GamePrepareWindowDock.DockingOptions.DockBottomRight = true;
            this.GamePrepareWindowDock.DockingOptions.DockFullScreen = true;
            this.GamePrepareWindowDock.DockingOptions.DockLeft = true;
            this.GamePrepareWindowDock.DockingOptions.DockRight = true;
            this.GamePrepareWindowDock.DockingOptions.DockTopLeft = true;
            this.GamePrepareWindowDock.DockingOptions.DockTopRight = true;
            this.GamePrepareWindowDock.FormDraggingOpacity = 0.9D;
            this.GamePrepareWindowDock.ParentForm = this;
            this.GamePrepareWindowDock.ShowCursorChanges = true;
            this.GamePrepareWindowDock.ShowDockingIndicators = true;
            this.GamePrepareWindowDock.TitleBarOptions.AllowFormDragging = true;
            this.GamePrepareWindowDock.TitleBarOptions.BunifuFormDock = this.GamePrepareWindowDock;
            this.GamePrepareWindowDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.GamePrepareWindowDock.TitleBarOptions.TitleBarControl = null;
            this.GamePrepareWindowDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // GameStartTimer
            // 
            this.GameStartTimer.Interval = 1000;
            this.GameStartTimer.Tick += new System.EventHandler(this.GameStartDelay_Tick);
            // 
            // PrepareText
            // 
            this.PrepareText.AutoSize = true;
            this.PrepareText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrepareText.Location = new System.Drawing.Point(140, 47);
            this.PrepareText.Name = "PrepareText";
            this.PrepareText.Size = new System.Drawing.Size(236, 24);
            this.PrepareText.TabIndex = 0;
            this.PrepareText.Text = "Игра начнется через ";
            // 
            // PrepareTimer
            // 
            this.PrepareTimer.AutoSize = true;
            this.PrepareTimer.Font = new System.Drawing.Font("Digital-7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrepareTimer.Location = new System.Drawing.Point(237, 88);
            this.PrepareTimer.Name = "PrepareTimer";
            this.PrepareTimer.Size = new System.Drawing.Size(27, 29);
            this.PrepareTimer.TabIndex = 2;
            this.PrepareTimer.Text = "0";
            // 
            // GamePrepareWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(510, 179);
            this.Controls.Add(this.PrepareTimer);
            this.Controls.Add(this.PrepareText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePrepareWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePrepareWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock GamePrepareWindowDock;
        private System.Windows.Forms.Label PrepareTimer;
        private System.Windows.Forms.Label PrepareText;
        private System.Windows.Forms.Timer GameStartTimer;
    }
}