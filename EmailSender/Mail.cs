/*
 * Created by SharpDevelop.
 * User: alexF
 * Date: 18.08.2018
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Data.SQLite;


namespace EmailSender
{
	public struct Sender
	{
		public string Email;
		public string Password;
		
		public Sender(string email, string password)
		{
			Email = email;
			Password = password;
		}
	}
	
	public class Emails
	{
		public Dictionary<int, Sender> Addresses;
		
		private void AddMails()
		{
			Addresses = new Dictionary<int, Sender>();
			Addresses.Add(1, new Sender("",""));
		}
	}
	
	public class Mail
	{	
		public string Subject { get; set;}
		public string Body { get; set;}
		//public object Attachment { get; set; }
		public string Sender{ get; set; }
		private string SendersPassword;
		public string Reciever { get; set; }
		
		public Mail(string subject, string body, /*object attachment,*/ Sender sender, string reciever)
		{
			Subject = subject;
			Body = body;
			//Attachment = attachment;
			Sender = sender.Email;
			SendersPassword = sender.Password;
			Reciever = reciever;
		}
		
		public void Send()
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(this.Sender, this.SendersPassword)
            };
            using (var message = new MailMessage(this.Sender, this.Reciever)
                   {Subject = this.Subject, Body = this.Body})
            {
                smtp.Send(message);
            }
        }
	}
	
	
}
