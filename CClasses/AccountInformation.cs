using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DBClasses;

namespace CClasses
{
    public partial class AccountInformation : Form
    {
        public AccountInformation()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            //this way inserts LoginForm.username
            viewAcctInfo(null, null);
            AccountInformation_Load(null, null);
            //AccountInformation_Load(null, null);
        }

        private void viewAcctInfo(object sender, EventArgs e)
        {
            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                var balance = context.Users.Where(u => u.Username == LoginForm.username).Select(u => u.Balance).FirstOrDefault();
                acctBalanceLbl.Text = $"Current Balance: ${balance}";
            }
/*            
            string sql = $"select balance from Users where Username = '{LoginForm.username}'";
            var rs = DBClasses.DbSingletonConn.Instance.GetReader(sql);
            if (rs.Read())
            {
                acctBalanceLbl.Text = "Current Balance: $" + rs["balance"];
            }*/
       }

        private void viewPayInfo(object sender, EventArgs e)
        {
            paymentAmountTxt.Clear();
        }
        private void toItemListingBtn_Click(object sender, EventArgs e)
        {
            Program.accountInformation.RefreshData();
            Program.accountInformation.Visible = false;
            Program.itemListing.Visible = false;
            Program.itemListing.ShowDialog();
        }
        
        private void switchtab_Click(object sender, EventArgs e)
        {
            if (monetaryOptions.TabPages[monetaryOptions.SelectedIndex].Equals(viewAcctTab))
            {
                viewAcctInfo(sender, e);
            }
            else
            {
                viewPayInfo(sender, e);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {
         
            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                if (!(context.Purchases
                  //  .ToList()
                   .Where(p => p.User.Username == LoginForm.username)
                    .Any())) return;
                var allPurchases = context.Purchases.ToList()
                    .Where(p => p.User.Username == LoginForm.username).ToList()
                    .Select(p => new
                       {
                           Item = p.Item.Description,
                        Date =  p.PurchaseDate,
                        UnitPrice = p.Item.Price,
                        Quantity = p.PurchaseQuantity,
                        TotalCost = p.Item.Price * p.PurchaseQuantity
                       })
                       .ToList();
                allPurchasesGrid.DataSource = allPurchases;
            }

            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                
                var datePurchases = context.Purchases.ToList()
                    .Where(p => p.User.Username == LoginForm.username && p.PurchaseDate >= startDateDTP.Value && p.PurchaseDate <= endDateDTP.Value).ToList()
                    .Select(p => new
                    {
                        Item = p.Item.Description,
                        Date = p.PurchaseDate,
                        UnitPrice = p.Item.Price,
                        Quantity = p.PurchaseQuantity,
                        TotalCost = p.Item.Price * p.PurchaseQuantity
                    })

                    .ToList();
                datePurchasesGrid.DataSource = datePurchases;
            }

            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                if (minPriceTxt.Text == String.Empty || maxPriceTxt.Text == String.Empty)
                {
                    return;
                }
                var pricePurchases = context.Purchases.ToList()
                    .Where(p => p.User.Username == LoginForm.username && p.Item.Price >= Double.Parse(minPriceTxt.Text) && p.Item.Price <= Double.Parse(maxPriceTxt.Text)).ToList()
                    .Select(p => new
                    {
                        Item = p.Item.Description,
                        Date = p.PurchaseDate,
                        UnitPrice = p.Item.Price,
                        Quantity = p.PurchaseQuantity,
                        TotalCost = p.Item.Price * p.PurchaseQuantity
                    })

                    .ToList();
                pricePurchasesGrid.DataSource = pricePurchases;
            }

            userAccountLbl.Text = $"Account Information for {LoginForm.username}";


        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
            {
                var balance = context.Users.Where(u => u.Username == LoginForm.username).First().Balance;
                context.Users.Where(u => u.Username == LoginForm.username).First().Balance = balance + double.Parse(paymentAmountTxt.Text);
                context.SubmitChanges();
            }
        }

        private void dateGoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SBT-PC1\\SQLEXPRESS; Initial Catalog = DBModel.Context; Integrated Security = True");
            con.Open();
            using (SqlCommand sqlCommand = new SqlCommand(
                $"select  Description, Price, PurchaseQuantity, PurchaseDate FROM dbo.Items inner join dbo.Purchases on Items.ItemId = Purchases.Item_ItemId where Purchases.User_UserId = (select UserId from Users where Username = '{LoginForm.username}' and purchaseDate >= '{startDateDTP.Value}' and purchaseDate <= '{endDateDTP.Value}')",
                con))
            {
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdap.Fill(ds);
                datePurchasesGrid.DataSource = ds.Tables[0].DefaultView;
            }
            con.Close();
        }

        private void priceGoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SBT-PC1\\SQLEXPRESS; Initial Catalog = DBModel.Context; Integrated Security = True");
            con.Open();
            using (SqlCommand sqlCommand = new SqlCommand(
                $"select  Description, Price, PurchaseQuantity, PurchaseDate FROM dbo.Items inner join dbo.Purchases on Items.ItemId = Purchases.Item_ItemId where Purchases.User_UserId = (select UserId from Users where Username = '{LoginForm.username}' and price >= '{minPriceTxt.Text}' and price <= '{maxPriceTxt.Text}')",
                con))
            {
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdap.Fill(ds);
                pricePurchasesGrid.DataSource = ds.Tables[0].DefaultView;
            }
            con.Close();
        }

    }
}
