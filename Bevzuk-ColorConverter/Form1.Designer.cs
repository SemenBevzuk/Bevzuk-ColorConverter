namespace Bevzuk_ColorConverter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHue = new System.Windows.Forms.Label();
            this.buttonHue = new System.Windows.Forms.Button();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.buttonSaturation = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.checkBoxHalfImage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 861);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1701, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(1088, 85);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(48, 20);
            this.labelHue.TabIndex = 2;
            this.labelHue.Text = "Цвет";
            // 
            // buttonHue
            // 
            this.buttonHue.Location = new System.Drawing.Point(1506, 85);
            this.buttonHue.Name = "buttonHue";
            this.buttonHue.Size = new System.Drawing.Size(131, 30);
            this.buttonHue.TabIndex = 3;
            this.buttonHue.Text = "Применить";
            this.buttonHue.UseVisualStyleBackColor = true;
            this.buttonHue.Click += new System.EventHandler(this.buttonHue_Click);
            // 
            // trackBarHue
            // 
            this.trackBarHue.LargeChange = 30;
            this.trackBarHue.Location = new System.Drawing.Point(1185, 85);
            this.trackBarHue.Maximum = 180;
            this.trackBarHue.Minimum = -180;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(295, 69);
            this.trackBarHue.SmallChange = 10;
            this.trackBarHue.TabIndex = 4;
            this.trackBarHue.TickFrequency = 10;
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(1088, 273);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(73, 20);
            this.labelBrightness.TabIndex = 5;
            this.labelBrightness.Text = "Яркость";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.LargeChange = 30;
            this.trackBarBrightness.Location = new System.Drawing.Point(1185, 273);
            this.trackBarBrightness.Maximum = 50;
            this.trackBarBrightness.Minimum = -50;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(295, 69);
            this.trackBarBrightness.SmallChange = 10;
            this.trackBarBrightness.TabIndex = 6;
            this.trackBarBrightness.TickFrequency = 10;
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Location = new System.Drawing.Point(1506, 273);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(131, 30);
            this.buttonBrightness.TabIndex = 7;
            this.buttonBrightness.Text = "Применить";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(1088, 178);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(81, 20);
            this.labelSaturation.TabIndex = 8;
            this.labelSaturation.Text = "Контраст";
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.LargeChange = 30;
            this.trackBarSaturation.Location = new System.Drawing.Point(1185, 178);
            this.trackBarSaturation.Maximum = 50;
            this.trackBarSaturation.Minimum = -50;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(295, 69);
            this.trackBarSaturation.SmallChange = 10;
            this.trackBarSaturation.TabIndex = 9;
            this.trackBarSaturation.TickFrequency = 10;
            // 
            // buttonSaturation
            // 
            this.buttonSaturation.Location = new System.Drawing.Point(1506, 178);
            this.buttonSaturation.Name = "buttonSaturation";
            this.buttonSaturation.Size = new System.Drawing.Size(131, 30);
            this.buttonSaturation.TabIndex = 10;
            this.buttonSaturation.Text = "Применить";
            this.buttonSaturation.UseVisualStyleBackColor = true;
            this.buttonSaturation.Click += new System.EventHandler(this.buttonSaturation_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(1185, 443);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(311, 109);
            this.buttonUndo.TabIndex = 11;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // checkBoxHalfImage
            // 
            this.checkBoxHalfImage.AutoSize = true;
            this.checkBoxHalfImage.Location = new System.Drawing.Point(1185, 365);
            this.checkBoxHalfImage.Name = "checkBoxHalfImage";
            this.checkBoxHalfImage.Size = new System.Drawing.Size(301, 24);
            this.checkBoxHalfImage.TabIndex = 14;
            this.checkBoxHalfImage.Text = "Обработка половины изображения";
            this.checkBoxHalfImage.UseVisualStyleBackColor = true;
            this.checkBoxHalfImage.CheckedChanged += new System.EventHandler(this.checkBoxHalfImage_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 936);
            this.Controls.Add(this.checkBoxHalfImage);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonSaturation);
            this.Controls.Add(this.trackBarSaturation);
            this.Controls.Add(this.labelSaturation);
            this.Controls.Add(this.buttonBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBarHue);
            this.Controls.Add(this.buttonHue);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Button buttonHue;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.Button buttonSaturation;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.CheckBox checkBoxHalfImage;
    }
}

