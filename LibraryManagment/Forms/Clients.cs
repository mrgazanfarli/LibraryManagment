﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Models;

namespace LibraryManagment.Forms
{
    public partial class Clients : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int clickedId;
        private int clickedRow;
        private User User;
        private string[] CmbItems;
        public Clients(User user)
        {
            InitializeComponent();
            User = user;
            CmbItems = new string[]
            {
                "Hamısı",
                "Borclular",
                "Borclu olmayanlar"
            };
            FillDgvClients();
            FillCmbShowClients();
        }

        private string GenerateClientNumber()
        {
            string ClientNumber;
            do
            {
                Random rnd = new Random();
                ClientNumber = DateTime.Now.ToString("yy") + DateTime.Now.Millisecond * 47 + rnd.Next(10, 99);
                if (ClientNumber.Length > 7)
                {
                    while (ClientNumber.Length > 7)
                    {
                        ClientNumber = ClientNumber.Remove(ClientNumber.Length - 1);
                    }
                }
                if (ClientNumber.Length < 7)
                {
                    while (ClientNumber.Length != 7)
                    {
                        Random r = new Random();
                        ClientNumber += r.Next(1, 10);
                    }
                }
            }
            while (db.Clients.Any(c => c.ClientNumber == ClientNumber));
            return ClientNumber;
        }

        private void FillCmbShowClients()
        {
            CmbShowClients.Items.Clear();
            CmbShowClients.Items.AddRange(CmbItems);
        }

        private void FillDgvClients()
        {
            DgvClients.Rows.Clear();
            List<Client> clients = new List<Client>();
            if (CmbShowClients.SelectedItem == null || CmbShowClients.SelectedIndex == 0)
            {
                clients = db.Clients.OrderByDescending(c => c.Surname).ToList();
            }
            //if (CmbShowClients.SelectedIndex == 1)
            //{
            //    clients = db.Clients.Where(u => u.IsBoss).OrderByDescending(u => u.Name).ToList();
            //}
            //if (CmbShowClients.SelectedIndex == 2)
            //{
            //    clients = db.Clients.Where(u => !u.IsBoss).OrderByDescending(u => u.Name).ToList();
            //}

            foreach (Client client in clients)
            {
                DgvClients.Rows.Add(client.Id, client.Name, client.Surname, client.Phone, client.ClientNumber, client.User.Name + " "+ client.User.Surname, client.CreatedAt.ToString("dd MMMM yyyy HH:mm"));
            }
        }

        // Resets all text boxes
        private void Reset()
        {
            TxtName.ResetText();
            TxtSurname.ResetText();
            TxtPhone.ResetText();
            BtnDeleteClient.Visible = false;
            BtnUpdateClient.Visible = false;
            clickedId = 0;
            clickedRow = -1;
        }

        private void DgvClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Do not give an error when the row index not found (clicking the last empty row in Dgv)
            try
            {
                // Take the clicked row in order to update the row when deleting, updating (no need to call FillDgvClients() again)
                clickedId = Convert.ToInt32(DgvClients.Rows[e.RowIndex].Cells[0].Value.ToString());
                clickedRow = e.RowIndex;
                TxtName.Text = DgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtSurname.Text = DgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtPhone.Text = DgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                Exception ClickedLastRow = new KeyNotFoundException();
                Reset();
            }
            BtnDeleteClient.Visible = true;
            BtnUpdateClient.Visible = true;
        }
        
        // When a client is added, validations are done and some other parameters are created...
        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }

            Client cl = new Client
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                WhoRegistered = User.Id,
                CreatedAt = DateTime.Now,
                ClientNumber = GenerateClientNumber()
            };
            db.Clients.Add(cl);
            db.SaveChanges();
            // Add new user to DgvUsers
            DgvClients.Rows.Add(cl.Id, cl.Name, cl.Surname, cl.Phone, cl.ClientNumber, db.Users.Find(cl.WhoRegistered).Name + " " + db.Users.Find(cl.WhoRegistered).Surname, cl.CreatedAt.ToString("dd MMMM yyyy HH:mm"));
            MessageBox.Show("Müştəri əlavə olundu!");
            Reset();
        }

        // The same validations as in adding are done when updating a client's data
        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            // Again check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }
            Client cl = db.Clients.Find(clickedId);
            cl.Name = TxtName.Text;
            cl.Surname = TxtSurname.Text;
            cl.Phone = TxtPhone.Text;
            db.SaveChanges();
            // Now update the Data Grid View
            DgvClients.Rows[clickedRow].Cells[1].Value = cl.Name;
            DgvClients.Rows[clickedRow].Cells[2].Value = cl.Surname;
            DgvClients.Rows[clickedRow].Cells[3].Value = cl.Phone;
            // Finished
            MessageBox.Show("Müştəri yeniləndi...");
            Reset();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            // First confirm user's request
            DialogResult r = MessageBox.Show("Müştərini silməyə əminsinizmi? Bu zaman bu müştəri haqqında bütün məlumatlar silinəcək", "Sil", MessageBoxButtons.YesNo);
            // If he/she confirms, start deleting
            if (r == DialogResult.Yes)
            {
                Client cl = db.Clients.Find(clickedId);
                db.Clients.Remove(cl);
                db.SaveChanges();
                // Update DGV
                DgvClients.Rows.RemoveAt(clickedRow);
                // Finished
                MessageBox.Show("Müştəri silindi");
                Reset();
            }
        }

        private void CmbShowClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvClients();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}