/*
 * Created by SharpDevelop.
 * User: alexF
 * Date: 18.08.2018
 * Time: 21:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SQLite;

namespace EmailSender
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
				
		List<string> sendersList;
		List<Sender> senders;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			sendersList = new List<string>();
			senders = new List<Sender>();
			
			sendersList.AddRange(File.ReadAllLines(@"c:\SharpDevelop Projects\EmailSender\EmailSender\emails.txt"));
			
			for(int i = 0; i < sendersList.Count - 1; i+=2)
			{
				senders.Add(new Sender(sendersList[i], sendersList[i+1]));
			}
			
			foreach(Sender s in senders)
			{
				comboBox1.Items.Add(s.Email);
			}
		}
		
		void SendBtnClick(object sender, EventArgs e)
		{
			Sender fromAddress = new Sender();
			try
			{
				fromAddress.Email = comboBox1.SelectedItem.ToString();
				foreach(Sender s in senders)
				{
					if(s.Email == fromAddress.Email)
						fromAddress.Password = s.Password;
				}
				Mail letter = new Mail(subjectTB.Text, bodyRTB.Text, fromAddress, recieverTB.Text);
				try
				{
					letter.Send();
					MessageBox.Show("Message sended!");
				}
				catch(Exception ex)
				{
					MessageBox.Show("Somethig went wrong2");
					MessageBox.Show(ex.Message);
					return;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Somethig went wrong1");
				MessageBox.Show(ex.Message);
				return;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            using (mailsEntities3 db = new mailsEntities3())
            {
                //var sender1 = new senders { Name = "test2", Password = "136661", mail_type_id = 3 };
                //db.senders.Add(sender1);
                //db.SaveChanges();

                var mailTypes = db.mail_types.ToList();
                //var senders1 = db.senders.ToList();
                //var sender1 = senders1[0];
                var mailType = mailTypes.FirstOrDefault(m => m.id == 3);
                MessageBox.Show(mailType.name);
            }
        }
    }
}
