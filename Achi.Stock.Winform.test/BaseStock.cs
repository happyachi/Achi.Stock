﻿using Achi.Stock.Winform.test.Models.Dtos;
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
	public partial class BaseStock : Form
	{
		private MemberDto _member;
		public BaseStock(MemberDto member)
		{
			InitializeComponent();
			_member = member;

			this.Load += BaseStock_Load;
		}

		private void BaseStock_Load(object sender, EventArgs e)
		{
			OpenChildForm(new FormTAIEX());
		}

		private void buttonTAIEX_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTAIEX());
		}

		private void buttonCommpany_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormStockSearch(_member,"Stock"));
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

		
	}
}
