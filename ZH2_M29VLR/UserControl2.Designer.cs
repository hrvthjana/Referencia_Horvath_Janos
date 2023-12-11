namespace ZH2_M29VLR
{
    partial class UserControl2
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
            label2 = new Label();
            lbCustomers = new ListBox();
            txtFilter = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 32);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Szűrés";
            // 
            // lbCustomers
            // 
            lbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(29, 82);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(236, 304);
            lbCustomers.TabIndex = 8;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(29, 53);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(130, 23);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(280, 94);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 57);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(280, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 57);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "-";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(lbCustomers);
            Controls.Add(txtFilter);
            Name = "UserControl2";
            Size = new Size(387, 449);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lbCustomers;
        private TextBox txtFilter;
        private Button btnAdd;
        private Button btnCancel;
    }
}
