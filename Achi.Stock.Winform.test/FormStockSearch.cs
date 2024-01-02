using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Interfaces;
using Achi.Stock.Winform.test.Models.Repositories;
using Achi.Stock.Winform.test.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test
{
	public partial class FormStockSearch : Form
	{
		private string _from;
		private MemberDto _member;

		private IStockCompanyRepository GetRepo()
		{
			return new StockCompanyEFRepository();
		}

		public FormStockSearch(MemberDto member, string from)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormStockSearch_Load;
			this.textBoxCode.TextChanged += TextBoxCode_TextChanged;
			this.textBoxName.TextChanged += TextBoxName_TextChanged;

			this.dataGridView1.CellClick += DataGridView1_CellClick;
			_from = from;
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			List<StockCompanyDto> companies = dataGridView1.DataSource as List<StockCompanyDto>;
			int companyId = companies[e.RowIndex].Id;

			if (_from == "Stock")
			{
				var form = new FormStock(_member, companyId);
				form.Owner = this;
				form.ShowDialog();
			}
			else if(_from == "Trade")
			{
				var form = new FormTrade(_member, companyId);
				form.Owner = this;
				form.ShowDialog();
			}
			
		}

		private void TextBoxName_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void TextBoxCode_TextChanged(object sender, EventArgs e)
		{
			Display();
		}

		private void FormStockSearch_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			var service = new StockCompanyService(GetRepo());

			List<StockCompanyDto> companies = service.SearchNameAndCode(textBoxName.Text, textBoxCode.Text);

			dataGridView1.DataSource = companies;
		}
	}
}
