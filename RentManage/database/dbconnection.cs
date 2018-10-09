using System;

namespace RentManage.database
{
	/// <summary>
	/// dbconnection 的摘要说明。
	/// </summary>
	public class dbconnection
	{
		public dbconnection()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static string connection
		{
			get{return"data source=(local);user id=sa;password=;initial catalog=RentManage;integrated security=SSPI;"; }
		}
	}
}
