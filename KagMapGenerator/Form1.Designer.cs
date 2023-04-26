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
            this.island = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stoneChance = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bedrockDepth = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bedrockRoughness = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.treeInterval = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.treeCount = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tentEdgeDst = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.midshopCount = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mapImage
            // 
            this.mapImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mapImage.Location = new System.Drawing.Point(230, 12);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(728, 518);
            this.mapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapImage.TabIndex = 0;
            this.mapImage.TabStop = false;
            this.mapImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.mapImage.Paint += new System.Windows.Forms.PaintEventHandler(this.mapImage_Paint);
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
            this.genButton.Location = new System.Drawing.Point(6, 632);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 7;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // seedText
            // 
            this.seedText.Location = new System.Drawing.Point(45, 584);
            this.seedText.Mask = "00000";
            this.seedText.Name = "seedText";
            this.seedText.Size = new System.Drawing.Size(36, 20);
            this.seedText.TabIndex = 8;
            this.seedText.Text = "0";
            this.seedText.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // randomSeed
            // 
            this.randomSeed.AutoSize = true;
            this.randomSeed.Location = new System.Drawing.Point(12, 607);
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
            this.frequencyInput.TextChanged += new System.EventHandler(this.frequencyInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hill steepness";
            // 
            // steepnessInput
            // 
            this.steepnessInput.Location = new System.Drawing.Point(123, 112);
            this.steepnessInput.Mask = "00000";
            this.steepnessInput.Name = "steepnessInput";
            this.steepnessInput.Size = new System.Drawing.Size(69, 20);
            this.steepnessInput.TabIndex = 13;
            this.steepnessInput.Text = "1";
            this.steepnessInput.ValidatingType = typeof(int);
            this.steepnessInput.TextChanged += new System.EventHandler(this.steepnessInput_TextChanged);
            // 
            // cave
            // 
            this.cave.AutoSize = true;
            this.cave.Location = new System.Drawing.Point(91, 607);
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
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grass chance";
            // 
            // grassChance
            // 
            this.grassChance.Location = new System.Drawing.Point(15, 184);
            this.grassChance.Mask = "00000";
            this.grassChance.Name = "grassChance";
            this.grassChance.Size = new System.Drawing.Size(69, 20);
            this.grassChance.TabIndex = 16;
            this.grassChance.Text = "50";
            this.grassChance.ValidatingType = typeof(int);
            this.grassChance.TextChanged += new System.EventHandler(this.grassChance_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Redzone position";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // redzone
            // 
            this.redzone.Location = new System.Drawing.Point(12, 516);
            this.redzone.Mask = "00000";
            this.redzone.Name = "redzone";
            this.redzone.Size = new System.Drawing.Size(69, 20);
            this.redzone.TabIndex = 18;
            this.redzone.Text = "60";
            this.redzone.ValidatingType = typeof(int);
            this.redzone.TextChanged += new System.EventHandler(this.redzone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Flag count";
            // 
            // flagCount
            // 
            this.flagCount.Location = new System.Drawing.Point(12, 449);
            this.flagCount.Mask = "00000";
            this.flagCount.Name = "flagCount";
            this.flagCount.Size = new System.Drawing.Size(69, 20);
            this.flagCount.TabIndex = 20;
            this.flagCount.Text = "2";
            this.flagCount.ValidatingType = typeof(int);
            this.flagCount.TextChanged += new System.EventHandler(this.flagCount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Flag interval";
            // 
            // flagInterval
            // 
            this.flagInterval.Location = new System.Drawing.Point(123, 449);
            this.flagInterval.Mask = "00000";
            this.flagInterval.Name = "flagInterval";
            this.flagInterval.Size = new System.Drawing.Size(69, 20);
            this.flagInterval.TabIndex = 22;
            this.flagInterval.Text = "10";
            this.flagInterval.ValidatingType = typeof(int);
            this.flagInterval.TextChanged += new System.EventHandler(this.flagInterval_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(879, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // island
            // 
            this.island.AutoSize = true;
            this.island.Location = new System.Drawing.Point(91, 584);
            this.island.Name = "island";
            this.island.Size = new System.Drawing.Size(54, 17);
            this.island.TabIndex = 25;
            this.island.Text = "Island";
            this.island.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Stone chance";
            // 
            // stoneChance
            // 
            this.stoneChance.Location = new System.Drawing.Point(126, 184);
            this.stoneChance.Mask = "00000";
            this.stoneChance.Name = "stoneChance";
            this.stoneChance.Size = new System.Drawing.Size(69, 20);
            this.stoneChance.TabIndex = 26;
            this.stoneChance.Text = "50";
            this.stoneChance.ValidatingType = typeof(int);
            this.stoneChance.TextChanged += new System.EventHandler(this.stoneChance_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Map shape";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tile placement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(82, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Flags";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Bedrock depth";
            // 
            // bedrockDepth
            // 
            this.bedrockDepth.Location = new System.Drawing.Point(12, 227);
            this.bedrockDepth.Mask = "00000";
            this.bedrockDepth.Name = "bedrockDepth";
            this.bedrockDepth.Size = new System.Drawing.Size(69, 20);
            this.bedrockDepth.TabIndex = 31;
            this.bedrockDepth.Text = "4";
            this.bedrockDepth.ValidatingType = typeof(int);
            this.bedrockDepth.TextChanged += new System.EventHandler(this.bedrockDepth_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(111, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Bedrock roughness";
            // 
            // bedrockRoughness
            // 
            this.bedrockRoughness.Location = new System.Drawing.Point(126, 227);
            this.bedrockRoughness.Mask = "00000";
            this.bedrockRoughness.Name = "bedrockRoughness";
            this.bedrockRoughness.Size = new System.Drawing.Size(69, 20);
            this.bedrockRoughness.TabIndex = 33;
            this.bedrockRoughness.Text = "50";
            this.bedrockRoughness.ValidatingType = typeof(int);
            this.bedrockRoughness.TextChanged += new System.EventHandler(this.bedrockRoughness_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(86, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Misc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(123, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "Tree interval";
            // 
            // treeInterval
            // 
            this.treeInterval.Location = new System.Drawing.Point(126, 279);
            this.treeInterval.Mask = "00000";
            this.treeInterval.Name = "treeInterval";
            this.treeInterval.Size = new System.Drawing.Size(69, 20);
            this.treeInterval.TabIndex = 38;
            this.treeInterval.Text = "10";
            this.treeInterval.ValidatingType = typeof(int);
            this.treeInterval.TextChanged += new System.EventHandler(this.treeInterval_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Max trees";
            // 
            // treeCount
            // 
            this.treeCount.Location = new System.Drawing.Point(12, 279);
            this.treeCount.Mask = "00000";
            this.treeCount.Name = "treeCount";
            this.treeCount.Size = new System.Drawing.Size(69, 20);
            this.treeCount.TabIndex = 36;
            this.treeCount.Text = "4";
            this.treeCount.ValidatingType = typeof(int);
            this.treeCount.TextChanged += new System.EventHandler(this.treeCount_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 539);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 15);
            this.label19.TabIndex = 41;
            this.label19.Text = "Min tent dst from edge";
            // 
            // tentEdgeDst
            // 
            this.tentEdgeDst.Location = new System.Drawing.Point(12, 557);
            this.tentEdgeDst.Mask = "00000";
            this.tentEdgeDst.Name = "tentEdgeDst";
            this.tentEdgeDst.Size = new System.Drawing.Size(69, 20);
            this.tentEdgeDst.TabIndex = 40;
            this.tentEdgeDst.Text = "10";
            this.tentEdgeDst.ValidatingType = typeof(int);
            this.tentEdgeDst.TextChanged += new System.EventHandler(this.tentEdgeDst_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "Midshop count";
            // 
            // midshopCount
            // 
            this.midshopCount.Location = new System.Drawing.Point(12, 326);
            this.midshopCount.Mask = "00000";
            this.midshopCount.Name = "midshopCount";
            this.midshopCount.Size = new System.Drawing.Size(69, 20);
            this.midshopCount.TabIndex = 42;
            this.midshopCount.Text = "1";
            this.midshopCount.ValidatingType = typeof(int);
            this.midshopCount.TextChanged += new System.EventHandler(this.midshopCount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 662);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.midshopCount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tentEdgeDst);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.treeInterval);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.treeCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bedrockRoughness);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bedrockDepth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stoneChance);
            this.Controls.Add(this.island);
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
        public System.Windows.Forms.CheckBox island;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox stoneChance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox bedrockDepth;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox bedrockRoughness;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.MaskedTextBox treeInterval;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.MaskedTextBox treeCount;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.MaskedTextBox tentEdgeDst;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.MaskedTextBox midshopCount;
    }
}

