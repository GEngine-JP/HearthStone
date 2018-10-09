using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RentManage
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class mainform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton information;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton query;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.ToolBarButton checkin;
		private System.Windows.Forms.ToolBarButton quit;
		private System.Windows.Forms.ToolBarButton renter;
		private System.Windows.Forms.ToolBarButton rental;
		private System.ComponentModel.IContainer components;

		public mainform()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mainform));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.renter = new System.Windows.Forms.ToolBarButton();
			this.information = new System.Windows.Forms.ToolBarButton();
			this.query = new System.Windows.Forms.ToolBarButton();
			this.checkin = new System.Windows.Forms.ToolBarButton();
			this.rental = new System.Windows.Forms.ToolBarButton();
			this.quit = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem1.Text = "系统管理(&M)";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "系统帮助";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "退出系统";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem2.Text = "数据维护(&D)";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "出租人信息";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "房屋信息";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem11});
			this.menuItem3.Text = "前台操作(&O)";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "房屋查询";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.Text = "客户查询";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "客户入住";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 3;
			this.menuItem11.Text = "利润信息";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.renter,
																						this.information,
																						this.query,
																						this.checkin,
																						this.rental,
																						this.quit});
			this.toolBar1.ButtonSize = new System.Drawing.Size(90, 22);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(546, 28);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// renter
			// 
			this.renter.ImageIndex = 0;
			this.renter.Text = "出租人信息";
			this.renter.ToolTipText = "出租人信息";
			// 
			// information
			// 
			this.information.ImageIndex = 1;
			this.information.Text = "房屋信息";
			this.information.ToolTipText = "房屋信息";
			// 
			// query
			// 
			this.query.ImageIndex = 2;
			this.query.Text = "房屋查询";
			this.query.ToolTipText = "房屋查询";
			// 
			// checkin
			// 
			this.checkin.ImageIndex = 3;
			this.checkin.Text = "客户查询";
			this.checkin.ToolTipText = "客户查询";
			// 
			// rental
			// 
			this.rental.ImageIndex = 4;
			this.rental.Text = "利润信息";
			this.rental.ToolTipText = "利润信息";
			// 
			// quit
			// 
			this.quit.ImageIndex = 5;
			this.quit.Text = "退出";
			this.quit.ToolTipText = "退出";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// mainform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(546, 403);
			this.Controls.Add(this.toolBar1);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "mainform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "主窗口";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new mainform());
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Form Renter = new Renter();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			Renter.MdiParent = this;
			Renter.WindowState = FormWindowState.Maximized;
			Renter.Show();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Form Room = new Room();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			Room.MdiParent = this;
			Room.WindowState = FormWindowState.Maximized;
			Room.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Form RoomQuery = new RoomQuery();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			RoomQuery.MdiParent = this;
			RoomQuery.WindowState = FormWindowState.Maximized;
			RoomQuery.Show();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			Form Customer = new Customer("1");
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			Customer.MdiParent = this;
			Customer.WindowState = FormWindowState.Maximized;
			Customer.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			Form CustomerQuery = new CustomerQuery();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			CustomerQuery.MdiParent = this;
			CustomerQuery.WindowState = FormWindowState.Maximized;
			CustomerQuery.Show();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			Form Profit = new Profit();
			for(int x=0;x<MdiChildren.Length;x++)
			{
				Form tempChild = (Form)MdiChildren[x];
				tempChild.Close();
			}
			Profit.MdiParent = this;
			Profit.WindowState = FormWindowState.Maximized;
			Profit.Show();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(toolBar1.Buttons.IndexOf(e.Button))
			{
				case 0:
					Form Renter = new Renter();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					Renter.MdiParent = this;
					Renter.WindowState = FormWindowState.Maximized;
					Renter.Show();
					break;
				case 1:
					Form Room = new Room();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					Room.MdiParent = this;
					Room.WindowState = FormWindowState.Maximized;
					Room.Show();
					break;
				case 2:
					Form RoomQuery = new RoomQuery();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					RoomQuery.MdiParent = this;
					RoomQuery.WindowState = FormWindowState.Maximized;
					RoomQuery.Show();
					break;
				case 3:
					Form CustomerQuery = new CustomerQuery();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					CustomerQuery.MdiParent = this;
					CustomerQuery.WindowState = FormWindowState.Maximized;
					CustomerQuery.Show();
					break;
				case 4:
					Form Profit = new Profit();
					for(int x=0;x<MdiChildren.Length;x++)
					{
						Form tempChild = (Form)MdiChildren[x];
						tempChild.Close();
					}
					Profit.MdiParent = this;
					Profit.WindowState = FormWindowState.Maximized;
					Profit.Show();
					break;
				case 5:
					Application.Exit();
					break;
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Form Help = new Help();
			for(int x=0;x<MdiChildren.Length;x++)
			{
				Form tempChild = (Form)MdiChildren[x];
				tempChild.Close();
			}
			Help.MdiParent = this;
			Help.WindowState = FormWindowState.Maximized;
			Help.Show();
		}
	}
}
