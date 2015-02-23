namespace RegexGetColumnNames
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.labelRegex = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelRegexError = new System.Windows.Forms.Label();
            this.labelFormatError = new System.Windows.Forms.Label();
            this.labelResultCount = new System.Windows.Forms.Label();
            this.checkBoxDuplicates = new System.Windows.Forms.CheckBox();
            this.checkBoxReplace = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 31);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(1093, 407);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.WordWrap = false;
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRegex.Location = new System.Drawing.Point(54, 444);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(973, 20);
            this.textBoxRegex.TabIndex = 1;
            this.textBoxRegex.TextChanged += new System.EventHandler(this.textBoxRegex_TextChanged);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 533);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(1093, 140);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.WordWrap = false;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFormat.Location = new System.Drawing.Point(54, 476);
            this.textBoxFormat.Multiline = true;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(973, 51);
            this.textBoxFormat.TabIndex = 3;
            this.textBoxFormat.TextChanged += new System.EventHandler(this.textBoxFormat_TextChanged);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(1111, 609);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxResults.Location = new System.Drawing.Point(1111, 31);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.ReadOnly = true;
            this.richTextBoxResults.Size = new System.Drawing.Size(394, 407);
            this.richTextBoxResults.TabIndex = 5;
            this.richTextBoxResults.Text = "";
            this.richTextBoxResults.WordWrap = false;
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Location = new System.Drawing.Point(10, 447);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(38, 13);
            this.labelRegex.TabIndex = 6;
            this.labelRegex.Text = "Regex";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(9, 476);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(39, 13);
            this.labelFormat.TabIndex = 7;
            this.labelFormat.Text = "Format";
            // 
            // labelRegexError
            // 
            this.labelRegexError.AutoSize = true;
            this.labelRegexError.ForeColor = System.Drawing.Color.Red;
            this.labelRegexError.Location = new System.Drawing.Point(1033, 451);
            this.labelRegexError.Name = "labelRegexError";
            this.labelRegexError.Size = new System.Drawing.Size(72, 13);
            this.labelRegexError.TabIndex = 8;
            this.labelRegexError.Text = "Invalid Regex";
            this.labelRegexError.Visible = false;
            // 
            // labelFormatError
            // 
            this.labelFormatError.AutoSize = true;
            this.labelFormatError.ForeColor = System.Drawing.Color.Red;
            this.labelFormatError.Location = new System.Drawing.Point(1033, 478);
            this.labelFormatError.Name = "labelFormatError";
            this.labelFormatError.Size = new System.Drawing.Size(73, 13);
            this.labelFormatError.TabIndex = 9;
            this.labelFormatError.Text = "Invalid Format";
            this.labelFormatError.Visible = false;
            // 
            // labelResultCount
            // 
            this.labelResultCount.AutoSize = true;
            this.labelResultCount.Location = new System.Drawing.Point(1108, 9);
            this.labelResultCount.Name = "labelResultCount";
            this.labelResultCount.Size = new System.Drawing.Size(48, 13);
            this.labelResultCount.TabIndex = 10;
            this.labelResultCount.Text = "Results: ";
            // 
            // checkBoxDuplicates
            // 
            this.checkBoxDuplicates.AutoSize = true;
            this.checkBoxDuplicates.Location = new System.Drawing.Point(1111, 451);
            this.checkBoxDuplicates.Name = "checkBoxDuplicates";
            this.checkBoxDuplicates.Size = new System.Drawing.Size(115, 17);
            this.checkBoxDuplicates.TabIndex = 11;
            this.checkBoxDuplicates.Text = "Ignore Duplicates?";
            this.checkBoxDuplicates.UseVisualStyleBackColor = true;
            this.checkBoxDuplicates.CheckedChanged += new System.EventHandler(this.checkBoxDuplicates_CheckedChanged);
            // 
            // checkBoxReplace
            // 
            this.checkBoxReplace.AutoSize = true;
            this.checkBoxReplace.Location = new System.Drawing.Point(1114, 518);
            this.checkBoxReplace.Name = "checkBoxReplace";
            this.checkBoxReplace.Size = new System.Drawing.Size(72, 17);
            this.checkBoxReplace.TabIndex = 12;
            this.checkBoxReplace.Text = "Replace?";
            this.checkBoxReplace.UseVisualStyleBackColor = true;
            this.checkBoxReplace.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 691);
            this.Controls.Add(this.checkBoxReplace);
            this.Controls.Add(this.checkBoxDuplicates);
            this.Controls.Add(this.labelResultCount);
            this.Controls.Add(this.labelFormatError);
            this.Controls.Add(this.labelRegexError);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelRegex);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.richTextBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelRegexError;
        private System.Windows.Forms.Label labelFormatError;
        private System.Windows.Forms.Label labelResultCount;
        private System.Windows.Forms.CheckBox checkBoxDuplicates;
        private System.Windows.Forms.CheckBox checkBoxReplace;
    }
}

