using System;
using System.Web.Mail;

namespace Tools
{
	/// <summary>
	/// obMail ��ժҪ˵����
	/// </summary>
	public class obMail
	{
		public obMail()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		#region �����ʼ�
		/// <summary>
		/// �����ʼ�
		/// </summary>
		/// <Author>Terminate</Author>
		/// <CreateTime>2006-10-1</CreateTime>
		/// <param name="MailFrom">������[�����˵�ַ]</param>
		/// <param name="MailTo">�����˵�ַ</param>
		/// <param name="MailSubject">�ż�����</param>
		/// <param name="MailBody">�ż�����</param>
		public static void SenddMail(string MailFrom,string MailTo,string MailSubject,string MailBody)
		{
			string SmtpServer,UserName,UserPwd;
			bool MailCheck;
			SmtpServer="mail.hbu.cn";
			UserName="haodongliang";
			UserPwd="hao@nic-hbu";
			MailCheck=true;

			MailMessage MailObj=new MailMessage();
			SmtpMail.SmtpServer=SmtpServer;
			if(MailCheck)
			{
				//��֤
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate","1");//��֤��ʽ1��֤��0����֤
				//�û���
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername",UserName);
				//����
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword",UserPwd);
			}
			MailObj.From		=MailFrom;			//������
			MailObj.To			=MailTo;			//�ռ���
			MailObj.Subject		=MailSubject;		//�ʼ�����
			MailObj.Priority	=MailPriority.High;	//�ʼ��ȼ�
			MailObj.BodyFormat	=MailFormat.Html;	//�ʼ����ݸ�ʽ
			MailObj.Body		=MailBody;			//�ʼ�����			
			SmtpMail.Send(MailObj);
		}
		#endregion

		#region �����ʼ���������������
		/// <summary>
		/// �����ʼ���������������
		/// </summary>
		/// <Author>Terminate</Author>
		/// <CreateTime>2006-10-1</CreateTime>
		/// <param name="SmtpServer">Smtp��������ַ</param>
		/// <param name="UserName">�û���</param>
		/// <param name="UserPwd">����</param>
		/// <param name="MailFrom">������[�����˵�ַ]</param>
		/// <param name="MailTo">�����˵�ַ</param>
		/// <param name="MailSubject">�ż�����</param>
		/// <param name="MailBody">�ż�����</param>
		/// <param name="MailCheck">��������֤</param>
		public static void SendMail(string SmtpServer,string UserName,string UserPwd,string MailFrom,string MailTo,string MailSubject,string MailBody,bool MailCheck)
		{ 
			MailMessage MailObj=new MailMessage();
			SmtpMail.SmtpServer=SmtpServer;
			if(MailCheck)
			{
				//��֤
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate","1");//��֤��ʽ1��֤��0����֤
				//�û���
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername",UserName);
				//����
				MailObj.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword",UserPwd);
			}
			MailObj.From		=MailFrom;			//������
			MailObj.To			=MailTo;			//�ռ���
			MailObj.Subject		=MailSubject;		//�ʼ�����
			MailObj.Priority	=MailPriority.High;	//�ʼ��ȼ�
			MailObj.BodyFormat	=MailFormat.Html;	//�ʼ����ݸ�ʽ
			MailObj.Body		=MailBody;			//�ʼ�����			
			SmtpMail.Send(MailObj);
		}
		#endregion
	}
}
