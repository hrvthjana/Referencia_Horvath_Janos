namespace ZH2_M29VLR
{
    partial class UserControl1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTotal = new TextBox();
            txtFilter = new TextBox();
            lbCustomers = new ListBox();
            lbOrders = new ListBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            sajatClassBindingSource = new BindingSource(components);
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipModeDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sajatClassBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(720, 461);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.Location = new Point(764, 458);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 1;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(38, 49);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(120, 23);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // lbCustomers
            // 
            lbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(38, 78);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(120, 319);
            lbCustomers.TabIndex = 3;
            lbCustomers.SelectedIndexChanged += lbCustomers_SelectedIndexChanged;
            // 
            // lbOrders
            // 
            lbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbOrders.FormattingEnabled = true;
            lbOrders.ItemHeight = 15;
            lbOrders.Location = new Point(188, 78);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(120, 319);
            lbOrders.TabIndex = 4;
            lbOrders.SelectedIndexChanged += lbOrders_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customerNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, subCategoryDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, shipDateDataGridViewTextBoxColumn, shipModeDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sajatClassBindingSource;
            dataGridView1.Location = new Point(331, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(545, 352);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 28);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Szűrés";
            // 
            // sajatClassBindingSource
            // 
            sajatClassBindingSource.DataSource = typeof(SajatClass);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            subCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory";
            subCategoryDataGridViewTextBoxColumn.HeaderText = "SubCategory";
            subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
            shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            // 
            // shipModeDataGridViewTextBoxColumn
            // 
            shipModeDataGridViewTextBoxColumn.DataPropertyName = "shipMode";
            shipModeDataGridViewTextBoxColumn.DataSource = sajatClassBindingSource;
            shipModeDataGridViewTextBoxColumn.DisplayMember = "shipMode";
            shipModeDataGridViewTextBoxColumn.HeaderText = "shipMode";
            shipModeDataGridViewTextBoxColumn.Name = "shipModeDataGridViewTextBoxColumn";
            shipModeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            shipModeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            salesDataGridViewTextBoxColumn.DataPropertyName = "Sales";
            salesDataGridViewTextBoxColumn.HeaderText = "Sales";
            salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(lbOrders);
            Controls.Add(lbCustomers);
            Controls.Add(txtFilter);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(900, 499);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sajatClassBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTotal;
        private TextBox txtFilter;
        private ListBox lbCustomers;
        private ListBox lbOrders;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn shipModeDataGridViewTextBoxColumn;
        private BindingSource sajatClassBindingSource;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
    }
}
