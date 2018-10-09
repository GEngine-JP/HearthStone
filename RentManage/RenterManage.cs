using System;
using System.Data;
using System.Data.SqlClient;
using RentManage.database;

namespace RentManage
{
	/// <summary>
	/// RenterManage 的摘要说明。
	/// </summary>
	public class RenterManage
	{
		private SqlConnection sqlConnection1=null;
		private SqlCommand sqlCommand1=null;
		private string strSql = null;
		
		public RenterManage()
		{
			this.sqlConnection1 = new SqlConnection(dbconnection.connection);
			this.sqlCommand1 = new SqlCommand();
			this.sqlCommand1.CommandType = CommandType.Text;
			this.sqlCommand1.Connection = this.sqlConnection1;
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public void Renter_Add(int renterID,string renterName,float renterRental,int contractID,string contact,string remark)
		{
			this.strSql="insert into Renter (RenterID,RenterName,RenterRental,ContractID,Contact,Remark)"+ 
				" values("+renterID+",'"+renterName+"',"+renterRental+","+contractID+",'"+contact+"','"+remark+"')";
			this.sqlCommand1.CommandText = this.strSql;
			try
			{
				this.sqlConnection1.Open();
				this.sqlCommand1.ExecuteNonQuery();
			}
			catch(System.Exception E)
			{
				Console.WriteLine(E.ToString());
			}
			finally
			{
				this.sqlConnection1.Close();
			}
		}

		public bool Renter_Modify(int renterID,string renterName,float renterRental,int contractID,string contact,string remark)
		{
			this.strSql="update Renter set RenterName="+renterName+","+"RenterRental="+renterRental+","+
						"ContractID="+contractID+","+"Contact="+contact+","+"Remark="+remark+
						" where RenterID="+"'"+renterID+"'";
			this.sqlCommand1.CommandText=this.strSql;
			try
			{
				this.sqlConnection1.Open();
				this.sqlCommand1.ExecuteNonQuery();
				return true;
			}
			catch(System.Exception E)
			{
				Console.WriteLine(E.ToString());
				return false;
			}
			finally
			{
				this.sqlConnection1.Close();
			}
		}

		public void Renter_Del(int renterID)
		{
			this.strSql="delete from Renter where RenterID= "+"'"+renterID+"'";
			this.sqlCommand1.CommandText=this.strSql;
			try
			{
				this.sqlConnection1.Open();
				this.sqlCommand1.ExecuteNonQuery();
			}
			catch(System.Exception E)
			{
				Console.WriteLine(E.ToString());
			}
			finally
			{
				this.sqlConnection1.Close();
			}
		}
	}
}
