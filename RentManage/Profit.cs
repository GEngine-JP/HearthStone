using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using RentManage.database;
namespace RentManage
{
	/// <summary>
	/// Profit ��ժҪ˵����
	/// </summary>
	public class Profit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private SqlConnection sqlConnection1 = null;
		private SqlCommand sqlCommand1 = null;
		private string strSql;
		DataSet ds;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Profit()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			sqlConnection1 = new SqlConnection(dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.Connection = sqlConnection1;

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		public Profit(string customerID)
		{
			InitializeComponent();
			sqlConnection1 = new SqlConnection(dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.Connection = sqlConnection1;
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(512, 344);
			this.dataGrid1.TabIndex = 0;
			// 
			// Profit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(528, 366);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Profit";
			this.Text = "�������";
			this.Load += new System.EventHandler(this.Profit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Profit_Load(object sender, System.EventArgs e)
		{
			strSql ="SELECT distinct RoomInfo.RoomID ����ID,Renter.RenterName ����������,Renter.RenterRental ���������,"+
					"RoomInfo.Price ���ݼ۸�,"+
					"(SELECT distinct SUM(Customer.CustomerRental) FROM Customer WHERE Customer.RoomID = Customer.RoomID)"+
					" as �ܷ���,"+
					"RoomInfo.Price - Renter.RenterRental AS �ο�����,"+ 
					"(SELECT distinct SUM(Customer.CustomerRental) FROM Customer WHERE Customer.RoomID = Customer.RoomID)"+
					"-Renter.RenterRental as ʵ������"+ 
					" FROM Customer INNER JOIN"+
					" RoomInfo ON Customer.RoomID = RoomInfo.RoomID INNER JOIN"+
					" Renter ON RoomInfo.RenterID = Renter.RenterID";
			FillDataGrid(strSql);
		}

		public void FillDataGrid(string sql)
		{
			if(this.sqlConnection1.State == ConnectionState.Closed)
				this.sqlConnection1.Open();
			Console.WriteLine(sql);
			SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlConnection1);
			ds = new DataSet("profit");
			adapter.Fill(ds,"profit");
			this.dataGrid1.SetDataBinding(ds,"profit");
		}
	}
}
