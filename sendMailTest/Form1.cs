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
            try
            {
                var smtpClient = new SmtpClient("192.1.1.30")
                {
                    Port = 25,
                    EnableSsl = false,
                };

                smtpClient.Send("shopfloor_service@konfe.dom", "Eduardo.Jimenez@ke-elektronik.de", "Prueba con c#", "prueba con C#");
                MessageBox.Show("Mensaje OK");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
