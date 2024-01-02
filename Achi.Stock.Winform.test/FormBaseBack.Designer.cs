namespace Achi.Stock.Winform.test
{
	partial class FormBaseBack
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
			this.buttonManageMember = new System.Windows.Forms.Button();
			this.buttonManageStock = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.buttonManageTAIEXS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonManageMember
			// 
			this.buttonManageMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonManageMember.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonManageMember.Location = new System.Drawing.Point(12, 53);
			this.buttonManageMember.Name = "buttonManageMember";
			this.buttonManageMember.Size = new System.Drawing.Size(196, 74);
			this.buttonManageMember.TabIndex = 25;
			this.buttonManageMember.Text = "會員管理";
			this.buttonManageMember.UseVisualStyleBackColor = false;
			this.buttonManageMember.Click += new System.EventHandler(this.buttonManageMember_Click);
			// 
			// buttonManageStock
			// 
			this.buttonManageStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonManageStock.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonManageStock.Location = new System.Drawing.Point(12, 270);
			this.buttonManageStock.Name = "buttonManageStock";
			this.buttonManageStock.Size = new System.Drawing.Size(196, 74);
			this.buttonManageStock.TabIndex = 25;
			this.buttonManageStock.Text = "股票管理";
			this.buttonManageStock.UseVisualStyleBackColor = false;
			this.buttonManageStock.Click += new System.EventHandler(this.buttonManageStock_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(226, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1444, 829);
			this.panelChildForm.TabIndex = 26;
			// 
			// buttonManageTAIEXS
			// 
			this.buttonManageTAIEXS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonManageTAIEXS.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonManageTAIEXS.Location = new System.Drawing.Point(12, 162);
			this.buttonManageTAIEXS.Name = "buttonManageTAIEXS";
			this.buttonManageTAIEXS.Size = new System.Drawing.Size(196, 74);
			this.buttonManageTAIEXS.TabIndex = 25;
			this.buttonManageTAIEXS.Text = "大盤管理";
			this.buttonManageTAIEXS.UseVisualStyleBackColor = false;
			this.buttonManageTAIEXS.Click += new System.EventHandler(this.buttonManageTAIEXS_Click);
			// 
			// FormBaseBack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1682, 853);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonManageTAIEXS);
			this.Controls.Add(this.buttonManageStock);
			this.Controls.Add(this.buttonManageMember);
			this.Name = "FormBaseBack";
			this.Text = "FormBaseBack";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBaseBack_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonManageMember;
		private System.Windows.Forms.Button buttonManageStock;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.Button buttonManageTAIEXS;
	}
}