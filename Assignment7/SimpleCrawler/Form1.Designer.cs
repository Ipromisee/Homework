namespace Assignment7
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
            state = new Label();
            label2 = new Label();
            Start = new Button();
            Result = new DataGridView();
            starturl = new TextBox();
            label1 = new Label();
            DataCrawler = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCrawler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(state);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Start);
            panel1.Controls.Add(Result);
            panel1.Controls.Add(starturl);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 484);
            panel1.TabIndex = 0;
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(176, 112);
            state.Name = "state";
            state.Size = new Size(0, 20);
            state.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "爬取信息";
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Start.Location = new Point(480, 70);
            Start.Name = "Start";
            Start.Size = new Size(94, 29);
            Start.TabIndex = 3;
            Start.Text = "爬取";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Result
            // 
            Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Result.Location = new Point(101, 135);
            Result.Name = "Result";
            Result.RowHeadersWidth = 51;
            Result.RowTemplate.Height = 29;
            Result.Size = new Size(473, 244);
            Result.TabIndex = 2;
            // 
            // starturl
            // 
            starturl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            starturl.Location = new Point(173, 70);
            starturl.Name = "starturl";
            starturl.Size = new Size(295, 27);
            starturl.TabIndex = 1;
            starturl.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(101, 73);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "爬取网址";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 484);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "网址爬虫";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Result).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCrawler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView Result;
        private TextBox starturl;
        private Label label1;
        private BindingSource DataCrawler;
        private Button Start;
        private Label label2;
        private Label state;
    }
}