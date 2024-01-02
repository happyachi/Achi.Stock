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
	public partial class FormManageMemberPermission : Form
	{
		private int _memberId;
		MemberDto _member;
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		public FormManageMemberPermission(int memberId)
		{
			InitializeComponent();
			this._memberId = memberId;

			this.Load += FormManageMemberPermission_Load;
		}

		private void FormManageMemberPermission_Load(object sender, EventArgs e)
		{
			MemberDto member = _memberService.Get(_memberId);
			_member = member;

			if (member.Permission)
			{
				radioButtonYes.Checked = true;
			}
			else 
			{ 
				radioButtonNo.Checked = true; 
			}

			if (member.IsAdmin)
			{
				radioButtonAdmin.Checked = true;
			}
			else
			{
				radioButtonUser.Checked = true;
			}
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			if (radioButtonYes.Checked)
			{
				_member.Permission = true;
			}
			else
			{
				_member.Permission = false;
			}

			if (radioButtonAdmin.Checked)
			{
				_member.IsAdmin = true;
			}
			else
			{
				_member.IsAdmin = false;
			}

			try
			{
				_memberService.Update(_member);
				MessageBox.Show("修改成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			this.Close();
			
		}
	}
}
