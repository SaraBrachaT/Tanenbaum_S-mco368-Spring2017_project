using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClasses;

namespace CClasses
{
    public partial class ItemListing : Form
    {
        private static int NUM_ITEMS = 8;
        public ItemListing()
        {
            InitializeComponent();
            setUpLabels();
        }

        private void RefreshData()
        {
            purchaseResponseLbl.Text = String.Empty;
            purchaseResponseLbl.Visible = false;
        }
        private void setUpLabels()
        {
            
            for (int i = 1; i <= NUM_ITEMS; i++)
            {
                using (LinqToSqlClassDataContext context = new LinqToSqlClassDataContext())
                {
                    var items = context.Items.Where(a => a.ItemId == i).First();
                    Label label = (Label)Controls.Find("item" + i + "Lbl", true).FirstOrDefault();
                    label.Text = $"{items.Description}\nPrice: {items.Price}";
                }
/*              string sqlInfo = "SELECT * FROM ITEMS WHERE ITEMID = " + i;
                var rs = DBClasses.DbSingletonConn.Instance.GetReader(sqlInfo);
                while (rs.Read())
                {
                Label label = (Label)Controls.Find("item" + i +"Lbl", true).FirstOrDefault();
                   
                string text = "";
                text = text + rs["Description"];
                text = text + "\nPrice: ";
                text = text + rs["Price"];
                label.Text = text;*/
            }
       }

        private void purchase1_Click(object sender, EventArgs e)
        {
            purchaseItem(1, qty1.Value);
        }

        private void purchase2_Click(object sender, EventArgs e)
        {
            purchaseItem(2, qty2.Value);
        }

        private void purchase3_Click(object sender, EventArgs e)
        {
            purchaseItem(3, qty3.Value);
        }

        private void purchase4_Click(object sender, EventArgs e)
        {
            purchaseItem(4, qty4.Value);
        }

        private void purchase5_Click(object sender, EventArgs e)
        {
            purchaseItem(5, qty5.Value);
        }

        private void purchase6_Click(object sender, EventArgs e)
        {
            purchaseItem(6, qty6.Value);
        }

        private void purchase7_Click(object sender, EventArgs e)
        {
            purchaseItem(7, qty7.Value);
        }

        private void purchase8_Click(object sender, EventArgs e)
        {
            purchaseItem(8, qty8.Value);
        }

        private void purchaseItem(int item, decimal qty)
        {
            //run sql trigger
            try
            {
                int amount = 0;
                string sql = "declare @userid int;"
                             + $" select @userid = UserId from Users where Username = '{LoginForm.username}' "
                             + $"INSERT INTO PURCHASES(PurchaseDate, ITEM_ITEMID, USER_USERID, PurchaseQuantity) VALUES(GETDATE(), {item}, @userid, {qty})";
                DBClasses.DbSingletonConn.Instance.GetReader(sql);
                purchaseResponseLbl.Text =
                    "Item purchased. To view all purchase information, click Account Information";
                purchaseResponseLbl.Visible = true;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Insufficient Balance"))
                {
                    purchaseResponseLbl.Text = "Insufficient Balance";
                }
                else
                {
                    purchaseResponseLbl.Text = "Item out of Stock";
                }
                purchaseResponseLbl.Visible = true;
            }
            
        }

        private void ItemListing_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = $"Welcome {LoginForm.username}";
        }

        private void viewAcctBtn_Click(object sender, EventArgs e)
        {
            Program.accountInformation.RefreshData();
            Program.accountInformation.Visible = true;
            Program.itemListing.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
