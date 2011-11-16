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
            this._EffectSettingGroupBox = new System.Windows.Forms.GroupBox();
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
            this._FooterSeparatorLabel = new System.Windows.Forms.Label();
            this.label_image = new System.Windows.Forms.Label();
            this._SaveSettingGroupBox = new System.Windows.Forms.GroupBox();
            this._SizeSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.numeric_filesize = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_size = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.numeric_quality = new System.Windows.Forms.NumericUpDown();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_width = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_filesize = new System.Windows.Forms.RadioButton();
            this.track_quality = new System.Windows.Forms.TrackBar();
            this.combo_quality = new System.Windows.Forms.ComboBox();
            this.radio_quality = new System.Windows.Forms.RadioButton();
            this._SizeSettingSeparatorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._EffectSettingGroupBox.SuspendLayout();
            this._SaveSettingGroupBox.SuspendLayout();
            this._SizeSettingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_filesize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_quality)).BeginInit();
            this.SuspendLayout();
            // 
            // _EffectSettingGroupBox
            // 
            this._EffectSettingGroupBox.Controls.Add(this.check_sepia);
            this._EffectSettingGroupBox.Controls.Add(this.check_monochrome);
            this._EffectSettingGroupBox.Controls.Add(this.check_contrast);
            this._EffectSettingGroupBox.Controls.Add(this.check_saturation);
            this._EffectSettingGroupBox.Controls.Add(this.check_brightness);
            this._EffectSettingGroupBox.Location = new System.Drawing.Point(12, 218);
            this._EffectSettingGroupBox.Name = "_EffectSettingGroupBox";
            this._EffectSettingGroupBox.Size = new System.Drawing.Size(205, 114);
            this._EffectSettingGroupBox.TabIndex = 14;
            this._EffectSettingGroupBox.TabStop = false;
            this._EffectSettingGroupBox.Text = "画像効果";
            // 
            // check_sepia
            // 
            this.check_sepia.AutoSize = true;
            this.check_sepia.Location = new System.Drawing.Point(126, 42);
            this.check_sepia.Name = "check_sepia";
            this.check_sepia.Size = new System.Drawing.Size(52, 16);
            this.check_sepia.TabIndex = 4;
            this.check_sepia.Text = "セピア";
            this.check_sepia.UseVisualStyleBackColor = true;
            // 
            // check_monochrome
            // 
            this.check_monochrome.AutoSize = true;
            this.check_monochrome.Location = new System.Drawing.Point(127, 20);
            this.check_monochrome.Name = "check_monochrome";
            this.check_monochrome.Size = new System.Drawing.Size(58, 16);
            this.check_monochrome.TabIndex = 3;
            this.check_monochrome.Text = "モノクロ";
            this.check_monochrome.UseVisualStyleBackColor = true;
            // 
            // check_contrast
            // 
            this.check_contrast.AutoSize = true;
            this.check_contrast.Location = new System.Drawing.Point(10, 64);
            this.check_contrast.Name = "check_contrast";
            this.check_contrast.Size = new System.Drawing.Size(98, 16);
            this.check_contrast.TabIndex = 2;
            this.check_contrast.Text = "コントラスト強調";
            this.check_contrast.UseVisualStyleBackColor = true;
            // 
            // check_saturation
            // 
            this.check_saturation.AutoSize = true;
            this.check_saturation.Location = new System.Drawing.Point(10, 42);
            this.check_saturation.Name = "check_saturation";
            this.check_saturation.Size = new System.Drawing.Size(84, 16);
            this.check_saturation.TabIndex = 1;
            this.check_saturation.Text = "鮮やかにする";
            this.check_saturation.UseVisualStyleBackColor = true;
            // 
            // check_brightness
            // 
            this.check_brightness.AutoSize = true;
            this.check_brightness.Location = new System.Drawing.Point(12, 20);
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
            this.radio_folder.Location = new System.Drawing.Point(12, 20);
            this.radio_folder.Name = "radio_folder";
            this.radio_folder.Size = new System.Drawing.Size(122, 16);
            this.radio_folder.TabIndex = 16;
            this.radio_folder.TabStop = true;
            this.radio_folder.Text = "新しいフォルダに保存";
            this.radio_folder.UseVisualStyleBackColor = true;
            // 
            // text_folder
            // 
            this.text_folder.Location = new System.Drawing.Point(89, 42);
            this.text_folder.Name = "text_folder";
            this.text_folder.Size = new System.Drawing.Size(250, 19);
            this.text_folder.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "フォルダ名：";
            // 
            // text_filename
            // 
            this.text_filename.Location = new System.Drawing.Point(28, 89);
            this.text_filename.Name = "text_filename";
            this.text_filename.Size = new System.Drawing.Size(220, 19);
            this.text_filename.TabIndex = 20;
            // 
            // radio_filename
            // 
            this.radio_filename.AutoSize = true;
            this.radio_filename.Location = new System.Drawing.Point(12, 67);
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
            this.combo_filename.Location = new System.Drawing.Point(254, 88);
            this.combo_filename.Name = "combo_filename";
            this.combo_filename.Size = new System.Drawing.Size(85, 20);
            this.combo_filename.TabIndex = 21;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(404, 351);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 29);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "設定を保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(490, 351);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 29);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // _FooterSeparatorLabel
            // 
            this._FooterSeparatorLabel.AutoSize = true;
            this._FooterSeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._FooterSeparatorLabel.Location = new System.Drawing.Point(12, 340);
            this._FooterSeparatorLabel.MaximumSize = new System.Drawing.Size(0, 2);
            this._FooterSeparatorLabel.MinimumSize = new System.Drawing.Size(558, 0);
            this._FooterSeparatorLabel.Name = "_FooterSeparatorLabel";
            this._FooterSeparatorLabel.Size = new System.Drawing.Size(558, 2);
            this._FooterSeparatorLabel.TabIndex = 24;
            // 
            // label_image
            // 
            this.label_image.AllowDrop = true;
            this.label_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_image.Image = global::cuberesize.Properties.Resources.draghere;
            this.label_image.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_image.Location = new System.Drawing.Point(428, 36);
            this.label_image.MinimumSize = new System.Drawing.Size(128, 128);
            this.label_image.Name = "label_image";
            this.label_image.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.label_image.Size = new System.Drawing.Size(140, 150);
            this.label_image.TabIndex = 25;
            this.label_image.Text = "ここに画像データをドラッグ";
            this.label_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_image.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_image_DragDrop);
            this.label_image.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_image_DragEnter);
            // 
            // _SaveSettingGroupBox
            // 
            this._SaveSettingGroupBox.Controls.Add(this.radio_filename);
            this._SaveSettingGroupBox.Controls.Add(this.label7);
            this._SaveSettingGroupBox.Controls.Add(this.text_folder);
            this._SaveSettingGroupBox.Controls.Add(this.radio_folder);
            this._SaveSettingGroupBox.Controls.Add(this.text_filename);
            this._SaveSettingGroupBox.Controls.Add(this.combo_filename);
            this._SaveSettingGroupBox.Location = new System.Drawing.Point(223, 218);
            this._SaveSettingGroupBox.Name = "_SaveSettingGroupBox";
            this._SaveSettingGroupBox.Size = new System.Drawing.Size(345, 114);
            this._SaveSettingGroupBox.TabIndex = 26;
            this._SaveSettingGroupBox.TabStop = false;
            this._SaveSettingGroupBox.Text = "保存方法";
            // 
            // _SizeSettingGroupBox
            // 
            this._SizeSettingGroupBox.Controls.Add(this.numeric_filesize);
            this._SizeSettingGroupBox.Controls.Add(this.panel1);
            this._SizeSettingGroupBox.Controls.Add(this.numeric_quality);
            this._SizeSettingGroupBox.Controls.Add(this.numeric_height);
            this._SizeSettingGroupBox.Controls.Add(this.numeric_width);
            this._SizeSettingGroupBox.Controls.Add(this.label5);
            this._SizeSettingGroupBox.Controls.Add(this.radio_filesize);
            this._SizeSettingGroupBox.Controls.Add(this.track_quality);
            this._SizeSettingGroupBox.Controls.Add(this.combo_quality);
            this._SizeSettingGroupBox.Controls.Add(this.radio_quality);
            this._SizeSettingGroupBox.Controls.Add(this._SizeSettingSeparatorLabel);
            this._SizeSettingGroupBox.Controls.Add(this.label3);
            this._SizeSettingGroupBox.Controls.Add(this.label2);
            this._SizeSettingGroupBox.Controls.Add(this.label1);
            this._SizeSettingGroupBox.Location = new System.Drawing.Point(12, 12);
            this._SizeSettingGroupBox.Name = "_SizeSettingGroupBox";
            this._SizeSettingGroupBox.Size = new System.Drawing.Size(410, 200);
            this._SizeSettingGroupBox.TabIndex = 27;
            this._SizeSettingGroupBox.TabStop = false;
            this._SizeSettingGroupBox.Text = "サイズ設定";
            // 
            // numeric_filesize
            // 
            this.numeric_filesize.Location = new System.Drawing.Point(281, 85);
            this.numeric_filesize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_filesize.Name = "numeric_filesize";
            this.numeric_filesize.Size = new System.Drawing.Size(92, 19);
            this.numeric_filesize.TabIndex = 46;
            this.numeric_filesize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button_size);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.combo_size);
            this.panel1.Location = new System.Drawing.Point(6, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 70);
            this.panel1.TabIndex = 45;
            // 
            // button_size
            // 
            this.button_size.Location = new System.Drawing.Point(6, 35);
            this.button_size.Name = "button_size";
            this.button_size.Size = new System.Drawing.Size(386, 24);
            this.button_size.TabIndex = 2;
            this.button_size.Text = "他の設定サイズより選ぶ";
            this.button_size.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "以前に使用したサイズ：";
            // 
            // combo_size
            // 
            this.combo_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Location = new System.Drawing.Point(129, 9);
            this.combo_size.Name = "combo_size";
            this.combo_size.Size = new System.Drawing.Size(263, 20);
            this.combo_size.TabIndex = 0;
            // 
            // numeric_quality
            // 
            this.numeric_quality.Location = new System.Drawing.Point(268, 22);
            this.numeric_quality.Name = "numeric_quality";
            this.numeric_quality.Size = new System.Drawing.Size(58, 19);
            this.numeric_quality.TabIndex = 44;
            this.numeric_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(85, 43);
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
            this.numeric_height.Size = new System.Drawing.Size(50, 19);
            this.numeric_height.TabIndex = 43;
            this.numeric_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_width
            // 
            this.numeric_width.Location = new System.Drawing.Point(6, 43);
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
            this.numeric_width.Size = new System.Drawing.Size(50, 19);
            this.numeric_width.TabIndex = 42;
            this.numeric_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "kB";
            // 
            // radio_filesize
            // 
            this.radio_filesize.AutoSize = true;
            this.radio_filesize.Location = new System.Drawing.Point(183, 85);
            this.radio_filesize.Name = "radio_filesize";
            this.radio_filesize.Size = new System.Drawing.Size(92, 16);
            this.radio_filesize.TabIndex = 40;
            this.radio_filesize.Text = "ファイルサイズ：";
            this.radio_filesize.UseVisualStyleBackColor = true;
            // 
            // track_quality
            // 
            this.track_quality.LargeChange = 10;
            this.track_quality.Location = new System.Drawing.Point(198, 47);
            this.track_quality.Maximum = 100;
            this.track_quality.Name = "track_quality";
            this.track_quality.Size = new System.Drawing.Size(203, 45);
            this.track_quality.TabIndex = 39;
            this.track_quality.TickFrequency = 10;
            this.track_quality.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_quality.Value = 100;
            this.track_quality.Scroll += new System.EventHandler(this.track_quality_Scroll);
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
            this.combo_quality.Location = new System.Drawing.Point(332, 21);
            this.combo_quality.Name = "combo_quality";
            this.combo_quality.Size = new System.Drawing.Size(69, 20);
            this.combo_quality.TabIndex = 38;
            // 
            // radio_quality
            // 
            this.radio_quality.AutoSize = true;
            this.radio_quality.Checked = true;
            this.radio_quality.Location = new System.Drawing.Point(184, 22);
            this.radio_quality.Name = "radio_quality";
            this.radio_quality.Size = new System.Drawing.Size(78, 16);
            this.radio_quality.TabIndex = 37;
            this.radio_quality.TabStop = true;
            this.radio_quality.Text = "Jpeg画質：";
            this.radio_quality.UseVisualStyleBackColor = true;
            // 
            // _SizeSettingSeparatorLabel
            // 
            this._SizeSettingSeparatorLabel.AutoSize = true;
            this._SizeSettingSeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._SizeSettingSeparatorLabel.Location = new System.Drawing.Point(176, 12);
            this._SizeSettingSeparatorLabel.MinimumSize = new System.Drawing.Size(0, 104);
            this._SizeSettingSeparatorLabel.Name = "_SizeSettingSeparatorLabel";
            this._SizeSettingSeparatorLabel.Size = new System.Drawing.Size(2, 104);
            this._SizeSettingSeparatorLabel.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "pixel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "×";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "画像サイズ：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this._SizeSettingGroupBox);
            this.Controls.Add(this._SaveSettingGroupBox);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this._FooterSeparatorLabel);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this._EffectSettingGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 520);
            this.Name = "MainForm";
            this.Text = "CubeResize";
            this._EffectSettingGroupBox.ResumeLayout(false);
            this._EffectSettingGroupBox.PerformLayout();
            this._SaveSettingGroupBox.ResumeLayout(false);
            this._SaveSettingGroupBox.PerformLayout();
            this._SizeSettingGroupBox.ResumeLayout(false);
            this._SizeSettingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_filesize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_quality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _EffectSettingGroupBox;
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
        private System.Windows.Forms.Label _FooterSeparatorLabel;
        private System.Windows.Forms.ComboBox combo_filename;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.GroupBox _SaveSettingGroupBox;
        private System.Windows.Forms.GroupBox _SizeSettingGroupBox;
        private System.Windows.Forms.NumericUpDown numeric_filesize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.NumericUpDown numeric_quality;
        private System.Windows.Forms.NumericUpDown numeric_height;
        private System.Windows.Forms.NumericUpDown numeric_width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_filesize;
        private System.Windows.Forms.TrackBar track_quality;
        private System.Windows.Forms.ComboBox combo_quality;
        private System.Windows.Forms.RadioButton radio_quality;
        private System.Windows.Forms.Label _SizeSettingSeparatorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

