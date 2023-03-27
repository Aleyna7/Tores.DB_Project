namespace Tores.DB_Project
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlRoomList = new Panel();
            lblOdaListesi = new Label();
            pnlRezervationRequest = new Panel();
            lblRezervasyonİstekleri = new Label();
            pnlLogData = new Panel();
            lblLogKayıtları = new Label();
            pnlMeetRoom = new Panel();
            lblToplantıOdaları = new Label();
            pnlSupport = new Panel();
            lblSupport = new Label();
            pnlExit = new Panel();
            lblExit = new Label();
            pnlRoomList.SuspendLayout();
            pnlRezervationRequest.SuspendLayout();
            pnlLogData.SuspendLayout();
            pnlMeetRoom.SuspendLayout();
            pnlSupport.SuspendLayout();
            pnlExit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoomList
            // 
            pnlRoomList.BackColor = Color.FromArgb(51, 217, 178);
            pnlRoomList.Controls.Add(lblOdaListesi);
            pnlRoomList.Location = new Point(12, 12);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(322, 141);
            pnlRoomList.TabIndex = 0;
            // 
            // lblOdaListesi
            // 
            lblOdaListesi.AutoSize = true;
            lblOdaListesi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdaListesi.Location = new Point(95, 59);
            lblOdaListesi.Name = "lblOdaListesi";
            lblOdaListesi.Size = new Size(126, 31);
            lblOdaListesi.TabIndex = 0;
            lblOdaListesi.Text = "Oda Listesi";
            // 
            // pnlRezervationRequest
            // 
            pnlRezervationRequest.BackColor = Color.FromArgb(204, 174, 98);
            pnlRezervationRequest.Controls.Add(lblRezervasyonİstekleri);
            pnlRezervationRequest.Location = new Point(340, 12);
            pnlRezervationRequest.Name = "pnlRezervationRequest";
            pnlRezervationRequest.Size = new Size(322, 141);
            pnlRezervationRequest.TabIndex = 1;
            pnlRezervationRequest.Click += pnlRezervationRequest_Click;
            // 
            // lblRezervasyonİstekleri
            // 
            lblRezervasyonİstekleri.AutoSize = true;
            lblRezervasyonİstekleri.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblRezervasyonİstekleri.Location = new Point(54, 59);
            lblRezervasyonİstekleri.Name = "lblRezervasyonİstekleri";
            lblRezervasyonİstekleri.Size = new Size(224, 31);
            lblRezervasyonİstekleri.TabIndex = 1;
            lblRezervasyonİstekleri.Text = "Rezervasyon İstekleri";
            // 
            // pnlLogData
            // 
            pnlLogData.BackColor = Color.FromArgb(33, 140, 116);
            pnlLogData.Controls.Add(lblLogKayıtları);
            pnlLogData.Location = new Point(12, 159);
            pnlLogData.Name = "pnlLogData";
            pnlLogData.Size = new Size(322, 141);
            pnlLogData.TabIndex = 2;
            pnlLogData.Click += pnlLogData_Click;
            // 
            // lblLogKayıtları
            // 
            lblLogKayıtları.AutoSize = true;
            lblLogKayıtları.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogKayıtları.Location = new Point(81, 56);
            lblLogKayıtları.Name = "lblLogKayıtları";
            lblLogKayıtları.Size = new Size(140, 31);
            lblLogKayıtları.TabIndex = 1;
            lblLogKayıtları.Text = "Log Kayıtları";
            // 
            // pnlMeetRoom
            // 
            pnlMeetRoom.BackColor = Color.FromArgb(52, 172, 224);
            pnlMeetRoom.Controls.Add(lblToplantıOdaları);
            pnlMeetRoom.Location = new Point(340, 159);
            pnlMeetRoom.Name = "pnlMeetRoom";
            pnlMeetRoom.Size = new Size(322, 141);
            pnlMeetRoom.TabIndex = 3;
            pnlMeetRoom.Click += pnlMeetRoom_Click;
            // 
            // lblToplantıOdaları
            // 
            lblToplantıOdaları.AutoSize = true;
            lblToplantıOdaları.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplantıOdaları.Location = new Point(77, 56);
            lblToplantıOdaları.Name = "lblToplantıOdaları";
            lblToplantıOdaları.Size = new Size(177, 31);
            lblToplantıOdaları.TabIndex = 1;
            lblToplantıOdaları.Text = "Toplantı Odaları";
            // 
            // pnlSupport
            // 
            pnlSupport.BackColor = Color.FromArgb(255, 218, 121);
            pnlSupport.Controls.Add(lblSupport);
            pnlSupport.Location = new Point(12, 306);
            pnlSupport.Name = "pnlSupport";
            pnlSupport.Size = new Size(322, 141);
            pnlSupport.TabIndex = 4;
            pnlSupport.Click += pnlSupport_Click;
            // 
            // lblSupport
            // 
            lblSupport.AutoSize = true;
            lblSupport.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupport.Location = new Point(95, 62);
            lblSupport.Name = "lblSupport";
            lblSupport.Size = new Size(96, 31);
            lblSupport.TabIndex = 1;
            lblSupport.Text = "Support";
            // 
            // pnlExit
            // 
            pnlExit.BackColor = Color.FromArgb(255, 82, 82);
            pnlExit.Controls.Add(lblExit);
            pnlExit.Location = new Point(340, 306);
            pnlExit.Name = "pnlExit";
            pnlExit.Size = new Size(322, 141);
            pnlExit.TabIndex = 5;
            pnlExit.Click += panel6_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.Location = new Point(127, 62);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(51, 31);
            lblExit.TabIndex = 1;
            lblExit.Text = "Exit";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 459);
            Controls.Add(pnlExit);
            Controls.Add(pnlSupport);
            Controls.Add(pnlMeetRoom);
            Controls.Add(pnlLogData);
            Controls.Add(pnlRezervationRequest);
            Controls.Add(pnlRoomList);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            pnlRoomList.ResumeLayout(false);
            pnlRoomList.PerformLayout();
            pnlRezervationRequest.ResumeLayout(false);
            pnlRezervationRequest.PerformLayout();
            pnlLogData.ResumeLayout(false);
            pnlLogData.PerformLayout();
            pnlMeetRoom.ResumeLayout(false);
            pnlMeetRoom.PerformLayout();
            pnlSupport.ResumeLayout(false);
            pnlSupport.PerformLayout();
            pnlExit.ResumeLayout(false);
            pnlExit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRoomList;
        private Label lblOdaListesi;
        private Panel pnlRezervationRequest;
        private Label lblRezervasyonİstekleri;
        private Panel pnlLogData;
        private Label lblLogKayıtları;
        private Panel pnlMeetRoom;
        private Label lblToplantıOdaları;
        private Panel pnlSupport;
        private Label lblSupport;
        private Panel pnlExit;
        private Label lblExit;
    }
}