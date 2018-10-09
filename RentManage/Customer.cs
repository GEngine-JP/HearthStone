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
	/// Customer 的摘要说明。
	/// </summary>
	public class Customer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textRoomID;
		private System.Windows.Forms.TextBox textCustomerID;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textContractID;
		private System.Windows.Forms.TextBox textIDCard;
		private System.Windows.Forms.TextBox textNativePlace;
		private System.Windows.Forms.TextBox textCustomerRental;
		private System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.ComboBox comSex;
		private System.Windows.Forms.DateTimePicker dateCheckIn;
		private System.Windows.Forms.DateTimePicker dateRental;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.DataGrid dataGrid1;
		private SqlConnection sqlConnection1 = null;
		private SqlCommand sqlCommand1 = null;
		private string strSql;
		private bool add;
		private DataSet ds = null;
		RentManage.CustomerManage customerManage;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Customer()
		{
			InitializeComponent();
			sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.Connection = sqlConnection1;
			add = false;
			customerManage = new CustomerManage();
			MessageBox.Show("没有选择房间！","警告");
		}

		public Customer(string roomID)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.textRoomID.Text = roomID;
			sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.Connection = sqlConnection1;
			add = false;
			customerManage = new CustomerManage();

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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textRoomID = new System.Windows.Forms.TextBox();
			this.textCustomerID = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textContractID = new System.Windows.Forms.TextBox();
			this.textIDCard = new System.Windows.Forms.TextBox();
			this.textNativePlace = new System.Windows.Forms.TextBox();
			this.textCustomerRental = new System.Windows.Forms.TextBox();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.comSex = new System.Windows.Forms.ComboBox();
			this.dateCheckIn = new System.Windows.Forms.DateTimePicker();
			this.dateRental = new System.Windows.Forms.DateTimePicker();
			this.btSave = new System.Windows.Forms.Button();
			this.btNew = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btNew);
			this.panel1.Controls.Add(this.btSave);
			this.panel1.Controls.Add(this.dateRental);
			this.panel1.Controls.Add(this.dateCheckIn);
			this.panel1.Controls.Add(this.comSex);
			this.panel1.Controls.Add(this.textNativePlace);
			this.panel1.Controls.Add(this.textIDCard);
			this.panel1.Controls.Add(this.textContractID);
			this.panel1.Controls.Add(this.textName);
			this.panel1.Controls.Add(this.textCustomerID);
			this.panel1.Controls.Add(this.textRoomID);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textCustomerRental);
			this.panel1.Controls.Add(this.textRemark);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 176);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "房屋编号";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(152, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "客户编号";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(291, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "姓名";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(403, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "性别";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "籍贯";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(160, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "身份证";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(288, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "入住时间";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(288, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "交租时间";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(19, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "合同编号";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(312, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 16);
			this.label10.TabIndex = 9;
			this.label10.Text = "租金";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(24, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 16);
			this.label11.TabIndex = 10;
			this.label11.Text = "备注";
			// 
			// textRoomID
			// 
			this.textRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomID.Location = new System.Drawing.Point(72, 16);
			this.textRoomID.Name = "textRoomID";
			this.textRoomID.ReadOnly = true;
			this.textRoomID.Size = new System.Drawing.Size(64, 21);
			this.textRoomID.TabIndex = 11;
			this.textRoomID.Text = "";
			// 
			// textCustomerID
			// 
			this.textCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCustomerID.Location = new System.Drawing.Point(208, 16);
			this.textCustomerID.Name = "textCustomerID";
			this.textCustomerID.Size = new System.Drawing.Size(64, 21);
			this.textCustomerID.TabIndex = 1;
			this.textCustomerID.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(320, 16);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(64, 21);
			this.textName.TabIndex = 2;
			this.textName.Text = "";
			// 
			// textContractID
			// 
			this.textContractID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContractID.Location = new System.Drawing.Point(72, 48);
			this.textContractID.Name = "textContractID";
			this.textContractID.Size = new System.Drawing.Size(64, 21);
			this.textContractID.TabIndex = 4;
			this.textContractID.Text = "";
			// 
			// textIDCard
			// 
			this.textIDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textIDCard.Location = new System.Drawing.Point(208, 48);
			this.textIDCard.Name = "textIDCard";
			this.textIDCard.Size = new System.Drawing.Size(64, 21);
			this.textIDCard.TabIndex = 5;
			this.textIDCard.Text = "";
			// 
			// textNativePlace
			// 
			this.textNativePlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNativePlace.Location = new System.Drawing.Point(64, 80);
			this.textNativePlace.Name = "textNativePlace";
			this.textNativePlace.Size = new System.Drawing.Size(208, 21);
			this.textNativePlace.TabIndex = 7;
			this.textNativePlace.Text = "";
			// 
			// textCustomerRental
			// 
			this.textCustomerRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCustomerRental.Location = new System.Drawing.Point(352, 112);
			this.textCustomerRental.Name = "textCustomerRental";
			this.textCustomerRental.Size = new System.Drawing.Size(136, 21);
			this.textCustomerRental.TabIndex = 10;
			this.textCustomerRental.Text = "";
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Location = new System.Drawing.Point(64, 112);
			this.textRemark.Name = "textRemark";
			this.textRemark.Size = new System.Drawing.Size(208, 21);
			this.textRemark.TabIndex = 9;
			this.textRemark.Text = "";
			// 
			// comSex
			// 
			this.comSex.Items.AddRange(new object[] {
														"男",
														"女"});
			this.comSex.Location = new System.Drawing.Point(432, 16);
			this.comSex.Name = "comSex";
			this.comSex.Size = new System.Drawing.Size(56, 20);
			this.comSex.TabIndex = 3;
			// 
			// dateCheckIn
			// 
			this.dateCheckIn.Location = new System.Drawing.Point(352, 48);
			this.dateCheckIn.Name = "dateCheckIn";
			this.dateCheckIn.Size = new System.Drawing.Size(136, 21);
			this.dateCheckIn.TabIndex = 6;
			// 
			// dateRental
			// 
			this.dateRental.Location = new System.Drawing.Point(352, 80);
			this.dateRental.Name = "dateRental";
			this.dateRental.Size = new System.Drawing.Size(136, 21);
			this.dateRental.TabIndex = 8;
			// 
			// btSave
			// 
			this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btSave.Location = new System.Drawing.Point(118, 144);
			this.btSave.Name = "btSave";
			this.btSave.TabIndex = 11;
			this.btSave.Text = "保存";
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(318, 144);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 12;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 192);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(512, 168);
			this.dataGrid1.TabIndex = 1;
			// 
			// Customer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(528, 366);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Name = "Customer";
			this.Text = "客户入住";
			this.Load += new System.EventHandler(this.Customer_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btSave_Click(object sender, System.EventArgs e)
		{
			add=true;
			if(textContractID.Text==""||textCustomerID.Text==""||textCustomerRental.Text==""||textRoomID.Text=="")
			{
				MessageBox.Show("请输入完整信息！","提示");
				return;
			}
			int customerID = Convert.ToInt16(textCustomerID.Text);
			string customerName = textName.Text;
			string sex = comSex.Text;
			string nativePlace = textNativePlace.Text;
			string IDCard = textIDCard.Text;
			string roomID = textRoomID.Text;
			System.DateTime indate = Convert.ToDateTime(dateCheckIn.Text);
			System.DateTime rentalDate = Convert.ToDateTime(dateRental.Text);
			int contractID = Convert.ToInt32(textContractID.Text);
			float customerRental = Convert.ToSingle(textCustomerRental.Text);
			string remark = textRemark.Text;
			if(add)
			{
				customerManage.Customer_Add(customerID,customerName,sex,nativePlace,IDCard,roomID,indate,
											rentalDate,contractID,customerRental,remark);
				MessageBox.Show("保存成功！");
				FillDataGrid(strSql);
			}
			else
			{
				MessageBox.Show("保存失败！");
			}
			this.add = false;
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			textContractID.Clear();
			textCustomerID.Clear();
			textCustomerRental.Clear();
			textIDCard.Clear();
			textName.Clear();
			textNativePlace.Clear();
			textRemark.Clear();
			comSex.Text="";
			dateCheckIn.Text="";
			dateRental.Text=Convert.ToString(DateTime.Now);
		}

		private void Customer_Load(object sender, System.EventArgs e)
		{
			strSql =" select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间,"+
					"RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号,"+
					"RoomID 房屋编号 from Customer where RoomID = "+"'"+textRoomID.Text+"'";
			FillDataGrid(strSql);
		}

		private void FillDataGrid(string sql)
		{
			if(sqlConnection1.State == ConnectionState.Closed)
				this.sqlConnection1.Open();
			Console.WriteLine(sql);
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			ds = new DataSet("t_customer");
			adapter.Fill(ds,"t_customer");
			dataGrid1.SetDataBinding(ds,"t_customer");
		}
	}
}
