namespace ZH2_M29VLR
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbSegment = new ComboBox();
            cbPostal = new ComboBox();
            label4 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            txtName.Validated += txtName_Validated;
            // 
            // txtId
            // 
            txtId.Location = new Point(21, 101);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            txtId.Validating += txtId_Validating;
            txtId.Validated += txtId_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 143);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Segment";
            // 
            // cbSegment
            // 
            cbSegment.FormattingEnabled = true;
            cbSegment.Location = new Point(21, 161);
            cbSegment.Name = "cbSegment";
            cbSegment.Size = new Size(121, 23);
            cbSegment.TabIndex = 5;
            // 
            // cbPostal
            // 
            cbPostal.FormattingEnabled = true;
            cbPostal.Location = new Point(21, 218);
            cbPostal.Name = "cbPostal";
            cbPostal.Size = new Size(121, 23);
            cbPostal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 200);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Postal code";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.CausesValidation = false;
            btnOK.Location = new Point(169, 345);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.CausesValidation = false;
            btnCancel.Location = new Point(250, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 380);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cbPostal);
            Controls.Add(label4);
            Controls.Add(cbSegment);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtName;
        public TextBox txtId;
        private Label label2;
        private Label label3;
        public ComboBox cbSegment;
        public ComboBox cbPostal;
        private Label label4;
        private Button btnOK;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}