namespace Achi.Stock.Winform.test
{
	partial class FormLogin
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.buttonForgetPassword = new System.Windows.Forms.Button();
			this.labelAccountCheck = new System.Windows.Forms.Label();
			this.labelPasswordCheck = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(202, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號";
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxAccount.Location = new System.Drawing.Point(292, 133);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(210, 43);
			this.textBoxAccount.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(202, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 36);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPassword.Location = new System.Drawing.Point(292, 203);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(210, 43);
			this.textBoxPassword.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(164, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(262, 50);
			this.label3.TabIndex = 0;
			this.label3.Text = "模擬交易平台";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonLogin.Location = new System.Drawing.Point(154, 297);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(379, 53);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "登入";
			this.buttonLogin.UseVisualStyleBackColor = true;
			// 
			// buttonRegister
			// 
			this.buttonRegister.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonRegister.Location = new System.Drawing.Point(154, 396);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(182, 53);
			this.buttonRegister.TabIndex = 3;
			this.buttonRegister.Text = "註冊";
			this.buttonRegister.UseVisualStyleBackColor = true;
			// 
			// buttonForgetPassword
			// 
			this.buttonForgetPassword.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonForgetPassword.Location = new System.Drawing.Point(351, 396);
			this.buttonForgetPassword.Name = "buttonForgetPassword";
			this.buttonForgetPassword.Size = new System.Drawing.Size(182, 53);
			this.buttonForgetPassword.TabIndex = 4;
			this.buttonForgetPassword.Text = "忘記密碼";
			this.buttonForgetPassword.UseVisualStyleBackColor = true;
			// 
			// labelAccountCheck
			// 
			this.labelAccountCheck.AutoSize = true;
			this.labelAccountCheck.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelAccountCheck.ForeColor = System.Drawing.Color.Red;
			this.labelAccountCheck.Location = new System.Drawing.Point(518, 141);
			this.labelAccountCheck.Name = "labelAccountCheck";
			this.labelAccountCheck.Size = new System.Drawing.Size(71, 36);
			this.labelAccountCheck.TabIndex = 0;
			this.labelAccountCheck.Text = "帳號";
			// 
			// labelPasswordCheck
			// 
			this.labelPasswordCheck.AutoSize = true;
			this.labelPasswordCheck.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPasswordCheck.ForeColor = System.Drawing.Color.Red;
			this.labelPasswordCheck.Location = new System.Drawing.Point(518, 212);
			this.labelPasswordCheck.Name = "labelPasswordCheck";
			this.labelPasswordCheck.Size = new System.Drawing.Size(71, 36);
			this.labelPasswordCheck.TabIndex = 0;
			this.labelPasswordCheck.Text = "密碼";
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 507);
			this.Controls.Add(this.buttonForgetPassword);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelPasswordCheck);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxAccount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelAccountCheck);
			this.Controls.Add(this.label1);
			this.Name = "FormLogin";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Button buttonForgetPassword;
		private System.Windows.Forms.Label labelAccountCheck;
		private System.Windows.Forms.Label labelPasswordCheck;
	}
}

