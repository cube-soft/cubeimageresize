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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this._SaveSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.check_overwrite = new System.Windows.Forms.CheckBox();
            this._SizeSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_resize_height = new System.Windows.Forms.RadioButton();
            this.radio_resize_width = new System.Windows.Forms.RadioButton();
            this.radio_resize_aspect = new System.Windows.Forms.RadioButton();
            this.radio_resize_force = new System.Windows.Forms.RadioButton();
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
            this.label_image = new System.Windows.Forms.Label();
            this._EffectSettingGroupBox.SuspendLayout();
            this._SaveSettingGroupBox.SuspendLayout();
            this._SizeSettingGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this._EffectSettingGroupBox.Location = new System.Drawing.Point(12, 239);
            this._EffectSettingGroupBox.Name = "_EffectSettingGroupBox";
            this._EffectSettingGroupBox.Size = new System.Drawing.Size(205, 136);
            this._EffectSettingGroupBox.TabIndex = 14;
            this._EffectSettingGroupBox.TabStop = false;
            this._EffectSettingGroupBox.Text = "画像効果";
            // 
            // check_sepia
            // 
            this.check_sepia.AutoSize = true;
            this.check_sepia.Location = new System.Drawing.Point(10, 110);
            this.check_sepia.Name = "check_sepia";
            this.check_sepia.Size = new System.Drawing.Size(92, 16);
            this.check_sepia.TabIndex = 4;
            this.check_sepia.Text = "セピア色にする";
            this.check_sepia.UseVisualStyleBackColor = true;
            // 
            // check_monochrome
            // 
            this.check_monochrome.AutoSize = true;
            this.check_monochrome.Location = new System.Drawing.Point(10, 88);
            this.check_monochrome.Name = "check_monochrome";
            this.check_monochrome.Size = new System.Drawing.Size(86, 16);
            this.check_monochrome.TabIndex = 3;
            this.check_monochrome.Text = "モノクロにする";
            this.check_monochrome.UseVisualStyleBackColor = true;
            // 
            // check_contrast
            // 
            this.check_contrast.AutoSize = true;
            this.check_contrast.Location = new System.Drawing.Point(10, 66);
            this.check_contrast.Name = "check_contrast";
            this.check_contrast.Size = new System.Drawing.Size(126, 16);
            this.check_contrast.TabIndex = 2;
            this.check_contrast.Text = "コントラストを強調する";
            this.check_contrast.UseVisualStyleBackColor = true;
            // 
            // check_saturation
            // 
            this.check_saturation.AutoSize = true;
            this.check_saturation.Location = new System.Drawing.Point(10, 44);
            this.check_saturation.Name = "check_saturation";
            this.check_saturation.Size = new System.Drawing.Size(84, 16);
            this.check_saturation.TabIndex = 1;
            this.check_saturation.Text = "鮮やかにする";
            this.check_saturation.UseVisualStyleBackColor = true;
            // 
            // check_brightness
            // 
            this.check_brightness.AutoSize = true;
            this.check_brightness.Location = new System.Drawing.Point(10, 22);
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
            this.radio_folder.Location = new System.Drawing.Point(10, 18);
            this.radio_folder.Name = "radio_folder";
            this.radio_folder.Size = new System.Drawing.Size(122, 16);
            this.radio_folder.TabIndex = 16;
            this.radio_folder.TabStop = true;
            this.radio_folder.Text = "新しいフォルダに保存";
            this.radio_folder.UseVisualStyleBackColor = true;
            this.radio_folder.CheckedChanged += new System.EventHandler(this.radio_folder_CheckedChanged);
            // 
            // text_folder
            // 
            this.text_folder.Location = new System.Drawing.Point(89, 38);
            this.text_folder.Name = "text_folder";
            this.text_folder.Size = new System.Drawing.Size(264, 19);
            this.text_folder.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "フォルダ名：";
            // 
            // text_filename
            // 
            this.text_filename.Location = new System.Drawing.Point(28, 85);
            this.text_filename.Name = "text_filename";
            this.text_filename.Size = new System.Drawing.Size(234, 19);
            this.text_filename.TabIndex = 20;
            // 
            // radio_filename
            // 
            this.radio_filename.AutoSize = true;
            this.radio_filename.Location = new System.Drawing.Point(10, 63);
            this.radio_filename.Name = "radio_filename";
            this.radio_filename.Size = new System.Drawing.Size(147, 16);
            this.radio_filename.TabIndex = 19;
            this.radio_filename.Text = "ファイル名にテキストを追加";
            this.radio_filename.UseVisualStyleBackColor = true;
            this.radio_filename.CheckedChanged += new System.EventHandler(this.radio_filename_CheckedChanged);
            // 
            // combo_filename
            // 
            this.combo_filename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_filename.Items.AddRange(new object[] {
            "前に",
            "後ろに"});
            this.combo_filename.Location = new System.Drawing.Point(268, 84);
            this.combo_filename.Name = "combo_filename";
            this.combo_filename.Size = new System.Drawing.Size(85, 20);
            this.combo_filename.TabIndex = 21;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(416, 381);
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
            this.button_cancel.Location = new System.Drawing.Point(502, 381);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 29);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "キャンセル";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // _SaveSettingGroupBox
            // 
            this._SaveSettingGroupBox.Controls.Add(this.check_overwrite);
            this._SaveSettingGroupBox.Controls.Add(this.radio_filename);
            this._SaveSettingGroupBox.Controls.Add(this.label7);
            this._SaveSettingGroupBox.Controls.Add(this.text_folder);
            this._SaveSettingGroupBox.Controls.Add(this.radio_folder);
            this._SaveSettingGroupBox.Controls.Add(this.text_filename);
            this._SaveSettingGroupBox.Controls.Add(this.combo_filename);
            this._SaveSettingGroupBox.Location = new System.Drawing.Point(223, 239);
            this._SaveSettingGroupBox.Name = "_SaveSettingGroupBox";
            this._SaveSettingGroupBox.Size = new System.Drawing.Size(359, 136);
            this._SaveSettingGroupBox.TabIndex = 26;
            this._SaveSettingGroupBox.TabStop = false;
            this._SaveSettingGroupBox.Text = "保存方法";
            // 
            // check_overwrite
            // 
            this.check_overwrite.AutoSize = true;
            this.check_overwrite.Location = new System.Drawing.Point(10, 110);
            this.check_overwrite.Name = "check_overwrite";
            this.check_overwrite.Size = new System.Drawing.Size(109, 16);
            this.check_overwrite.TabIndex = 22;
            this.check_overwrite.Text = "上書き確認を行う";
            this.check_overwrite.UseVisualStyleBackColor = true;
            // 
            // _SizeSettingGroupBox
            // 
            this._SizeSettingGroupBox.Controls.Add(this.panel2);
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
            this._SizeSettingGroupBox.Location = new System.Drawing.Point(12, 12);
            this._SizeSettingGroupBox.Name = "_SizeSettingGroupBox";
            this._SizeSettingGroupBox.Size = new System.Drawing.Size(424, 221);
            this._SizeSettingGroupBox.TabIndex = 27;
            this._SizeSettingGroupBox.TabStop = false;
            this._SizeSettingGroupBox.Text = "サイズ設定";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_resize_height);
            this.panel2.Controls.Add(this.radio_resize_width);
            this.panel2.Controls.Add(this.radio_resize_aspect);
            this.panel2.Controls.Add(this.radio_resize_force);
            this.panel2.Location = new System.Drawing.Point(6, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 90);
            this.panel2.TabIndex = 47;
            // 
            // radio_resize_height
            // 
            this.radio_resize_height.AutoSize = true;
            this.radio_resize_height.Location = new System.Drawing.Point(6, 68);
            this.radio_resize_height.Name = "radio_resize_height";
            this.radio_resize_height.Size = new System.Drawing.Size(93, 16);
            this.radio_resize_height.TabIndex = 54;
            this.radio_resize_height.TabStop = true;
            this.radio_resize_height.Text = "高さに合わせる";
            this.radio_resize_height.UseVisualStyleBackColor = true;
            this.radio_resize_height.CheckedChanged += new System.EventHandler(this.radio_resize_method_CheckedChanged);
            // 
            // radio_resize_width
            // 
            this.radio_resize_width.AutoSize = true;
            this.radio_resize_width.Location = new System.Drawing.Point(6, 46);
            this.radio_resize_width.Name = "radio_resize_width";
            this.radio_resize_width.Size = new System.Drawing.Size(85, 16);
            this.radio_resize_width.TabIndex = 53;
            this.radio_resize_width.TabStop = true;
            this.radio_resize_width.Text = "幅に合わせる";
            this.radio_resize_width.UseVisualStyleBackColor = true;
            this.radio_resize_width.CheckedChanged += new System.EventHandler(this.radio_resize_method_CheckedChanged);
            // 
            // radio_resize_aspect
            // 
            this.radio_resize_aspect.AutoSize = true;
            this.radio_resize_aspect.Location = new System.Drawing.Point(6, 24);
            this.radio_resize_aspect.Name = "radio_resize_aspect";
            this.radio_resize_aspect.Size = new System.Drawing.Size(111, 16);
            this.radio_resize_aspect.TabIndex = 52;
            this.radio_resize_aspect.TabStop = true;
            this.radio_resize_aspect.Text = "縦横比を維持する";
            this.radio_resize_aspect.UseVisualStyleBackColor = true;
            this.radio_resize_aspect.CheckedChanged += new System.EventHandler(this.radio_resize_method_CheckedChanged);
            // 
            // radio_resize_force
            // 
            this.radio_resize_force.AutoSize = true;
            this.radio_resize_force.Location = new System.Drawing.Point(6, 4);
            this.radio_resize_force.Name = "radio_resize_force";
            this.radio_resize_force.Size = new System.Drawing.Size(147, 16);
            this.radio_resize_force.TabIndex = 51;
            this.radio_resize_force.TabStop = true;
            this.radio_resize_force.Text = "指定したサイズで変換する";
            this.radio_resize_force.UseVisualStyleBackColor = true;
            this.radio_resize_force.CheckedChanged += new System.EventHandler(this.radio_resize_method_CheckedChanged);
            // 
            // numeric_filesize
            // 
            this.numeric_filesize.Location = new System.Drawing.Point(294, 89);
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
            this.panel1.Location = new System.Drawing.Point(6, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 70);
            this.panel1.TabIndex = 45;
            // 
            // button_size
            // 
            this.button_size.Location = new System.Drawing.Point(6, 35);
            this.button_size.Name = "button_size";
            this.button_size.Size = new System.Drawing.Size(401, 24);
            this.button_size.TabIndex = 2;
            this.button_size.Text = "他の設定サイズより選ぶ";
            this.button_size.UseVisualStyleBackColor = true;
            this.button_size.Click += new System.EventHandler(this.button_size_Click);
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
            this.combo_size.Size = new System.Drawing.Size(278, 20);
            this.combo_size.TabIndex = 0;
            this.combo_size.SelectedIndexChanged += new System.EventHandler(this.combo_size_SelectedIndexChanged);
            // 
            // numeric_quality
            // 
            this.numeric_quality.Location = new System.Drawing.Point(280, 26);
            this.numeric_quality.Name = "numeric_quality";
            this.numeric_quality.Size = new System.Drawing.Size(58, 19);
            this.numeric_quality.TabIndex = 44;
            this.numeric_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_quality.ValueChanged += new System.EventHandler(this.numeric_quality_ValueChanged);
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(85, 22);
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
            this.numeric_height.ValueChanged += new System.EventHandler(this.numeric_wh_ValueChanged);
            // 
            // numeric_width
            // 
            this.numeric_width.Location = new System.Drawing.Point(6, 22);
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
            this.numeric_width.ValueChanged += new System.EventHandler(this.numeric_wh_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "kB";
            // 
            // radio_filesize
            // 
            this.radio_filesize.AutoSize = true;
            this.radio_filesize.Location = new System.Drawing.Point(198, 89);
            this.radio_filesize.Name = "radio_filesize";
            this.radio_filesize.Size = new System.Drawing.Size(92, 16);
            this.radio_filesize.TabIndex = 40;
            this.radio_filesize.Text = "ファイルサイズ：";
            this.radio_filesize.UseVisualStyleBackColor = true;
            this.radio_filesize.CheckedChanged += new System.EventHandler(this.radio_filesize_CheckedChanged);
            // 
            // track_quality
            // 
            this.track_quality.LargeChange = 10;
            this.track_quality.Location = new System.Drawing.Point(198, 51);
            this.track_quality.Maximum = 100;
            this.track_quality.Name = "track_quality";
            this.track_quality.Size = new System.Drawing.Size(215, 45);
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
            this.combo_quality.Location = new System.Drawing.Point(344, 25);
            this.combo_quality.Name = "combo_quality";
            this.combo_quality.Size = new System.Drawing.Size(69, 20);
            this.combo_quality.TabIndex = 38;
            this.combo_quality.SelectedIndexChanged += new System.EventHandler(this.combo_quality_SelectedIndexChanged);
            // 
            // radio_quality
            // 
            this.radio_quality.AutoSize = true;
            this.radio_quality.Checked = true;
            this.radio_quality.Location = new System.Drawing.Point(198, 26);
            this.radio_quality.Name = "radio_quality";
            this.radio_quality.Size = new System.Drawing.Size(78, 16);
            this.radio_quality.TabIndex = 37;
            this.radio_quality.TabStop = true;
            this.radio_quality.Text = "Jpeg画質：";
            this.radio_quality.UseVisualStyleBackColor = true;
            this.radio_quality.CheckedChanged += new System.EventHandler(this.radio_quality_CheckedChanged);
            // 
            // _SizeSettingSeparatorLabel
            // 
            this._SizeSettingSeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._SizeSettingSeparatorLabel.Location = new System.Drawing.Point(189, 19);
            this._SizeSettingSeparatorLabel.MinimumSize = new System.Drawing.Size(0, 104);
            this._SizeSettingSeparatorLabel.Name = "_SizeSettingSeparatorLabel";
            this._SizeSettingSeparatorLabel.Size = new System.Drawing.Size(2, 120);
            this._SizeSettingSeparatorLabel.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "ピクセル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "×";
            // 
            // label_image
            // 
            this.label_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_image.Image = global::cuberesize.Properties.Resources.draghere;
            this.label_image.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_image.Location = new System.Drawing.Point(442, 37);
            this.label_image.MinimumSize = new System.Drawing.Size(128, 128);
            this.label_image.Name = "label_image";
            this.label_image.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.label_image.Size = new System.Drawing.Size(140, 177);
            this.label_image.TabIndex = 25;
            this.label_image.Text = "ここに画像データをドラッグ";
            this.label_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this._SizeSettingGroupBox);
            this.Controls.Add(this._SaveSettingGroupBox);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this._EffectSettingGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CubeImage Resize";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_image_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_image_DragEnter);
            this._EffectSettingGroupBox.ResumeLayout(false);
            this._EffectSettingGroupBox.PerformLayout();
            this._SaveSettingGroupBox.ResumeLayout(false);
            this._SaveSettingGroupBox.PerformLayout();
            this._SizeSettingGroupBox.ResumeLayout(false);
            this._SizeSettingGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_filesize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_quality)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radio_resize_height;
        private System.Windows.Forms.RadioButton radio_resize_width;
        private System.Windows.Forms.RadioButton radio_resize_aspect;
        private System.Windows.Forms.RadioButton radio_resize_force;
        private System.Windows.Forms.CheckBox check_overwrite;
    }
}

