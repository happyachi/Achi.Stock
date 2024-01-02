namespace Achi.Stock.Winform.test
{
	partial class FormTradeDataSearch
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.labelCode = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerStrat = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.buttonSale = new System.Windows.Forms.Button();
			this.buttonAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(11, 181);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(218, 34);
			this.textBoxName.TabIndex = 6;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelName.Location = new System.Drawing.Point(6, 134);
			this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(82, 29);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "公司名";
			// 
			// textBoxCode
			// 
			this.textBoxCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxCode.Location = new System.Drawing.Point(11, 73);
			this.textBoxCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(218, 34);
			this.textBoxCode.TabIndex = 7;
			// 
			// labelCode
			// 
			this.labelCode.AutoSize = true;
			this.labelCode.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCode.Location = new System.Drawing.Point(6, 26);
			this.labelCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelCode.Name = "labelCode";
			this.labelCode.Size = new System.Drawing.Size(105, 29);
			this.labelCode.TabIndex = 5;
			this.labelCode.Text = "股票代號";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(254, 15);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(976, 682);
			this.dataGridView1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(6, 252);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "起始日期";
			// 
			// dateTimePickerStrat
			// 
			this.dateTimePickerStrat.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerStrat.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerStrat.Location = new System.Drawing.Point(11, 300);
			this.dateTimePickerStrat.Name = "dateTimePickerStrat";
			this.dateTimePickerStrat.Size = new System.Drawing.Size(218, 38);
			this.dateTimePickerStrat.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(7, 360);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "結束日期";
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerEnd.Location = new System.Drawing.Point(12, 408);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(218, 38);
			this.dateTimePickerEnd.TabIndex = 8;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonBuy.Location = new System.Drawing.Point(8, 477);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(104, 57);
			this.buttonBuy.TabIndex = 10;
			this.buttonBuy.Text = "買";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
			// 
			// buttonSale
			// 
			this.buttonSale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSale.Location = new System.Drawing.Point(129, 477);
			this.buttonSale.Name = "buttonSale";
			this.buttonSale.Size = new System.Drawing.Size(101, 57);
			this.buttonSale.TabIndex = 10;
			this.buttonSale.Text = "賣";
			this.buttonSale.UseVisualStyleBackColor = true;
			this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
			// 
			// buttonAll
			// 
			this.buttonAll.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAll.Location = new System.Drawing.Point(12, 555);
			this.buttonAll.Name = "buttonAll";
			this.buttonAll.Size = new System.Drawing.Size(218, 53);
			this.buttonAll.TabIndex = 10;
			this.buttonAll.Text = "全部";
			this.buttonAll.UseVisualStyleBackColor = true;
			this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
			// 
			// FormTradeDataSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 712);
			this.Controls.Add(this.buttonSale);
			this.Controls.Add(this.buttonAll);
			this.Controls.Add(this.buttonBuy);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.dateTimePickerStrat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.labelCode);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormTradeDataSearch";
			this.Text = "FormTradeDataSearch";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerStrat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.Button buttonSale;
		private System.Windows.Forms.Button buttonAll;
	}
}