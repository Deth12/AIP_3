namespace MontyHallProblem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnnouncer = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblWinsByKeep = new System.Windows.Forms.Label();
            this.lblLosesByKeep = new System.Windows.Forms.Label();
            this.lblLosesByChange = new System.Windows.Forms.Label();
            this.lblWinsByChange = new System.Windows.Forms.Label();
            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle7 = new System.Windows.Forms.Label();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.rbKeep = new System.Windows.Forms.RadioButton();
            this.gbAutoSim = new System.Windows.Forms.GroupBox();
            this.nAmount = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.pbArrow3 = new System.Windows.Forms.PictureBox();
            this.pbArrow2 = new System.Windows.Forms.PictureBox();
            this.pbArrow1 = new System.Windows.Forms.PictureBox();
            this.pbDoor3 = new System.Windows.Forms.PictureBox();
            this.pbDoor2 = new System.Windows.Forms.PictureBox();
            this.pbDoor1 = new System.Windows.Forms.PictureBox();
            this.gbAutoSim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).BeginInit();
            this.gbStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnnouncer
            // 
            this.lblAnnouncer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnouncer.Location = new System.Drawing.Point(12, 9);
            this.lblAnnouncer.Name = "lblAnnouncer";
            this.lblAnnouncer.Size = new System.Drawing.Size(469, 67);
            this.lblAnnouncer.TabIndex = 3;
            this.lblAnnouncer.Text = "Pick one of three doors or start auto-simulation";
            this.lblAnnouncer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle3.Location = new System.Drawing.Point(142, 23);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(55, 16);
            this.lblTitle3.TabIndex = 5;
            this.lblTitle3.Text = "Change";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle2.Location = new System.Drawing.Point(39, 23);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(40, 16);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "Keep";
            // 
            // lblTitle5
            // 
            this.lblTitle5.AutoSize = true;
            this.lblTitle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle5.Location = new System.Drawing.Point(6, 61);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(34, 15);
            this.lblTitle5.TabIndex = 8;
            this.lblTitle5.Text = "Lose";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle4.Location = new System.Drawing.Point(12, 46);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(28, 15);
            this.lblTitle4.TabIndex = 9;
            this.lblTitle4.Text = "Win";
            // 
            // lblWinsByKeep
            // 
            this.lblWinsByKeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinsByKeep.Location = new System.Drawing.Point(42, 45);
            this.lblWinsByKeep.Name = "lblWinsByKeep";
            this.lblWinsByKeep.Size = new System.Drawing.Size(73, 16);
            this.lblWinsByKeep.TabIndex = 10;
            this.lblWinsByKeep.Text = "0";
            this.lblWinsByKeep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLosesByKeep
            // 
            this.lblLosesByKeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLosesByKeep.Location = new System.Drawing.Point(42, 62);
            this.lblLosesByKeep.Name = "lblLosesByKeep";
            this.lblLosesByKeep.Size = new System.Drawing.Size(73, 16);
            this.lblLosesByKeep.TabIndex = 11;
            this.lblLosesByKeep.Text = "0";
            this.lblLosesByKeep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLosesByChange
            // 
            this.lblLosesByChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLosesByChange.Location = new System.Drawing.Point(158, 61);
            this.lblLosesByChange.Name = "lblLosesByChange";
            this.lblLosesByChange.Size = new System.Drawing.Size(69, 16);
            this.lblLosesByChange.TabIndex = 15;
            this.lblLosesByChange.Text = "0";
            this.lblLosesByChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWinsByChange
            // 
            this.lblWinsByChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinsByChange.Location = new System.Drawing.Point(158, 45);
            this.lblWinsByChange.Name = "lblWinsByChange";
            this.lblWinsByChange.Size = new System.Drawing.Size(69, 16);
            this.lblWinsByChange.TabIndex = 14;
            this.lblWinsByChange.Text = "0";
            this.lblWinsByChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle6
            // 
            this.lblTitle6.AutoSize = true;
            this.lblTitle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle6.Location = new System.Drawing.Point(126, 46);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(28, 15);
            this.lblTitle6.TabIndex = 13;
            this.lblTitle6.Text = "Win";
            // 
            // lblTitle7
            // 
            this.lblTitle7.AutoSize = true;
            this.lblTitle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle7.Location = new System.Drawing.Point(120, 62);
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Size = new System.Drawing.Size(34, 15);
            this.lblTitle7.TabIndex = 12;
            this.lblTitle7.Text = "Lose";
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Location = new System.Drawing.Point(6, 47);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(73, 20);
            this.rbChange.TabIndex = 16;
            this.rbChange.TabStop = true;
            this.rbChange.Text = "Change";
            this.rbChange.UseVisualStyleBackColor = true;
            // 
            // rbKeep
            // 
            this.rbKeep.AutoSize = true;
            this.rbKeep.Location = new System.Drawing.Point(6, 21);
            this.rbKeep.Name = "rbKeep";
            this.rbKeep.Size = new System.Drawing.Size(58, 20);
            this.rbKeep.TabIndex = 17;
            this.rbKeep.TabStop = true;
            this.rbKeep.Text = "Keep";
            this.rbKeep.UseVisualStyleBackColor = true;
            // 
            // gbAutoSim
            // 
            this.gbAutoSim.Controls.Add(this.nAmount);
            this.gbAutoSim.Controls.Add(this.btnRun);
            this.gbAutoSim.Controls.Add(this.rbKeep);
            this.gbAutoSim.Controls.Add(this.label1);
            this.gbAutoSim.Controls.Add(this.rbChange);
            this.gbAutoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAutoSim.Location = new System.Drawing.Point(12, 295);
            this.gbAutoSim.Name = "gbAutoSim";
            this.gbAutoSim.Size = new System.Drawing.Size(228, 100);
            this.gbAutoSim.TabIndex = 18;
            this.gbAutoSim.TabStop = false;
            this.gbAutoSim.Text = "Auto Simulation";
            // 
            // nAmount
            // 
            this.nAmount.Location = new System.Drawing.Point(139, 46);
            this.nAmount.Name = "nAmount";
            this.nAmount.Size = new System.Drawing.Size(84, 22);
            this.nAmount.TabIndex = 21;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(73, 72);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 20;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount";
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lblTitle3);
            this.gbStatistics.Controls.Add(this.lblTitle2);
            this.gbStatistics.Controls.Add(this.lblTitle4);
            this.gbStatistics.Controls.Add(this.lblLosesByChange);
            this.gbStatistics.Controls.Add(this.lblTitle5);
            this.gbStatistics.Controls.Add(this.lblWinsByChange);
            this.gbStatistics.Controls.Add(this.lblWinsByKeep);
            this.gbStatistics.Controls.Add(this.lblTitle7);
            this.gbStatistics.Controls.Add(this.lblTitle6);
            this.gbStatistics.Controls.Add(this.lblLosesByKeep);
            this.gbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStatistics.Location = new System.Drawing.Point(246, 295);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(235, 100);
            this.gbStatistics.TabIndex = 21;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Statistics";
            // 
            // pbArrow3
            // 
            this.pbArrow3.Image = global::MontyHallProblem.Properties.Resources.Arrow;
            this.pbArrow3.Location = new System.Drawing.Point(378, 66);
            this.pbArrow3.Name = "pbArrow3";
            this.pbArrow3.Size = new System.Drawing.Size(103, 50);
            this.pbArrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow3.TabIndex = 24;
            this.pbArrow3.TabStop = false;
            // 
            // pbArrow2
            // 
            this.pbArrow2.Image = global::MontyHallProblem.Properties.Resources.Arrow;
            this.pbArrow2.Location = new System.Drawing.Point(195, 66);
            this.pbArrow2.Name = "pbArrow2";
            this.pbArrow2.Size = new System.Drawing.Size(103, 50);
            this.pbArrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow2.TabIndex = 23;
            this.pbArrow2.TabStop = false;
            // 
            // pbArrow1
            // 
            this.pbArrow1.Image = global::MontyHallProblem.Properties.Resources.Arrow;
            this.pbArrow1.Location = new System.Drawing.Point(12, 66);
            this.pbArrow1.Name = "pbArrow1";
            this.pbArrow1.Size = new System.Drawing.Size(103, 50);
            this.pbArrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow1.TabIndex = 22;
            this.pbArrow1.TabStop = false;
            // 
            // pbDoor3
            // 
            this.pbDoor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDoor3.Image = global::MontyHallProblem.Properties.Resources.Door;
            this.pbDoor3.Location = new System.Drawing.Point(378, 115);
            this.pbDoor3.Name = "pbDoor3";
            this.pbDoor3.Size = new System.Drawing.Size(103, 175);
            this.pbDoor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoor3.TabIndex = 2;
            this.pbDoor3.TabStop = false;
            this.pbDoor3.Click += new System.EventHandler(this.pbDoor3_Click);
            // 
            // pbDoor2
            // 
            this.pbDoor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDoor2.Image = global::MontyHallProblem.Properties.Resources.Door;
            this.pbDoor2.Location = new System.Drawing.Point(195, 115);
            this.pbDoor2.Name = "pbDoor2";
            this.pbDoor2.Size = new System.Drawing.Size(103, 175);
            this.pbDoor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoor2.TabIndex = 1;
            this.pbDoor2.TabStop = false;
            this.pbDoor2.Click += new System.EventHandler(this.pbDoor2_Click);
            // 
            // pbDoor1
            // 
            this.pbDoor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDoor1.Image = global::MontyHallProblem.Properties.Resources.Door;
            this.pbDoor1.Location = new System.Drawing.Point(12, 115);
            this.pbDoor1.Name = "pbDoor1";
            this.pbDoor1.Size = new System.Drawing.Size(103, 175);
            this.pbDoor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoor1.TabIndex = 0;
            this.pbDoor1.TabStop = false;
            this.pbDoor1.Click += new System.EventHandler(this.pbDoor1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 408);
            this.Controls.Add(this.lblAnnouncer);
            this.Controls.Add(this.pbArrow3);
            this.Controls.Add(this.pbArrow2);
            this.Controls.Add(this.pbArrow1);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.gbAutoSim);
            this.Controls.Add(this.pbDoor3);
            this.Controls.Add(this.pbDoor2);
            this.Controls.Add(this.pbDoor1);
            this.Name = "MainForm";
            this.Text = "Monty Hall Problem";
            this.gbAutoSim.ResumeLayout(false);
            this.gbAutoSim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).EndInit();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDoor1;
        private System.Windows.Forms.PictureBox pbDoor2;
        private System.Windows.Forms.PictureBox pbDoor3;
        private System.Windows.Forms.Label lblAnnouncer;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblWinsByKeep;
        private System.Windows.Forms.Label lblLosesByKeep;
        private System.Windows.Forms.Label lblLosesByChange;
        private System.Windows.Forms.Label lblWinsByChange;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.Label lblTitle7;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Windows.Forms.RadioButton rbKeep;
        private System.Windows.Forms.GroupBox gbAutoSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.NumericUpDown nAmount;
        private System.Windows.Forms.PictureBox pbArrow1;
        private System.Windows.Forms.PictureBox pbArrow2;
        private System.Windows.Forms.PictureBox pbArrow3;
    }
}

