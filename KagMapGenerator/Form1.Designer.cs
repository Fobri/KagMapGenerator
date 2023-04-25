namespace KagMapGenerator
{
    partial class Form1
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
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ySize = new System.Windows.Forms.MaskedTextBox();
            this.xSize = new System.Windows.Forms.MaskedTextBox();
            this.genButton = new System.Windows.Forms.Button();
            this.seedText = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.randomSeed = new System.Windows.Forms.CheckBox();
            this.frequencyInput = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.steepnessInput = new System.Windows.Forms.MaskedTextBox();
            this.cave = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grassChance = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.redzone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flagCount = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flagInterval = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mapImage
            // 
            this.mapImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mapImage.Location = new System.Drawing.Point(230, 12);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(558, 302);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            this.mapImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ySize
            // 
            this.ySize.Location = new System.Drawing.Point(113, 49);
            this.ySize.Mask = "00000";
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(69, 20);
            this.ySize.TabIndex = 5;
            this.ySize.Text = "75";
            // 
            // xSize
            // 
            this.xSize.Location = new System.Drawing.Point(12, 48);
            this.xSize.Mask = "00000";
            this.xSize.Name = "xSize";
            this.xSize.Size = new System.Drawing.Size(69, 20);
            this.xSize.TabIndex = 6;
            this.xSize.Text = "200";
            this.xSize.ValidatingType = typeof(int);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(6, 415);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 7;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // seedText
            // 
            this.seedText.Location = new System.Drawing.Point(12, 345);
            this.seedText.Mask = "00000";
            this.seedText.Name = "seedText";
            this.seedText.Size = new System.Drawing.Size(69, 20);
            this.seedText.TabIndex = 8;
            this.seedText.Text = "0";
            this.seedText.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // randomSeed
            // 
            this.randomSeed.AutoSize = true;
            this.randomSeed.Location = new System.Drawing.Point(12, 371);
            this.randomSeed.Name = "randomSeed";
            this.randomSeed.Size = new System.Drawing.Size(79, 17);
            this.randomSeed.TabIndex = 10;
            this.randomSeed.Text = "Randomize";
            this.randomSeed.UseVisualStyleBackColor = true;
            // 
            // frequencyInput
            // 
            this.frequencyInput.Location = new System.Drawing.Point(12, 112);
            this.frequencyInput.Mask = "00000";
            this.frequencyInput.Name = "frequencyInput";
            this.frequencyInput.Size = new System.Drawing.Size(69, 20);
            this.frequencyInput.TabIndex = 11;
            this.frequencyInput.Text = "15";
            this.frequencyInput.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hill steepness";
            // 
            // steepnessInput
            // 
            this.steepnessInput.Location = new System.Drawing.Point(12, 153);
            this.steepnessInput.Mask = "00000";
            this.steepnessInput.Name = "steepnessInput";
            this.steepnessInput.Size = new System.Drawing.Size(69, 20);
            this.steepnessInput.TabIndex = 13;
            this.steepnessInput.Text = "1";
            this.steepnessInput.ValidatingType = typeof(int);
            // 
            // cave
            // 
            this.cave.AutoSize = true;
            this.cave.Location = new System.Drawing.Point(15, 297);
            this.cave.Name = "cave";
            this.cave.Size = new System.Drawing.Size(51, 17);
            this.cave.TabIndex = 15;
            this.cave.Text = "Cave";
            this.cave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grass chance";
            // 
            // grassChance
            // 
            this.grassChance.Location = new System.Drawing.Point(12, 194);
            this.grassChance.Mask = "00000";
            this.grassChance.Name = "grassChance";
            this.grassChance.Size = new System.Drawing.Size(69, 20);
            this.grassChance.TabIndex = 16;
            this.grassChance.Text = "15";
            this.grassChance.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Redzone position";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // redzone
            // 
            this.redzone.Location = new System.Drawing.Point(113, 112);
            this.redzone.Mask = "00000";
            this.redzone.Name = "redzone";
            this.redzone.Size = new System.Drawing.Size(69, 20);
            this.redzone.TabIndex = 18;
            this.redzone.Text = "60";
            this.redzone.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Flag count";
            // 
            // flagCount
            // 
            this.flagCount.Location = new System.Drawing.Point(113, 153);
            this.flagCount.Mask = "00000";
            this.flagCount.Name = "flagCount";
            this.flagCount.Size = new System.Drawing.Size(69, 20);
            this.flagCount.TabIndex = 20;
            this.flagCount.Text = "2";
            this.flagCount.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Flag interval";
            // 
            // flagInterval
            // 
            this.flagInterval.Location = new System.Drawing.Point(113, 194);
            this.flagInterval.Mask = "00000";
            this.flagInterval.Name = "flagInterval";
            this.flagInterval.Size = new System.Drawing.Size(69, 20);
            this.flagInterval.TabIndex = 22;
            this.flagInterval.Text = "5";
            this.flagInterval.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flagInterval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flagCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.redzone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grassChance);
            this.Controls.Add(this.cave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.steepnessInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frequencyInput);
            this.Controls.Add(this.randomSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seedText);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.xSize);
            this.Controls.Add(this.ySize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapImage);
            this.Name = "Form1";
            this.Text = "King Arthurs Gold map generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox mapImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox ySize;
        public System.Windows.Forms.MaskedTextBox xSize;
        public System.Windows.Forms.Button genButton;
        public System.Windows.Forms.MaskedTextBox seedText;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox frequencyInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox steepnessInput;
        public System.Windows.Forms.CheckBox randomSeed;
        public System.Windows.Forms.CheckBox cave;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox grassChance;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox redzone;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox flagCount;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox flagInterval;
        private System.Windows.Forms.Button button1;
    }
}

