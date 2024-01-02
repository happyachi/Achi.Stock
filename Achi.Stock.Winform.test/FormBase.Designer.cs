namespace Achi.Stock.Winform.test
{
	partial class FormBase
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
			this.buttonStock = new System.Windows.Forms.Button();
			this.buttonTrade = new System.Windows.Forms.Button();
			this.buttonAccount = new System.Windows.Forms.Button();
			this.buttonMember = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.buttonRanking = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonStock
			// 
			this.buttonStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonStock.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonStock.Location = new System.Drawing.Point(12, 71);
			this.buttonStock.Name = "buttonStock";
			this.buttonStock.Size = new System.Drawing.Size(171, 53);
			this.buttonStock.TabIndex = 24;
			this.buttonStock.Text = "股票";
			this.buttonStock.UseVisualStyleBackColor = false;
			this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
			// 
			// buttonTrade
			// 
			this.buttonTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTrade.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTrade.Location = new System.Drawing.Point(12, 130);
			this.buttonTrade.Name = "buttonTrade";
			this.buttonTrade.Size = new System.Drawing.Size(171, 53);
			this.buttonTrade.TabIndex = 24;
			this.buttonTrade.Text = "交易";
			this.buttonTrade.UseVisualStyleBackColor = false;
			this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
			// 
			// buttonAccount
			// 
			this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonAccount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAccount.Location = new System.Drawing.Point(12, 12);
			this.buttonAccount.Name = "buttonAccount";
			this.buttonAccount.Size = new System.Drawing.Size(171, 53);
			this.buttonAccount.TabIndex = 24;
			this.buttonAccount.Text = "帳戶紀錄";
			this.buttonAccount.UseVisualStyleBackColor = false;
			this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
			// 
			// buttonMember
			// 
			this.buttonMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonMember.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonMember.Location = new System.Drawing.Point(12, 779);
			this.buttonMember.Name = "buttonMember";
			this.buttonMember.Size = new System.Drawing.Size(171, 53);
			this.buttonMember.TabIndex = 24;
			this.buttonMember.Text = "會員";
			this.buttonMember.UseVisualStyleBackColor = false;
			this.buttonMember.Click += new System.EventHandler(this.buttonMember_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelChildForm.Location = new System.Drawing.Point(200, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1482, 820);
			this.panelChildForm.TabIndex = 25;
			// 
			// buttonRanking
			// 
			this.buttonRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonRanking.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonRanking.Location = new System.Drawing.Point(12, 189);
			this.buttonRanking.Name = "buttonRanking";
			this.buttonRanking.Size = new System.Drawing.Size(171, 53);
			this.buttonRanking.TabIndex = 26;
			this.buttonRanking.Text = "排名";
			this.buttonRanking.UseVisualStyleBackColor = false;
			this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
			// 
			// FormBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1682, 853);
			this.Controls.Add(this.buttonRanking);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonMember);
			this.Controls.Add(this.buttonAccount);
			this.Controls.Add(this.buttonTrade);
			this.Controls.Add(this.buttonStock);
			this.Name = "FormBase";
			this.Text = "Base";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBase_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonStock;
		private System.Windows.Forms.Button buttonTrade;
		private System.Windows.Forms.Button buttonAccount;
		private System.Windows.Forms.Button buttonMember;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.Button buttonRanking;
	}
}