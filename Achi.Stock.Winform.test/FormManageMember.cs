using Achi.Stock.Winform.test.Models.Dtos;
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
	public partial class FormManageMember : Form
	{
		private MemberDto _member;
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		public FormManageMember(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormManageMember_Load;

			this.dataGridView1.CellClick += DataGridView1_CellClick;
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			List<MemberDto> memberList = dataGridView1.DataSource as List<MemberDto>;
			int memberId = memberList[e.RowIndex].Id;

			var form = new FormManageMemberPermission(memberId);
			form.Owner = this;
			form.ShowDialog();
			
		}

		private void FormManageMember_Load(object sender, EventArgs e)
		{
			List<MemberDto> memberList = _memberService.GetAllList();
			dataGridView1.DataSource = memberList;
		}


	}
}
