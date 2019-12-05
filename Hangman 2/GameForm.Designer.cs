namespace hangman2
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.HpBox = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.G_MaximizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.G_MinimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.G_CloseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.letter1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AlphabetContainer = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.Letter32 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter31 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter30 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter29 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter28 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter27 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter26 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter25 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter24 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter22 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter21 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter20 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter19 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter18 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter17 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter16 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Letter2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.HangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.TotalTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusTextBox = new System.Windows.Forms.Label();
            this.SecretWordTextBox = new System.Windows.Forms.Label();
            this.TimerTextBox = new System.Windows.Forms.Label();
            this.DifficultyTextBox = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.AlphabetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameFormDock
            // 
            this.GameFormDock.AllowFormDragging = true;
            this.GameFormDock.AllowFormDropShadow = true;
            this.GameFormDock.AllowFormResizing = true;
            this.GameFormDock.AllowHidingBottomRegion = true;
            this.GameFormDock.AllowOpacityChangesWhileDragging = false;
            this.GameFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.GameFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.GameFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.GameFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.GameFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.GameFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.GameFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.GameFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.GameFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.GameFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.GameFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.GameFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.GameFormDock.ContainerControl = this;
            this.GameFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.GameFormDock.DockingIndicatorsOpacity = 0.5D;
            this.GameFormDock.DockingOptions.DockAll = true;
            this.GameFormDock.DockingOptions.DockBottomLeft = true;
            this.GameFormDock.DockingOptions.DockBottomRight = true;
            this.GameFormDock.DockingOptions.DockFullScreen = true;
            this.GameFormDock.DockingOptions.DockLeft = true;
            this.GameFormDock.DockingOptions.DockRight = true;
            this.GameFormDock.DockingOptions.DockTopLeft = true;
            this.GameFormDock.DockingOptions.DockTopRight = true;
            this.GameFormDock.FormDraggingOpacity = 0.9D;
            this.GameFormDock.ParentForm = this;
            this.GameFormDock.ShowCursorChanges = true;
            this.GameFormDock.ShowDockingIndicators = true;
            this.GameFormDock.TitleBarOptions.AllowFormDragging = true;
            this.GameFormDock.TitleBarOptions.BunifuFormDock = this.GameFormDock;
            this.GameFormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.GameFormDock.TitleBarOptions.TitleBarControl = null;
            this.GameFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // HpBox
            // 
            this.HpBox.Active = false;
            this.HpBox.Activecolor = System.Drawing.Color.Transparent;
            this.HpBox.BackColor = System.Drawing.Color.SteelBlue;
            this.HpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HpBox.BorderRadius = 0;
            this.HpBox.ButtonText = "0";
            this.HpBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HpBox.DisabledColor = System.Drawing.Color.Gray;
            this.HpBox.Iconcolor = System.Drawing.Color.Transparent;
            this.HpBox.Iconimage = ((System.Drawing.Image)(resources.GetObject("HpBox.Iconimage")));
            this.HpBox.Iconimage_right = null;
            this.HpBox.Iconimage_right_Selected = null;
            this.HpBox.Iconimage_Selected = null;
            this.HpBox.IconMarginLeft = 0;
            this.HpBox.IconMarginRight = 0;
            this.HpBox.IconRightVisible = true;
            this.HpBox.IconRightZoom = 0D;
            this.HpBox.IconVisible = true;
            this.HpBox.IconZoom = 60D;
            this.HpBox.IsTab = false;
            this.HpBox.Location = new System.Drawing.Point(26, 99);
            this.HpBox.Name = "HpBox";
            this.HpBox.Normalcolor = System.Drawing.Color.SteelBlue;
            this.HpBox.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.HpBox.OnHoverTextColor = System.Drawing.Color.White;
            this.HpBox.selected = false;
            this.HpBox.Size = new System.Drawing.Size(56, 31);
            this.HpBox.TabIndex = 10;
            this.HpBox.Text = "0";
            this.HpBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HpBox.Textcolor = System.Drawing.Color.White;
            this.HpBox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TopPanel.Controls.Add(this.AppNameLabel);
            this.TopPanel.Controls.Add(this.G_MaximizeButton);
            this.TopPanel.Controls.Add(this.G_MinimizeButton);
            this.TopPanel.Controls.Add(this.G_CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(667, 40);
            this.TopPanel.TabIndex = 6;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppNameLabel.ForeColor = System.Drawing.Color.White;
            this.AppNameLabel.Location = new System.Drawing.Point(19, 11);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(84, 17);
            this.AppNameLabel.TabIndex = 27;
            this.AppNameLabel.Text = "Hangman 2";
            // 
            // G_MaximizeButton
            // 
            this.G_MaximizeButton.Active = false;
            this.G_MaximizeButton.Activecolor = System.Drawing.Color.Transparent;
            this.G_MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.G_MaximizeButton.BackgroundImage = global::hangman2.Properties.Resources.maximizeButton;
            this.G_MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G_MaximizeButton.BorderRadius = 0;
            this.G_MaximizeButton.ButtonText = "";
            this.G_MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_MaximizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.G_MaximizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.G_MaximizeButton.Iconimage = null;
            this.G_MaximizeButton.Iconimage_right = null;
            this.G_MaximizeButton.Iconimage_right_Selected = null;
            this.G_MaximizeButton.Iconimage_Selected = null;
            this.G_MaximizeButton.IconMarginLeft = 0;
            this.G_MaximizeButton.IconMarginRight = 0;
            this.G_MaximizeButton.IconRightVisible = true;
            this.G_MaximizeButton.IconRightZoom = 0D;
            this.G_MaximizeButton.IconVisible = true;
            this.G_MaximizeButton.IconZoom = 90D;
            this.G_MaximizeButton.IsTab = false;
            this.G_MaximizeButton.Location = new System.Drawing.Point(582, -1);
            this.G_MaximizeButton.Name = "G_MaximizeButton";
            this.G_MaximizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.G_MaximizeButton.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.G_MaximizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.G_MaximizeButton.selected = false;
            this.G_MaximizeButton.Size = new System.Drawing.Size(38, 42);
            this.G_MaximizeButton.TabIndex = 20;
            this.G_MaximizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.G_MaximizeButton.Textcolor = System.Drawing.Color.White;
            this.G_MaximizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_MaximizeButton.Click += new System.EventHandler(this.G_MaximizeButton_Click);
            // 
            // G_MinimizeButton
            // 
            this.G_MinimizeButton.Active = false;
            this.G_MinimizeButton.Activecolor = System.Drawing.Color.Transparent;
            this.G_MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.G_MinimizeButton.BackgroundImage = global::hangman2.Properties.Resources.minimizeButton;
            this.G_MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G_MinimizeButton.BorderRadius = 0;
            this.G_MinimizeButton.ButtonText = "";
            this.G_MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_MinimizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.G_MinimizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.G_MinimizeButton.Iconimage = null;
            this.G_MinimizeButton.Iconimage_right = null;
            this.G_MinimizeButton.Iconimage_right_Selected = null;
            this.G_MinimizeButton.Iconimage_Selected = null;
            this.G_MinimizeButton.IconMarginLeft = 0;
            this.G_MinimizeButton.IconMarginRight = 0;
            this.G_MinimizeButton.IconRightVisible = true;
            this.G_MinimizeButton.IconRightZoom = 0D;
            this.G_MinimizeButton.IconVisible = true;
            this.G_MinimizeButton.IconZoom = 90D;
            this.G_MinimizeButton.IsTab = false;
            this.G_MinimizeButton.Location = new System.Drawing.Point(538, -1);
            this.G_MinimizeButton.Name = "G_MinimizeButton";
            this.G_MinimizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.G_MinimizeButton.OnHovercolor = System.Drawing.SystemColors.Desktop;
            this.G_MinimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.G_MinimizeButton.selected = false;
            this.G_MinimizeButton.Size = new System.Drawing.Size(38, 42);
            this.G_MinimizeButton.TabIndex = 19;
            this.G_MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.G_MinimizeButton.Textcolor = System.Drawing.Color.White;
            this.G_MinimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_MinimizeButton.Click += new System.EventHandler(this.G_MinimizeButton_Click);
            // 
            // G_CloseButton
            // 
            this.G_CloseButton.Active = false;
            this.G_CloseButton.Activecolor = System.Drawing.Color.Transparent;
            this.G_CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.G_CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.G_CloseButton.BackgroundImage = global::hangman2.Properties.Resources.closeButton;
            this.G_CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.G_CloseButton.BorderRadius = 0;
            this.G_CloseButton.ButtonText = "";
            this.G_CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.G_CloseButton.DisabledColor = System.Drawing.Color.Gray;
            this.G_CloseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.G_CloseButton.Iconimage = null;
            this.G_CloseButton.Iconimage_right = null;
            this.G_CloseButton.Iconimage_right_Selected = null;
            this.G_CloseButton.Iconimage_Selected = null;
            this.G_CloseButton.IconMarginLeft = 0;
            this.G_CloseButton.IconMarginRight = 0;
            this.G_CloseButton.IconRightVisible = true;
            this.G_CloseButton.IconRightZoom = 0D;
            this.G_CloseButton.IconVisible = true;
            this.G_CloseButton.IconZoom = 80D;
            this.G_CloseButton.IsTab = false;
            this.G_CloseButton.Location = new System.Drawing.Point(626, -1);
            this.G_CloseButton.Name = "G_CloseButton";
            this.G_CloseButton.Normalcolor = System.Drawing.Color.Transparent;
            this.G_CloseButton.OnHovercolor = System.Drawing.Color.Red;
            this.G_CloseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.G_CloseButton.selected = false;
            this.G_CloseButton.Size = new System.Drawing.Size(38, 42);
            this.G_CloseButton.TabIndex = 18;
            this.G_CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.G_CloseButton.Textcolor = System.Drawing.Color.White;
            this.G_CloseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G_CloseButton.Click += new System.EventHandler(this.G_CloseButton_Click);
            // 
            // letter1
            // 
            this.letter1.Active = false;
            this.letter1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.letter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.letter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letter1.BorderRadius = 0;
            this.letter1.ButtonText = "А";
            this.letter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letter1.DisabledColor = System.Drawing.Color.Gray;
            this.letter1.Iconcolor = System.Drawing.Color.Transparent;
            this.letter1.Iconimage = null;
            this.letter1.Iconimage_right = null;
            this.letter1.Iconimage_right_Selected = null;
            this.letter1.Iconimage_Selected = null;
            this.letter1.IconMarginLeft = 0;
            this.letter1.IconMarginRight = 0;
            this.letter1.IconRightVisible = true;
            this.letter1.IconRightZoom = 0D;
            this.letter1.IconVisible = true;
            this.letter1.IconZoom = 90D;
            this.letter1.IsTab = false;
            this.letter1.Location = new System.Drawing.Point(0, 0);
            this.letter1.Name = "letter1";
            this.letter1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.letter1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.letter1.OnHoverTextColor = System.Drawing.Color.White;
            this.letter1.selected = false;
            this.letter1.Size = new System.Drawing.Size(41, 42);
            this.letter1.TabIndex = 7;
            this.letter1.Text = "А";
            this.letter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.letter1.Textcolor = System.Drawing.Color.White;
            this.letter1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AlphabetContainer
            // 
            this.AlphabetContainer.BorderColor = System.Drawing.Color.Gainsboro;
            this.AlphabetContainer.Controls.Add(this.Letter32);
            this.AlphabetContainer.Controls.Add(this.Letter31);
            this.AlphabetContainer.Controls.Add(this.Letter30);
            this.AlphabetContainer.Controls.Add(this.Letter29);
            this.AlphabetContainer.Controls.Add(this.Letter28);
            this.AlphabetContainer.Controls.Add(this.Letter27);
            this.AlphabetContainer.Controls.Add(this.Letter26);
            this.AlphabetContainer.Controls.Add(this.Letter25);
            this.AlphabetContainer.Controls.Add(this.Letter24);
            this.AlphabetContainer.Controls.Add(this.Letter23);
            this.AlphabetContainer.Controls.Add(this.Letter22);
            this.AlphabetContainer.Controls.Add(this.Letter21);
            this.AlphabetContainer.Controls.Add(this.Letter20);
            this.AlphabetContainer.Controls.Add(this.Letter19);
            this.AlphabetContainer.Controls.Add(this.Letter18);
            this.AlphabetContainer.Controls.Add(this.Letter17);
            this.AlphabetContainer.Controls.Add(this.Letter16);
            this.AlphabetContainer.Controls.Add(this.Letter15);
            this.AlphabetContainer.Controls.Add(this.Letter14);
            this.AlphabetContainer.Controls.Add(this.Letter13);
            this.AlphabetContainer.Controls.Add(this.Letter12);
            this.AlphabetContainer.Controls.Add(this.Letter11);
            this.AlphabetContainer.Controls.Add(this.Letter10);
            this.AlphabetContainer.Controls.Add(this.Letter9);
            this.AlphabetContainer.Controls.Add(this.Letter7);
            this.AlphabetContainer.Controls.Add(this.Letter8);
            this.AlphabetContainer.Controls.Add(this.Letter6);
            this.AlphabetContainer.Controls.Add(this.Letter5);
            this.AlphabetContainer.Controls.Add(this.Letter4);
            this.AlphabetContainer.Controls.Add(this.Letter3);
            this.AlphabetContainer.Controls.Add(this.Letter2);
            this.AlphabetContainer.Controls.Add(this.letter1);
            this.AlphabetContainer.Location = new System.Drawing.Point(308, 99);
            this.AlphabetContainer.Name = "AlphabetContainer";
            this.AlphabetContainer.PanelColor = System.Drawing.Color.Empty;
            this.AlphabetContainer.ShadowDept = 2;
            this.AlphabetContainer.ShadowTopLeftVisible = false;
            this.AlphabetContainer.Size = new System.Drawing.Size(325, 169);
            this.AlphabetContainer.TabIndex = 8;
            // 
            // Letter32
            // 
            this.Letter32.Active = false;
            this.Letter32.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter32.BorderRadius = 0;
            this.Letter32.ButtonText = "Я";
            this.Letter32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter32.DisabledColor = System.Drawing.Color.Gray;
            this.Letter32.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter32.Iconimage = null;
            this.Letter32.Iconimage_right = null;
            this.Letter32.Iconimage_right_Selected = null;
            this.Letter32.Iconimage_Selected = null;
            this.Letter32.IconMarginLeft = 0;
            this.Letter32.IconMarginRight = 0;
            this.Letter32.IconRightVisible = true;
            this.Letter32.IconRightZoom = 0D;
            this.Letter32.IconVisible = true;
            this.Letter32.IconZoom = 90D;
            this.Letter32.IsTab = false;
            this.Letter32.Location = new System.Drawing.Point(280, 123);
            this.Letter32.Name = "Letter32";
            this.Letter32.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter32.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter32.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter32.selected = false;
            this.Letter32.Size = new System.Drawing.Size(41, 42);
            this.Letter32.TabIndex = 47;
            this.Letter32.Text = "Я";
            this.Letter32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter32.Textcolor = System.Drawing.Color.White;
            this.Letter32.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter31
            // 
            this.Letter31.Active = false;
            this.Letter31.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter31.BorderRadius = 0;
            this.Letter31.ButtonText = "Ю";
            this.Letter31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter31.DisabledColor = System.Drawing.Color.Gray;
            this.Letter31.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter31.Iconimage = null;
            this.Letter31.Iconimage_right = null;
            this.Letter31.Iconimage_right_Selected = null;
            this.Letter31.Iconimage_Selected = null;
            this.Letter31.IconMarginLeft = 0;
            this.Letter31.IconMarginRight = 0;
            this.Letter31.IconRightVisible = true;
            this.Letter31.IconRightZoom = 0D;
            this.Letter31.IconVisible = true;
            this.Letter31.IconZoom = 90D;
            this.Letter31.IsTab = false;
            this.Letter31.Location = new System.Drawing.Point(240, 123);
            this.Letter31.Name = "Letter31";
            this.Letter31.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter31.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter31.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter31.selected = false;
            this.Letter31.Size = new System.Drawing.Size(41, 42);
            this.Letter31.TabIndex = 46;
            this.Letter31.Text = "Ю";
            this.Letter31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter31.Textcolor = System.Drawing.Color.White;
            this.Letter31.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter30
            // 
            this.Letter30.Active = false;
            this.Letter30.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter30.BorderRadius = 0;
            this.Letter30.ButtonText = "Э";
            this.Letter30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter30.DisabledColor = System.Drawing.Color.Gray;
            this.Letter30.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter30.Iconimage = null;
            this.Letter30.Iconimage_right = null;
            this.Letter30.Iconimage_right_Selected = null;
            this.Letter30.Iconimage_Selected = null;
            this.Letter30.IconMarginLeft = 0;
            this.Letter30.IconMarginRight = 0;
            this.Letter30.IconRightVisible = true;
            this.Letter30.IconRightZoom = 0D;
            this.Letter30.IconVisible = true;
            this.Letter30.IconZoom = 90D;
            this.Letter30.IsTab = false;
            this.Letter30.Location = new System.Drawing.Point(200, 123);
            this.Letter30.Name = "Letter30";
            this.Letter30.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter30.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter30.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter30.selected = false;
            this.Letter30.Size = new System.Drawing.Size(41, 42);
            this.Letter30.TabIndex = 45;
            this.Letter30.Text = "Э";
            this.Letter30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter30.Textcolor = System.Drawing.Color.White;
            this.Letter30.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter29
            // 
            this.Letter29.Active = false;
            this.Letter29.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter29.BorderRadius = 0;
            this.Letter29.ButtonText = "Ь";
            this.Letter29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter29.DisabledColor = System.Drawing.Color.Gray;
            this.Letter29.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter29.Iconimage = null;
            this.Letter29.Iconimage_right = null;
            this.Letter29.Iconimage_right_Selected = null;
            this.Letter29.Iconimage_Selected = null;
            this.Letter29.IconMarginLeft = 0;
            this.Letter29.IconMarginRight = 0;
            this.Letter29.IconRightVisible = true;
            this.Letter29.IconRightZoom = 0D;
            this.Letter29.IconVisible = true;
            this.Letter29.IconZoom = 90D;
            this.Letter29.IsTab = false;
            this.Letter29.Location = new System.Drawing.Point(160, 123);
            this.Letter29.Name = "Letter29";
            this.Letter29.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter29.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter29.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter29.selected = false;
            this.Letter29.Size = new System.Drawing.Size(41, 42);
            this.Letter29.TabIndex = 44;
            this.Letter29.Text = "Ь";
            this.Letter29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter29.Textcolor = System.Drawing.Color.White;
            this.Letter29.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter28
            // 
            this.Letter28.Active = false;
            this.Letter28.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter28.BorderRadius = 0;
            this.Letter28.ButtonText = "Ы";
            this.Letter28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter28.DisabledColor = System.Drawing.Color.Gray;
            this.Letter28.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter28.Iconimage = null;
            this.Letter28.Iconimage_right = null;
            this.Letter28.Iconimage_right_Selected = null;
            this.Letter28.Iconimage_Selected = null;
            this.Letter28.IconMarginLeft = 0;
            this.Letter28.IconMarginRight = 0;
            this.Letter28.IconRightVisible = true;
            this.Letter28.IconRightZoom = 0D;
            this.Letter28.IconVisible = true;
            this.Letter28.IconZoom = 90D;
            this.Letter28.IsTab = false;
            this.Letter28.Location = new System.Drawing.Point(120, 123);
            this.Letter28.Name = "Letter28";
            this.Letter28.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter28.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter28.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter28.selected = false;
            this.Letter28.Size = new System.Drawing.Size(41, 42);
            this.Letter28.TabIndex = 43;
            this.Letter28.Text = "Ы";
            this.Letter28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter28.Textcolor = System.Drawing.Color.White;
            this.Letter28.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter27
            // 
            this.Letter27.Active = false;
            this.Letter27.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter27.BorderRadius = 0;
            this.Letter27.ButtonText = "Ъ";
            this.Letter27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter27.DisabledColor = System.Drawing.Color.Gray;
            this.Letter27.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter27.Iconimage = null;
            this.Letter27.Iconimage_right = null;
            this.Letter27.Iconimage_right_Selected = null;
            this.Letter27.Iconimage_Selected = null;
            this.Letter27.IconMarginLeft = 0;
            this.Letter27.IconMarginRight = 0;
            this.Letter27.IconRightVisible = true;
            this.Letter27.IconRightZoom = 0D;
            this.Letter27.IconVisible = true;
            this.Letter27.IconZoom = 90D;
            this.Letter27.IsTab = false;
            this.Letter27.Location = new System.Drawing.Point(80, 123);
            this.Letter27.Name = "Letter27";
            this.Letter27.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter27.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter27.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter27.selected = false;
            this.Letter27.Size = new System.Drawing.Size(41, 42);
            this.Letter27.TabIndex = 42;
            this.Letter27.Text = "Ъ";
            this.Letter27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter27.Textcolor = System.Drawing.Color.White;
            this.Letter27.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter26
            // 
            this.Letter26.Active = false;
            this.Letter26.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter26.BorderRadius = 0;
            this.Letter26.ButtonText = "Щ";
            this.Letter26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter26.DisabledColor = System.Drawing.Color.Gray;
            this.Letter26.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter26.Iconimage = null;
            this.Letter26.Iconimage_right = null;
            this.Letter26.Iconimage_right_Selected = null;
            this.Letter26.Iconimage_Selected = null;
            this.Letter26.IconMarginLeft = 0;
            this.Letter26.IconMarginRight = 0;
            this.Letter26.IconRightVisible = true;
            this.Letter26.IconRightZoom = 0D;
            this.Letter26.IconVisible = true;
            this.Letter26.IconZoom = 90D;
            this.Letter26.IsTab = false;
            this.Letter26.Location = new System.Drawing.Point(40, 123);
            this.Letter26.Name = "Letter26";
            this.Letter26.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter26.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter26.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter26.selected = false;
            this.Letter26.Size = new System.Drawing.Size(41, 42);
            this.Letter26.TabIndex = 41;
            this.Letter26.Text = "Щ";
            this.Letter26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter26.Textcolor = System.Drawing.Color.White;
            this.Letter26.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter25
            // 
            this.Letter25.Active = false;
            this.Letter25.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter25.BorderRadius = 0;
            this.Letter25.ButtonText = "Ш";
            this.Letter25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter25.DisabledColor = System.Drawing.Color.Gray;
            this.Letter25.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter25.Iconimage = null;
            this.Letter25.Iconimage_right = null;
            this.Letter25.Iconimage_right_Selected = null;
            this.Letter25.Iconimage_Selected = null;
            this.Letter25.IconMarginLeft = 0;
            this.Letter25.IconMarginRight = 0;
            this.Letter25.IconRightVisible = true;
            this.Letter25.IconRightZoom = 0D;
            this.Letter25.IconVisible = true;
            this.Letter25.IconZoom = 90D;
            this.Letter25.IsTab = false;
            this.Letter25.Location = new System.Drawing.Point(0, 123);
            this.Letter25.Name = "Letter25";
            this.Letter25.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter25.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter25.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter25.selected = false;
            this.Letter25.Size = new System.Drawing.Size(41, 42);
            this.Letter25.TabIndex = 40;
            this.Letter25.Text = "Ш";
            this.Letter25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter25.Textcolor = System.Drawing.Color.White;
            this.Letter25.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter24
            // 
            this.Letter24.Active = false;
            this.Letter24.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter24.BorderRadius = 0;
            this.Letter24.ButtonText = "Ч";
            this.Letter24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter24.DisabledColor = System.Drawing.Color.Gray;
            this.Letter24.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter24.Iconimage = null;
            this.Letter24.Iconimage_right = null;
            this.Letter24.Iconimage_right_Selected = null;
            this.Letter24.Iconimage_Selected = null;
            this.Letter24.IconMarginLeft = 0;
            this.Letter24.IconMarginRight = 0;
            this.Letter24.IconRightVisible = true;
            this.Letter24.IconRightZoom = 0D;
            this.Letter24.IconVisible = true;
            this.Letter24.IconZoom = 90D;
            this.Letter24.IsTab = false;
            this.Letter24.Location = new System.Drawing.Point(280, 82);
            this.Letter24.Name = "Letter24";
            this.Letter24.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter24.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter24.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter24.selected = false;
            this.Letter24.Size = new System.Drawing.Size(41, 42);
            this.Letter24.TabIndex = 39;
            this.Letter24.Text = "Ч";
            this.Letter24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter24.Textcolor = System.Drawing.Color.White;
            this.Letter24.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter23
            // 
            this.Letter23.Active = false;
            this.Letter23.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter23.BorderRadius = 0;
            this.Letter23.ButtonText = "Ц";
            this.Letter23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter23.DisabledColor = System.Drawing.Color.Gray;
            this.Letter23.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter23.Iconimage = null;
            this.Letter23.Iconimage_right = null;
            this.Letter23.Iconimage_right_Selected = null;
            this.Letter23.Iconimage_Selected = null;
            this.Letter23.IconMarginLeft = 0;
            this.Letter23.IconMarginRight = 0;
            this.Letter23.IconRightVisible = true;
            this.Letter23.IconRightZoom = 0D;
            this.Letter23.IconVisible = true;
            this.Letter23.IconZoom = 90D;
            this.Letter23.IsTab = false;
            this.Letter23.Location = new System.Drawing.Point(240, 82);
            this.Letter23.Name = "Letter23";
            this.Letter23.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter23.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter23.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter23.selected = false;
            this.Letter23.Size = new System.Drawing.Size(41, 42);
            this.Letter23.TabIndex = 38;
            this.Letter23.Text = "Ц";
            this.Letter23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter23.Textcolor = System.Drawing.Color.White;
            this.Letter23.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter22
            // 
            this.Letter22.Active = false;
            this.Letter22.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter22.BorderRadius = 0;
            this.Letter22.ButtonText = "Х";
            this.Letter22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter22.DisabledColor = System.Drawing.Color.Gray;
            this.Letter22.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter22.Iconimage = null;
            this.Letter22.Iconimage_right = null;
            this.Letter22.Iconimage_right_Selected = null;
            this.Letter22.Iconimage_Selected = null;
            this.Letter22.IconMarginLeft = 0;
            this.Letter22.IconMarginRight = 0;
            this.Letter22.IconRightVisible = true;
            this.Letter22.IconRightZoom = 0D;
            this.Letter22.IconVisible = true;
            this.Letter22.IconZoom = 90D;
            this.Letter22.IsTab = false;
            this.Letter22.Location = new System.Drawing.Point(200, 82);
            this.Letter22.Name = "Letter22";
            this.Letter22.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter22.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter22.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter22.selected = false;
            this.Letter22.Size = new System.Drawing.Size(41, 42);
            this.Letter22.TabIndex = 37;
            this.Letter22.Text = "Х";
            this.Letter22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter22.Textcolor = System.Drawing.Color.White;
            this.Letter22.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter21
            // 
            this.Letter21.Active = false;
            this.Letter21.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter21.BorderRadius = 0;
            this.Letter21.ButtonText = "Ф";
            this.Letter21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter21.DisabledColor = System.Drawing.Color.Gray;
            this.Letter21.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter21.Iconimage = null;
            this.Letter21.Iconimage_right = null;
            this.Letter21.Iconimage_right_Selected = null;
            this.Letter21.Iconimage_Selected = null;
            this.Letter21.IconMarginLeft = 0;
            this.Letter21.IconMarginRight = 0;
            this.Letter21.IconRightVisible = true;
            this.Letter21.IconRightZoom = 0D;
            this.Letter21.IconVisible = true;
            this.Letter21.IconZoom = 90D;
            this.Letter21.IsTab = false;
            this.Letter21.Location = new System.Drawing.Point(160, 82);
            this.Letter21.Name = "Letter21";
            this.Letter21.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter21.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter21.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter21.selected = false;
            this.Letter21.Size = new System.Drawing.Size(41, 42);
            this.Letter21.TabIndex = 36;
            this.Letter21.Text = "Ф";
            this.Letter21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter21.Textcolor = System.Drawing.Color.White;
            this.Letter21.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter20
            // 
            this.Letter20.Active = false;
            this.Letter20.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter20.BorderRadius = 0;
            this.Letter20.ButtonText = "У";
            this.Letter20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter20.DisabledColor = System.Drawing.Color.Gray;
            this.Letter20.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter20.Iconimage = null;
            this.Letter20.Iconimage_right = null;
            this.Letter20.Iconimage_right_Selected = null;
            this.Letter20.Iconimage_Selected = null;
            this.Letter20.IconMarginLeft = 0;
            this.Letter20.IconMarginRight = 0;
            this.Letter20.IconRightVisible = true;
            this.Letter20.IconRightZoom = 0D;
            this.Letter20.IconVisible = true;
            this.Letter20.IconZoom = 90D;
            this.Letter20.IsTab = false;
            this.Letter20.Location = new System.Drawing.Point(120, 82);
            this.Letter20.Name = "Letter20";
            this.Letter20.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter20.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter20.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter20.selected = false;
            this.Letter20.Size = new System.Drawing.Size(41, 42);
            this.Letter20.TabIndex = 35;
            this.Letter20.Text = "У";
            this.Letter20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter20.Textcolor = System.Drawing.Color.White;
            this.Letter20.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter19
            // 
            this.Letter19.Active = false;
            this.Letter19.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter19.BorderRadius = 0;
            this.Letter19.ButtonText = "Т";
            this.Letter19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter19.DisabledColor = System.Drawing.Color.Gray;
            this.Letter19.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter19.Iconimage = null;
            this.Letter19.Iconimage_right = null;
            this.Letter19.Iconimage_right_Selected = null;
            this.Letter19.Iconimage_Selected = null;
            this.Letter19.IconMarginLeft = 0;
            this.Letter19.IconMarginRight = 0;
            this.Letter19.IconRightVisible = true;
            this.Letter19.IconRightZoom = 0D;
            this.Letter19.IconVisible = true;
            this.Letter19.IconZoom = 90D;
            this.Letter19.IsTab = false;
            this.Letter19.Location = new System.Drawing.Point(80, 82);
            this.Letter19.Name = "Letter19";
            this.Letter19.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter19.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter19.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter19.selected = false;
            this.Letter19.Size = new System.Drawing.Size(41, 42);
            this.Letter19.TabIndex = 34;
            this.Letter19.Text = "Т";
            this.Letter19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter19.Textcolor = System.Drawing.Color.White;
            this.Letter19.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter18
            // 
            this.Letter18.Active = false;
            this.Letter18.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter18.BorderRadius = 0;
            this.Letter18.ButtonText = "С";
            this.Letter18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter18.DisabledColor = System.Drawing.Color.Gray;
            this.Letter18.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter18.Iconimage = null;
            this.Letter18.Iconimage_right = null;
            this.Letter18.Iconimage_right_Selected = null;
            this.Letter18.Iconimage_Selected = null;
            this.Letter18.IconMarginLeft = 0;
            this.Letter18.IconMarginRight = 0;
            this.Letter18.IconRightVisible = true;
            this.Letter18.IconRightZoom = 0D;
            this.Letter18.IconVisible = true;
            this.Letter18.IconZoom = 90D;
            this.Letter18.IsTab = false;
            this.Letter18.Location = new System.Drawing.Point(40, 82);
            this.Letter18.Name = "Letter18";
            this.Letter18.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter18.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter18.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter18.selected = false;
            this.Letter18.Size = new System.Drawing.Size(41, 42);
            this.Letter18.TabIndex = 33;
            this.Letter18.Text = "С";
            this.Letter18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter18.Textcolor = System.Drawing.Color.White;
            this.Letter18.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter17
            // 
            this.Letter17.Active = false;
            this.Letter17.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter17.BorderRadius = 0;
            this.Letter17.ButtonText = "Р";
            this.Letter17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter17.DisabledColor = System.Drawing.Color.Gray;
            this.Letter17.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter17.Iconimage = null;
            this.Letter17.Iconimage_right = null;
            this.Letter17.Iconimage_right_Selected = null;
            this.Letter17.Iconimage_Selected = null;
            this.Letter17.IconMarginLeft = 0;
            this.Letter17.IconMarginRight = 0;
            this.Letter17.IconRightVisible = true;
            this.Letter17.IconRightZoom = 0D;
            this.Letter17.IconVisible = true;
            this.Letter17.IconZoom = 90D;
            this.Letter17.IsTab = false;
            this.Letter17.Location = new System.Drawing.Point(0, 82);
            this.Letter17.Name = "Letter17";
            this.Letter17.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter17.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter17.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter17.selected = false;
            this.Letter17.Size = new System.Drawing.Size(41, 42);
            this.Letter17.TabIndex = 32;
            this.Letter17.Text = "Р";
            this.Letter17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter17.Textcolor = System.Drawing.Color.White;
            this.Letter17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter16
            // 
            this.Letter16.Active = false;
            this.Letter16.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter16.BorderRadius = 0;
            this.Letter16.ButtonText = "П";
            this.Letter16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter16.DisabledColor = System.Drawing.Color.Gray;
            this.Letter16.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter16.Iconimage = null;
            this.Letter16.Iconimage_right = null;
            this.Letter16.Iconimage_right_Selected = null;
            this.Letter16.Iconimage_Selected = null;
            this.Letter16.IconMarginLeft = 0;
            this.Letter16.IconMarginRight = 0;
            this.Letter16.IconRightVisible = true;
            this.Letter16.IconRightZoom = 0D;
            this.Letter16.IconVisible = true;
            this.Letter16.IconZoom = 90D;
            this.Letter16.IsTab = false;
            this.Letter16.Location = new System.Drawing.Point(280, 41);
            this.Letter16.Name = "Letter16";
            this.Letter16.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter16.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter16.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter16.selected = false;
            this.Letter16.Size = new System.Drawing.Size(41, 42);
            this.Letter16.TabIndex = 31;
            this.Letter16.Text = "П";
            this.Letter16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter16.Textcolor = System.Drawing.Color.White;
            this.Letter16.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter15
            // 
            this.Letter15.Active = false;
            this.Letter15.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter15.BorderRadius = 0;
            this.Letter15.ButtonText = "О";
            this.Letter15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter15.DisabledColor = System.Drawing.Color.Gray;
            this.Letter15.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter15.Iconimage = null;
            this.Letter15.Iconimage_right = null;
            this.Letter15.Iconimage_right_Selected = null;
            this.Letter15.Iconimage_Selected = null;
            this.Letter15.IconMarginLeft = 0;
            this.Letter15.IconMarginRight = 0;
            this.Letter15.IconRightVisible = true;
            this.Letter15.IconRightZoom = 0D;
            this.Letter15.IconVisible = true;
            this.Letter15.IconZoom = 90D;
            this.Letter15.IsTab = false;
            this.Letter15.Location = new System.Drawing.Point(240, 41);
            this.Letter15.Name = "Letter15";
            this.Letter15.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter15.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter15.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter15.selected = false;
            this.Letter15.Size = new System.Drawing.Size(41, 42);
            this.Letter15.TabIndex = 30;
            this.Letter15.Text = "О";
            this.Letter15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter15.Textcolor = System.Drawing.Color.White;
            this.Letter15.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter14
            // 
            this.Letter14.Active = false;
            this.Letter14.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter14.BorderRadius = 0;
            this.Letter14.ButtonText = "Н";
            this.Letter14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter14.DisabledColor = System.Drawing.Color.Gray;
            this.Letter14.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter14.Iconimage = null;
            this.Letter14.Iconimage_right = null;
            this.Letter14.Iconimage_right_Selected = null;
            this.Letter14.Iconimage_Selected = null;
            this.Letter14.IconMarginLeft = 0;
            this.Letter14.IconMarginRight = 0;
            this.Letter14.IconRightVisible = true;
            this.Letter14.IconRightZoom = 0D;
            this.Letter14.IconVisible = true;
            this.Letter14.IconZoom = 90D;
            this.Letter14.IsTab = false;
            this.Letter14.Location = new System.Drawing.Point(200, 41);
            this.Letter14.Name = "Letter14";
            this.Letter14.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter14.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter14.selected = false;
            this.Letter14.Size = new System.Drawing.Size(41, 42);
            this.Letter14.TabIndex = 29;
            this.Letter14.Text = "Н";
            this.Letter14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter14.Textcolor = System.Drawing.Color.White;
            this.Letter14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter13
            // 
            this.Letter13.Active = false;
            this.Letter13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter13.BorderRadius = 0;
            this.Letter13.ButtonText = "М";
            this.Letter13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter13.DisabledColor = System.Drawing.Color.Gray;
            this.Letter13.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter13.Iconimage = null;
            this.Letter13.Iconimage_right = null;
            this.Letter13.Iconimage_right_Selected = null;
            this.Letter13.Iconimage_Selected = null;
            this.Letter13.IconMarginLeft = 0;
            this.Letter13.IconMarginRight = 0;
            this.Letter13.IconRightVisible = true;
            this.Letter13.IconRightZoom = 0D;
            this.Letter13.IconVisible = true;
            this.Letter13.IconZoom = 90D;
            this.Letter13.IsTab = false;
            this.Letter13.Location = new System.Drawing.Point(160, 41);
            this.Letter13.Name = "Letter13";
            this.Letter13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter13.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter13.selected = false;
            this.Letter13.Size = new System.Drawing.Size(41, 42);
            this.Letter13.TabIndex = 28;
            this.Letter13.Text = "М";
            this.Letter13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter13.Textcolor = System.Drawing.Color.White;
            this.Letter13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter12
            // 
            this.Letter12.Active = false;
            this.Letter12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter12.BorderRadius = 0;
            this.Letter12.ButtonText = "Л";
            this.Letter12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter12.DisabledColor = System.Drawing.Color.Gray;
            this.Letter12.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter12.Iconimage = null;
            this.Letter12.Iconimage_right = null;
            this.Letter12.Iconimage_right_Selected = null;
            this.Letter12.Iconimage_Selected = null;
            this.Letter12.IconMarginLeft = 0;
            this.Letter12.IconMarginRight = 0;
            this.Letter12.IconRightVisible = true;
            this.Letter12.IconRightZoom = 0D;
            this.Letter12.IconVisible = true;
            this.Letter12.IconZoom = 90D;
            this.Letter12.IsTab = false;
            this.Letter12.Location = new System.Drawing.Point(120, 41);
            this.Letter12.Name = "Letter12";
            this.Letter12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter12.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter12.selected = false;
            this.Letter12.Size = new System.Drawing.Size(41, 42);
            this.Letter12.TabIndex = 27;
            this.Letter12.Text = "Л";
            this.Letter12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter12.Textcolor = System.Drawing.Color.White;
            this.Letter12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter11
            // 
            this.Letter11.Active = false;
            this.Letter11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter11.BorderRadius = 0;
            this.Letter11.ButtonText = "К";
            this.Letter11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter11.DisabledColor = System.Drawing.Color.Gray;
            this.Letter11.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter11.Iconimage = null;
            this.Letter11.Iconimage_right = null;
            this.Letter11.Iconimage_right_Selected = null;
            this.Letter11.Iconimage_Selected = null;
            this.Letter11.IconMarginLeft = 0;
            this.Letter11.IconMarginRight = 0;
            this.Letter11.IconRightVisible = true;
            this.Letter11.IconRightZoom = 0D;
            this.Letter11.IconVisible = true;
            this.Letter11.IconZoom = 90D;
            this.Letter11.IsTab = false;
            this.Letter11.Location = new System.Drawing.Point(80, 41);
            this.Letter11.Name = "Letter11";
            this.Letter11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter11.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter11.selected = false;
            this.Letter11.Size = new System.Drawing.Size(41, 42);
            this.Letter11.TabIndex = 26;
            this.Letter11.Text = "К";
            this.Letter11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter11.Textcolor = System.Drawing.Color.White;
            this.Letter11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter10
            // 
            this.Letter10.Active = false;
            this.Letter10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter10.BorderRadius = 0;
            this.Letter10.ButtonText = "Й";
            this.Letter10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter10.DisabledColor = System.Drawing.Color.Gray;
            this.Letter10.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter10.Iconimage = null;
            this.Letter10.Iconimage_right = null;
            this.Letter10.Iconimage_right_Selected = null;
            this.Letter10.Iconimage_Selected = null;
            this.Letter10.IconMarginLeft = 0;
            this.Letter10.IconMarginRight = 0;
            this.Letter10.IconRightVisible = true;
            this.Letter10.IconRightZoom = 0D;
            this.Letter10.IconVisible = true;
            this.Letter10.IconZoom = 90D;
            this.Letter10.IsTab = false;
            this.Letter10.Location = new System.Drawing.Point(40, 41);
            this.Letter10.Name = "Letter10";
            this.Letter10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter10.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter10.selected = false;
            this.Letter10.Size = new System.Drawing.Size(41, 42);
            this.Letter10.TabIndex = 25;
            this.Letter10.Text = "Й";
            this.Letter10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter10.Textcolor = System.Drawing.Color.White;
            this.Letter10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter9
            // 
            this.Letter9.Active = false;
            this.Letter9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter9.BorderRadius = 0;
            this.Letter9.ButtonText = "И";
            this.Letter9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter9.DisabledColor = System.Drawing.Color.Gray;
            this.Letter9.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter9.Iconimage = null;
            this.Letter9.Iconimage_right = null;
            this.Letter9.Iconimage_right_Selected = null;
            this.Letter9.Iconimage_Selected = null;
            this.Letter9.IconMarginLeft = 0;
            this.Letter9.IconMarginRight = 0;
            this.Letter9.IconRightVisible = true;
            this.Letter9.IconRightZoom = 0D;
            this.Letter9.IconVisible = true;
            this.Letter9.IconZoom = 90D;
            this.Letter9.IsTab = false;
            this.Letter9.Location = new System.Drawing.Point(0, 41);
            this.Letter9.Name = "Letter9";
            this.Letter9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter9.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter9.selected = false;
            this.Letter9.Size = new System.Drawing.Size(41, 42);
            this.Letter9.TabIndex = 24;
            this.Letter9.Text = "И";
            this.Letter9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter9.Textcolor = System.Drawing.Color.White;
            this.Letter9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter7
            // 
            this.Letter7.Active = false;
            this.Letter7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter7.BorderRadius = 0;
            this.Letter7.ButtonText = "Ж";
            this.Letter7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter7.DisabledColor = System.Drawing.Color.Gray;
            this.Letter7.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter7.Iconimage = null;
            this.Letter7.Iconimage_right = null;
            this.Letter7.Iconimage_right_Selected = null;
            this.Letter7.Iconimage_Selected = null;
            this.Letter7.IconMarginLeft = 0;
            this.Letter7.IconMarginRight = 0;
            this.Letter7.IconRightVisible = true;
            this.Letter7.IconRightZoom = 0D;
            this.Letter7.IconVisible = true;
            this.Letter7.IconZoom = 90D;
            this.Letter7.IsTab = false;
            this.Letter7.Location = new System.Drawing.Point(240, 0);
            this.Letter7.Name = "Letter7";
            this.Letter7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter7.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter7.selected = false;
            this.Letter7.Size = new System.Drawing.Size(41, 42);
            this.Letter7.TabIndex = 23;
            this.Letter7.Text = "Ж";
            this.Letter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter7.Textcolor = System.Drawing.Color.White;
            this.Letter7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter8
            // 
            this.Letter8.Active = false;
            this.Letter8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter8.BorderRadius = 0;
            this.Letter8.ButtonText = "З";
            this.Letter8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter8.DisabledColor = System.Drawing.Color.Gray;
            this.Letter8.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter8.Iconimage = null;
            this.Letter8.Iconimage_right = null;
            this.Letter8.Iconimage_right_Selected = null;
            this.Letter8.Iconimage_Selected = null;
            this.Letter8.IconMarginLeft = 0;
            this.Letter8.IconMarginRight = 0;
            this.Letter8.IconRightVisible = true;
            this.Letter8.IconRightZoom = 0D;
            this.Letter8.IconVisible = true;
            this.Letter8.IconZoom = 90D;
            this.Letter8.IsTab = false;
            this.Letter8.Location = new System.Drawing.Point(280, 0);
            this.Letter8.Name = "Letter8";
            this.Letter8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter8.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter8.selected = false;
            this.Letter8.Size = new System.Drawing.Size(41, 42);
            this.Letter8.TabIndex = 22;
            this.Letter8.Text = "З";
            this.Letter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter8.Textcolor = System.Drawing.Color.White;
            this.Letter8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter6
            // 
            this.Letter6.Active = false;
            this.Letter6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter6.BorderRadius = 0;
            this.Letter6.ButtonText = "Е";
            this.Letter6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter6.DisabledColor = System.Drawing.Color.Gray;
            this.Letter6.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter6.Iconimage = null;
            this.Letter6.Iconimage_right = null;
            this.Letter6.Iconimage_right_Selected = null;
            this.Letter6.Iconimage_Selected = null;
            this.Letter6.IconMarginLeft = 0;
            this.Letter6.IconMarginRight = 0;
            this.Letter6.IconRightVisible = true;
            this.Letter6.IconRightZoom = 0D;
            this.Letter6.IconVisible = true;
            this.Letter6.IconZoom = 90D;
            this.Letter6.IsTab = false;
            this.Letter6.Location = new System.Drawing.Point(200, 0);
            this.Letter6.Name = "Letter6";
            this.Letter6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter6.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter6.selected = false;
            this.Letter6.Size = new System.Drawing.Size(41, 42);
            this.Letter6.TabIndex = 9;
            this.Letter6.Text = "Е";
            this.Letter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter6.Textcolor = System.Drawing.Color.White;
            this.Letter6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter5
            // 
            this.Letter5.Active = false;
            this.Letter5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter5.BorderRadius = 0;
            this.Letter5.ButtonText = "Д";
            this.Letter5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter5.DisabledColor = System.Drawing.Color.Gray;
            this.Letter5.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter5.Iconimage = null;
            this.Letter5.Iconimage_right = null;
            this.Letter5.Iconimage_right_Selected = null;
            this.Letter5.Iconimage_Selected = null;
            this.Letter5.IconMarginLeft = 0;
            this.Letter5.IconMarginRight = 0;
            this.Letter5.IconRightVisible = true;
            this.Letter5.IconRightZoom = 0D;
            this.Letter5.IconVisible = true;
            this.Letter5.IconZoom = 90D;
            this.Letter5.IsTab = false;
            this.Letter5.Location = new System.Drawing.Point(160, 0);
            this.Letter5.Name = "Letter5";
            this.Letter5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter5.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter5.selected = false;
            this.Letter5.Size = new System.Drawing.Size(41, 42);
            this.Letter5.TabIndex = 21;
            this.Letter5.Text = "Д";
            this.Letter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter5.Textcolor = System.Drawing.Color.White;
            this.Letter5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter4
            // 
            this.Letter4.Active = false;
            this.Letter4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter4.BorderRadius = 0;
            this.Letter4.ButtonText = "Г";
            this.Letter4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter4.DisabledColor = System.Drawing.Color.Gray;
            this.Letter4.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter4.Iconimage = null;
            this.Letter4.Iconimage_right = null;
            this.Letter4.Iconimage_right_Selected = null;
            this.Letter4.Iconimage_Selected = null;
            this.Letter4.IconMarginLeft = 0;
            this.Letter4.IconMarginRight = 0;
            this.Letter4.IconRightVisible = true;
            this.Letter4.IconRightZoom = 0D;
            this.Letter4.IconVisible = true;
            this.Letter4.IconZoom = 90D;
            this.Letter4.IsTab = false;
            this.Letter4.Location = new System.Drawing.Point(120, 0);
            this.Letter4.Name = "Letter4";
            this.Letter4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter4.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter4.selected = false;
            this.Letter4.Size = new System.Drawing.Size(41, 42);
            this.Letter4.TabIndex = 10;
            this.Letter4.Text = "Г";
            this.Letter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter4.Textcolor = System.Drawing.Color.White;
            this.Letter4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter3
            // 
            this.Letter3.Active = false;
            this.Letter3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter3.BorderRadius = 0;
            this.Letter3.ButtonText = "В";
            this.Letter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter3.DisabledColor = System.Drawing.Color.Gray;
            this.Letter3.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter3.Iconimage = null;
            this.Letter3.Iconimage_right = null;
            this.Letter3.Iconimage_right_Selected = null;
            this.Letter3.Iconimage_Selected = null;
            this.Letter3.IconMarginLeft = 0;
            this.Letter3.IconMarginRight = 0;
            this.Letter3.IconRightVisible = true;
            this.Letter3.IconRightZoom = 0D;
            this.Letter3.IconVisible = true;
            this.Letter3.IconZoom = 90D;
            this.Letter3.IsTab = false;
            this.Letter3.Location = new System.Drawing.Point(80, 0);
            this.Letter3.Name = "Letter3";
            this.Letter3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter3.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter3.selected = false;
            this.Letter3.Size = new System.Drawing.Size(41, 42);
            this.Letter3.TabIndex = 9;
            this.Letter3.Text = "В";
            this.Letter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter3.Textcolor = System.Drawing.Color.White;
            this.Letter3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Letter2
            // 
            this.Letter2.Active = false;
            this.Letter2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Letter2.BorderRadius = 0;
            this.Letter2.ButtonText = "Б";
            this.Letter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Letter2.DisabledColor = System.Drawing.Color.Gray;
            this.Letter2.Iconcolor = System.Drawing.Color.Transparent;
            this.Letter2.Iconimage = null;
            this.Letter2.Iconimage_right = null;
            this.Letter2.Iconimage_right_Selected = null;
            this.Letter2.Iconimage_Selected = null;
            this.Letter2.IconMarginLeft = 0;
            this.Letter2.IconMarginRight = 0;
            this.Letter2.IconRightVisible = true;
            this.Letter2.IconRightZoom = 0D;
            this.Letter2.IconVisible = true;
            this.Letter2.IconZoom = 90D;
            this.Letter2.IsTab = false;
            this.Letter2.Location = new System.Drawing.Point(40, 0);
            this.Letter2.Name = "Letter2";
            this.Letter2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Letter2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Letter2.OnHoverTextColor = System.Drawing.Color.White;
            this.Letter2.selected = false;
            this.Letter2.Size = new System.Drawing.Size(41, 42);
            this.Letter2.TabIndex = 8;
            this.Letter2.Text = "Б";
            this.Letter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letter2.Textcolor = System.Drawing.Color.White;
            this.Letter2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Висельник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Алфавит";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Время на ход";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HangmanPictureBox
            // 
            this.HangmanPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HangmanPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HangmanPictureBox.Image")));
            this.HangmanPictureBox.Location = new System.Drawing.Point(26, 99);
            this.HangmanPictureBox.Name = "HangmanPictureBox";
            this.HangmanPictureBox.Size = new System.Drawing.Size(195, 218);
            this.HangmanPictureBox.TabIndex = 18;
            this.HangmanPictureBox.TabStop = false;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyLabel.Location = new System.Drawing.Point(364, 364);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(128, 24);
            this.DifficultyLabel.TabIndex = 20;
            this.DifficultyLabel.Text = "Сложность";
            // 
            // TotalTimeTimer
            // 
            this.TotalTimeTimer.Interval = 1000;
            this.TotalTimeTimer.Tick += new System.EventHandler(this.TotalTimeTimer_Tick);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.Color.White;
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusTextBox.Location = new System.Drawing.Point(308, 267);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(321, 34);
            this.StatusTextBox.TabIndex = 22;
            this.StatusTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecretWordTextBox
            // 
            this.SecretWordTextBox.BackColor = System.Drawing.Color.White;
            this.SecretWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecretWordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretWordTextBox.Location = new System.Drawing.Point(26, 316);
            this.SecretWordTextBox.Name = "SecretWordTextBox";
            this.SecretWordTextBox.Size = new System.Drawing.Size(195, 34);
            this.SecretWordTextBox.TabIndex = 24;
            this.SecretWordTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.BackColor = System.Drawing.Color.White;
            this.TimerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerTextBox.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTextBox.Location = new System.Drawing.Point(528, 316);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.Size = new System.Drawing.Size(101, 34);
            this.TimerTextBox.TabIndex = 25;
            this.TimerTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.BackColor = System.Drawing.Color.White;
            this.DifficultyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DifficultyTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyTextBox.Location = new System.Drawing.Point(528, 356);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(101, 34);
            this.DifficultyTextBox.TabIndex = 26;
            this.DifficultyTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 405);
            this.Controls.Add(this.DifficultyTextBox);
            this.Controls.Add(this.TimerTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.SecretWordTextBox);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.HpBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlphabetContainer);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.HangmanPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.AlphabetContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock GameFormDock;
        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuFlatButton G_MaximizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton G_MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton G_CloseButton;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel AlphabetContainer;
        private Bunifu.Framework.UI.BunifuFlatButton Letter32;
        private Bunifu.Framework.UI.BunifuFlatButton Letter31;
        private Bunifu.Framework.UI.BunifuFlatButton Letter30;
        private Bunifu.Framework.UI.BunifuFlatButton Letter29;
        private Bunifu.Framework.UI.BunifuFlatButton Letter28;
        private Bunifu.Framework.UI.BunifuFlatButton Letter27;
        private Bunifu.Framework.UI.BunifuFlatButton Letter26;
        private Bunifu.Framework.UI.BunifuFlatButton Letter25;
        private Bunifu.Framework.UI.BunifuFlatButton Letter24;
        private Bunifu.Framework.UI.BunifuFlatButton Letter23;
        private Bunifu.Framework.UI.BunifuFlatButton Letter22;
        private Bunifu.Framework.UI.BunifuFlatButton Letter21;
        private Bunifu.Framework.UI.BunifuFlatButton Letter20;
        private Bunifu.Framework.UI.BunifuFlatButton Letter19;
        private Bunifu.Framework.UI.BunifuFlatButton Letter18;
        private Bunifu.Framework.UI.BunifuFlatButton Letter17;
        private Bunifu.Framework.UI.BunifuFlatButton Letter16;
        private Bunifu.Framework.UI.BunifuFlatButton Letter15;
        private Bunifu.Framework.UI.BunifuFlatButton Letter14;
        private Bunifu.Framework.UI.BunifuFlatButton Letter13;
        private Bunifu.Framework.UI.BunifuFlatButton Letter12;
        private Bunifu.Framework.UI.BunifuFlatButton Letter11;
        private Bunifu.Framework.UI.BunifuFlatButton Letter10;
        private Bunifu.Framework.UI.BunifuFlatButton Letter9;
        private Bunifu.Framework.UI.BunifuFlatButton Letter7;
        private Bunifu.Framework.UI.BunifuFlatButton Letter8;
        private Bunifu.Framework.UI.BunifuFlatButton Letter6;
        private Bunifu.Framework.UI.BunifuFlatButton Letter5;
        private Bunifu.Framework.UI.BunifuFlatButton Letter4;
        private Bunifu.Framework.UI.BunifuFlatButton Letter3;
        private Bunifu.Framework.UI.BunifuFlatButton Letter2;
        private Bunifu.Framework.UI.BunifuFlatButton letter1;
        private Bunifu.Framework.UI.BunifuFlatButton HpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox HangmanPictureBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Timer TotalTimeTimer;
        private System.Windows.Forms.Label StatusTextBox;
        private System.Windows.Forms.Label SecretWordTextBox;
        private System.Windows.Forms.Label TimerTextBox;
        private System.Windows.Forms.Label DifficultyTextBox;
        private System.Windows.Forms.Label AppNameLabel;
    }
}