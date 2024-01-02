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
	public partial class FormBaseMember : Form
	{
		private MemberDto _member;
		private MemberAccountMoneyService _accountService = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		public FormBaseMember(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormHome_Load;
		}

		private void FormHome_Load(object sender, EventArgs e)
		{
			OpenChildForm(new FormMemberBasic(_member));
		}

		private void buttonBasic_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormMemberBasic(_member));
		}



		// 子表單切換
		private Form activeForm = null; // 確認表單是否開啟
		private void OpenChildForm(Form childForm) // 開啟子表單
		{
			if (activeForm != null) activeForm.Close();

			activeForm = childForm; // 若表單未開啟，將表單指名給變數
			childForm.TopLevel = false; // 子表單不能設定為最上層表單
			childForm.FormBorderStyle = FormBorderStyle.None; // 設定子表單無邊框
			childForm.Dock = DockStyle.Fill; // 設定子表單位置
			panelChildForm.Controls.Add(childForm); // 表單加入panel顯示
			panelChildForm.Tag = childForm; // 將標籤設為子表單名
			childForm.BringToFront(); // 將表單放置到前面
			childForm.Show();
		}

		private void buttonInitialize_Click(object sender, EventArgs e)
		{
			// 显示包含两个按钮的消息框
			DialogResult result = MessageBox.Show("確定要初始化帳號嗎？初始化後將無法復原", "初始化帳號", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// 处理用户的响应
			if (result == DialogResult.Yes)
			{
				// 用户点击了"Yes"按钮
				var form = new FormPasswordConfirm(_member, "Initialize");
				form.Owner = this;
				form.ShowDialog();
				this.Owner.Close();
			}
			else if (result == DialogResult.No)
			{
				// 用户点击了"No"按钮
			}
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			// 显示包含两个按钮的消息框
			DialogResult result = MessageBox.Show("確定要移除帳號嗎？移除後將無法復原", "移除帳號", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// 处理用户的响应
			if (result == DialogResult.Yes)
			{
				// 用户点击了"Yes"按钮
				var form = new FormPasswordConfirm(_member, "Delete");
				form.Owner = this;
				form.ShowDialog();
				this.Owner.Close();
			}
			else if (result == DialogResult.No)
			{
				// 用户点击了"No"按钮
			}
			
		}
	}
}
