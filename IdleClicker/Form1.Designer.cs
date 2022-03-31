namespace IdleClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.A2UpgradeAmmount = new System.Windows.Forms.Button();
            this.A2UpgradeInterval = new System.Windows.Forms.Button();
            this.A2AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A2IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A2Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.A3AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A3IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A3UpgradeAmmount = new System.Windows.Forms.Button();
            this.A3UpgradeInterval = new System.Windows.Forms.Button();
            this.A2Timer = new System.Windows.Forms.Timer(this.components);
            this.A3Timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::IdleClicker.Properties.Resources.moni;
            this.button1.Location = new System.Drawing.Point(589, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click for Moni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moni: $0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(558, 410);
            this.upgradeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(116, 59);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Upgrade\r\n($10)";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.Location = new System.Drawing.Point(701, 442);
            this.buttonLevelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.ReadOnly = true;
            this.buttonLevelTextBox.Size = new System.Drawing.Size(85, 27);
            this.buttonLevelTextBox.TabIndex = 3;
            this.buttonLevelTextBox.Text = "1";
            this.buttonLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1AmmountTextBox.Location = new System.Drawing.Point(70, 55);
            this.A1AmmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(122, 26);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            this.A1AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A1AmmountTextBox.TextChanged += new System.EventHandler(this.A1AmmountTextBox_TextChanged);
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(70, 76);
            this.A1UpgradeAmmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(122, 69);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "Ulepsz ilość";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1UpgradeInterval.Location = new System.Drawing.Point(223, 76);
            this.A1UpgradeInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(142, 69);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.BackColor = System.Drawing.Color.DodgerBlue;
            this.A1Label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1Label.Location = new System.Drawing.Point(70, 31);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(115, 18);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "AutoUpgrade1";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1IntervalTextBox.Location = new System.Drawing.Point(223, 55);
            this.A1IntervalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.ReadOnly = true;
            this.A1IntervalTextBox.Size = new System.Drawing.Size(141, 26);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A1IntervalTextBox.TextChanged += new System.EventHandler(this.A1IntervalTextBox_TextChanged);
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(223, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "/min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Upgrade lvl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::IdleClicker.Properties.Resources.chonk;
            this.pictureBox1.Location = new System.Drawing.Point(536, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 165);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // A2UpgradeAmmount
            // 
            this.A2UpgradeAmmount.Location = new System.Drawing.Point(70, 204);
            this.A2UpgradeAmmount.Name = "A2UpgradeAmmount";
            this.A2UpgradeAmmount.Size = new System.Drawing.Size(122, 64);
            this.A2UpgradeAmmount.TabIndex = 12;
            this.A2UpgradeAmmount.Text = "Ulepsz ilość";
            this.A2UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmmount.Click += new System.EventHandler(this.A2UpgradeAmmount_Click);
            // 
            // A2UpgradeInterval
            // 
            this.A2UpgradeInterval.Location = new System.Drawing.Point(223, 204);
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.Size = new System.Drawing.Size(142, 64);
            this.A2UpgradeInterval.TabIndex = 13;
            this.A2UpgradeInterval.Text = "Ulepsz częstosliwość";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // A2AmmountTextBox
            // 
            this.A2AmmountTextBox.Location = new System.Drawing.Point(70, 182);
            this.A2AmmountTextBox.Name = "A2AmmountTextBox";
            this.A2AmmountTextBox.Size = new System.Drawing.Size(122, 27);
            this.A2AmmountTextBox.TabIndex = 14;
            this.A2AmmountTextBox.Text = "0";
            this.A2AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A2AmmountTextBox.TextChanged += new System.EventHandler(this.A2AmmountTextBox_TextChanged);
            // 
            // A2IntervalTextBox
            // 
            this.A2IntervalTextBox.Location = new System.Drawing.Point(223, 182);
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            this.A2IntervalTextBox.Size = new System.Drawing.Size(142, 27);
            this.A2IntervalTextBox.TabIndex = 15;
            this.A2IntervalTextBox.Text = "0";
            this.A2IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A2Label
            // 
            this.A2Label.AutoSize = true;
            this.A2Label.BackColor = System.Drawing.Color.DodgerBlue;
            this.A2Label.Location = new System.Drawing.Point(70, 159);
            this.A2Label.Name = "A2Label";
            this.A2Label.Size = new System.Drawing.Size(107, 20);
            this.A2Label.TabIndex = 16;
            this.A2Label.Text = "AutoUpgrade2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(223, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "/min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(70, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "AutoUpgrade3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(223, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "/min";
            // 
            // A3AmmountTextBox
            // 
            this.A3AmmountTextBox.Location = new System.Drawing.Point(70, 311);
            this.A3AmmountTextBox.Name = "A3AmmountTextBox";
            this.A3AmmountTextBox.Size = new System.Drawing.Size(122, 27);
            this.A3AmmountTextBox.TabIndex = 20;
            this.A3AmmountTextBox.Text = "0";
            this.A3AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A3IntervalTextBox
            // 
            this.A3IntervalTextBox.Location = new System.Drawing.Point(222, 311);
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
            this.A3IntervalTextBox.Size = new System.Drawing.Size(142, 27);
            this.A3IntervalTextBox.TabIndex = 21;
            this.A3IntervalTextBox.Text = "0";
            this.A3IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A3UpgradeAmmount
            // 
            this.A3UpgradeAmmount.Location = new System.Drawing.Point(70, 330);
            this.A3UpgradeAmmount.Name = "A3UpgradeAmmount";
            this.A3UpgradeAmmount.Size = new System.Drawing.Size(122, 64);
            this.A3UpgradeAmmount.TabIndex = 22;
            this.A3UpgradeAmmount.Text = "Ulepsz ilość";
            this.A3UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A3UpgradeAmmount.Click += new System.EventHandler(this.A3UpgradeAmmount_Click);
            // 
            // A3UpgradeInterval
            // 
            this.A3UpgradeInterval.Location = new System.Drawing.Point(223, 330);
            this.A3UpgradeInterval.Name = "A3UpgradeInterval";
            this.A3UpgradeInterval.Size = new System.Drawing.Size(142, 64);
            this.A3UpgradeInterval.TabIndex = 23;
            this.A3UpgradeInterval.Text = "Ulepsz częstosliwość";
            this.A3UpgradeInterval.UseVisualStyleBackColor = true;
            this.A3UpgradeInterval.Click += new System.EventHandler(this.A3UpgradeInterval_Click);
            // 
            // A2Timer
            // 
            this.A2Timer.Tick += new System.EventHandler(this.A2Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 545);
            this.Controls.Add(this.A3IntervalTextBox);
            this.Controls.Add(this.A3AmmountTextBox);
            this.Controls.Add(this.A3UpgradeInterval);
            this.Controls.Add(this.A3UpgradeAmmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.A2Label);
            this.Controls.Add(this.A2IntervalTextBox);
            this.Controls.Add(this.A2AmmountTextBox);
            this.Controls.Add(this.A2UpgradeInterval);
            this.Controls.Add(this.A2UpgradeAmmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Clicker JM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradeButton;
        private TextBox buttonLevelTextBox;
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button A2UpgradeAmmount;
        private Button A2UpgradeInterval;
        private TextBox A2AmmountTextBox;
        private TextBox A2IntervalTextBox;
        private Label A2Label;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox A3AmmountTextBox;
        private TextBox A3IntervalTextBox;
        private Button A3UpgradeAmmount;
        private Button A3UpgradeInterval;
        private System.Windows.Forms.Timer A2Timer;
        private System.Windows.Forms.Timer A3Timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}