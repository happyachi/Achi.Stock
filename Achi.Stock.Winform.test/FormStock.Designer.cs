namespace Achi.Stock.Winform.test
{
	partial class FormStock
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonWeek = new System.Windows.Forms.Button();
			this.buttonMonth = new System.Windows.Forms.Button();
			this.buttonSeason = new System.Windows.Forms.Button();
			this.buttonYear = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.buttonTrade = new System.Windows.Forms.Button();
			this.labelCode = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(194, 439);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1035, 264);
			this.dataGridView1.TabIndex = 33;
			// 
			// buttonWeek
			// 
			this.buttonWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonWeek.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonWeek.Location = new System.Drawing.Point(12, 227);
			this.buttonWeek.Name = "buttonWeek";
			this.buttonWeek.Size = new System.Drawing.Size(171, 53);
			this.buttonWeek.TabIndex = 29;
			this.buttonWeek.Text = "週線";
			this.buttonWeek.UseVisualStyleBackColor = false;
			// 
			// buttonMonth
			// 
			this.buttonMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonMonth.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonMonth.Location = new System.Drawing.Point(12, 153);
			this.buttonMonth.Name = "buttonMonth";
			this.buttonMonth.Size = new System.Drawing.Size(171, 53);
			this.buttonMonth.TabIndex = 30;
			this.buttonMonth.Text = "月線";
			this.buttonMonth.UseVisualStyleBackColor = false;
			// 
			// buttonSeason
			// 
			this.buttonSeason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonSeason.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSeason.Location = new System.Drawing.Point(12, 82);
			this.buttonSeason.Name = "buttonSeason";
			this.buttonSeason.Size = new System.Drawing.Size(171, 53);
			this.buttonSeason.TabIndex = 31;
			this.buttonSeason.Text = "季線";
			this.buttonSeason.UseVisualStyleBackColor = false;
			// 
			// buttonYear
			// 
			this.buttonYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonYear.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonYear.Location = new System.Drawing.Point(12, 12);
			this.buttonYear.Name = "buttonYear";
			this.buttonYear.Size = new System.Drawing.Size(171, 53);
			this.buttonYear.TabIndex = 32;
			this.buttonYear.Text = "年線";
			this.buttonYear.UseVisualStyleBackColor = false;
			// 
			// chart1
			// 
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart1.Legends.Add(legend3);
			this.chart1.Location = new System.Drawing.Point(194, 10);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(1035, 414);
			this.chart1.TabIndex = 28;
			this.chart1.Text = "chart1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// buttonTrade
			// 
			this.buttonTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.buttonTrade.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonTrade.Location = new System.Drawing.Point(12, 610);
			this.buttonTrade.Name = "buttonTrade";
			this.buttonTrade.Size = new System.Drawing.Size(171, 53);
			this.buttonTrade.TabIndex = 29;
			this.buttonTrade.Text = "交易此股";
			this.buttonTrade.UseVisualStyleBackColor = false;
			// 
			// labelCode
			// 
			this.labelCode.AutoSize = true;
			this.labelCode.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCode.Location = new System.Drawing.Point(23, 497);
			this.labelCode.Name = "labelCode";
			this.labelCode.Size = new System.Drawing.Size(86, 36);
			this.labelCode.TabIndex = 34;
			this.labelCode.Text = "Code";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelName.Location = new System.Drawing.Point(23, 551);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(97, 36);
			this.labelName.TabIndex = 34;
			this.labelName.Text = "Name";
			// 
			// FormStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1237, 712);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelCode);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonTrade);
			this.Controls.Add(this.buttonWeek);
			this.Controls.Add(this.buttonMonth);
			this.Controls.Add(this.buttonSeason);
			this.Controls.Add(this.buttonYear);
			this.Controls.Add(this.chart1);
			this.Name = "FormStock";
			this.Text = "FormStock";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonWeek;
		private System.Windows.Forms.Button buttonMonth;
		private System.Windows.Forms.Button buttonSeason;
		private System.Windows.Forms.Button buttonYear;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button buttonTrade;
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.Label labelName;
	}
}