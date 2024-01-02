using Achi.Stock.Winform.test.Models.Dtos;
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
	public partial class FormAdminLoginChoose : Form
	{
		private MemberDto _member;
		public FormAdminLoginChoose(MemberDto member)
		{
			InitializeComponent();
			_member = member;
		}

		private void buttonFront_Click(object sender, EventArgs e)
		{
			var form = new FormBase(_member);
			form.Owner = this.Owner;
			form.Show();
			this.Close();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			var form = new FormBaseBack(_member);
			form.Owner = this.Owner;
			form.Show();
			this.Close();
		}
	}
}
