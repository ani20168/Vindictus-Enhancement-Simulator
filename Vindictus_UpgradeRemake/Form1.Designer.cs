namespace Vindictus_UpgradeRemake
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.level_show = new System.Windows.Forms.Label();
            this.From0_radio = new System.Windows.Forms.RadioButton();
            this.FromCurrent_Lock_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetLevel_input = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LockLevel_input = new System.Windows.Forms.NumericUpDown();
            this.start_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gold_show = new System.Windows.Forms.Label();
            this.stone_show = new System.Windows.Forms.Label();
            this.elixir_show = new System.Windows.Forms.Label();
            this.broken_show = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.upgrade_count_show = new System.Windows.Forms.Label();
            this.timer_show = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetLevel_input)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockLevel_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "正義的 審判 杜拉漢龍魂巨刃";
            // 
            // level_show
            // 
            this.level_show.AutoSize = true;
            this.level_show.Font = new System.Drawing.Font("新細明體", 12F);
            this.level_show.Location = new System.Drawing.Point(32, 53);
            this.level_show.Name = "level_show";
            this.level_show.Size = new System.Drawing.Size(24, 16);
            this.level_show.TabIndex = 1;
            this.level_show.Text = "+0";
            // 
            // From0_radio
            // 
            this.From0_radio.AutoSize = true;
            this.From0_radio.Checked = true;
            this.From0_radio.Location = new System.Drawing.Point(6, 21);
            this.From0_radio.Name = "From0_radio";
            this.From0_radio.Size = new System.Drawing.Size(65, 16);
            this.From0_radio.TabIndex = 3;
            this.From0_radio.TabStop = true;
            this.From0_radio.Text = "從0開始";
            this.From0_radio.UseVisualStyleBackColor = true;
            // 
            // FromCurrent_Lock_radio
            // 
            this.FromCurrent_Lock_radio.AutoSize = true;
            this.FromCurrent_Lock_radio.Location = new System.Drawing.Point(6, 58);
            this.FromCurrent_Lock_radio.Name = "FromCurrent_Lock_radio";
            this.FromCurrent_Lock_radio.Size = new System.Drawing.Size(116, 40);
            this.FromCurrent_Lock_radio.TabIndex = 5;
            this.FromCurrent_Lock_radio.Text = "鎖定               等為\r\n\r\n最低等級後開始";
            this.FromCurrent_Lock_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "強化選項";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TargetLevel_input);
            this.groupBox3.Location = new System.Drawing.Point(161, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 104);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "目標等級";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(96, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "級";
            // 
            // TargetLevel_input
            // 
            this.TargetLevel_input.Location = new System.Drawing.Point(29, 43);
            this.TargetLevel_input.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TargetLevel_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetLevel_input.Name = "TargetLevel_input";
            this.TargetLevel_input.Size = new System.Drawing.Size(61, 22);
            this.TargetLevel_input.TabIndex = 7;
            this.TargetLevel_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LockLevel_input);
            this.groupBox2.Controls.Add(this.From0_radio);
            this.groupBox2.Controls.Add(this.FromCurrent_Lock_radio);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 104);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "起始等級";
            // 
            // LockLevel_input
            // 
            this.LockLevel_input.Location = new System.Drawing.Point(49, 54);
            this.LockLevel_input.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.LockLevel_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LockLevel_input.Name = "LockLevel_input";
            this.LockLevel_input.Size = new System.Drawing.Size(41, 22);
            this.LockLevel_input.TabIndex = 21;
            this.LockLevel_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(43, 225);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(120, 37);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "開始";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(40, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "已使用樂園強化石:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(40, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "已花費的金幣:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F);
            this.label5.Location = new System.Drawing.Point(40, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "已使用強化藥水:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(40, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "被破壞的武器數目:";
            // 
            // gold_show
            // 
            this.gold_show.AutoSize = true;
            this.gold_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.gold_show.Location = new System.Drawing.Point(141, 291);
            this.gold_show.Name = "gold_show";
            this.gold_show.Size = new System.Drawing.Size(14, 14);
            this.gold_show.TabIndex = 12;
            this.gold_show.Text = "0";
            // 
            // stone_show
            // 
            this.stone_show.AutoSize = true;
            this.stone_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.stone_show.Location = new System.Drawing.Point(169, 317);
            this.stone_show.Name = "stone_show";
            this.stone_show.Size = new System.Drawing.Size(14, 14);
            this.stone_show.TabIndex = 13;
            this.stone_show.Text = "0";
            // 
            // elixir_show
            // 
            this.elixir_show.AutoSize = true;
            this.elixir_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.elixir_show.Location = new System.Drawing.Point(155, 342);
            this.elixir_show.Name = "elixir_show";
            this.elixir_show.Size = new System.Drawing.Size(14, 14);
            this.elixir_show.TabIndex = 14;
            this.elixir_show.Text = "0";
            // 
            // broken_show
            // 
            this.broken_show.AutoSize = true;
            this.broken_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.broken_show.Location = new System.Drawing.Point(169, 367);
            this.broken_show.Name = "broken_show";
            this.broken_show.Size = new System.Drawing.Size(14, 14);
            this.broken_show.TabIndex = 15;
            this.broken_show.Text = "0";
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(173, 225);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(120, 37);
            this.reset_button.TabIndex = 17;
            this.reset_button.Text = "數據重置";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10F);
            this.label7.Location = new System.Drawing.Point(40, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "總強化次數:";
            // 
            // upgrade_count_show
            // 
            this.upgrade_count_show.AutoSize = true;
            this.upgrade_count_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.upgrade_count_show.Location = new System.Drawing.Point(127, 393);
            this.upgrade_count_show.Name = "upgrade_count_show";
            this.upgrade_count_show.Size = new System.Drawing.Size(14, 14);
            this.upgrade_count_show.TabIndex = 19;
            this.upgrade_count_show.Text = "0";
            // 
            // timer_show
            // 
            this.timer_show.AutoSize = true;
            this.timer_show.Font = new System.Drawing.Font("新細明體", 10F);
            this.timer_show.Location = new System.Drawing.Point(113, 434);
            this.timer_show.Name = "timer_show";
            this.timer_show.Size = new System.Drawing.Size(97, 14);
            this.timer_show.TabIndex = 20;
            this.timer_show.Text = "花費時間: 0 ms";
            this.timer_show.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 457);
            this.Controls.Add(this.timer_show);
            this.Controls.Add(this.upgrade_count_show);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.broken_show);
            this.Controls.Add(this.elixir_show);
            this.Controls.Add(this.stone_show);
            this.Controls.Add(this.gold_show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.level_show);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "強化模擬器-快速強化重製版";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TargetLevel_input)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockLevel_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label level_show;
        private System.Windows.Forms.RadioButton FromCurrent_Lock_radio;
        private System.Windows.Forms.RadioButton From0_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TargetLevel_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gold_show;
        private System.Windows.Forms.Label stone_show;
        private System.Windows.Forms.Label elixir_show;
        private System.Windows.Forms.Label broken_show;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label upgrade_count_show;
        private System.Windows.Forms.Label timer_show;
        private System.Windows.Forms.NumericUpDown LockLevel_input;
    }
}

