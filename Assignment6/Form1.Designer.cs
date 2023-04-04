namespace Assignment6
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ButtonModify = new Button();
            ButtonDelete = new Button();
            ButtonAdd = new Button();
            panel4 = new Panel();
            ButtonSearch = new Button();
            SearchMessage = new TextBox();
            SelectProperty = new ComboBox();
            OrderDetailSource = new BindingSource(components);
            OrderSource = new BindingSource(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            OrderDetailGridView2 = new DataGridView();
            goodsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OrderGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDetailSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDetailGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ButtonModify);
            panel1.Controls.Add(ButtonDelete);
            panel1.Controls.Add(ButtonAdd);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 101);
            panel1.TabIndex = 0;
            // 
            // ButtonModify
            // 
            ButtonModify.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonModify.Location = new Point(254, 51);
            ButtonModify.Name = "ButtonModify";
            ButtonModify.Size = new Size(97, 42);
            ButtonModify.TabIndex = 3;
            ButtonModify.Text = "修改订单";
            ButtonModify.UseVisualStyleBackColor = true;
            ButtonModify.Click += Modify_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonDelete.Location = new Point(133, 51);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(97, 42);
            ButtonDelete.TabIndex = 2;
            ButtonDelete.Text = "删除订单";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += Delete_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonAdd.Location = new Point(12, 51);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(97, 42);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "增加订单";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += Add_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ButtonSearch);
            panel4.Controls.Add(SearchMessage);
            panel4.Controls.Add(SelectProperty);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(855, 47);
            panel4.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(408, 11);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(98, 29);
            ButtonSearch.TabIndex = 2;
            ButtonSearch.Text = "查询";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += Search_Click;
            // 
            // SearchMessage
            // 
            SearchMessage.Location = new Point(157, 11);
            SearchMessage.Name = "SearchMessage";
            SearchMessage.Size = new Size(221, 27);
            SearchMessage.TabIndex = 1;
            SearchMessage.TextChanged += InputMessage_TextChanged;
            // 
            // SelectProperty
            // 
            SelectProperty.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectProperty.FormattingEnabled = true;
            SelectProperty.Items.AddRange(new object[] { "id", "Customer", "Goods", "TotalPrice" });
            SelectProperty.Location = new Point(12, 11);
            SelectProperty.Name = "SelectProperty";
            SelectProperty.Size = new Size(125, 28);
            SelectProperty.TabIndex = 0;
            // 
            // OrderDetailSource
            // 
            OrderDetailSource.DataMember = "Details";
            OrderDetailSource.DataSource = typeof(OrderApp.Order);
            // 
            // OrderSource
            // 
            OrderSource.DataSource = typeof(OrderApp.Order);
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OrderDetailGridView2, 1, 0);
            tableLayoutPanel1.Controls.Add(OrderGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(857, 378);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // OrderDetailGridView2
            // 
            OrderDetailGridView2.AutoGenerateColumns = false;
            OrderDetailGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDetailGridView2.Columns.AddRange(new DataGridViewColumn[] { goodsDataGridViewTextBoxColumn1, quantityDataGridViewTextBoxColumn1, totalPriceDataGridViewTextBoxColumn1 });
            OrderDetailGridView2.DataSource = OrderDetailSource;
            OrderDetailGridView2.Dock = DockStyle.Fill;
            OrderDetailGridView2.Location = new Point(431, 3);
            OrderDetailGridView2.Name = "OrderDetailGridView2";
            OrderDetailGridView2.RowHeadersWidth = 51;
            OrderDetailGridView2.RowTemplate.Height = 29;
            OrderDetailGridView2.Size = new Size(423, 372);
            OrderDetailGridView2.TabIndex = 1;
            // 
            // goodsDataGridViewTextBoxColumn1
            // 
            goodsDataGridViewTextBoxColumn1.DataPropertyName = "Goods";
            goodsDataGridViewTextBoxColumn1.HeaderText = "Goods";
            goodsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            goodsDataGridViewTextBoxColumn1.Name = "goodsDataGridViewTextBoxColumn1";
            goodsDataGridViewTextBoxColumn1.ReadOnly = true;
            goodsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            quantityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // OrderGridView1
            // 
            OrderGridView1.AutoGenerateColumns = false;
            OrderGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, createTimeDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            OrderGridView1.DataSource = OrderSource;
            OrderGridView1.Dock = DockStyle.Fill;
            OrderGridView1.Location = new Point(3, 3);
            OrderGridView1.Name = "OrderGridView1";
            OrderGridView1.RowHeadersWidth = 51;
            OrderGridView1.RowTemplate.Height = 29;
            OrderGridView1.Size = new Size(422, 372);
            OrderGridView1.TabIndex = 2;
            OrderGridView1.CellClick += OrderGridView1_CellContentClick;
            OrderGridView1.CellContentClick += OrderGridView1_CellContentClick;
            OrderGridView1.CellContentDoubleClick += OrderGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.ReadOnly = true;
            customerDataGridViewTextBoxColumn.Width = 110;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            createTimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 479);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "订单管理系统";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderDetailSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderDetailGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonModify;
        private Button ButtonDelete;
        private Button ButtonAdd;
        private Panel panel4;
        private Button ButtonSearch;
        private TextBox SearchMessage;
        private ComboBox SelectProperty;
        private Panel panel2;
        private BindingSource OrderSource;
        private Panel panel5;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView OrderDataGridView;
        private BindingSource OrderDetailSource;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView OrderDetailGridView2;
        private DataGridView OrderGridView1;
        private DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}