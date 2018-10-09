using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RentManage
{
	/// <summary>
	/// CustomerQuery 的摘要说明。
	/// </summary>
	public class CustomerQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textCustomerID;
		private System.Windows.Forms.TextBox textRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btQuery;
		private System.Windows.Forms.Button btAll;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.DataGrid dataGrid1;
		private SqlConnection sqlConnection1=null;
		private SqlCommand sqlCommand1=null;
		private string strSql;
		private DataSet ds;
		private System.Windows.Forms.Button btCheck;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CustomerQuery()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.Connection = sqlConnection1;

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
				if(components != null)
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btNew = new System.Windows.Forms.Button();
			this.btAll = new System.Windows.Forms.Button();
			this.btQuery = new System.Windows.Forms.Button();
			this.textName = new System.Windows.Forms.TextBox();
			this.textCustomerID = new System.Windows.Forms.TextBox();
			this.textRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btCheck = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btCheck);
			this.panel1.Controls.Add(this.btNew);
			this.panel1.Controls.Add(this.btAll);
			this.panel1.Controls.Add(this.btQuery);
			this.panel1.Controls.Add(this.textName);
			this.panel1.Controls.Add(this.textCustomerID);
			this.panel1.Controls.Add(this.textRoomID);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 88);
			this.panel1.TabIndex = 0;
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(294, 56);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 6;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btAll
			// 
			this.btAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAll.Location = new System.Drawing.Point(166, 56);
			this.btAll.Name = "btAll";
			this.btAll.TabIndex = 5;
			this.btAll.Text = "全部";
			this.btAll.Click += new System.EventHandler(this.btAll_Click);
			// 
			// btQuery
			// 
			this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btQuery.Location = new System.Drawing.Point(38, 56);
			this.btQuery.Name = "btQuery";
			this.btQuery.TabIndex = 4;
			this.btQuery.Text = "查询";
			this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(328, 16);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(64, 21);
			this.textName.TabIndex = 3;
			this.textName.Text = "";
			// 
			// textCustomerID
			// 
			this.textCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCustomerID.Location = new System.Drawing.Point(208, 16);
			this.textCustomerID.Name = "textCustomerID";
			this.textCustomerID.Size = new System.Drawing.Size(64, 21);
			this.textCustomerID.TabIndex = 2;
			this.textCustomerID.Text = "";
			// 
			// textRoomID
			// 
			this.textRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomID.Location = new System.Drawing.Point(72, 16);
			this.textRoomID.Name = "textRoomID";
			this.textRoomID.Size = new System.Drawing.Size(64, 21);
			this.textRoomID.TabIndex = 1;
			this.textRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(288, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "姓名";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(152, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "客户编号";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "房屋编号";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 10F);
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid1.Location = new System.Drawing.Point(8, 104);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(408, 256);
			this.dataGrid1.TabIndex = 1;
			// 
			// btCheck
			// 
			this.btCheck.BackColor = System.Drawing.Color.AliceBlue;
			this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btCheck.Location = new System.Drawing.Point(272, 32);
			this.btCheck.Name = "btCheck";
			this.btCheck.TabIndex = 7;
			this.btCheck.Text = "结算";
			this.btCheck.Visible = false;
			this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
			// 
			// CustomerQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(424, 366);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Name = "CustomerQuery";
			this.Text = "客户查询";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuery_Click(object sender, System.EventArgs e)
		{
			strSql=" select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间,"+
				"RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号,"+
				"RoomID 房屋编号 from Customer where ";
			if(textRoomID.Text != "")
				strSql = strSql+"RoomID="+"'"+textRoomID.Text+"'";
			else if(textCustomerID.Text != "")
				strSql = strSql+"CustomerID="+"'"+textCustomerID.Text+"'";
			else if(textName.Text != "")
				strSql = strSql+"CustomerName like"+"'%"+textName.Text+"%'";
			else
			{
				MessageBox.Show("请选择查询条件！","提示");
				return;
			}
				
			FillDataGrid(strSql);
		}

		private void btAll_Click(object sender, System.EventArgs e)
		{
			strSql=" select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间,"+
				"RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号,"+
				"RoomID 房屋编号 from Customer";
			sqlCommand1.CommandText = strSql;
			FillDataGrid(strSql);
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			textCustomerID.Clear();
			textName.Clear();
			textRoomID.Clear();
		}

		private void btCheck_Click(object sender, System.EventArgs e)
		{
			try
			{
				Profit profit = new Profit(dataGrid1[dataGrid1.CurrentCell.RowNumber,9].ToString());
				profit.Show();
			}
			catch
			{
				MessageBox.Show("请先选择客户！","提示");
			}
		}

		public void FillDataGrid(string sql)
		{
			if(sqlConnection1.State == ConnectionState.Closed)
				sqlConnection1.Open();
			Console.WriteLine(sql);
			ds = new DataSet("t_customer");
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			adapter.Fill(ds,"t_customer");
			dataGrid1.SetDataBinding(ds,"t_customer");
		}
	}
}
