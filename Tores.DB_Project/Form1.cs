using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Tores.DB_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            //Uygulamadan çýkýþ
            Application.Exit();
        }

        private void pnlRoomList_Click(object sender, EventArgs e)
        {
            //Oda Listesi açýlacak
        }

        private void pnlRezervationRequest_Click(object sender, EventArgs e)
        {
            //Rezervasyon listesi
        }

        private void pnlLogData_Click(object sender, EventArgs e)
        {
            //Giriþ Kayýtlarý
        }

        private void pnlMeetRoom_Click(object sender, EventArgs e)
        {
            //Toplantý Odasý
        }

        private void pnlSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Novas Works Toplantý Odalarý Rezervasyon sistemindesiniz. TORES sizlerin toplantýlarýnýzýn çakýþmasýný engelemek için yapýlmýþtýr. " +
                "\r\n Admin giriþi için;\r\n Kullanýcý Adý = Admin" +
                "\r\n Þifre = Q1w2e3" +
                "\r\n EMail = umit.karacivi@outlook.com");
        }

    }
}