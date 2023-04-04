namespace Assignment6
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            RemoveButton = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox2 = new GroupBox();
            DetailGridView = new DataGridView();
            goodsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DetailSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreatTime = new TextBox();
            Customer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DetailGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailSource).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(RemoveButton);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 405);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 45);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "添加明细";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(103, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(94, 29);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "删除明细";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "修改明细";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Modify_Click;
            // 
            // button4
            // 
            button4.Location = new Point(303, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "保存订单";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Save_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DetailGridView);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 280);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "订单明细";
            // 
            // DetailGridView
            // 
            DetailGridView.AutoGenerateColumns = false;
            DetailGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetailGridView.Columns.AddRange(new DataGridViewColumn[] { goodsDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            DetailGridView.DataSource = DetailSource;
            DetailGridView.Dock = DockStyle.Fill;
            DetailGridView.Location = new Point(3, 23);
            DetailGridView.Name = "DetailGridView";
            DetailGridView.RowHeadersWidth = 51;
            DetailGridView.RowTemplate.Height = 29;
            DetailGridView.Size = new Size(794, 254);
            DetailGridView.TabIndex = 0;
            DetailGridView.CellClick += DetailGridView_CellContentClick;
            DetailGridView.CellContentClick += DetailGridView_CellContentClick;
            DetailGridView.CellContentDoubleClick += DetailGridView_CellContentClick;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            goodsDataGridViewTextBoxColumn.ReadOnly = true;
            goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
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
            // DetailSource
            // 
            DetailSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "基本信息";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.625F));
            tableLayoutPanel1.Controls.Add(CreatTime, 1, 2);
            tableLayoutPanel1.Controls.Add(Customer, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(794, 99);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CreatTime
            // 
            CreatTime.Anchor = AnchorStyles.Left;
            CreatTime.BorderStyle = BorderStyle.None;
            CreatTime.Location = new Point(102, 71);
            CreatTime.Name = "CreatTime";
            CreatTime.ReadOnly = true;
            CreatTime.Size = new Size(235, 20);
            CreatTime.TabIndex = 5;
            // 
            // Customer
            // 
            Customer.Anchor = AnchorStyles.Left;
            Customer.BorderStyle = BorderStyle.None;
            Customer.Location = new Point(102, 38);
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.Size = new Size(235, 20);
            Customer.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "订单号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 1;
            label2.Text = "客户名";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 65);
            label3.Name = "label3";
            label3.Size = new Size(91, 33);
            label3.TabIndex = 2;
            label3.Text = "下单时间";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(102, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "修改订单";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DetailGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailSource).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox CreatTime;
        private TextBox Customer;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button RemoveButton;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private DataGridView DetailGridView;
        private BindingSource DetailSource;
        private DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}