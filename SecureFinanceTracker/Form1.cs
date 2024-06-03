using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureFinanceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTransactions();
        }

        public string EncryptString(string plainText, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        
                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptString(string cipherText, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void AddTransaction(string type)
        {
            string amount = txtAmount.Text;
            string description = txtDescription.Text;
            string date = txtDate.Text;
            string key = "arusha1324arusha"; // Use a secure key

            string encryptedAmount = EncryptString(amount, key);
            string encryptedDescription = EncryptString(description, key);
            string encryptedDate = EncryptString(date, key);

            string record = $"{type},{encryptedAmount},{encryptedDescription},{encryptedDate}";

            File.AppendAllText("transactions.txt", record + Environment.NewLine);
            MessageBox.Show($"{type} added successfully!");
        }

        private void LoadTransactions()
        {
            string[] lines = File.ReadAllLines("transactions.txt");
            dgvTransactions.Rows.Clear();
            string key = "arusha1324arusha"; // Use a secure key

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string amount = DecryptString(parts[1], key);
                string description = DecryptString(parts[2], key);
                string date = DecryptString(parts[3], key);

                dgvTransactions.Rows.Add(type, amount, description, date);
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddTransaction("Income");
            LoadTransactions();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddTransaction("Expense");
            LoadTransactions();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTransaction("Income");
                LoadTransactions();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
