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
	public partial class FormSetNewPassword : Form
	{
		private MemberDto _member;
		private MemberService _serivce = new MemberService(new MemberEFRepository());
		public FormSetNewPassword(MemberDto member)
		{
			InitializeComponent();
			_member = member;


			this.textBoxPassword.Leave += TextBoxPassword_Leave;
			this.textBoxPasswordAgain.Leave += TextBoxPasswordAgain_Leave;
			this.buttonSend.Click += ButtonSend_Click;

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

		private void ButtonSend_Click(object sender, EventArgs e)
		{
			// 確認欄位質是否正確
			// todo 要欄位驗證，是否為空
			if (TextBoxPasswordAgainCheck() &&
				TextBoxPasswordCheck() )
			{
				try
				{
					_member.Password = textBoxPassword.Text;
					// 存進資料庫
					_serivce.Update(_member);
					MessageBox.Show("密碼已更新");

					this.Close();
					this.Owner.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void SetNewPassword_Load(object sender, EventArgs e)
		{
			labelPasswordAgainCheck.Text = string.Empty;
			labelPasswordCheck.Text = string.Empty;
		}

		private void FormSetNewPassword_FormClosed(object sender, FormClosedEventArgs e)
		{
			labelPasswordCheck.Text= string.Empty;
			labelPasswordAgainCheck.Text = string.Empty;
		}
	}
}
