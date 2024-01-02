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
	public partial class FormMemberBasic : Form
	{
		private MemberDto _memberDto;
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		private MemberLoginDataService _loginDataService = new MemberLoginDataService(new MemberLoginDataEFRopository());

		public FormMemberBasic(MemberDto member)
		{
			InitializeComponent();
			_memberDto = member;

			this.Load += FormMemberBasic_Load;
		}



		private void FormMemberBasic_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void Display()
		{
			_memberDto = _memberService.Get(_memberDto.Id);
			labelName.Text = _memberDto.Name;
			labelBirthday.Text = _memberDto.Birthday.ToString("yyyy 年 MM 月 dd 日");
			labelEmail.Text = _memberDto.Email;
			labelFavorite.Text = _memberDto.FavoriteThing;
			labelRegisterTime.Text = $"{_memberDto.RegisterTime.ToString("yyyy 年 MM 月 dd 日")}\n" +
				$"{_memberDto.RegisterTime.ToString("HH 時 mm 分 ss 秒")}";
			
			var data = _loginDataService.SearchMemberId(_memberDto.Id);

			dataGridView1.DataSource = data;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var form = new FormMemberUpdate(_memberDto);
			form.Owner = this;
			form.ShowDialog();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			var form = new FormMemberUpdatePassword(_memberDto);
			form.Owner = this;
			form.ShowDialog();
		}
	}
}
