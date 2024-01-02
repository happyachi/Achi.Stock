namespace Achi.Stock.Winform.test
{
	partial class FormUseApiGetStockPrice
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
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerStrat = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(58, 312);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(206, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "開始新增";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerEnd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerEnd.Location = new System.Drawing.Point(58, 189);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(218, 38);
			this.dateTimePickerEnd.TabIndex = 38;
			// 
			// dateTimePickerStrat
			// 
			this.dateTimePickerStrat.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerStrat.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerStrat.Location = new System.Drawing.Point(57, 81);
			this.dateTimePickerStrat.Name = "dateTimePickerStrat";
			this.dateTimePickerStrat.Size = new System.Drawing.Size(218, 38);
			this.dateTimePickerStrat.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(53, 141);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 29);
			this.label2.TabIndex = 36;
			this.label2.Text = "結束日期";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(52, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 29);
			this.label1.TabIndex = 37;
			this.label1.Text = "起始日期";
			// 
			// FormUseApiGetStockPrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 411);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.dateTimePickerStrat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "FormUseApiGetStockPrice";
			this.Text = "FormApiGetStockPrice";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUseApiGetStockPrice_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.DateTimePicker dateTimePickerStrat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}