using System;

namespace RentManage.database
{
	/// <summary>
	/// dbconnection ��ժҪ˵����
	/// </summary>
	public class dbconnection
	{
		public dbconnection()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public static string connection
		{
			get{return"data source=(local);user id=sa;password=;initial catalog=RentManage;integrated security=SSPI;"; }
		}
	}
}
