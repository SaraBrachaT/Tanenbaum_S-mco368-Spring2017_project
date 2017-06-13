using DBClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CClasses
{
    public partial class LoginForm : Form
    {
        public static string username { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            signInErrorLabel.Hide();
            newUserErrorLbl.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                var password = context.Users.Where(u => u.Username == userNameTxt.Text).Select(u => u.Password).FirstOrDefault();
                if (!string.IsNullOrEmpty(password) && passwordTxt.Text.Equals(password.ToString()))
                {
                    username = userNameTxt.Text;
                    Program.itemListing.Show();
                    this.Hide();
                }
                else
                {
                    userNameTxt.Text = string.Empty;
                    passwordTxt.Text = string.Empty;
                    signInErrorLabel.Show();
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (ValidateNewCredentials())
            {
                newUserErrorLbl.Hide();
                using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
                {
                    var user = context.Users.FirstOrDefault(u => newUsernameTxt.Text == u.Username);
                    if (user == null)
                    {
                        username = newUsernameTxt.Text;
                        LinqToSqlClassDataContext dc = new LinqToSqlClassDataContext();
                        User usr = new User
                        {
                            Username = username,
                            Password = newPasswordTxt.Text,
                            Balance = 0.0
                        };
                        dc.Users.InsertOnSubmit(usr);
                        dc.SubmitChanges();
                        
                        Program.itemListing.Show();
                        this.Hide();
                    }
                    else
                    {
                        newUsernameTxt.Text = string.Empty;
                        newPasswordTxt.Text = string.Empty;
                        confirmPasswordTxt.Text = string.Empty;
                        newUserErrorLbl.Text = "User already exists";
                        newUserErrorLbl.Show();
                    }
                }
            }
               /* string sql = $"Insert into Users(Username, Password, Balance) values ('{newUsernameTxt.Text}', '{newPasswordTxt.Text}', 0)";
                try
                {
                    DBClasses.DbSingletonConn.Instance.GetReader(sql);
                    username = userNameTxt.Text;
                    Program.itemListing.Show();
                    this.Hide();
                }
/*              catch (System.Data.SqlClient.SqlException)
                {
                    newUserErrorLbl.Text = "User already exists";
                    newUserErrorLbl.Show();
                }*/
        }

        private bool ValidateNewCredentials()
        {
            string errorText = "\nPlease Try Again";
            newUserErrorLbl.Show();

            if (newUsernameTxt.Text.Equals(newPasswordTxt.Text))
            {
                newUserErrorLbl.Text = $"Password and Username Cannot Be the Same {errorText}";
                return false;
            }

            if (!newPasswordTxt.Text.Equals(confirmPasswordTxt.Text))
            {
                newUserErrorLbl.Text = $"Password and Confirm Password fields must contain the same text {errorText}";
                return false;
            }

            // if(//username exists)) return false;
            //                newUserErrorLbl.Text = "A User With This Name Already Exists + errorText;
            //return false;
            if (newPasswordTxt.TextLength < 8)
            {
                newUserErrorLbl.Text = $"Password Must Be Atleast 8 Characters {errorText}";
                return false;
            }
            Boolean hasUpper = false;
            Boolean hasLower = false;
            Boolean hasNumber = false;
            foreach (char c in newPasswordTxt.Text)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsNumber(c)) hasNumber = true;
            }
            if (!hasUpper || !hasLower || !hasNumber)
            {
                newUserErrorLbl.Text =
                    $"Password must be a combination of uppercase letters, lowercase letters, and numbers {errorText}";
                return false;
            }
            return true;
        }

        private void newUsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if(!(newUserErrorLbl.Text.Equals(string.Empty)))
                newUserErrorLbl.Hide();
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(userNameTxt.Text.Equals(string.Empty)))
            {
                signInErrorLabel.Hide();
            }
        }
    }
}
