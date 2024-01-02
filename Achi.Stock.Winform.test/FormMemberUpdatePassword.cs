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
	public partial class FormMemberUpdatePassword : Form
	{
		private MemberDto _member;
		private MemberService _serivce = new MemberService(new MemberEFRepository());

		public FormMemberUpdatePassword(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += FormMemberUpdatePassword_Load;
			this.textBoxOrdPassword.Leave += TextBoxOrdPassword_Leave;
			this.textBoxPassword.Leave += TextBoxPassword_Leave;
			this.textBoxPasswordAgain.Leave += TextBoxPasswordAgain_Leave;
			this.buttonSend.Click += ButtonSend_Click;
		}

		private void FormMemberUpdatePassword_Load(object sender, EventArgs e)
		{
			labelOrdPasswordCheck.Text = string.Empty;
			labelPasswordCheck.Text = string.Empty;
			labelPasswordAgainCheck.Text = string.Empty;
		}

		private void TextBoxOrdPassword_Leave(object sender, EventArgs e)
		{
			TextBoxOrdPasswordCheck();
		}
		private bool TextBoxOrdPasswordCheck()
		{
			try
			{
				string account = textBoxOrdPassword.Text.FormTextAccountAndPasswordCheck();
				labelOrdPasswordCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelOrdPasswordCheck.Text = ex.Message;
				return false;
			}
		}
		private void ButtonSend_Click(object sender, EventArgs e)
		{
			// 確認欄位質是否正確
			// todo 要欄位驗證，是否為空
			if (TextBoxPasswordAgainCheck() &&
				TextBoxPasswordCheck() &&
				TextBoxOrdPasswordCheck())
			{

				if(_member.Password != textBoxOrdPassword.Text)
				{
					labelOrdPasswordCheck.Text = "密碼錯誤！";
					MessageBox.Show("密碼錯誤!");
					return;
				}
				try
				{
					_member.Password = textBoxPassword.Text;
					// 存進資料庫
					_serivce.Update(_member);
					MessageBox.Show("密碼已更新");

					this.Close();
					this.Owner.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void TextBoxPassword_Leave(object sender, EventArgs e)
		{
			TextBoxPasswordCheck();
		}

		private void TextBoxPasswordAgain_Leave(object sender, EventArgs e)
		{
			TextBoxPasswordAgainCheck();
		}
		private bool TextBoxPasswordCheck()
		{
			try
			{
				string account = textBoxPassword.Text.FormTextAccountAndPasswordCheck();
				labelPasswordCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelPasswordCheck.Text = ex.Message;
				return false;
			}
		}
		private bool TextBoxPasswordAgainCheck()
		{
			try
			{
				string favorite = textBoxPasswordAgain.Text.FormTextAccountAndPasswordCheck();
				labelPasswordAgainCheck.Text = string.Empty;

			}
			catch (Exception ex)
			{
				labelPasswordAgainCheck.Text = ex.Message;
				return false;
			}

			if (textBoxPasswordAgain.Text != textBoxPassword.Text)
			{
				labelPasswordAgainCheck.Text = "二次密碼輸入不一樣";
				return false;
			}
			else
			{
				labelPasswordAgainCheck.Text = string.Empty;
				return true;
			}
		}

	}
}
