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
            this.label21 = new System.Windows.Forms.Label();
            this.generateBase = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.baseSeed = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.baseSizeX = new System.Windows.Forms.MaskedTextBox();
            this.baseSizeY = new System.Windows.Forms.MaskedTextBox();
            this.randomizeBaseSeed = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.surfaceLevel = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.flatness = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadPreset = new System.Windows.Forms.Button();
            this.savePreset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.blockRemove = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.blockWeight = new System.Windows.Forms.MaskedTextBox();
            this.blockPicture = new System.Windows.Forms.PictureBox();
            this.blockRight = new System.Windows.Forms.CheckBox();
            this.blockLeft = new System.Windows.Forms.CheckBox();
            this.blockDown = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.blockUp = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.blockName = new System.Windows.Forms.TextBox();
            this.blockOpenImage = new System.Windows.Forms.Button();
            this.blockSave = new System.Windows.Forms.Button();
            this.blockList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestrictDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mapImage
            // 
            this.mapImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mapImage.Location = new System.Drawing.Point(227, 3);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(665, 486);
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
            this.label1.Location = new System.Drawing.Point(48, 3);
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
            this.label2.Location = new System.Drawing.Point(84, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ySize
            // 
            this.ySize.Location = new System.Drawing.Point(110, 40);
            this.ySize.Mask = "00000";
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(69, 20);
            this.ySize.TabIndex = 5;
            this.ySize.Text = "75";
            // 
            // xSize
            // 
            this.xSize.Location = new System.Drawing.Point(9, 39);
            this.xSize.Mask = "00000";
            this.xSize.Name = "xSize";
            this.xSize.Size = new System.Drawing.Size(69, 20);
            this.xSize.TabIndex = 6;
            this.xSize.Text = "200";
            this.xSize.ValidatingType = typeof(int);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(3, 623);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 7;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // seedText
            // 
            this.seedText.Location = new System.Drawing.Point(42, 575);
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
            this.label3.Location = new System.Drawing.Point(6, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // randomSeed
            // 
            this.randomSeed.AutoSize = true;
            this.randomSeed.Location = new System.Drawing.Point(9, 598);
            this.randomSeed.Name = "randomSeed";
            this.randomSeed.Size = new System.Drawing.Size(79, 17);
            this.randomSeed.TabIndex = 10;
            this.randomSeed.Text = "Randomize";
            this.randomSeed.UseVisualStyleBackColor = true;
            // 
            // frequencyInput
            // 
            this.frequencyInput.Location = new System.Drawing.Point(9, 103);
            this.frequencyInput.Mask = "00000";
            this.frequencyInput.Name = "frequencyInput";
            this.frequencyInput.Size = new System.Drawing.Size(69, 20);
            this.frequencyInput.TabIndex = 11;
            this.frequencyInput.Text = "15";
            this.frequencyInput.ValidatingType = typeof(int);
            this.frequencyInput.TextChanged += new System.EventHandler(this.frequencyInput_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hill steepness";
            // 
            // steepnessInput
            // 
            this.steepnessInput.Location = new System.Drawing.Point(120, 103);
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
            this.cave.Location = new System.Drawing.Point(88, 598);
            this.cave.Name = "cave";
            this.cave.Size = new System.Drawing.Size(51, 17);
            this.cave.TabIndex = 15;
            this.cave.Text = "Cave";
            this.cave.UseVisualStyleBackColor = true;
            this.cave.CheckedChanged += new System.EventHandler(this.cave_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grass chance";
            // 
            // grassChance
            // 
            this.grassChance.Location = new System.Drawing.Point(12, 238);
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
            this.label7.Location = new System.Drawing.Point(9, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Redzone position";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // redzone
            // 
            this.redzone.Location = new System.Drawing.Point(9, 507);
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
            this.label8.Location = new System.Drawing.Point(9, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Flag count";
            // 
            // flagCount
            // 
            this.flagCount.Location = new System.Drawing.Point(9, 440);
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
            this.label9.Location = new System.Drawing.Point(117, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Flag interval";
            // 
            // flagInterval
            // 
            this.flagInterval.Location = new System.Drawing.Point(120, 440);
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
            this.button1.Location = new System.Drawing.Point(817, 623);
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
            this.island.Location = new System.Drawing.Point(88, 575);
            this.island.Name = "island";
            this.island.Size = new System.Drawing.Size(54, 17);
            this.island.TabIndex = 25;
            this.island.Text = "Island";
            this.island.UseVisualStyleBackColor = true;
            this.island.CheckedChanged += new System.EventHandler(this.island_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Stone chance";
            // 
            // stoneChance
            // 
            this.stoneChance.Location = new System.Drawing.Point(123, 238);
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
            this.label11.Location = new System.Drawing.Point(58, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Map shape";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tile placement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Flags";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Bedrock depth";
            // 
            // bedrockDepth
            // 
            this.bedrockDepth.Location = new System.Drawing.Point(9, 281);
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
            this.label15.Location = new System.Drawing.Point(108, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Bedrock roughness";
            // 
            // bedrockRoughness
            // 
            this.bedrockRoughness.Location = new System.Drawing.Point(123, 281);
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
            this.label16.Location = new System.Drawing.Point(83, 474);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Misc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(120, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "Tree interval";
            // 
            // treeInterval
            // 
            this.treeInterval.Location = new System.Drawing.Point(123, 333);
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
            this.label18.Location = new System.Drawing.Point(9, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Max trees";
            // 
            // treeCount
            // 
            this.treeCount.Location = new System.Drawing.Point(9, 333);
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
            this.label19.Location = new System.Drawing.Point(9, 530);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 15);
            this.label19.TabIndex = 41;
            this.label19.Text = "Min tent dst from edge";
            // 
            // tentEdgeDst
            // 
            this.tentEdgeDst.Location = new System.Drawing.Point(9, 548);
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
            this.label20.Location = new System.Drawing.Point(9, 362);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "Midshop count";
            // 
            // midshopCount
            // 
            this.midshopCount.Location = new System.Drawing.Point(9, 380);
            this.midshopCount.Mask = "00000";
            this.midshopCount.Name = "midshopCount";
            this.midshopCount.Size = new System.Drawing.Size(69, 20);
            this.midshopCount.TabIndex = 42;
            this.midshopCount.Text = "1";
            this.midshopCount.ValidatingType = typeof(int);
            this.midshopCount.TextChanged += new System.EventHandler(this.midshopCount_TextChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(231, 501);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 24);
            this.label21.TabIndex = 45;
            this.label21.Text = "Base generation";
            // 
            // generateBase
            // 
            this.generateBase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generateBase.AutoSize = true;
            this.generateBase.Location = new System.Drawing.Point(235, 528);
            this.generateBase.Name = "generateBase";
            this.generateBase.Size = new System.Drawing.Size(56, 17);
            this.generateBase.TabIndex = 46;
            this.generateBase.Text = "Active";
            this.generateBase.UseVisualStyleBackColor = true;
            this.generateBase.CheckedChanged += new System.EventHandler(this.generateBase_CheckedChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(232, 545);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 15);
            this.label22.TabIndex = 48;
            this.label22.Text = "Seed";
            // 
            // baseSeed
            // 
            this.baseSeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baseSeed.Location = new System.Drawing.Point(268, 545);
            this.baseSeed.Mask = "00000";
            this.baseSeed.Name = "baseSeed";
            this.baseSeed.Size = new System.Drawing.Size(36, 20);
            this.baseSeed.TabIndex = 47;
            this.baseSeed.Text = "0";
            this.baseSeed.ValidatingType = typeof(int);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(232, 563);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 15);
            this.label23.TabIndex = 50;
            this.label23.Text = "Base size";
            // 
            // baseSizeX
            // 
            this.baseSizeX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baseSizeX.Location = new System.Drawing.Point(232, 581);
            this.baseSizeX.Mask = "00000";
            this.baseSizeX.Name = "baseSizeX";
            this.baseSizeX.Size = new System.Drawing.Size(34, 20);
            this.baseSizeX.TabIndex = 49;
            this.baseSizeX.Text = "5";
            this.baseSizeX.ValidatingType = typeof(int);
            this.baseSizeX.TextChanged += new System.EventHandler(this.baseSizeX_TextChanged);
            // 
            // baseSizeY
            // 
            this.baseSizeY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baseSizeY.Location = new System.Drawing.Point(272, 580);
            this.baseSizeY.Mask = "00000";
            this.baseSizeY.Name = "baseSizeY";
            this.baseSizeY.Size = new System.Drawing.Size(34, 20);
            this.baseSizeY.TabIndex = 51;
            this.baseSizeY.Text = "10";
            this.baseSizeY.ValidatingType = typeof(int);
            this.baseSizeY.TextChanged += new System.EventHandler(this.baseSizeY_TextChanged);
            // 
            // randomizeBaseSeed
            // 
            this.randomizeBaseSeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.randomizeBaseSeed.AutoSize = true;
            this.randomizeBaseSeed.Location = new System.Drawing.Point(310, 546);
            this.randomizeBaseSeed.Name = "randomizeBaseSeed";
            this.randomizeBaseSeed.Size = new System.Drawing.Size(79, 17);
            this.randomizeBaseSeed.TabIndex = 52;
            this.randomizeBaseSeed.Text = "Randomize";
            this.randomizeBaseSeed.UseVisualStyleBackColor = true;
            this.randomizeBaseSeed.CheckedChanged += new System.EventHandler(this.randomizeBaseSeed_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 127);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 15);
            this.label24.TabIndex = 54;
            this.label24.Text = "Surface level";
            // 
            // surfaceLevel
            // 
            this.surfaceLevel.Location = new System.Drawing.Point(9, 145);
            this.surfaceLevel.Mask = "00000";
            this.surfaceLevel.Name = "surfaceLevel";
            this.surfaceLevel.Size = new System.Drawing.Size(69, 20);
            this.surfaceLevel.TabIndex = 53;
            this.surfaceLevel.Text = "15";
            this.surfaceLevel.ValidatingType = typeof(int);
            this.surfaceLevel.TextChanged += new System.EventHandler(this.surfaceLevel_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(120, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 15);
            this.label25.TabIndex = 56;
            this.label25.Text = "Map flatness";
            // 
            // flatness
            // 
            this.flatness.Location = new System.Drawing.Point(120, 145);
            this.flatness.Mask = "00000";
            this.flatness.Name = "flatness";
            this.flatness.Size = new System.Drawing.Size(69, 20);
            this.flatness.TabIndex = 55;
            this.flatness.Text = "10";
            this.flatness.ValidatingType = typeof(int);
            this.flatness.TextChanged += new System.EventHandler(this.flatness_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 672);
            this.tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapImage);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.flatness);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.generateBase);
            this.tabPage1.Controls.Add(this.surfaceLevel);
            this.tabPage1.Controls.Add(this.baseSeed);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.randomizeBaseSeed);
            this.tabPage1.Controls.Add(this.midshopCount);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.baseSizeY);
            this.tabPage1.Controls.Add(this.tentEdgeDst);
            this.tabPage1.Controls.Add(this.baseSizeX);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.treeInterval);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.treeCount);
            this.tabPage1.Controls.Add(this.ySize);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.xSize);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.genButton);
            this.tabPage1.Controls.Add(this.bedrockRoughness);
            this.tabPage1.Controls.Add(this.seedText);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bedrockDepth);
            this.tabPage1.Controls.Add(this.randomSeed);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.frequencyInput);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.steepnessInput);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.stoneChance);
            this.tabPage1.Controls.Add(this.cave);
            this.tabPage1.Controls.Add(this.island);
            this.tabPage1.Controls.Add(this.grassChance);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.flagInterval);
            this.tabPage1.Controls.Add(this.redzone);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.flagCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loadPreset);
            this.tabPage2.Controls.Add(this.savePreset);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.blockRemove);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.blockWeight);
            this.tabPage2.Controls.Add(this.blockPicture);
            this.tabPage2.Controls.Add(this.blockRight);
            this.tabPage2.Controls.Add(this.blockLeft);
            this.tabPage2.Controls.Add(this.blockDown);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.blockUp);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.blockName);
            this.tabPage2.Controls.Add(this.blockOpenImage);
            this.tabPage2.Controls.Add(this.blockSave);
            this.tabPage2.Controls.Add(this.blockList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base blocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadPreset
            // 
            this.loadPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadPreset.Location = new System.Drawing.Point(87, 617);
            this.loadPreset.Name = "loadPreset";
            this.loadPreset.Size = new System.Drawing.Size(75, 23);
            this.loadPreset.TabIndex = 60;
            this.loadPreset.Text = "Load preset";
            this.loadPreset.UseVisualStyleBackColor = true;
            this.loadPreset.Click += new System.EventHandler(this.loadPreset_Click);
            // 
            // savePreset
            // 
            this.savePreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savePreset.Location = new System.Drawing.Point(6, 617);
            this.savePreset.Name = "savePreset";
            this.savePreset.Size = new System.Drawing.Size(75, 23);
            this.savePreset.TabIndex = 59;
            this.savePreset.Text = "Save preset";
            this.savePreset.UseVisualStyleBackColor = true;
            this.savePreset.Click += new System.EventHandler(this.savePreset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blockRemove
            // 
            this.blockRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blockRemove.Location = new System.Drawing.Point(791, 620);
            this.blockRemove.Name = "blockRemove";
            this.blockRemove.Size = new System.Drawing.Size(75, 23);
            this.blockRemove.TabIndex = 57;
            this.blockRemove.Text = "Remove";
            this.blockRemove.UseVisualStyleBackColor = true;
            this.blockRemove.Click += new System.EventHandler(this.blockRemove_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(16, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 15);
            this.label28.TabIndex = 56;
            this.label28.Text = "Weight";
            // 
            // blockWeight
            // 
            this.blockWeight.Location = new System.Drawing.Point(16, 123);
            this.blockWeight.Mask = "00000";
            this.blockWeight.Name = "blockWeight";
            this.blockWeight.Size = new System.Drawing.Size(69, 20);
            this.blockWeight.TabIndex = 55;
            this.blockWeight.Text = "3";
            this.blockWeight.ValidatingType = typeof(int);
            // 
            // blockPicture
            // 
            this.blockPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.blockPicture.Location = new System.Drawing.Point(177, 21);
            this.blockPicture.Name = "blockPicture";
            this.blockPicture.Size = new System.Drawing.Size(224, 148);
            this.blockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blockPicture.TabIndex = 19;
            this.blockPicture.TabStop = false;
            this.blockPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.blockPicture_Paint);
            // 
            // blockRight
            // 
            this.blockRight.AutoSize = true;
            this.blockRight.Location = new System.Drawing.Point(69, 85);
            this.blockRight.Name = "blockRight";
            this.blockRight.Size = new System.Drawing.Size(51, 17);
            this.blockRight.TabIndex = 18;
            this.blockRight.Text = "Right";
            this.blockRight.UseVisualStyleBackColor = true;
            // 
            // blockLeft
            // 
            this.blockLeft.AutoSize = true;
            this.blockLeft.Location = new System.Drawing.Point(19, 85);
            this.blockLeft.Name = "blockLeft";
            this.blockLeft.Size = new System.Drawing.Size(44, 17);
            this.blockLeft.TabIndex = 17;
            this.blockLeft.Text = "Left";
            this.blockLeft.UseVisualStyleBackColor = true;
            // 
            // blockDown
            // 
            this.blockDown.AutoSize = true;
            this.blockDown.Location = new System.Drawing.Point(69, 62);
            this.blockDown.Name = "blockDown";
            this.blockDown.Size = new System.Drawing.Size(54, 17);
            this.blockDown.TabIndex = 16;
            this.blockDown.Text = "Down";
            this.blockDown.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(16, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(106, 15);
            this.label27.TabIndex = 15;
            this.label27.Text = "Allowed directions";
            // 
            // blockUp
            // 
            this.blockUp.AutoSize = true;
            this.blockUp.Location = new System.Drawing.Point(19, 62);
            this.blockUp.Name = "blockUp";
            this.blockUp.Size = new System.Drawing.Size(40, 17);
            this.blockUp.TabIndex = 14;
            this.blockUp.Text = "Up";
            this.blockUp.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 15);
            this.label26.TabIndex = 13;
            this.label26.Text = "Name";
            // 
            // blockName
            // 
            this.blockName.Location = new System.Drawing.Point(16, 21);
            this.blockName.Name = "blockName";
            this.blockName.Size = new System.Drawing.Size(100, 20);
            this.blockName.TabIndex = 10;
            // 
            // blockOpenImage
            // 
            this.blockOpenImage.Location = new System.Drawing.Point(96, 120);
            this.blockOpenImage.Name = "blockOpenImage";
            this.blockOpenImage.Size = new System.Drawing.Size(75, 23);
            this.blockOpenImage.TabIndex = 9;
            this.blockOpenImage.Text = "Open image";
            this.blockOpenImage.UseVisualStyleBackColor = true;
            this.blockOpenImage.Click += new System.EventHandler(this.blockOpenImage_Click);
            // 
            // blockSave
            // 
            this.blockSave.Location = new System.Drawing.Point(6, 155);
            this.blockSave.Name = "blockSave";
            this.blockSave.Size = new System.Drawing.Size(75, 23);
            this.blockSave.TabIndex = 8;
            this.blockSave.Text = "Add";
            this.blockSave.UseVisualStyleBackColor = true;
            this.blockSave.Click += new System.EventHandler(this.blockSave_Click);
            // 
            // blockList
            // 
            this.blockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.RestrictDirection,
            this.Weight});
            this.blockList.GridLines = true;
            this.blockList.HideSelection = false;
            this.blockList.Location = new System.Drawing.Point(6, 193);
            this.blockList.MultiSelect = false;
            this.blockList.Name = "blockList";
            this.blockList.Size = new System.Drawing.Size(862, 420);
            this.blockList.TabIndex = 0;
            this.blockList.UseCompatibleStateImageBehavior = false;
            this.blockList.View = System.Windows.Forms.View.Details;
            this.blockList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.blockList_ItemSelectionChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // RestrictDirection
            // 
            this.RestrictDirection.Text = "Allowed directions";
            this.RestrictDirection.Width = 140;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 678);
            this.Controls.Add(this.tabControl1);
           // this.Name = "Form1";
            this.Text = "King Arthurs Gold map generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockPicture)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.CheckBox generateBase;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.MaskedTextBox baseSeed;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.MaskedTextBox baseSizeX;
        public System.Windows.Forms.MaskedTextBox baseSizeY;
        public System.Windows.Forms.CheckBox randomizeBaseSeed;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.MaskedTextBox surfaceLevel;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.MaskedTextBox flatness;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox blockPicture;
        private System.Windows.Forms.CheckBox blockRight;
        private System.Windows.Forms.CheckBox blockLeft;
        private System.Windows.Forms.CheckBox blockDown;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox blockUp;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox blockName;
        public System.Windows.Forms.Button blockSave;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader RestrictDirection;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.MaskedTextBox blockWeight;
        private System.Windows.Forms.ColumnHeader Weight;
        public System.Windows.Forms.ListView blockList;
        public System.Windows.Forms.Button blockRemove;
        public System.Windows.Forms.Button blockOpenImage;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button loadPreset;
        public System.Windows.Forms.Button savePreset;
    }
}

