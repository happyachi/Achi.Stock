namespace Achi.Stock.Winform.test
{
	partial class FormBaseAccount
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
			this.buttonTotalAccount = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// buttonTotalAccount
			// 
			this.buttonTotalAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTotalAccount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTotalAccount.Location = new System.Drawing.Point(12, 49);
			this.buttonTotalAccount.Name = "buttonTotalAccount";
			this.buttonTotalAccount.Size = new System.Drawing.Size(171, 53);
			this.buttonTotalAccount.TabIndex = 28;
			this.buttonTotalAccount.Text = "總覽";
			this.buttonTotalAccount.UseVisualStyleBackColor = false;
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(189, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1255, 754);
			this.panelChildForm.TabIndex = 29;
			// 
			// FormBaseAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1468, 782);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonTotalAccount);
			this.Name = "FormBaseAccount";
			this.Text = "FormBaseAccount";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonTotalAccount;
		private System.Windows.Forms.Panel panelChildForm;
	}
}