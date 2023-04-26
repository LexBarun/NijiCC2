
namespace NijiCC2
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxInputLine = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.text_LineCharCount = new System.Windows.Forms.Label();
            this.buttonLoadPrimary = new System.Windows.Forms.Button();
            this.gradientPreviewPrimary = new System.Windows.Forms.PictureBox();
            this.buttonCopyOutputLine = new System.Windows.Forms.Button();
            this.boxOutputLine = new System.Windows.Forms.TextBox();
            this.openGradientDialog = new System.Windows.Forms.OpenFileDialog();
            this.gradientPreviewSecondary = new System.Windows.Forms.PictureBox();
            this.buttonLoadSecondary = new System.Windows.Forms.Button();
            this.gradientPreviewOutline = new System.Windows.Forms.PictureBox();
            this.buttonLoadOutline = new System.Windows.Forms.Button();
            this.gradientPreviewShadow = new System.Windows.Forms.PictureBox();
            this.buttonLoadShadow = new System.Windows.Forms.Button();
            this.checkBoxPrimary = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondary = new System.Windows.Forms.CheckBox();
            this.checkBoxOutline = new System.Windows.Forms.CheckBox();
            this.checkBoxShadow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewShadow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lyric:";
            // 
            // boxInputLine
            // 
            this.boxInputLine.Location = new System.Drawing.Point(83, 18);
            this.boxInputLine.Name = "boxInputLine";
            this.boxInputLine.Size = new System.Drawing.Size(418, 23);
            this.boxInputLine.TabIndex = 1;
            this.boxInputLine.TextChanged += new System.EventHandler(this.boxInputLine_TextChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 243);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(614, 37);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // text_LineCharCount
            // 
            this.text_LineCharCount.AutoSize = true;
            this.text_LineCharCount.Location = new System.Drawing.Point(476, 22);
            this.text_LineCharCount.MinimumSize = new System.Drawing.Size(19, 15);
            this.text_LineCharCount.Name = "text_LineCharCount";
            this.text_LineCharCount.Size = new System.Drawing.Size(19, 15);
            this.text_LineCharCount.TabIndex = 8;
            this.text_LineCharCount.Text = "0";
            this.text_LineCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadPrimary
            // 
            this.buttonLoadPrimary.Location = new System.Drawing.Point(12, 47);
            this.buttonLoadPrimary.Name = "buttonLoadPrimary";
            this.buttonLoadPrimary.Size = new System.Drawing.Size(65, 43);
            this.buttonLoadPrimary.TabIndex = 6;
            this.buttonLoadPrimary.Text = "Load Gradient";
            this.buttonLoadPrimary.UseVisualStyleBackColor = true;
            this.buttonLoadPrimary.Click += new System.EventHandler(this.buttonLoadPrimary_Click);
            // 
            // gradientPreviewPrimary
            // 
            this.gradientPreviewPrimary.Location = new System.Drawing.Point(83, 47);
            this.gradientPreviewPrimary.Name = "gradientPreviewPrimary";
            this.gradientPreviewPrimary.Size = new System.Drawing.Size(418, 43);
            this.gradientPreviewPrimary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientPreviewPrimary.TabIndex = 7;
            this.gradientPreviewPrimary.TabStop = false;
            // 
            // buttonCopyOutputLine
            // 
            this.buttonCopyOutputLine.Location = new System.Drawing.Point(551, 286);
            this.buttonCopyOutputLine.Name = "buttonCopyOutputLine";
            this.buttonCopyOutputLine.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyOutputLine.TabIndex = 70;
            this.buttonCopyOutputLine.Text = "Copy Line";
            this.buttonCopyOutputLine.UseVisualStyleBackColor = true;
            this.buttonCopyOutputLine.Click += new System.EventHandler(this.buttonCopyOutputLine_Click);
            // 
            // boxOutputLine
            // 
            this.boxOutputLine.Location = new System.Drawing.Point(12, 286);
            this.boxOutputLine.Name = "boxOutputLine";
            this.boxOutputLine.ReadOnly = true;
            this.boxOutputLine.Size = new System.Drawing.Size(533, 23);
            this.boxOutputLine.TabIndex = 69;
            // 
            // gradientPreviewSecondary
            // 
            this.gradientPreviewSecondary.Location = new System.Drawing.Point(83, 96);
            this.gradientPreviewSecondary.Name = "gradientPreviewSecondary";
            this.gradientPreviewSecondary.Size = new System.Drawing.Size(418, 43);
            this.gradientPreviewSecondary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientPreviewSecondary.TabIndex = 7;
            this.gradientPreviewSecondary.TabStop = false;
            // 
            // buttonLoadSecondary
            // 
            this.buttonLoadSecondary.Location = new System.Drawing.Point(12, 96);
            this.buttonLoadSecondary.Name = "buttonLoadSecondary";
            this.buttonLoadSecondary.Size = new System.Drawing.Size(65, 43);
            this.buttonLoadSecondary.TabIndex = 6;
            this.buttonLoadSecondary.Text = "Load Gradient";
            this.buttonLoadSecondary.UseVisualStyleBackColor = true;
            this.buttonLoadSecondary.Click += new System.EventHandler(this.buttonLoadSecondary_Click);
            // 
            // gradientPreviewOutline
            // 
            this.gradientPreviewOutline.Location = new System.Drawing.Point(83, 145);
            this.gradientPreviewOutline.Name = "gradientPreviewOutline";
            this.gradientPreviewOutline.Size = new System.Drawing.Size(418, 43);
            this.gradientPreviewOutline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientPreviewOutline.TabIndex = 7;
            this.gradientPreviewOutline.TabStop = false;
            // 
            // buttonLoadOutline
            // 
            this.buttonLoadOutline.Location = new System.Drawing.Point(12, 145);
            this.buttonLoadOutline.Name = "buttonLoadOutline";
            this.buttonLoadOutline.Size = new System.Drawing.Size(65, 43);
            this.buttonLoadOutline.TabIndex = 6;
            this.buttonLoadOutline.Text = "Load Gradient";
            this.buttonLoadOutline.UseVisualStyleBackColor = true;
            this.buttonLoadOutline.Click += new System.EventHandler(this.buttonLoadOutline_Click);
            // 
            // gradientPreviewShadow
            // 
            this.gradientPreviewShadow.Location = new System.Drawing.Point(83, 194);
            this.gradientPreviewShadow.Name = "gradientPreviewShadow";
            this.gradientPreviewShadow.Size = new System.Drawing.Size(418, 43);
            this.gradientPreviewShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientPreviewShadow.TabIndex = 7;
            this.gradientPreviewShadow.TabStop = false;
            // 
            // buttonLoadShadow
            // 
            this.buttonLoadShadow.Location = new System.Drawing.Point(12, 194);
            this.buttonLoadShadow.Name = "buttonLoadShadow";
            this.buttonLoadShadow.Size = new System.Drawing.Size(65, 43);
            this.buttonLoadShadow.TabIndex = 6;
            this.buttonLoadShadow.Text = "Load Gradient";
            this.buttonLoadShadow.UseVisualStyleBackColor = true;
            this.buttonLoadShadow.Click += new System.EventHandler(this.buttonLoadShadow_Click);
            // 
            // checkBoxPrimary
            // 
            this.checkBoxPrimary.AutoSize = true;
            this.checkBoxPrimary.Location = new System.Drawing.Point(507, 60);
            this.checkBoxPrimary.Name = "checkBoxPrimary";
            this.checkBoxPrimary.Size = new System.Drawing.Size(105, 19);
            this.checkBoxPrimary.TabIndex = 72;
            this.checkBoxPrimary.Text = "Enable Primary";
            this.checkBoxPrimary.UseVisualStyleBackColor = true;
            // 
            // checkBoxSecondary
            // 
            this.checkBoxSecondary.AutoSize = true;
            this.checkBoxSecondary.Location = new System.Drawing.Point(507, 109);
            this.checkBoxSecondary.Name = "checkBoxSecondary";
            this.checkBoxSecondary.Size = new System.Drawing.Size(119, 19);
            this.checkBoxSecondary.TabIndex = 72;
            this.checkBoxSecondary.Text = "Enable Secondary";
            this.checkBoxSecondary.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutline
            // 
            this.checkBoxOutline.AutoSize = true;
            this.checkBoxOutline.Location = new System.Drawing.Point(507, 158);
            this.checkBoxOutline.Name = "checkBoxOutline";
            this.checkBoxOutline.Size = new System.Drawing.Size(103, 19);
            this.checkBoxOutline.TabIndex = 72;
            this.checkBoxOutline.Text = "Enable Outline";
            this.checkBoxOutline.UseVisualStyleBackColor = true;
            // 
            // checkBoxShadow
            // 
            this.checkBoxShadow.AutoSize = true;
            this.checkBoxShadow.Location = new System.Drawing.Point(507, 207);
            this.checkBoxShadow.Name = "checkBoxShadow";
            this.checkBoxShadow.Size = new System.Drawing.Size(106, 19);
            this.checkBoxShadow.TabIndex = 72;
            this.checkBoxShadow.Text = "Enable Shadow";
            this.checkBoxShadow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 318);
            this.Controls.Add(this.checkBoxShadow);
            this.Controls.Add(this.checkBoxOutline);
            this.Controls.Add(this.checkBoxSecondary);
            this.Controls.Add(this.checkBoxPrimary);
            this.Controls.Add(this.buttonCopyOutputLine);
            this.Controls.Add(this.boxOutputLine);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.text_LineCharCount);
            this.Controls.Add(this.buttonLoadShadow);
            this.Controls.Add(this.gradientPreviewShadow);
            this.Controls.Add(this.buttonLoadOutline);
            this.Controls.Add(this.gradientPreviewOutline);
            this.Controls.Add(this.buttonLoadSecondary);
            this.Controls.Add(this.gradientPreviewSecondary);
            this.Controls.Add(this.buttonLoadPrimary);
            this.Controls.Add(this.gradientPreviewPrimary);
            this.Controls.Add(this.boxInputLine);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPreviewShadow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxInputLine;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label text_LineCharCount;
        private System.Windows.Forms.Button buttonLoadPrimary;
        private System.Windows.Forms.PictureBox gradientPreviewPrimary;
        private System.Windows.Forms.Button buttonCopyOutputLine;
        private System.Windows.Forms.TextBox boxOutputLine;
        private System.Windows.Forms.OpenFileDialog openGradientDialog;
        private System.Windows.Forms.PictureBox gradientPreviewSecondary;
        private System.Windows.Forms.Button buttonLoadSecondary;
        private System.Windows.Forms.PictureBox gradientPreviewOutline;
        private System.Windows.Forms.Button buttonLoadOutline;
        private System.Windows.Forms.PictureBox gradientPreviewShadow;
        private System.Windows.Forms.Button buttonLoadShadow;
        private System.Windows.Forms.CheckBox checkBoxPrimary;
        private System.Windows.Forms.CheckBox checkBoxSecondary;
        private System.Windows.Forms.CheckBox checkBoxOutline;
        private System.Windows.Forms.CheckBox checkBoxShadow;
    }
}

