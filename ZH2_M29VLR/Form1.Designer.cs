namespace ZH2_M29VLR
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
            brnUc1 = new Button();
            btnUc2 = new Button();
            btnUc3 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // brnUc1
            // 
            brnUc1.Location = new Point(12, 30);
            brnUc1.Name = "brnUc1";
            brnUc1.Size = new Size(124, 23);
            brnUc1.TabIndex = 0;
            brnUc1.Text = "Rendelés adatok";
            brnUc1.UseVisualStyleBackColor = true;
            brnUc1.Click += brnUc1_Click;
            // 
            // btnUc2
            // 
            btnUc2.Location = new Point(12, 68);
            btnUc2.Name = "btnUc2";
            btnUc2.Size = new Size(124, 23);
            btnUc2.TabIndex = 1;
            btnUc2.Text = "Vevő +/-";
            btnUc2.UseVisualStyleBackColor = true;
            btnUc2.Click += btnUc2_Click;
            // 
            // btnUc3
            // 
            btnUc3.Location = new Point(12, 107);
            btnUc3.Name = "btnUc3";
            btnUc3.Size = new Size(124, 23);
            btnUc3.TabIndex = 2;
            btnUc3.Text = "Adatvizualizáció";
            btnUc3.UseVisualStyleBackColor = true;
            btnUc3.Click += btnUc3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(167, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 509);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 551);
            Controls.Add(panel1);
            Controls.Add(btnUc3);
            Controls.Add(btnUc2);
            Controls.Add(brnUc1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button brnUc1;
        private Button btnUc2;
        private Button btnUc3;
        private Panel panel1;
    }
}