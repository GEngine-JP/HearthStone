using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RentManage
{
	/// <summary>
	/// Help 的摘要说明。
	/// </summary>
	public class Help : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Help()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(144, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "房屋出租管理系统";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(56, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "数据库设置步骤：";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(88, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 40);
			this.label3.TabIndex = 2;
			this.label3.Text = "打开SQL Server企业管理器，单击控制台前面的加号按钮，直到出现数据库，然后在数据库上单击鼠标右键";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(88, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(368, 72);
			this.label4.TabIndex = 3;
			this.label4.Text = "从弹出式菜单选择【所有任务】－>【附加数据库】，然后单击【...】按钮，选择本章源代码中的DataBase文件夹下的RentManage.mdf文件，其他采用默认" +
				"设置，然后单击【确定】按钮";
			// 
			// Help
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(542, 326);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Help";
			this.Text = "帮助";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
