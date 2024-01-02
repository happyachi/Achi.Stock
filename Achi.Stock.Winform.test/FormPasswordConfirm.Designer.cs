namespace Achi.Stock.Winform.test
{
	partial class FormPasswordConfirm
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
			this.labelPasswordAgainCheck = new System.Windows.Forms.Label();
			this.labelPasswordCheck = new System.Windows.Forms.Label();
			this.textBoxPasswordAgain = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonSend = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPasswordAgainCheck
			// 
			this.labelPasswordAgainCheck.AutoSize = true;
			this.labelPasswordAgainCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPasswordAgainCheck.ForeColor = System.Drawing.Color.Red;
			this.labelPasswordAgainCheck.Location = new System.Drawing.Point(205, 237);
			this.labelPasswordAgainCheck.Name = "labelPasswordAgainCheck";
			this.labelPasswordAgainCheck.Size = new System.Drawing.Size(95, 22);
			this.labelPasswordAgainCheck.TabIndex = 43;
			this.labelPasswordAgainCheck.Text = "密碼再確認";
			// 
			// labelPasswordCheck
			// 
			this.labelPasswordCheck.AutoSize = true;
			this.labelPasswordCheck.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPasswordCheck.ForeColor = System.Drawing.Color.Red;
			this.labelPasswordCheck.Location = new System.Drawing.Point(205, 161);
			this.labelPasswordCheck.Name = "labelPasswordCheck";
			this.labelPasswordCheck.Size = new System.Drawing.Size(44, 22);
			this.labelPasswordCheck.TabIndex = 42;
			this.labelPasswordCheck.Text = "密碼";
			// 
			// textBoxPasswordAgain
			// 
			this.textBoxPasswordAgain.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPasswordAgain.Location = new System.Drawing.Point(209, 191);
			this.textBoxPasswordAgain.Name = "textBoxPasswordAgain";
			this.textBoxPasswordAgain.Size = new System.Drawing.Size(210, 43);
			this.textBoxPasswordAgain.TabIndex = 38;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(20, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(183, 36);
			this.label6.TabIndex = 40;
			this.label6.Text = "再次確認密碼";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPassword.Location = new System.Drawing.Point(209, 115);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(210, 43);
			this.textBoxPassword.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(119, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 36);
			this.label5.TabIndex = 41;
			this.label5.Text = "密碼";
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSend.Location = new System.Drawing.Point(119, 312);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(300, 53);
			this.buttonSend.TabIndex = 39;
			this.buttonSend.Text = "送出";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// FormPasswordConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 450);
			this.Controls.Add(this.labelPasswordAgainCheck);
			this.Controls.Add(this.labelPasswordCheck);
			this.Controls.Add(this.textBoxPasswordAgain);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonSend);
			this.Name = "FormPasswordConfirm";
			this.Text = "FormPasswordConfirm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPasswordAgainCheck;
		private System.Windows.Forms.Label labelPasswordCheck;
		private System.Windows.Forms.TextBox textBoxPasswordAgain;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonSend;
	}
}