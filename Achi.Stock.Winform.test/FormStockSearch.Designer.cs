namespace Achi.Stock.Winform.test
{
	partial class FormStockSearch
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.labelCode = new System.Windows.Forms.Label();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(177, 15);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1056, 682);
			this.dataGridView1.TabIndex = 0;
			// 
			// labelCode
			// 
			this.labelCode.AutoSize = true;
			this.labelCode.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCode.Location = new System.Drawing.Point(9, 26);
			this.labelCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelCode.Name = "labelCode";
			this.labelCode.Size = new System.Drawing.Size(105, 29);
			this.labelCode.TabIndex = 1;
			this.labelCode.Text = "股票代號";
			// 
			// textBoxCode
			// 
			this.textBoxCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxCode.Location = new System.Drawing.Point(14, 73);
			this.textBoxCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(146, 34);
			this.textBoxCode.TabIndex = 2;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelName.Location = new System.Drawing.Point(9, 134);
			this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(103, 36);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "公司名";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxName.Location = new System.Drawing.Point(14, 181);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(146, 34);
			this.textBoxName.TabIndex = 2;
			// 
			// FormStockSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1237, 712);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.labelCode);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "FormStockSearch";
			this.Text = "FormStockSearch";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
	}
}