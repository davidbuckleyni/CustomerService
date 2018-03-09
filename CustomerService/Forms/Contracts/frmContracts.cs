using CustomerService.Classes;
using CustomerService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CustomerService.Forms
{
    public partial class frmContracts : Form
    {
        CustomersContext _db = new CustomersContext();
        public int LookupType { get; set; }
        public int LookupId { get; set; }
        public int CustomerId { get; set; }
        public int ContractId { get; set; }
        public bool IsEdit { get; set; }
        public frmContracts()
        {
            InitializeComponent();
        }

        private void frmContracts_Load(object sender, EventArgs e)
        {

            if (IsEdit == true)
            {
                ContractDetail _newContract = new ContractDetail();
                if (IsEdit == true)
                {
                    _newContract = _db.GetContractById(ContractId);

                    txtBasePrice.Text = _newContract.BasePrice.ToString();
                    txtBaseUsers.Text = _newContract.BaseUsers.ToString();
                    txtCostOfExtraUser.Text = _newContract.CostExtraUser.ToString();
                    txtNumberOfUsers.Text = _newContract.NoOfUsers.ToString();
                    txtRRARR.Text = _newContract.RRARR.ToString();
                    txtMonthlyCharge.Text = _newContract.MonthlyCharge.ToString();


                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContractDetail _newContract = new ContractDetail();
            if (IsEdit == true)
                _newContract = _db.GetContractById(ContractId);


            _newContract.CustomerId = CustomerId;
            _newContract.BasePrice = Convert.ToDecimal(txtBasePrice.Text);
            _newContract.BaseUsers = Convert.ToInt32(txtBaseUsers.Text);
            _newContract.CostExtraUser = Convert.ToDecimal(txtCostOfExtraUser.Text);
            _newContract.MonthlyCharge = Convert.ToDecimal(txtMonthlyCharge.Text);
            if (IsEdit == true)
            {

                _db.SaveContractType(_newContract);
                _db.SaveChanges();
                MessageBox.Show("Contract has been Update", "Contract Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {


                _db.AddToContract(_newContract);
                _db.SaveChanges();
                MessageBox.Show("Contract has been Created", "Contract Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }







        }
    }
}
