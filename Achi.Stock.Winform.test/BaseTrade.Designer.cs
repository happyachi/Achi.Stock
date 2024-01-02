namespace Achi.Stock.Winform.test
{
	partial class BaseTrade
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
			this.buttonTrade = new System.Windows.Forms.Button();
			this.buttonTradeData = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// buttonTrade
			// 
			this.buttonTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTrade.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTrade.Location = new System.Drawing.Point(12, 12);
			this.buttonTrade.Name = "buttonTrade";
			this.buttonTrade.Size = new System.Drawing.Size(171, 53);
			this.buttonTrade.TabIndex = 27;
			this.buttonTrade.Text = "交易";
			this.buttonTrade.UseVisualStyleBackColor = false;
			this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
			// 
			// buttonTradeData
			// 
			this.buttonTradeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTradeData.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTradeData.Location = new System.Drawing.Point(12, 81);
			this.buttonTradeData.Name = "buttonTradeData";
			this.buttonTradeData.Size = new System.Drawing.Size(171, 53);
			this.buttonTradeData.TabIndex = 27;
			this.buttonTradeData.Text = "交易紀錄";
			this.buttonTradeData.UseVisualStyleBackColor = false;
			this.buttonTradeData.Click += new System.EventHandler(this.buttonTradeData_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(197, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1255, 749);
			this.panelChildForm.TabIndex = 28;
			// 
			// BaseTrade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1464, 773);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonTradeData);
			this.Controls.Add(this.buttonTrade);
			this.Name = "BaseTrade";
			this.Text = "BaseTrade";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonTrade;
		private System.Windows.Forms.Button buttonTradeData;
		private System.Windows.Forms.Panel panelChildForm;
	}
}