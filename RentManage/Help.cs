using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RentManage
{
	/// <summary>
	/// Help ��ժҪ˵����
	/// </summary>
	public class Help : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Help()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����_GB2312", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(144, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "���ݳ������ϵͳ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("����_GB2312", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(56, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "���ݿ����ò��裺";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(88, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 40);
			this.label3.TabIndex = 2;
			this.label3.Text = "��SQL Server��ҵ����������������̨ǰ��ļӺŰ�ť��ֱ���������ݿ⣬Ȼ�������ݿ��ϵ�������Ҽ�";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("����", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(88, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(368, 72);
			this.label4.TabIndex = 3;
			this.label4.Text = "�ӵ���ʽ�˵�ѡ���������񡿣�>���������ݿ⡿��Ȼ�󵥻���...����ť��ѡ����Դ�����е�DataBase�ļ����µ�RentManage.mdf�ļ�����������Ĭ��" +
				"���ã�Ȼ�󵥻���ȷ������ť";
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
			this.Text = "����";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
