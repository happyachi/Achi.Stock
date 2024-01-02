namespace Achi.Stock.Winform.test
{
	partial class FormTAIEX
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonYear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonSeason = new System.Windows.Forms.Button();
			this.buttonMonth = new System.Windows.Forms.Button();
			this.buttonWeek = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
			// 
			// chart1
			// 
			this.chart1.BorderSkin.BorderWidth = 2;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(199, 12);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(1035, 414);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// buttonYear
			// 
			this.buttonYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonYear.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonYear.Location = new System.Drawing.Point(12, 12);
			this.buttonYear.Name = "buttonYear";
			this.buttonYear.Size = new System.Drawing.Size(171, 53);
			this.buttonYear.TabIndex = 26;
			this.buttonYear.Text = "年線";
			this.buttonYear.UseVisualStyleBackColor = false;
			this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(199, 441);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1035, 264);
			this.dataGridView1.TabIndex = 27;
			// 
			// buttonSeason
			// 
			this.buttonSeason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonSeason.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSeason.Location = new System.Drawing.Point(12, 82);
			this.buttonSeason.Name = "buttonSeason";
			this.buttonSeason.Size = new System.Drawing.Size(171, 53);
			this.buttonSeason.TabIndex = 26;
			this.buttonSeason.Text = "季線";
			this.buttonSeason.UseVisualStyleBackColor = false;
			this.buttonSeason.Click += new System.EventHandler(this.buttonSeason_Click);
			// 
			// buttonMonth
			// 
			this.buttonMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonMonth.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonMonth.Location = new System.Drawing.Point(12, 153);
			this.buttonMonth.Name = "buttonMonth";
			this.buttonMonth.Size = new System.Drawing.Size(171, 53);
			this.buttonMonth.TabIndex = 26;
			this.buttonMonth.Text = "月線";
			this.buttonMonth.UseVisualStyleBackColor = false;
			this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
			// 
			// buttonWeek
			// 
			this.buttonWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonWeek.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonWeek.Location = new System.Drawing.Point(12, 227);
			this.buttonWeek.Name = "buttonWeek";
			this.buttonWeek.Size = new System.Drawing.Size(171, 53);
			this.buttonWeek.TabIndex = 26;
			this.buttonWeek.Text = "週線";
			this.buttonWeek.UseVisualStyleBackColor = false;
			this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
			// 
			// FormTAIEX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1237, 712);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonWeek);
			this.Controls.Add(this.buttonMonth);
			this.Controls.Add(this.buttonSeason);
			this.Controls.Add(this.buttonYear);
			this.Controls.Add(this.chart1);
			this.Name = "FormTAIEX";
			this.Text = "FormTAIEX";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button buttonYear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonSeason;
		private System.Windows.Forms.Button buttonMonth;
		private System.Windows.Forms.Button buttonWeek;
	}
}