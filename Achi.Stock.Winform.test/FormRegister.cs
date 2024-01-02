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
	public partial class FormRegister : Form
	{
		private MemberService _serivce = new MemberService(new MemberEFRepository());
		private MemberAccountMoneyService _accountMoneySerivce = new MemberAccountMoneyService(new MemberAccountMoneyEFRepository());
		public FormRegister()
		{
			InitializeComponent();

			this.Load += Register_Load;
			this.buttonRegister.Click += ButtonRegister_Click;

			this.textBoxName.Leave += TextBoxName_Leave;
			this.dateTimePickerBirthday.Leave += DateTimePickerBirthday_Leave;
			this.textBoxEmail.Leave += TextBoxEmail_Leave;
			this.textBoxAccount.Leave += TextBoxAccount_Leave;
			this.textBoxPassword.Leave += TextBoxPassword_Leave;
			this.textBoxPasswordAgain.Leave += TextBoxPasswordAgain_Leave;
			this.textBoxFavorite.Leave += TextBoxFavorite_Leave;
			
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

		private void TextBoxPasswordAgain_Leave(object sender, EventArgs e)
		{
			TextBoxPasswordAgainCheck();
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

		private void TextBoxPassword_Leave(object sender, EventArgs e)
		{
			TextBoxPasswordCheck();
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

		private void TextBoxAccount_Leave(object sender, EventArgs e)
		{
			TextBoxAccountCheck();
		}
		private bool TextBoxAccountCheck()
		{
			try
			{
				string account = textBoxAccount.Text.FormTextAccountAndPasswordCheck();
				labelAccountCheck.Text = string.Empty;
				
			}
			catch (Exception ex)
			{
				labelAccountCheck.Text = ex.Message;
				return false;
			}

			if (_serivce.CheckAccountNotExist(textBoxAccount.Text))
			{
				return true;
			}
			else
			{
				labelAccountCheck.Text = "此帳號已被註冊！";
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

		private void DateTimePickerBirthday_Leave(object sender, EventArgs e)
		{
			DateTimePickerBirthdayCheck();
		}
		private bool DateTimePickerBirthdayCheck()
		{
			if (dateTimePickerBirthday.Value >= DateTime.Today)
			{
				labelBirthdayCheck.Text = "日期不得大於等於今天";
				return false;
			}
			else
			{
				labelBirthdayCheck.Text = string.Empty;
				return true;
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


		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			// todo 要欄位驗證，是否為空
			if(TextBoxFavoriteCheck() &&
				TextBoxPasswordAgainCheck() &&
				TextBoxPasswordCheck() &&
				TextBoxAccountCheck() &&
				TextBoxEmailCheck() &&
				TextBoxNameCheck() &&
				DateTimePickerBirthdayCheck())
			{
				try
				{
					MemberDto dto = new MemberDto
					{
						Name = textBoxName.Text,
						Account = textBoxAccount.Text,
						Password = textBoxPassword.Text,
						Birthday = dateTimePickerBirthday.Value,
						Email = textBoxEmail.Text,
						FavoriteThing = textBoxFavorite.Text,
						RegisterTime = DateTime.Now,
						Permission = true,
						IsAdmin = false,
					};
					// 進資料庫建立會員
					int newId = _serivce.Creat(dto);

					// 要同時建立金錢帳戶
					MemberAccountMoneyDto accountDto = new MemberAccountMoneyDto
					{
						MemberId = newId,
						OriginalAccount = 1000000,
						LatestAccount = 1000000,
					};
					int countId = _accountMoneySerivce.Creat(accountDto);

					MessageBox.Show($"註冊完成！");
					// 要關閉自己
					this.Close();

				}
				catch (Exception ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
			}
			// todo 要欄位驗證 確認密碼是否一樣
			// todo 生日是否小於 NOW 
			// 將錯誤顯示於欄位旁

			
		}

		private void Register_Load(object sender, EventArgs e)
		{
			this.Text = "註冊";
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;

			this.labelEmailCheck.Text = string.Empty;
			this.labelAccountCheck.Text = string.Empty;
			this.labelPasswordCheck.Text = string.Empty;
			this.labelPasswordAgainCheck.Text = string.Empty;
			this.labelFavoitCheck.Text = string.Empty;
			this.labelBirthdayCheck.Text = string.Empty;
			this.labelAccountCheck.Text = string.Empty;
			this.labelNameCheck.Text = string.Empty;
		}

		private void FormRegister_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}


	}
}
