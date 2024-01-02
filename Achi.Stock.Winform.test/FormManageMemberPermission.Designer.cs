namespace Achi.Stock.Winform.test
{
	partial class FormManageMemberPermission
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioButtonYes = new System.Windows.Forms.RadioButton();
			this.radioButtonNo = new System.Windows.Forms.RadioButton();
			this.radioButtonUser = new System.Windows.Forms.RadioButton();
			this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
			this.buttonSend = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(50, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "登入權限";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(50, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 45);
			this.label2.TabIndex = 0;
			this.label2.Text = "管理權限";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonNo);
			this.panel1.Controls.Add(this.radioButtonYes);
			this.panel1.Location = new System.Drawing.Point(56, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(564, 100);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioButtonUser);
			this.panel2.Controls.Add(this.radioButtonAdmin);
			this.panel2.Location = new System.Drawing.Point(56, 278);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(564, 100);
			this.panel2.TabIndex = 1;
			// 
			// radioButtonYes
			// 
			this.radioButtonYes.AutoSize = true;
			this.radioButtonYes.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonYes.Location = new System.Drawing.Point(25, 33);
			this.radioButtonYes.Name = "radioButtonYes";
			this.radioButtonYes.Size = new System.Drawing.Size(129, 41);
			this.radioButtonYes.TabIndex = 2;
			this.radioButtonYes.TabStop = true;
			this.radioButtonYes.Text = "可使用";
			this.radioButtonYes.UseVisualStyleBackColor = true;
			// 
			// radioButtonNo
			// 
			this.radioButtonNo.AutoSize = true;
			this.radioButtonNo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonNo.Location = new System.Drawing.Point(257, 33);
			this.radioButtonNo.Name = "radioButtonNo";
			this.radioButtonNo.Size = new System.Drawing.Size(100, 41);
			this.radioButtonNo.TabIndex = 2;
			this.radioButtonNo.TabStop = true;
			this.radioButtonNo.Text = "停權";
			this.radioButtonNo.UseVisualStyleBackColor = true;
			// 
			// radioButtonUser
			// 
			this.radioButtonUser.AutoSize = true;
			this.radioButtonUser.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonUser.Location = new System.Drawing.Point(257, 38);
			this.radioButtonUser.Name = "radioButtonUser";
			this.radioButtonUser.Size = new System.Drawing.Size(186, 41);
			this.radioButtonUser.TabIndex = 3;
			this.radioButtonUser.TabStop = true;
			this.radioButtonUser.Text = "一般使用者";
			this.radioButtonUser.UseVisualStyleBackColor = true;
			// 
			// radioButtonAdmin
			// 
			this.radioButtonAdmin.AutoSize = true;
			this.radioButtonAdmin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radioButtonAdmin.Location = new System.Drawing.Point(25, 38);
			this.radioButtonAdmin.Name = "radioButtonAdmin";
			this.radioButtonAdmin.Size = new System.Drawing.Size(129, 41);
			this.radioButtonAdmin.TabIndex = 4;
			this.radioButtonAdmin.TabStop = true;
			this.radioButtonAdmin.Text = "管理者";
			this.radioButtonAdmin.UseVisualStyleBackColor = true;
			// 
			// buttonSend
			// 
			this.buttonSend.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSend.Location = new System.Drawing.Point(336, 395);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(284, 60);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "確認儲存";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// FormManageMemberPermission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 490);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormManageMemberPermission";
			this.Text = "FormManageMemberPermission";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonNo;
		private System.Windows.Forms.RadioButton radioButtonYes;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton radioButtonUser;
		private System.Windows.Forms.RadioButton radioButtonAdmin;
		private System.Windows.Forms.Button buttonSend;
	}
}