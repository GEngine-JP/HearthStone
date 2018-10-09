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
	/// Room 的摘要说明。
	/// </summary>
	public class Room : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textRenterID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textRoomType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textFloor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textRatingNum;
		private System.Windows.Forms.TextBox textTrueNum;
		private System.Windows.Forms.TextBox textArea;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.CheckBox checkAircondition;
		private System.Windows.Forms.CheckBox checkTelephone;
		private System.Windows.Forms.CheckBox checkTV;
		private System.Windows.Forms.CheckBox checkWashRoom;
		private System.Windows.Forms.CheckBox checkKitchen;
		private System.Windows.Forms.CheckBox checkInternet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.DataGrid dataGrid1;
		private SqlConnection sqlConnection1 = null;
		private SqlCommand sqlCommand1 = null;
		private SqlDataReader sqlDataReader1 = null;
		private string strSql;
		private DataSet ds;
		private bool add;
		RentManage.RoomManange roomManage;
		private System.Windows.Forms.TextBox textLocation;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Room()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			this.sqlCommand1 = new SqlCommand();
			this.sqlCommand1.Connection = this.sqlConnection1;
			this.add = false;
			roomManage = new RoomManange();
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
			this.btSave = new System.Windows.Forms.Button();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkInternet = new System.Windows.Forms.CheckBox();
			this.checkKitchen = new System.Windows.Forms.CheckBox();
			this.checkWashRoom = new System.Windows.Forms.CheckBox();
			this.checkTV = new System.Windows.Forms.CheckBox();
			this.checkTelephone = new System.Windows.Forms.CheckBox();
			this.checkAircondition = new System.Windows.Forms.CheckBox();
			this.textLocation = new System.Windows.Forms.TextBox();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.textArea = new System.Windows.Forms.TextBox();
			this.textTrueNum = new System.Windows.Forms.TextBox();
			this.textRatingNum = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textFloor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textRoomType = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textRoomID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textRenterID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel1.Controls.Add(this.textRemark);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.checkInternet);
			this.panel1.Controls.Add(this.checkKitchen);
			this.panel1.Controls.Add(this.checkWashRoom);
			this.panel1.Controls.Add(this.checkTV);
			this.panel1.Controls.Add(this.checkTelephone);
			this.panel1.Controls.Add(this.checkAircondition);
			this.panel1.Controls.Add(this.textLocation);
			this.panel1.Controls.Add(this.textPrice);
			this.panel1.Controls.Add(this.textArea);
			this.panel1.Controls.Add(this.textTrueNum);
			this.panel1.Controls.Add(this.textRatingNum);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textFloor);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textRoomType);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textRoomID);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textRenterID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 208);
			this.panel1.TabIndex = 0;
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(323, 176);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 18;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btSave
			// 
			this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btSave.Location = new System.Drawing.Point(115, 176);
			this.btSave.Name = "btSave";
			this.btSave.TabIndex = 17;
			this.btSave.Text = "保存";
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Location = new System.Drawing.Point(48, 144);
			this.textRemark.Name = "textRemark";
			this.textRemark.Size = new System.Drawing.Size(445, 21);
			this.textRemark.TabIndex = 16;
			this.textRemark.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 16);
			this.label10.TabIndex = 24;
			this.label10.Text = "备注";
			// 
			// checkInternet
			// 
			this.checkInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkInternet.Location = new System.Drawing.Point(265, 112);
			this.checkInternet.Name = "checkInternet";
			this.checkInternet.Size = new System.Drawing.Size(48, 20);
			this.checkInternet.TabIndex = 13;
			this.checkInternet.Text = "宽带";
			// 
			// checkKitchen
			// 
			this.checkKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkKitchen.Location = new System.Drawing.Point(348, 112);
			this.checkKitchen.Name = "checkKitchen";
			this.checkKitchen.Size = new System.Drawing.Size(48, 20);
			this.checkKitchen.TabIndex = 14;
			this.checkKitchen.Text = "厨房";
			// 
			// checkWashRoom
			// 
			this.checkWashRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkWashRoom.Location = new System.Drawing.Point(431, 112);
			this.checkWashRoom.Name = "checkWashRoom";
			this.checkWashRoom.Size = new System.Drawing.Size(64, 20);
			this.checkWashRoom.TabIndex = 15;
			this.checkWashRoom.Text = "洗手间";
			// 
			// checkTV
			// 
			this.checkTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkTV.Location = new System.Drawing.Point(182, 112);
			this.checkTV.Name = "checkTV";
			this.checkTV.Size = new System.Drawing.Size(48, 20);
			this.checkTV.TabIndex = 12;
			this.checkTV.Text = "电视";
			// 
			// checkTelephone
			// 
			this.checkTelephone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkTelephone.Location = new System.Drawing.Point(99, 112);
			this.checkTelephone.Name = "checkTelephone";
			this.checkTelephone.Size = new System.Drawing.Size(48, 20);
			this.checkTelephone.TabIndex = 11;
			this.checkTelephone.Text = "电话";
			// 
			// checkAircondition
			// 
			this.checkAircondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkAircondition.Location = new System.Drawing.Point(16, 112);
			this.checkAircondition.Name = "checkAircondition";
			this.checkAircondition.Size = new System.Drawing.Size(48, 20);
			this.checkAircondition.TabIndex = 10;
			this.checkAircondition.Text = "空调";
			// 
			// textLocation
			// 
			this.textLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textLocation.Location = new System.Drawing.Point(48, 80);
			this.textLocation.Name = "textLocation";
			this.textLocation.Size = new System.Drawing.Size(445, 21);
			this.textLocation.TabIndex = 9;
			this.textLocation.Text = "";
			// 
			// textPrice
			// 
			this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrice.Location = new System.Drawing.Point(432, 48);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(60, 21);
			this.textPrice.TabIndex = 8;
			this.textPrice.Text = "";
			// 
			// textArea
			// 
			this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textArea.Location = new System.Drawing.Point(320, 48);
			this.textArea.Name = "textArea";
			this.textArea.Size = new System.Drawing.Size(60, 21);
			this.textArea.TabIndex = 7;
			this.textArea.Text = "";
			// 
			// textTrueNum
			// 
			this.textTrueNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTrueNum.Location = new System.Drawing.Point(208, 48);
			this.textTrueNum.Name = "textTrueNum";
			this.textTrueNum.Size = new System.Drawing.Size(60, 21);
			this.textTrueNum.TabIndex = 6;
			this.textTrueNum.Text = "";
			// 
			// textRatingNum
			// 
			this.textRatingNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRatingNum.Location = new System.Drawing.Point(80, 48);
			this.textRatingNum.Name = "textRatingNum";
			this.textRatingNum.Size = new System.Drawing.Size(60, 21);
			this.textRatingNum.TabIndex = 5;
			this.textRatingNum.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(400, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 16);
			this.label9.TabIndex = 12;
			this.label9.Text = "价格";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(288, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 16);
			this.label8.TabIndex = 11;
			this.label8.Text = "面积";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(152, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "实住人数";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "额定人数";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "位置";
			// 
			// textFloor
			// 
			this.textFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textFloor.Location = new System.Drawing.Point(432, 16);
			this.textFloor.Name = "textFloor";
			this.textFloor.Size = new System.Drawing.Size(60, 21);
			this.textFloor.TabIndex = 4;
			this.textFloor.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(400, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "楼层";
			// 
			// textRoomType
			// 
			this.textRoomType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomType.Location = new System.Drawing.Point(288, 16);
			this.textRoomType.Name = "textRoomType";
			this.textRoomType.TabIndex = 3;
			this.textRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(256, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "类型";
			// 
			// textRoomID
			// 
			this.textRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomID.Location = new System.Drawing.Point(184, 16);
			this.textRoomID.Name = "textRoomID";
			this.textRoomID.Size = new System.Drawing.Size(60, 21);
			this.textRoomID.TabIndex = 2;
			this.textRoomID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(152, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "编号";
			// 
			// textRenterID
			// 
			this.textRenterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRenterID.Location = new System.Drawing.Point(80, 16);
			this.textRenterID.Name = "textRenterID";
			this.textRenterID.Size = new System.Drawing.Size(60, 21);
			this.textRenterID.TabIndex = 1;
			this.textRenterID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "出租人编号";
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 224);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(512, 136);
			this.dataGrid1.TabIndex = 1;
			// 
			// Room
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(528, 366);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Name = "Room";
			this.Text = "房屋信息";
			this.Load += new System.EventHandler(this.Room_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Room_Load(object sender, System.EventArgs e)
		{
			this.strSql = " select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数,"+
							"TrueNum 实住人数,Area 面积,Price 价格,"+
							" case AirCondition when 1 then '有' when 0 then '无' end 空调,"+
							" case Telephone when 1 then '有' when 0 then '无' end 电话,"+
							" case TV when 1 then '有' when 0 then '无' end 电视,"+
							" case WashRoom when 1 then '有' when 0 then '无' end 卫生间,"+
							" case Kitchen when 1 then '有' when 0 then '无' end 厨房,"+
							" case Internet when 1 then '有' when 0 then '无' end 宽带,"+
							" Remark 备注,RoomID 房屋编号,RenterID 出租人编号"+
							" from RoomInfo";
			this.FillDataGrid(strSql);
		}

		private void FillDataGrid(string sql)
		{
			if(this.sqlConnection1.State==ConnectionState.Closed)
				this.sqlConnection1.Open();
			Console.WriteLine(sql);
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			ds = new DataSet("t_room");
			adapter.Fill(ds,"t_room");
			this.dataGrid1.SetDataBinding(ds,"t_room");
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			this.textArea.Clear();
			this.textFloor.Clear();
			this.textLocation.Clear();
			this.textPrice.Clear();
			this.textRatingNum.Clear();
			this.textRemark.Clear();
			this.textRenterID.Clear();
			this.textRoomID.Clear();
			this.textRoomType.Clear();
			this.textTrueNum.Clear();
			this.checkAircondition.Checked=false;
			this.checkInternet.Checked=false;
			this.checkKitchen.Checked=false;
			this.checkTelephone.Checked=false;
			this.checkTV.Checked=false;
			this.checkWashRoom.Checked=false;
		}

		private void btSave_Click(object sender, System.EventArgs e)
		{
			this.add = true;
			if(textPrice.Text==""||textRenterID.Text==""||textRoomID.Text=="")
			{
				MessageBox.Show("请输入完整信息！","提示");
				return;
			}
			int roomID = Convert.ToInt16(this.textRoomID.Text);
			int renterID = Convert.ToInt16(this.textRenterID.Text);
			string roomtype = this.textRoomType.Text;
			string location = this.textLocation.Text;
			string floor = this.textFloor.Text;
			int ratingNum = Convert.ToInt16(this.textRatingNum.Text);
			int trueNum = Convert.ToInt16(this.textTrueNum.Text);
			int area = Convert.ToInt16(this.textArea.Text);
			float price = Convert.ToSingle(this.textPrice.Text);
			int airCondition = Convert.ToInt16(this.checkAircondition.Checked);
			int telephone = Convert.ToInt16(this.checkTelephone.Checked);
			int TV = Convert.ToInt16(this.checkTV.Checked);
			int washRoom = Convert.ToInt16(this.checkWashRoom.Checked);
			int kitchen = Convert.ToInt16(this.checkKitchen.Checked);
			int internet = Convert.ToInt16(this.checkInternet.Checked);
			string remark = this.textRemark.Text;

			if(add)
			{
				this.roomManage.room_Add(roomID,renterID,roomtype,location,floor,ratingNum,trueNum,area,
					price,airCondition,telephone,TV,washRoom,kitchen,internet,remark);
				MessageBox.Show("保存成功！");
				this.FillDataGrid(strSql);
			}
			else
			{}

			this.sqlCommand1.CommandText = this.strSql;

			try
			{
				this.sqlConnection1.Open();
				this.sqlCommand1.ExecuteNonQuery();
				this.FillDataGrid(this.strSql);
			}
			catch(System.Exception E)
			{
				MessageBox.Show(E.ToString());
			}
			finally
			{
				this.sqlConnection1.Close();
			}
			this.add = false;
		}
	}
}
