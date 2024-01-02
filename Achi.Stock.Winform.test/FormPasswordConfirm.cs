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
	public partial class FormPasswordConfirm : Form
	{
		private MemberDto _member;
		private MemberService _serivce = new MemberService(new MemberEFRepository());
		private string _choosed;
		public FormPasswordConfirm(MemberDto member, string choosed)
		{
			InitializeComponent();
			_member = member;
			_choosed = choosed;

			this.Load += FormPasswordConfirm_Load;

			this.textBoxPassword.Leave += TextBoxPassword_Leave;
			this.textBoxPasswordAgain.Leave += TextBoxPasswordAgain_Leave;
			this.buttonSend.Click += ButtonSend_Click;
		}

		private void FormPasswordConfirm_Load(object sender, EventArgs e)
		{
			labelPasswordCheck.Text = string.Empty;
			labelPasswordAgainCheck.Text = string.Empty;
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
				TextBoxPasswordCheck())
			{
				try
				{
					if(_member.Password == textBoxPassword.Text)
					{
						if(_choosed == "Initialize")
						{
							_serivce.Initialize(_member.Id);
							MessageBox.Show("密碼正確，帳戶已初始化，請重新登入");
							this.Close();
							
						}
						else if (_choosed == "Delete")
						{
							_serivce.Delete(_member.Id);
							MessageBox.Show("密碼正確，帳戶已移除");
							this.Close();
						}
					}
					else
					{
						MessageBox.Show("密碼錯誤");
						this.Close();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}


	}
}
