namespace ZH2_M29VLR
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGenerate = new Button();
            radioCategory = new RadioButton();
            radioState = new RadioButton();
            radioSegment = new RadioButton();
            radioYear = new RadioButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 562);
            panel1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Location = new Point(934, 40);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(121, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // radioCategory
            // 
            radioCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioCategory.AutoSize = true;
            radioCategory.Checked = true;
            radioCategory.Location = new Point(934, 69);
            radioCategory.Name = "radioCategory";
            radioCategory.Size = new Size(73, 19);
            radioCategory.TabIndex = 2;
            radioCategory.TabStop = true;
            radioCategory.Text = "Category";
            radioCategory.UseVisualStyleBackColor = true;
            // 
            // radioState
            // 
            radioState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioState.AutoSize = true;
            radioState.Location = new Point(934, 94);
            radioState.Name = "radioState";
            radioState.Size = new Size(51, 19);
            radioState.TabIndex = 3;
            radioState.Text = "State";
            radioState.UseVisualStyleBackColor = true;
            // 
            // radioSegment
            // 
            radioSegment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioSegment.AutoSize = true;
            radioSegment.Location = new Point(935, 119);
            radioSegment.Name = "radioSegment";
            radioSegment.Size = new Size(72, 19);
            radioSegment.TabIndex = 4;
            radioSegment.Text = "Segment";
            radioSegment.UseVisualStyleBackColor = true;
            // 
            // radioYear
            // 
            radioYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioYear.AutoSize = true;
            radioYear.Location = new Point(934, 144);
            radioYear.Name = "radioYear";
            radioYear.Size = new Size(47, 19);
            radioYear.TabIndex = 5;
            radioYear.Text = "Year";
            radioYear.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(radioYear);
            Controls.Add(radioSegment);
            Controls.Add(radioState);
            Controls.Add(radioCategory);
            Controls.Add(btnGenerate);
            Controls.Add(panel1);
            Name = "UserControl3";
            Size = new Size(1081, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGenerate;
        private RadioButton radioCategory;
        private RadioButton radioState;
        private RadioButton radioSegment;
        private RadioButton radioYear;
    }
}
