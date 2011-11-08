namespace cuberesize
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_quality = new System.Windows.Forms.RadioButton();
            this.track_quality = new System.Windows.Forms.TrackBar();
            this.radio_size = new System.Windows.Forms.RadioButton();
            this.text_size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_sepia = new System.Windows.Forms.CheckBox();
            this.check_monochrome = new System.Windows.Forms.CheckBox();
            this.check_contrast = new System.Windows.Forms.CheckBox();
            this.check_saturation = new System.Windows.Forms.CheckBox();
            this.check_brightness = new System.Windows.Forms.CheckBox();
            this.radio_folder = new System.Windows.Forms.RadioButton();
            this.text_folder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_filename = new System.Windows.Forms.TextBox();
            this.radio_filename = new System.Windows.Forms.RadioButton();
            this.combo_filename = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_image = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_quality = new System.Windows.Forms.ComboBox();
            this.numeric_width = new System.Windows.Forms.NumericUpDown();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_quality = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_size = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_quality)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "画像サイズ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "×";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "pixel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(187, 74);
            this.label4.MinimumSize = new System.Drawing.Size(0, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 120);
            this.label4.TabIndex = 6;
            // 
            // radio_quality
            // 
            this.radio_quality.AutoSize = true;
            this.radio_quality.Checked = true;
            this.radio_quality.Location = new System.Drawing.Point(195, 82);
            this.radio_quality.Name = "radio_quality";
            this.radio_quality.Size = new System.Drawing.Size(78, 16);
            this.radio_quality.TabIndex = 7;
            this.radio_quality.TabStop = true;
            this.radio_quality.Text = "Jpeg画質：";
            this.radio_quality.UseVisualStyleBackColor = true;
            // 
            // track_quality
            // 
            this.track_quality.LargeChange = 10;
            this.track_quality.Location = new System.Drawing.Point(235, 106);
            this.track_quality.Maximum = 100;
            this.track_quality.Name = "track_quality";
            this.track_quality.Size = new System.Drawing.Size(175, 45);
            this.track_quality.TabIndex = 10;
            this.track_quality.TickFrequency = 10;
            this.track_quality.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_quality.Scroll += new System.EventHandler(this.track_quality_Scroll);
            // 
            // radio_size
            // 
            this.radio_size.AutoSize = true;
            this.radio_size.Location = new System.Drawing.Point(195, 157);
            this.radio_size.Name = "radio_size";
            this.radio_size.Size = new System.Drawing.Size(92, 16);
            this.radio_size.TabIndex = 11;
            this.radio_size.Text = "ファイルサイズ：";
            this.radio_size.UseVisualStyleBackColor = true;
            // 
            // text_size
            // 
            this.text_size.Location = new System.Drawing.Point(293, 156);
            this.text_size.Name = "text_size";
            this.text_size.Size = new System.Drawing.Size(92, 19);
            this.text_size.TabIndex = 12;
            this.text_size.Text = "10";
            this.text_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "kB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_sepia);
            this.groupBox1.Controls.Add(this.check_monochrome);
            this.groupBox1.Controls.Add(this.check_contrast);
            this.groupBox1.Controls.Add(this.check_saturation);
            this.groupBox1.Controls.Add(this.check_brightness);
            this.groupBox1.Location = new System.Drawing.Point(27, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "画像効果";
            // 
            // check_sepia
            // 
            this.check_sepia.AutoSize = true;
            this.check_sepia.Location = new System.Drawing.Point(127, 50);
            this.check_sepia.Name = "check_sepia";
            this.check_sepia.Size = new System.Drawing.Size(52, 16);
            this.check_sepia.TabIndex = 4;
            this.check_sepia.Text = "セピア";
            this.check_sepia.UseVisualStyleBackColor = true;
            // 
            // check_monochrome
            // 
            this.check_monochrome.AutoSize = true;
            this.check_monochrome.Location = new System.Drawing.Point(127, 18);
            this.check_monochrome.Name = "check_monochrome";
            this.check_monochrome.Size = new System.Drawing.Size(58, 16);
            this.check_monochrome.TabIndex = 3;
            this.check_monochrome.Text = "モノクロ";
            this.check_monochrome.UseVisualStyleBackColor = true;
            // 
            // check_contrast
            // 
            this.check_contrast.AutoSize = true;
            this.check_contrast.Location = new System.Drawing.Point(6, 82);
            this.check_contrast.Name = "check_contrast";
            this.check_contrast.Size = new System.Drawing.Size(98, 16);
            this.check_contrast.TabIndex = 2;
            this.check_contrast.Text = "コントラスト強調";
            this.check_contrast.UseVisualStyleBackColor = true;
            // 
            // check_saturation
            // 
            this.check_saturation.AutoSize = true;
            this.check_saturation.Location = new System.Drawing.Point(6, 50);
            this.check_saturation.Name = "check_saturation";
            this.check_saturation.Size = new System.Drawing.Size(84, 16);
            this.check_saturation.TabIndex = 1;
            this.check_saturation.Text = "鮮やかにする";
            this.check_saturation.UseVisualStyleBackColor = true;
            // 
            // check_brightness
            // 
            this.check_brightness.AutoSize = true;
            this.check_brightness.Location = new System.Drawing.Point(6, 18);
            this.check_brightness.Name = "check_brightness";
            this.check_brightness.Size = new System.Drawing.Size(70, 16);
            this.check_brightness.TabIndex = 0;
            this.check_brightness.Text = "明るくする";
            this.check_brightness.UseVisualStyleBackColor = true;
            // 
            // radio_folder
            // 
            this.radio_folder.AutoSize = true;
            this.radio_folder.Checked = true;
            this.radio_folder.Location = new System.Drawing.Point(18, 17);
            this.radio_folder.Name = "radio_folder";
            this.radio_folder.Size = new System.Drawing.Size(122, 16);
            this.radio_folder.TabIndex = 16;
            this.radio_folder.TabStop = true;
            this.radio_folder.Text = "新しいフォルダに保存";
            this.radio_folder.UseVisualStyleBackColor = true;
            // 
            // text_folder
            // 
            this.text_folder.Location = new System.Drawing.Point(33, 39);
            this.text_folder.Name = "text_folder";
            this.text_folder.Size = new System.Drawing.Size(172, 19);
            this.text_folder.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "：フォルダ名";
            // 
            // text_filename
            // 
            this.text_filename.Location = new System.Drawing.Point(34, 83);
            this.text_filename.Name = "text_filename";
            this.text_filename.Size = new System.Drawing.Size(171, 19);
            this.text_filename.TabIndex = 20;
            // 
            // radio_filename
            // 
            this.radio_filename.AutoSize = true;
            this.radio_filename.Location = new System.Drawing.Point(18, 65);
            this.radio_filename.Name = "radio_filename";
            this.radio_filename.Size = new System.Drawing.Size(147, 16);
            this.radio_filename.TabIndex = 19;
            this.radio_filename.Text = "ファイル名にテキストを追加";
            this.radio_filename.UseVisualStyleBackColor = true;
            // 
            // combo_filename
            // 
            this.combo_filename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_filename.Items.AddRange(new object[] {
            "前に",
            "後ろに"});
            this.combo_filename.Location = new System.Drawing.Point(211, 83);
            this.combo_filename.Name = "combo_filename";
            this.combo_filename.Size = new System.Drawing.Size(85, 20);
            this.combo_filename.TabIndex = 21;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(378, 440);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(72, 29);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "設定を保存";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(469, 440);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(72, 29);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 426);
            this.label8.MaximumSize = new System.Drawing.Size(0, 1);
            this.label8.MinimumSize = new System.Drawing.Size(540, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 1);
            this.label8.TabIndex = 24;
            // 
            // label_image
            // 
            this.label_image.AllowDrop = true;
            this.label_image.AutoSize = true;
            this.label_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_image.Location = new System.Drawing.Point(419, 74);
            this.label_image.MinimumSize = new System.Drawing.Size(128, 128);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(128, 128);
            this.label_image.TabIndex = 25;
            this.label_image.Text = "ここに画像データをドラッグ";
            this.label_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_image.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_image_DragDrop);
            this.label_image.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_image_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_filename);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.text_folder);
            this.groupBox2.Controls.Add(this.radio_folder);
            this.groupBox2.Controls.Add(this.text_filename);
            this.groupBox2.Controls.Add(this.combo_filename);
            this.groupBox2.Location = new System.Drawing.Point(245, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 112);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存方法";
            // 
            // combo_quality
            // 
            this.combo_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_quality.FormattingEnabled = true;
            this.combo_quality.Items.AddRange(new object[] {
            "カスタム",
            "高",
            "中",
            "低"});
            this.combo_quality.Location = new System.Drawing.Point(341, 81);
            this.combo_quality.Name = "combo_quality";
            this.combo_quality.Size = new System.Drawing.Size(69, 20);
            this.combo_quality.TabIndex = 9;
            this.combo_quality.SelectedIndexChanged += new System.EventHandler(this.combo_quality_SelectedIndexChanged);
            // 
            // numeric_width
            // 
            this.numeric_width.Location = new System.Drawing.Point(27, 137);
            this.numeric_width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_width.Name = "numeric_width";
            this.numeric_width.Size = new System.Drawing.Size(45, 19);
            this.numeric_width.TabIndex = 27;
            this.numeric_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(101, 137);
            this.numeric_height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_height.Name = "numeric_height";
            this.numeric_height.Size = new System.Drawing.Size(45, 19);
            this.numeric_height.TabIndex = 28;
            this.numeric_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_quality
            // 
            this.numeric_quality.Location = new System.Drawing.Point(277, 81);
            this.numeric_quality.Name = "numeric_quality";
            this.numeric_quality.Size = new System.Drawing.Size(58, 19);
            this.numeric_quality.TabIndex = 29;
            this.numeric_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_quality.ValueChanged += new System.EventHandler(this.numeric_quality_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(535, 48);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_size);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.combo_size);
            this.panel1.Location = new System.Drawing.Point(12, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 77);
            this.panel1.TabIndex = 31;
            // 
            // combo_size
            // 
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(134, 12);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(392, 20);
            this.combo_size.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "以前に使用したサイズ：";
            // 
            // button_size
            // 
            this.button_size.Location = new System.Drawing.Point(15, 41);
            this.button_size.Name = "button_size";
            this.button_size.Size = new System.Drawing.Size(510, 24);
            this.button_size.TabIndex = 2;
            this.button_size.Text = "他の設定サイズより選ぶ";
            this.button_size.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(559, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numeric_quality);
            this.Controls.Add(this.numeric_height);
            this.Controls.Add(this.numeric_width);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.radio_size);
            this.Controls.Add(this.track_quality);
            this.Controls.Add(this.combo_quality);
            this.Controls.Add(this.radio_quality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 520);
            this.Name = "MainForm";
            this.Text = "CubeResize";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_quality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_quality;
        private System.Windows.Forms.TrackBar track_quality;
        private System.Windows.Forms.RadioButton radio_size;
        private System.Windows.Forms.TextBox text_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_sepia;
        private System.Windows.Forms.CheckBox check_monochrome;
        private System.Windows.Forms.CheckBox check_contrast;
        private System.Windows.Forms.CheckBox check_saturation;
        private System.Windows.Forms.CheckBox check_brightness;
        private System.Windows.Forms.RadioButton radio_folder;
        private System.Windows.Forms.TextBox text_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_filename;
        private System.Windows.Forms.RadioButton radio_filename;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_filename;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_quality;
        private System.Windows.Forms.NumericUpDown numeric_width;
        private System.Windows.Forms.NumericUpDown numeric_height;
        private System.Windows.Forms.NumericUpDown numeric_quality;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_size;
    }
}

