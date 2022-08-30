using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendMailTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("shopfloor_service@konfe.dom");
            mail.To.Add("Eduardo.Garcia@ke-elektronik.de");
            mail.Subject = "STROC";
            mail.Body = "<h3><b>Tienes requisiciones por aprobar</b></h3> <h5><p><i>Favor de no responder este correo.</i></p></h5> <h5><p><i>Atte. IT-Shopfloor</i></p></h5>";
            mail.IsBodyHtml = true;

            try
            {
                var smtpClient = new SmtpClient("192.1.1.30")
                {
                    Port = 25,
                    EnableSsl = false,
                };

                smtpClient.Send(mail);
                MessageBox.Show("Mensaje OK");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
