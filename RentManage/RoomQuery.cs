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
	/// RoomQuery 的摘要说明。
	/// </summary>
	public class RoomQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textLocation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textRoomID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textMinArea;
		private System.Windows.Forms.TextBox textMaxArea;
		private System.Windows.Forms.TextBox textMinPrice;
		private System.Windows.Forms.TextBox textMaxPrice;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TextBox textTrueNum;
		private System.Windows.Forms.TextBox textRatingNum;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btQuery;
		private System.Windows.Forms.Button btNotfull;
		private System.Windows.Forms.Button btEmpty;
		private System.Windows.Forms.Button btCheckIn;
		private SqlConnection sqlConnection1=null;
		private SqlCommand sqlCommand1=null;
		private string strSql;
		private DataSet ds;
		private System.Windows.Forms.Button btNew;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RoomQuery()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			this.sqlCommand1 = new SqlCommand();
			this.sqlCommand1.Connection = this.sqlConnection1;
			//roomQuery = new RoomQuery();

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
			this.btCheckIn = new System.Windows.Forms.Button();
			this.btEmpty = new System.Windows.Forms.Button();
			this.btNotfull = new System.Windows.Forms.Button();
			this.btQuery = new System.Windows.Forms.Button();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textTrueNum = new System.Windows.Forms.TextBox();
			this.textRatingNum = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textMaxPrice = new System.Windows.Forms.TextBox();
			this.textMinPrice = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textMaxArea = new System.Windows.Forms.TextBox();
			this.textMinArea = new System.Windows.Forms.TextBox();
			this.textLocation = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textRoomType = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textRoomID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btNew);
			this.panel1.Controls.Add(this.btCheckIn);
			this.panel1.Controls.Add(this.btEmpty);
			this.panel1.Controls.Add(this.btNotfull);
			this.panel1.Controls.Add(this.btQuery);
			this.panel1.Controls.Add(this.textRemark);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.textTrueNum);
			this.panel1.Controls.Add(this.textRatingNum);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.textLocation);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textRoomType);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textRoomID);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 216);
			this.panel1.TabIndex = 0;
			// 
			// btNew
			// 
			this.btNew.BackColor = System.Drawing.Color.AliceBlue;
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(320, 184);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 12;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btCheckIn
			// 
			this.btCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btCheckIn.Location = new System.Drawing.Point(424, 184);
			this.btCheckIn.Name = "btCheckIn";
			this.btCheckIn.TabIndex = 13;
			this.btCheckIn.Text = "入住";
			this.btCheckIn.Click += new System.EventHandler(this.btCheckIn_Click);
			// 
			// btEmpty
			// 
			this.btEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btEmpty.Location = new System.Drawing.Point(218, 184);
			this.btEmpty.Name = "btEmpty";
			this.btEmpty.TabIndex = 11;
			this.btEmpty.Text = "空房";
			this.btEmpty.Click += new System.EventHandler(this.btEmpty_Click);
			// 
			// btNotfull
			// 
			this.btNotfull.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNotfull.Location = new System.Drawing.Point(116, 184);
			this.btNotfull.Name = "btNotfull";
			this.btNotfull.TabIndex = 10;
			this.btNotfull.Text = "未满";
			this.btNotfull.Click += new System.EventHandler(this.btNotfull_Click);
			// 
			// btQuery
			// 
			this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btQuery.Location = new System.Drawing.Point(14, 184);
			this.btQuery.Name = "btQuery";
			this.btQuery.TabIndex = 9;
			this.btQuery.Text = "查询";
			this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Location = new System.Drawing.Point(40, 152);
			this.textRemark.Name = "textRemark";
			this.textRemark.Size = new System.Drawing.Size(445, 21);
			this.textRemark.TabIndex = 8;
			this.textRemark.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 16);
			this.label10.TabIndex = 30;
			this.label10.Text = "备注";
			// 
			// textTrueNum
			// 
			this.textTrueNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTrueNum.Location = new System.Drawing.Point(440, 16);
			this.textTrueNum.Name = "textTrueNum";
			this.textTrueNum.Size = new System.Drawing.Size(60, 21);
			this.textTrueNum.TabIndex = 4;
			this.textTrueNum.Text = "";
			// 
			// textRatingNum
			// 
			this.textRatingNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRatingNum.Location = new System.Drawing.Point(312, 16);
			this.textRatingNum.Name = "textRatingNum";
			this.textRatingNum.Size = new System.Drawing.Size(60, 21);
			this.textRatingNum.TabIndex = 3;
			this.textRatingNum.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(384, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "实住人数";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(256, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.TabIndex = 26;
			this.label9.Text = "额定人数";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textMaxPrice);
			this.groupBox2.Controls.Add(this.textMinPrice);
			this.groupBox2.Location = new System.Drawing.Point(279, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(185, 64);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "价格";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(104, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "小于";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "大于";
			// 
			// textMaxPrice
			// 
			this.textMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMaxPrice.Location = new System.Drawing.Point(104, 32);
			this.textMaxPrice.Name = "textMaxPrice";
			this.textMaxPrice.Size = new System.Drawing.Size(64, 21);
			this.textMaxPrice.TabIndex = 2;
			this.textMaxPrice.Text = "";
			// 
			// textMinPrice
			// 
			this.textMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMinPrice.Location = new System.Drawing.Point(24, 32);
			this.textMinPrice.Name = "textMinPrice";
			this.textMinPrice.Size = new System.Drawing.Size(64, 21);
			this.textMinPrice.TabIndex = 1;
			this.textMinPrice.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textMaxArea);
			this.groupBox1.Controls.Add(this.textMinArea);
			this.groupBox1.Location = new System.Drawing.Point(47, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 64);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "面积";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(104, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "小于";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "大于";
			// 
			// textMaxArea
			// 
			this.textMaxArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMaxArea.Location = new System.Drawing.Point(104, 32);
			this.textMaxArea.Name = "textMaxArea";
			this.textMaxArea.Size = new System.Drawing.Size(64, 21);
			this.textMaxArea.TabIndex = 2;
			this.textMaxArea.Text = "";
			// 
			// textMinArea
			// 
			this.textMinArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMinArea.Location = new System.Drawing.Point(24, 32);
			this.textMinArea.Name = "textMinArea";
			this.textMinArea.Size = new System.Drawing.Size(64, 21);
			this.textMinArea.TabIndex = 1;
			this.textMinArea.Text = "";
			// 
			// textLocation
			// 
			this.textLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textLocation.Location = new System.Drawing.Point(40, 120);
			this.textLocation.Name = "textLocation";
			this.textLocation.Size = new System.Drawing.Size(445, 21);
			this.textLocation.TabIndex = 7;
			this.textLocation.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 22;
			this.label5.Text = "位置";
			// 
			// textRoomType
			// 
			this.textRoomType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomType.Location = new System.Drawing.Point(144, 16);
			this.textRoomType.Name = "textRoomType";
			this.textRoomType.TabIndex = 2;
			this.textRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "类型";
			// 
			// textRoomID
			// 
			this.textRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomID.Location = new System.Drawing.Point(40, 16);
			this.textRoomID.Name = "textRoomID";
			this.textRoomID.Size = new System.Drawing.Size(60, 21);
			this.textRoomID.TabIndex = 1;
			this.textRoomID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "编号";
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 232);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(512, 128);
			this.dataGrid1.TabIndex = 1;
			// 
			// RoomQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(528, 366);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Name = "RoomQuery";
			this.Text = "房屋查询";
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btNew_Click(object sender, System.EventArgs e)
		{
			this.textLocation.Clear();
			this.textMaxArea.Clear();
			this.textMinArea.Clear();
			this.textMaxPrice.Clear();
			this.textMinPrice.Clear();
			this.textRatingNum.Clear();
			this.textTrueNum.Clear();
			this.textRemark.Clear();
			this.textRoomID.Clear();
			this.textRoomType.Clear();
		}

		private void btQuery_Click(object sender, System.EventArgs e)
		{
			bool flag=true;
			this.strSql=" select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数,"+
						"TrueNum 实住人数,Area 面积,Price 价格,"+
						" case AirCondition when 1 then '有' when 0 then '无' end 空调,"+
						" case Telephone when 1 then '有' when 0 then '无' end 电话,"+
						" case TV when 1 then '有' when 0 then '无' end 电视,"+
						" case WashRoom when 1 then '有' when 0 then '无' end 卫生间,"+
						" case Kitchen when 1 then '有' when 0 then '无' end 厨房,"+
						" case Internet when 1 then '有' when 0 then '无' end 宽带,"+
						" Remark 备注,RoomID 房屋编号,RenterID 出租人编号"+
						" from RoomInfo where ";
			if(this.textRoomID.Text != "")
				this.strSql = this.strSql+" RoomID="+"'" +this.textRoomID.Text+"'";
			else
			{
				if(this.textRoomType.Text !="")
				{
					this.strSql = this.strSql+" RoomType like "+"'%"+this.textRoomType.Text+"%'";
					flag=false;
				}	
				if(this.textRatingNum.Text !="")
				{
					if(flag)
						this.strSql = this.strSql+" RatingNum="+"'"+this.textRatingNum.Text+"'";
					else
						this.strSql = this.strSql+" and RatingNum="+"'"+this.textRatingNum.Text+"'";
					flag=false;
				}
				if(this.textTrueNum.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" TrueNum="+"'"+this.textTrueNum.Text+"'";
					else
						this.strSql = this.strSql+" and TrueNum="+"'"+this.textTrueNum.Text+"'";
					flag=false;
				}
				if(this.textMinArea.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Area>="+"'"+this.textMinArea.Text+"'";
					else
						this.strSql = this.strSql+" and Area>="+"'"+this.textMinArea.Text+"'";
					flag=false;
				}
				if(this.textMaxArea.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Area<="+"'"+this.textMaxArea.Text+"'";
					else
						this.strSql = this.strSql+" and Area<="+"'"+this.textMaxArea.Text+"'";
					flag=false;
				}
				if(this.textMinPrice.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Price>="+this.textMinPrice.Text+"";
					else
						this.strSql = this.strSql+" and Price>="+this.textMinPrice.Text+"";
					flag=false;
				}
				if(this.textMaxPrice.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Price<="+this.textMaxPrice.Text+"";
					else
						this.strSql = this.strSql+" and Price<="+this.textMaxPrice.Text+"";
					flag=false;
				}
				if(this.textLocation.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Location like "+"'%"+this.textLocation.Text+"%'";
					else
						this.strSql = this.strSql+" and Location like "+"'%"+this.textLocation.Text+"%'";
					flag=false;
				}
				if(this.textRemark.Text != "")
				{
					if(flag)
						this.strSql = this.strSql+" Remark like "+"'%"+this.textRemark.Text+"%'";
					else
						this.strSql = this.strSql+" and Remark like "+"'%"+this.textRemark.Text+"%'";
				}
				else
				{
					//MessageBox.Show("请输入查询条件！","提示");
					//return;
				}
			}
			this.FillDataGrid(strSql);
		}

		private void btNotfull_Click(object sender, System.EventArgs e)
		{
			this.strSql=" select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数,"+
						"TrueNum 实住人数,Area 面积,Price 价格,"+
						" case AirCondition when 1 then '有' when 0 then '无' end 空调,"+
						" case Telephone when 1 then '有' when 0 then '无' end 电话,"+
						" case TV when 1 then '有' when 0 then '无' end 电视,"+
						" case WashRoom when 1 then '有' when 0 then '无' end 卫生间,"+
						" case Kitchen when 1 then '有' when 0 then '无' end 厨房,"+
						" case Internet when 1 then '有' when 0 then '无' end 宽带,"+
						" Remark 备注,RoomID 房屋编号,RenterID 出租人编号"+
						" from RoomInfo where RatingNum > TrueNum";
			this.FillDataGrid(strSql);
		}

		private void btEmpty_Click(object sender, System.EventArgs e)
		{
			this.strSql=" select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数,"+
						"TrueNum 实住人数,Area 面积,Price 价格,"+
						" case AirCondition when 1 then '有' when 0 then '无' end 空调,"+
						" case Telephone when 1 then '有' when 0 then '无' end 电话,"+
						" case TV when 1 then '有' when 0 then '无' end 电视,"+
						" case WashRoom when 1 then '有' when 0 then '无' end 卫生间,"+
						" case Kitchen when 1 then '有' when 0 then '无' end 厨房,"+
						" case Internet when 1 then '有' when 0 then '无' end 宽带,"+
						" Remark 备注,RoomID 房屋编号,RenterID 出租人编号"+
						" from RoomInfo where TrueNum=0";
			this.FillDataGrid(strSql);
		}

		private void btCheckIn_Click(object sender, System.EventArgs e)
		{
			try
			{
				Customer customer = new Customer(dataGrid1[this.dataGrid1.CurrentCell.RowNumber,14].ToString());
				customer.Show();
			}
			catch
			{
				MessageBox.Show("请先选择房间！","提示");
			}
		}

		public void FillDataGrid(string sql)
		{
			if(this.sqlConnection1.State == ConnectionState.Closed)
				this.sqlConnection1.Open();
			Console.WriteLine(sql);
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			ds = new DataSet("t_roomQuery");
			adapter.Fill(ds,"t_roomQuery");
			this.dataGrid1.SetDataBinding(ds,"t_roomQuery");
		}
	}
}
