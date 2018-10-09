using System;
using System.Data;
using System.Data.SqlClient;

namespace RentManage
{
	/// <summary>
	/// RoomManange 的摘要说明。
	/// </summary>
	public class RoomManange
	{
		private SqlConnection sqlConnection1 = null;
		private SqlCommand sqlCommand1 = null;
		private string strSql = null;
		
		public RoomManange()
		{
			this.sqlConnection1=new SqlConnection(RentManage.database.dbconnection.connection);
			this.sqlCommand1=new SqlCommand();
			this.sqlCommand1.CommandType=CommandType.Text;
			this.sqlCommand1.Connection=this.sqlConnection1;
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public void room_Add(int roomID,int renterID,string roomtype,string location,string floor,int ratingNum,
			int trueNum,int area,float price,int airCondition,int telephone,int TV,int washRoom,int kitchen,
			int internet,string remark)
		{
			this.strSql="insert into RoomInfo (RoomID,RenterID,RoomType,Location,Floor,RatingNum,TrueNum,Area,"+
						"Price,AirCondition,Telephone,TV,WashRoom,Kitchen,Internet,Remark) values ("+roomID+","+renterID+","+
						"'"+roomtype+"','"+location+"','"+floor+"',"+ratingNum+","+trueNum+","+area+","+price+","+
						""+airCondition+","+telephone+","+TV+","+washRoom+","+kitchen+","+internet+",'"+remark+"')";
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
	}
}
