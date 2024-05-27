using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Brute_Force_Password_Cracker
{

	public partial class Form1 : Form
	{
		private const string Charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

		private const int MaxPasswordLength = 8;
		private const int MaxAttempts = 1000000;

		private string _targetPassword;
		private int _attempts;
		private DateTime _startTime;

		public Form1()
		{
			InitializeComponent();
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			_targetPassword = txtTargetPassword.Text;
			_attempts = 0;
			_startTime = DateTime.Now;
			label2.Text = "Cracking...";
			await Task.Delay(2000);

			string foundPassword = BruteForcePassword();
			TimeSpan elapsedTime = DateTime.Now - _startTime;

			if (!string.IsNullOrEmpty(foundPassword))
			{
				label2.Text = $"Password cracked: {foundPassword}\nAttempts: {_attempts}\nTime taken: {elapsedTime.TotalSeconds} seconds";
			}
			else
			{
				MessageBox.Show("Password not found.");
			}
		}

		private string BruteForcePassword()
		{
			foreach (string password in GeneratePassword())
			{
				_attempts++;
				if (password == _targetPassword)
				{
					return password;
				}
			}
			return null;
		}
		private System.Collections.Generic.IEnumerable<string> GeneratePassword()
		{
			for (int length = 1; length <= MaxPasswordLength; length++)
			{
				foreach (var combination in GeneratePasswords("", length))
				{
					yield return combination;
				}
			}
		}

		private System.Collections.Generic.IEnumerable<string> GeneratePasswords(string prefix, int length)
		{
			if (length == 0)
			{
				yield return prefix;
			}
			else
			{
				foreach (char c in Charset)
				{
					foreach (var combination in GeneratePasswords(prefix + c, length - 1))
					{
						yield return combination;
					}
				}
			}
		}

		private void txtTargetPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnStart_Click(sender, e);
			}
		}
	}
}
