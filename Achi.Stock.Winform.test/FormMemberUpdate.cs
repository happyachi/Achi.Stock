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
	public partial class FormMemberUpdate : Form
	{
		private MemberDto _member;
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		public FormMemberUpdate(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormMemberUpdate_Load;

			this.textBoxName.Leave += TextBoxName_Leave;
			this.textBoxEmail.Leave += TextBoxEmail_Leave;
			this.textBoxFavorite.Leave += TextBoxFavorite_Leave;
		}

		private void FormMemberUpdate_Load(object sender, EventArgs e)
		{
			labelFavoitCheck.Text = string.Empty;
			labelEmailCheck.Text = string.Empty;
			labelNameCheck.Text = string.Empty;
		}

		private void TextBoxFavorite_Leave(object sender, EventArgs e)
		{
			TextBoxFavoriteCheck();
		}
		private bool TextBoxFavoriteCheck()
		{
			try
			{
				string favorite = textBoxFavorite.Text.FormTextInputCheck();
				labelFavoitCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelFavoitCheck.Text = ex.Message;
				return false;
			}
		}

		private void TextBoxEmail_Leave(object sender, EventArgs e)
		{
			TextBoxEmailCheck();
		}
		private bool TextBoxEmailCheck()
		{
			try
			{
				string favorite = textBoxEmail.Text.FormTextInputCheck();
				labelEmailCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelEmailCheck.Text = ex.Message;
				return false;
			}
		}

		private void TextBoxName_Leave(object sender, EventArgs e)
		{
			TextBoxNameCheck();
		}
		private bool TextBoxNameCheck()
		{
			try
			{
				string favorite = textBoxName.Text.FormTextInputCheck();
				labelNameCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelNameCheck.Text = ex.Message;
				return false;
			}
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			// todo 要欄位驗證，是否為空
			if (TextBoxFavoriteCheck() &&
				TextBoxEmailCheck() &&
				TextBoxNameCheck())
			{
				try
				{
					_member.FavoriteThing = textBoxFavorite.Text;
					_member.Name = textBoxName.Text;
					_member.Email = textBoxEmail.Text;

					_memberService.Update(_member);

					MessageBox.Show("更新成功！");

					this.Owner.Close();
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}


	}
}
