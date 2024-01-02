namespace Achi.Stock.Winform.test
{
	partial class FormAdminLoginChoose
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
			this.buttonFront = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonFront
			// 
			this.buttonFront.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonFront.Location = new System.Drawing.Point(177, 107);
			this.buttonFront.Name = "buttonFront";
			this.buttonFront.Size = new System.Drawing.Size(181, 136);
			this.buttonFront.TabIndex = 0;
			this.buttonFront.Text = "前台";
			this.buttonFront.UseVisualStyleBackColor = true;
			this.buttonFront.Click += new System.EventHandler(this.buttonFront_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonBack.Location = new System.Drawing.Point(392, 107);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(181, 136);
			this.buttonBack.TabIndex = 0;
			this.buttonBack.Text = "後台";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// FormAdminLoginChoose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonFront);
			this.Name = "FormAdminLoginChoose";
			this.Text = "FormAdminLogin";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonFront;
		private System.Windows.Forms.Button buttonBack;
	}
}