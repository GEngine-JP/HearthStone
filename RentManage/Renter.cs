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
	/// Renter 的摘要说明。
	/// </summary>
	public class Renter : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btSave;
		private SqlConnection sqlConnection1;
		private SqlCommand sqlCommand1 = null;
		private DataSet ds = null;
		private bool add;
		private string strSql;
		RentManage.RenterManage renterManage;
		private System.Windows.Forms.TextBox textRenterName;
		private System.Windows.Forms.TextBox textRenterID;
		private System.Windows.Forms.TextBox textContractID;
		private System.Windows.Forms.TextBox textContact;
		private System.Windows.Forms.TextBox textRenterRental;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.TextBox textRemark;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Renter()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			this.sqlCommand1 = new SqlCommand();
			this.sqlCommand1.Connection = this.sqlConnection1;
			this.add = false;
			renterManage = new RenterManage();

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
			this.textContractID = new System.Windows.Forms.TextBox();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.textContact = new System.Windows.Forms.TextBox();
			this.textRenterRental = new System.Windows.Forms.TextBox();
			this.textRenterName = new System.Windows.Forms.TextBox();
			this.textRenterID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.panel1.Controls.Add(this.textContractID);
			this.panel1.Controls.Add(this.textRemark);
			this.panel1.Controls.Add(this.textContact);
			this.panel1.Controls.Add(this.textRenterRental);
			this.panel1.Controls.Add(this.textRenterName);
			this.panel1.Controls.Add(this.textRenterID);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 152);
			this.panel1.TabIndex = 0;
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(408, 112);
			this.btNew.Name = "btNew";
			this.btNew.Size = new System.Drawing.Size(56, 23);
			this.btNew.TabIndex = 8;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btSave
			// 
			this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btSave.Location = new System.Drawing.Point(408, 72);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(56, 23);
			this.btSave.TabIndex = 7;
			this.btSave.Text = "保存";
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// textContractID
			// 
			this.textContractID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContractID.Location = new System.Drawing.Point(416, 16);
			this.textContractID.Name = "textContractID";
			this.textContractID.Size = new System.Drawing.Size(60, 21);
			this.textContractID.TabIndex = 4;
			this.textContractID.Text = "";
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Location = new System.Drawing.Point(208, 64);
			this.textRemark.Multiline = true;
			this.textRemark.Name = "textRemark";
			this.textRemark.Size = new System.Drawing.Size(168, 72);
			this.textRemark.TabIndex = 6;
			this.textRemark.Text = "";
			// 
			// textContact
			// 
			this.textContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContact.Location = new System.Drawing.Point(24, 64);
			this.textContact.Multiline = true;
			this.textContact.Name = "textContact";
			this.textContact.Size = new System.Drawing.Size(168, 72);
			this.textContact.TabIndex = 5;
			this.textContact.Text = "";
			// 
			// textRenterRental
			// 
			this.textRenterRental.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRenterRental.Location = new System.Drawing.Point(280, 16);
			this.textRenterRental.Name = "textRenterRental";
			this.textRenterRental.Size = new System.Drawing.Size(60, 21);
			this.textRenterRental.TabIndex = 3;
			this.textRenterRental.Text = "";
			// 
			// textRenterName
			// 
			this.textRenterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRenterName.Location = new System.Drawing.Point(168, 16);
			this.textRenterName.Name = "textRenterName";
			this.textRenterName.Size = new System.Drawing.Size(60, 21);
			this.textRenterName.TabIndex = 2;
			this.textRenterName.Text = "";
			// 
			// textRenterID
			// 
			this.textRenterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRenterID.Location = new System.Drawing.Point(56, 16);
			this.textRenterID.Name = "textRenterID";
			this.textRenterID.Size = new System.Drawing.Size(60, 21);
			this.textRenterID.TabIndex = 1;
			this.textRenterID.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(208, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "备注";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(248, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "租金";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(360, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "合同编号";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "联系方式";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "姓名";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "编号";
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 168);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(512, 192);
			this.dataGrid1.TabIndex = 1;
			// 
			// Renter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(528, 366);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.panel1);
			this.Name = "Renter";
			this.Text = "出租人信息";
			this.Load += new System.EventHandler(this.Renter_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Renter_Load(object sender, System.EventArgs e)
		{
			this.strSql = " select RenterName 姓名,Contact 联系方式,ContractID 合同编号,"+
							"RenterRental 出租人租金,Remark 备注,RenterID 出租人编号"+
							" from Renter ";
			this.FillDataGrid(strSql);
		}

		private void FillDataGrid(string sql)
		{
			if(this.sqlConnection1.State==ConnectionState.Closed)
				this.sqlConnection1.Open();
			Console.WriteLine(sql);
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			ds = new DataSet("t_renter");
			adapter.Fill(ds,"t_renter");
			this.dataGrid1.SetDataBinding(ds,"t_renter");
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			this.textContact.Clear();
			this.textContractID.Clear();
			this.textRenterID.Clear();
			this.textRenterName.Clear();
			this.textRenterRental.Clear();
			this.textRemark.Clear();
		}

		private void btSave_Click(object sender, System.EventArgs e)
		{
			this.add = true;
			if(textContractID.Text==""||textRenterID.Text==""||textRenterRental.Text=="")
			{
				MessageBox.Show("请输入完整信息！","提示");
				return;
			}
			int renterID = Convert.ToInt16( this.textRenterID.Text);
			string renterName = this.textRenterName.Text;
			float renterRental = Convert.ToSingle(this.textRenterRental.Text);
			int contractID = Convert.ToInt32(this.textContractID.Text);
			string contact = this.textContact.Text;
			string remark = this.textRemark.Text;
			if(add)
			{
				this.renterManage.Renter_Add(renterID,renterName,renterRental,contractID,contact,remark);
				MessageBox.Show("保存成功！");
				this.FillDataGrid(this.strSql);
			}
			else
			{
				if(this.renterManage.Renter_Modify(renterID,renterName,renterRental,contractID,contact,remark))
				{
					MessageBox.Show("修改成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.FillDataGrid(this.strSql);
				}
				else
				{
					MessageBox.Show("修改失败！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

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
}
