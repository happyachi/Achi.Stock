namespace Achi.Stock.Winform.test
{
	partial class FormBaseMember
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
			this.buttonBasic = new System.Windows.Forms.Button();
			this.buttonInitialize = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.eventLog1 = new System.Diagnostics.EventLog();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBasic
			// 
			this.buttonBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonBasic.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonBasic.Location = new System.Drawing.Point(12, 27);
			this.buttonBasic.Name = "buttonBasic";
			this.buttonBasic.Size = new System.Drawing.Size(171, 53);
			this.buttonBasic.TabIndex = 28;
			this.buttonBasic.Text = "基本資料";
			this.buttonBasic.UseVisualStyleBackColor = false;
			this.buttonBasic.Click += new System.EventHandler(this.buttonBasic_Click);
			// 
			// buttonInitialize
			// 
			this.buttonInitialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonInitialize.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonInitialize.Location = new System.Drawing.Point(12, 638);
			this.buttonInitialize.Name = "buttonInitialize";
			this.buttonInitialize.Size = new System.Drawing.Size(171, 53);
			this.buttonInitialize.TabIndex = 28;
			this.buttonInitialize.Text = "初始化帳戶";
			this.buttonInitialize.UseVisualStyleBackColor = false;
			this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonRemove.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonRemove.Location = new System.Drawing.Point(12, 717);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(171, 53);
			this.buttonRemove.TabIndex = 28;
			this.buttonRemove.Text = "移除帳號";
			this.buttonRemove.UseVisualStyleBackColor = false;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(201, 12);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(1255, 749);
			this.panelChildForm.TabIndex = 29;
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// FormBaseMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1468, 782);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonInitialize);
			this.Controls.Add(this.buttonBasic);
			this.Name = "FormBaseMember";
			this.Text = "FormHome";
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonBasic;
		private System.Windows.Forms.Button buttonInitialize;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Diagnostics.EventLog eventLog1;
	}
}