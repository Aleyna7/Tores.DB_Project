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
            //Uygulamadan ��k��
            Application.Exit();
        }

        private void pnlRoomList_Click(object sender, EventArgs e)
        {
            //Oda Listesi a��lacak
        }

        private void pnlRezervationRequest_Click(object sender, EventArgs e)
        {
            //Rezervasyon listesi
        }

        private void pnlLogData_Click(object sender, EventArgs e)
        {
            //Giri� Kay�tlar�
        }

        private void pnlMeetRoom_Click(object sender, EventArgs e)
        {
            //Toplant� Odas�
        }

        private void pnlSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Novas Works Toplant� Odalar� Rezervasyon sistemindesiniz. TORES sizlerin toplant�lar�n�z�n �ak��mas�n� engelemek i�in yap�lm��t�r. " +
                "\r\n Admin giri�i i�in;\r\n Kullan�c� Ad� = Admin" +
                "\r\n �ifre = Q1w2e3" +
                "\r\n EMail = umit.karacivi@outlook.com");
        }

    }
}