using Achi.Stock.Winform.test.Models.Dtos;
using Achi.Stock.Winform.test.Models.Repositories;
using Achi.Stock.Winform.test.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi.Stock.Winform.test
{
	public partial class FormLogin : Form
	{
		private MemberService _memberService = new MemberService(new MemberEFRepository());
		private MemberLoginDataService _loginService = new MemberLoginDataService(new MemberLoginDataEFRopository());
		public FormLogin()
		{
			InitializeComponent();
			

			this.buttonLogin.Click += ButtonLogin_Click;
			this.buttonRegister.Click += ButtonRegister_Click;
			this.buttonForgetPassword.Click += ButtonForgetPassword_Click;

			this.textBoxAccount.Leave += TextBoxAccount_Leave;
			this.textBoxPassword.Leave += TextBoxPassword_Leave;

			this.textBoxAccount.KeyDown += TextBoxAccount_KeyDown;
			this.textBoxPassword.KeyDown += TextBoxPassword_KeyDown;
		}

		private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.SelectNextControl(this.ActiveControl, true, true, true, true);
			}
		}

		private void TextBoxAccount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.SelectNextControl(this.ActiveControl, true, true, true, true);
			}
		}

		private void TextBoxPassword_Leave(object sender, EventArgs e)
		{
			try
			{
				string password = textBoxPassword.Text.FormTextAccountAndPasswordCheck();
				labelPasswordCheck.Text = string.Empty;
			}
			catch (Exception ex)
			{
				labelPasswordCheck.Text = ex.Message;
				return;
			}
		}

		private void TextBoxAccount_Leave(object sender, EventArgs e)
		{
			try
			{
				string account = textBoxAccount.Text.FormTextAccountAndPasswordCheck();
				labelAccountCheck.Text = string.Empty;
			}
			catch (Exception ex)
			{
				labelAccountCheck.Text = ex.Message;
				return;
			}
		}

		private void ButtonForgetPassword_Click(object sender, EventArgs e)
		{
			var form = new FormForgetPassword();
			form.Owner = this;
			form.ShowDialog();

			
			CleanCheckText();
		}

		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			var form = new FormRegister();
			form.Owner = this;
			form.ShowDialog();

			CleanCheckText();
			//this.Hide(); // 不要close自己	，而是隱藏，否則系統會結束
		}

		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			string account=string.Empty, password= string.Empty;
			// todo 檢查帳密是否有填寫、欄位驗證
			try
			{
				account = textBoxAccount.Text.FormTextAccountAndPasswordCheck();
				labelAccountCheck.Text = string.Empty;
			}
			catch (Exception ex)
			{
				labelAccountCheck.Text = ex.Message;
				return;
			}

			try
			{
				password = textBoxPassword.Text.FormTextAccountAndPasswordCheck();
				labelPasswordCheck.Text = string.Empty;
			}
			catch (Exception ex)
			{
				labelPasswordCheck.Text = ex.Message;
				return;
			}

			MemberDto dto = new MemberDto();
			try
			{
				// todo 叫用 SecurityService.Valid() 判斷帳密是否正確
				dto = _memberService.GetByAccountAndPassword(account, password);
			}
			catch (Exception ex)
			{
				string msg = "帳號或密碼錯誤";
				labelAccountCheck.Text = msg;
				labelPasswordCheck.Text = msg;
				return;
			}

			try
			{
				IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
				var ippaddress =
					host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);

				MemberLoginDataDto loginDataDto = new MemberLoginDataDto
				{
					MemberId = dto.Id,
					Datetime = DateTime.Now,
					IP = ippaddress.ToString()
				};
				_loginService.Creat(loginDataDto);
			}
			catch (Exception ex)
			{
				// MessageBox.Show(ex.Message);
			}

			if (dto.IsAdmin)
			{
				var form = new FormAdminLoginChoose(dto);
				form.Owner = this;
				form.Show();
			}
			else
			{
				// 若正確，顯示 FormMain(傳帳號過去)，清空自己的textbox，並隱藏自己(不可以關閉自己)
				var form = new FormBase(dto);
				form.Owner = this;
				form.Show();
			}
			CleanCheckText();
			this.Hide(); // 不要close自己	，而是隱藏，否則系統會結束
		}

		private void login_Load(object sender, EventArgs e)
		{
			labelAccountCheck.Text = string.Empty;
			labelPasswordCheck.Text = string.Empty;
		}

		private void CleanCheckText()
		{
			textBoxAccount.Text = string.Empty;
			textBoxPassword.Text = string.Empty;
			labelAccountCheck.Text = string.Empty;
			labelPasswordCheck.Text = string.Empty;
		}
	}
}
