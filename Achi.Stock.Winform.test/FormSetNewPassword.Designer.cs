namespace Achi.Stock.Winform.test
{
	partial class FormSetNewPassword
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPasswordAgain = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.labelPasswordCheck = new System.Windows.Forms.Label();
			this.labelPasswordAgainCheck = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSend.Location = new System.Drawing.Point(170, 466);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(300, 53);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "送出";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(210, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 50);
			this.label1.TabIndex = 24;
			this.label1.Text = "設定新密碼";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(65, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(262, 50);
			this.label3.TabIndex = 25;
			this.label3.Text = "模擬交易平台";
			// 
			// textBoxPasswordAgain
			// 
			this.textBoxPasswordAgain.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPasswordAgain.Location = new System.Drawing.Point(260, 345);
			this.textBoxPasswordAgain.Name = "textBoxPasswordAgain";
			this.textBoxPasswordAgain.Size = new System.Drawing.Size(210, 43);
			this.textBoxPasswordAgain.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(71, 348);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(183, 36);
			this.label6.TabIndex = 33;
			this.label6.Text = "再次確認密碼";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPassword.Location = new System.Drawing.Point(260, 269);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(210, 43);
			this.textBoxPassword.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(170, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 36);
			this.label5.TabIndex = 34;
			this.label5.Text = "密碼";
			// 
			// labelPasswordCheck
			// 
			this.labelPasswordCheck.AutoSize = true;
			this.labelPasswordCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPasswordCheck.ForeColor = System.Drawing.Color.Red;
			this.labelPasswordCheck.Location = new System.Drawing.Point(256, 315);
			this.labelPasswordCheck.Name = "labelPasswordCheck";
			this.labelPasswordCheck.Size = new System.Drawing.Size(44, 22);
			this.labelPasswordCheck.TabIndex = 35;
			this.labelPasswordCheck.Text = "密碼";
			// 
			// labelPasswordAgainCheck
			// 
			this.labelPasswordAgainCheck.AutoSize = true;
			this.labelPasswordAgainCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPasswordAgainCheck.ForeColor = System.Drawing.Color.Red;
			this.labelPasswordAgainCheck.Location = new System.Drawing.Point(256, 391);
			this.labelPasswordAgainCheck.Name = "labelPasswordAgainCheck";
			this.labelPasswordAgainCheck.Size = new System.Drawing.Size(95, 22);
			this.labelPasswordAgainCheck.TabIndex = 36;
			this.labelPasswordAgainCheck.Text = "密碼再確認";
			// 
			// FormSetNewPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 638);
			this.Controls.Add(this.labelPasswordAgainCheck);
			this.Controls.Add(this.labelPasswordCheck);
			this.Controls.Add(this.textBoxPasswordAgain);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Name = "FormSetNewPassword";
			this.Text = "SetNewPassword";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetNewPassword_FormClosed);
			this.Load += new System.EventHandler(this.SetNewPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPasswordAgain;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelPasswordCheck;
		private System.Windows.Forms.Label labelPasswordAgainCheck;
	}
}