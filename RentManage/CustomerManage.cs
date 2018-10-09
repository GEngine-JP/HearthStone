using System;
using System.Data;
using System.Data.SqlClient;

namespace RentManage
{
	/// <summary>
	/// CustomerManage 的摘要说明。
	/// </summary>
	public class CustomerManage
	{
		private SqlConnection sqlConnection1 = null;
		private SqlCommand sqlCommand1 = null;
		private SqlCommand sqlCommand2 = null;
		private string strSql = null;
		
		public CustomerManage()
		{
			sqlConnection1 = new SqlConnection(RentManage.database.dbconnection.connection);
			sqlCommand1 = new SqlCommand();
			sqlCommand1.CommandType = CommandType.Text;
			sqlCommand1.Connection = sqlConnection1;
			sqlCommand2 = new SqlCommand();
			sqlCommand2.CommandType = CommandType.Text;
			sqlCommand2.Connection = sqlConnection1;
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public void Customer_Add(int customerID,string customerName,string sex,string nativePlace,string IDCard,string roomID,
			System.DateTime indate,System.DateTime rentalDate,int contractID,float customerRental,string remark)
		{
			strSql="insert into Customer (CustomerID,CustomerName,Sex,NativePlace,IDCard,RoomID,InDate,RentalDate,"+
				"ContractID,CustomerRental,Remark) values ("+customerID+",'"+customerName+"','"+sex+"','"+nativePlace+"',"+
				""+IDCard+","+roomID+",'"+indate+"','"+rentalDate+"',"+contractID+","+customerRental+",'"+remark+"')";
			sqlCommand1.CommandText = strSql;
			try
			{
				sqlConnection1.Open();
				sqlCommand1.ExecuteNonQuery();
				trueNum_add(roomID);
			}
			catch(System.Exception E)
			{
				Console.WriteLine(E.ToString());
			}
			finally
			{
				sqlConnection1.Close();
			}
		}

		public void trueNum_add(string roomID)
		{
			strSql="Update RoomInfo Set TrueNum=TrueNum+1 Where RoomID="+"'"+roomID+"'";
			sqlCommand2.CommandText = strSql;

			try
			{
				if(sqlConnection1.State == ConnectionState.Closed)
					sqlConnection1.Open();
				sqlCommand2.ExecuteNonQuery();
			}
			catch(System.Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			finally
			{
				sqlConnection1.Close();
			}
		}
	}
}
