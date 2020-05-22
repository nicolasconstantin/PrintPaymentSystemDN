using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace AWinForm
{
    public partial class Form1 : Form
    {

        PrinterService.PrinterClient client = new PrinterService.PrinterClient();
        int ID;
        decimal quota;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (FirstNameBox.Visible)
            {
                //Hide the register part
                FirstNameBox.Visible = false;
                LastnameBox.Visible = false;
                RUsernameBox.Visible = false;
                RPwdBox.Visible = false;
                WrittenFN.Visible = false;
                WrittenLN.Visible = false;
                WrittenRUsername.Visible = false;
                WrittenRPwd.Visible = false;

                //Display the login part
                UsernameBox.Visible = true;
                PwdBox.Visible = true;
                WrittenUsername.Visible = true;
                WrittenPwd.Visible = true;

            }
            else
            {
                if(client.GetUserAccount(WrittenUsername.Text, WrittenPwd.Text) 
                    && !WrittenUsername.Text.Equals("") 
                    && !WrittenPwd.Text.Equals("")){
                    //Get logged
                    UsernameBox.Visible = false;
                    PwdBox.Visible = false;
                    WrittenUsername.Visible = false;
                    WrittenPwd.Visible = false;
                    LoginButton.Visible = false;
                    RegisterButton.Visible = false;
                    ID = client.GetIdByUsername(WrittenUsername.Text);

                    //Display everything
                    TransferBox.Visible = true;
                    AccountBox.Visible = true;
                    RemainBox.Visible = true;
                    WrittenTransfert.Visible = true;
                    BalanceBox.Visible = true;
                    ImpresBox.Visible = true;
                    POButton.Visible = true;
                    FButton.Visible = true;
                    ConnectorButton.Visible = true;
                    PrintButton.Visible = true;
                    LogoutButton.Visible = true;
                    quota = client.GetQuotaById(ID);
                    BalanceBox.Text = quota.ToString();
                    ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();

                } else
                {
                    WrittenUsername.Text = "";
                    WrittenPwd.Text = "";
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!FirstNameBox.Visible)
            {
                //Display the register part
                FirstNameBox.Visible = true;
                LastnameBox.Visible = true;
                RUsernameBox.Visible = true;
                RPwdBox.Visible = true;
                WrittenFN.Visible = true;
                WrittenLN.Visible = true;
                WrittenRUsername.Visible = true;
                WrittenRPwd.Visible = true;

                //Hide the login part
                UsernameBox.Visible = false;
                PwdBox.Visible = false;
                WrittenUsername.Visible = false;
                WrittenPwd.Visible = false;

            } else
            {
                if(!WrittenFN.Text.Equals("") && !WrittenLN.Text.Equals("") 
                    && !WrittenRUsername.Text.Equals("") && !WrittenRPwd.Text.Equals(""))
                {
                    AD User = new AD();
                    User.Firstname = WrittenFN.Text;
                    User.Lastname = WrittenLN.Text;
                    User.Username = WrittenRUsername.Text;
                    User.Password = WrittenRPwd.Text;

                    User = client.CreateUser(User);
                    ID = User.UserId;

                    //Hide register part
                    FirstNameBox.Visible = false;
                    LastnameBox.Visible = false;
                    RUsernameBox.Visible = false;
                    RPwdBox.Visible = false;
                    WrittenFN.Visible = false;
                    WrittenLN.Visible = false;
                    WrittenRUsername.Visible = false;
                    WrittenRPwd.Visible = false;
                    LoginButton.Visible = false;
                    RegisterButton.Visible = false;

                    //Display everything
                    TransferBox.Visible = true;
                    AccountBox.Visible = true;
                    RemainBox.Visible = true;
                    WrittenTransfert.Visible = true;
                    BalanceBox.Visible = true;
                    ImpresBox.Visible = true;
                    POButton.Visible = true;
                    FButton.Visible = true;
                    ConnectorButton.Visible = true;
                    PrintButton.Visible = true;
                    LogoutButton.Visible = true;

                    quota = client.GetQuotaById(ID);
                    BalanceBox.Text = quota.ToString();
                    ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void POButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(WrittenTransfert.Text) > 0)
                {
                    quota += Decimal.Parse(WrittenTransfert.Text);
                    client.ModifyQuotaById(ID, quota);
                    BalanceBox.Text = quota.ToString();
                    ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();
                }
            } catch (Exception)
            {

            }
            WrittenTransfert.Text = "";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //Hide everything
            TransferBox.Visible = false;
            AccountBox.Visible = false;
            RemainBox.Visible = false;
            WrittenTransfert.Visible = false;
            BalanceBox.Visible = false;
            ImpresBox.Visible = false;
            POButton.Visible = false;
            FButton.Visible = false;
            ConnectorButton.Visible = false;
            PrintButton.Visible = false;
            LogoutButton.Visible = false;

            //Show login page
            UsernameBox.Visible = true;
            PwdBox.Visible = true;
            WrittenUsername.Visible = true;
            WrittenPwd.Visible = true;
            LoginButton.Visible = true;
            RegisterButton.Visible = true;
            WrittenUsername.Text = "";
            WrittenPwd.Text = "";
            WrittenFN.Text = "";
            WrittenLN.Text = "";
            WrittenRUsername.Text = "";
            WrittenRPwd.Text = "";

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            
            if ((float) quota >= 0.08)
            {
                quota -= (decimal)0.08;
                client.ModifyQuotaById(ID, quota);
                BalanceBox.Text = quota.ToString();
                ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();
            }
            
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(WrittenTransfert.Text) > 0)
                {
                    quota += Decimal.Parse(WrittenTransfert.Text);
                    client.ModifyQuotaById(ID, quota);
                    BalanceBox.Text = quota.ToString();
                    ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();
                }
            }
            catch (Exception)
            {

            }
            WrittenTransfert.Text = "";
        }

        private void ConnectorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(WrittenTransfert.Text) > 0)
                {
                    quota += Decimal.Parse(WrittenTransfert.Text);
                    client.ModifyQuotaById(ID, quota);
                    BalanceBox.Text = quota.ToString();
                    ImpresBox.Text = client.ReturnQuotaToQuantity(quota).ToString();
                }
            }
            catch (Exception)
            {

            }
            WrittenTransfert.Text = "";
        }
    }
}
