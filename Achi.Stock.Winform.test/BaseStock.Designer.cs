namespace Achi.Stock.Winform.test
{
	partial class BaseStock
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
			this.buttonTAIEX = new System.Windows.Forms.Button();
			this.buttonCommpany = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// buttonTAIEX
			// 
			this.buttonTAIEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTAIEX.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTAIEX.Location = new System.Drawing.Point(12, 12);
			this.buttonTAIEX.Name = "buttonTAIEX";
			this.buttonTAIEX.Size = new System.Drawing.Size(171, 53);
			this.buttonTAIEX.TabIndex = 25;
			this.buttonTAIEX.Text = "大盤";
			this.buttonTAIEX.UseVisualStyleBackColor = false;
			this.buttonTAIEX.Click += new System.EventHandler(this.buttonTAIEX_Click);
			// 
			// buttonCommpany
			// 
			this.buttonCommpany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonCommpany.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCommpany.Location = new System.Drawing.Point(12, 89);
			this.buttonCommpany.Name = "buttonCommpany";
			this.buttonCommpany.Size = new System.Drawing.Size(171, 53);
			this.buttonCommpany.TabIndex = 26;
			this.buttonCommpany.Text = "個股";
			this.buttonCommpany.UseVisualStyleBackColor = false;
			this.buttonCommpany.Click += new System.EventHandler(this.buttonCommpany_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(206, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1255, 749);
			this.panelChildForm.TabIndex = 27;
			// 
			// BaseStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1464, 773);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonCommpany);
			this.Controls.Add(this.buttonTAIEX);
			this.Name = "BaseStock";
			this.Text = "BaseStock";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonTAIEX;
		private System.Windows.Forms.Button buttonCommpany;
		private System.Windows.Forms.Panel panelChildForm;
	}
}