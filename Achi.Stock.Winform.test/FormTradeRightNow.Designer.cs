namespace Achi.Stock.Winform.test
{
	partial class FormTradeRightNow
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
			this.buttonSend = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelBuyOrSellCheck = new System.Windows.Forms.Label();
			this.radioButtonSale = new System.Windows.Forms.RadioButton();
			this.radioButtonBuy = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.labelAmountCheck = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSend.Location = new System.Drawing.Point(265, 432);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(143, 50);
			this.buttonSend.TabIndex = 23;
			this.buttonSend.Text = "送出";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelBuyOrSellCheck);
			this.panel1.Controls.Add(this.radioButtonSale);
			this.panel1.Controls.Add(this.radioButtonBuy);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 64);
			this.panel1.TabIndex = 22;
			// 
			// labelBuyOrSellCheck
			// 
			this.labelBuyOrSellCheck.AutoSize = true;
			this.labelBuyOrSellCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelBuyOrSellCheck.ForeColor = System.Drawing.Color.Red;
			this.labelBuyOrSellCheck.Location = new System.Drawing.Point(130, 42);
			this.labelBuyOrSellCheck.Name = "labelBuyOrSellCheck";
			this.labelBuyOrSellCheck.Size = new System.Drawing.Size(61, 22);
			this.labelBuyOrSellCheck.TabIndex = 24;
			this.labelBuyOrSellCheck.Text = "買或賣";
			// 
			// radioButtonSale
			// 
			this.radioButtonSale.AutoSize = true;
			this.radioButtonSale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonSale.Location = new System.Drawing.Point(216, 11);
			this.radioButtonSale.Name = "radioButtonSale";
			this.radioButtonSale.Size = new System.Drawing.Size(57, 33);
			this.radioButtonSale.TabIndex = 0;
			this.radioButtonSale.TabStop = true;
			this.radioButtonSale.Text = "賣";
			this.radioButtonSale.UseVisualStyleBackColor = true;
			// 
			// radioButtonBuy
			// 
			this.radioButtonBuy.AutoSize = true;
			this.radioButtonBuy.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonBuy.Location = new System.Drawing.Point(134, 11);
			this.radioButtonBuy.Name = "radioButtonBuy";
			this.radioButtonBuy.Size = new System.Drawing.Size(57, 33);
			this.radioButtonBuy.TabIndex = 0;
			this.radioButtonBuy.TabStop = true;
			this.radioButtonBuy.Text = "買";
			this.radioButtonBuy.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(11, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "買或賣";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(335, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 29);
			this.label6.TabIndex = 18;
			this.label6.Text = "張";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(23, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 29);
			this.label5.TabIndex = 20;
			this.label5.Text = "數量";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxAmount.Location = new System.Drawing.Point(146, 92);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(182, 38);
			this.textBoxAmount.TabIndex = 21;
			// 
			// labelAmountCheck
			// 
			this.labelAmountCheck.AutoSize = true;
			this.labelAmountCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelAmountCheck.ForeColor = System.Drawing.Color.Red;
			this.labelAmountCheck.Location = new System.Drawing.Point(142, 133);
			this.labelAmountCheck.Name = "labelAmountCheck";
			this.labelAmountCheck.Size = new System.Drawing.Size(44, 22);
			this.labelAmountCheck.TabIndex = 24;
			this.labelAmountCheck.Text = "數量";
			// 
			// FormTradeRightNow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 579);
			this.Controls.Add(this.labelAmountCheck);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxAmount);
			this.Name = "FormTradeRightNow";
			this.Text = "FormTradeRightNow";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonSale;
		private System.Windows.Forms.RadioButton radioButtonBuy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label labelAmountCheck;
		private System.Windows.Forms.Label labelBuyOrSellCheck;
	}
}