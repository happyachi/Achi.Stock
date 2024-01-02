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
	public partial class FormForgetPassword : Form
	{
		private MemberService _serivce = new MemberService(new MemberEFRepository());
		
		public FormForgetPassword()
		{
			InitializeComponent();
			this.Load += FormForgetPassword_Load;

			this.textBoxEmail.Leave += TextBoxEmail_Leave;
			this.textBoxAccount.Leave += TextBoxAccount_Leave;
			this.textBoxFavorite.Leave += TextBoxFavorite_Leave;


			buttonSend.Click += ButtonSend_Click;
		}

		private void FormForgetPassword_Load(object sender, EventArgs e)
		{
			labelAccountCheck.Text = string.Empty;
			labelEmailCheck.Text = string.Empty;
			labelFavoitCheck.Text = string.Empty;
		}

		private void TextBoxFavorite_Leave(object sender, EventArgs e)
		{
			TextBoxFavoriteCheck();
		}

		private void TextBoxAccount_Leave(object sender, EventArgs e)
		{
			TextBoxAccountCheck();
		}

		private void TextBoxEmail_Leave(object sender, EventArgs e)
		{
			TextBoxEmailCheck();
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

		private bool TextBoxAccountCheck()
		{
			try
			{
				string account = textBoxAccount.Text.FormTextAccountAndPasswordCheck();
				labelAccountCheck.Text = string.Empty;
				return true;
			}
			catch (Exception ex)
			{
				labelAccountCheck.Text = ex.Message;
				return false;
			}
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


		private void ButtonSend_Click(object sender, EventArgs e)
		{
			// 確認是否與資料庫相同
			// todo 要欄位驗證，是否為空
			if (TextBoxFavoriteCheck() &&
				TextBoxAccountCheck() &&
				TextBoxEmailCheck())
			{
				string account = textBoxAccount.Text;
				string email = textBoxEmail.Text;
				string favorite = textBoxFavorite.Text;
				try
				{
					MemberDto member = _serivce.GetForgetPassword(account, email, favorite);

					// 如果有過去設定密碼
					var form = new FormSetNewPassword(member);
					form.Owner = this;
					form.ShowDialog();
				}
				catch (Exception ex)
				{
					// 沒過，Messagebox
					MessageBox.Show("驗證錯誤！");
				}
			}
		}
	}
}
