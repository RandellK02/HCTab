using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCTab
{
    public partial class GetUserForm : Form
    {
        public string User { get; set; }

        private string[] AD_Users;

        public GetUserForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User = tbEmail.Text;
        }

        private void GetUserForm_Load(object sender, EventArgs e)
        {
            // Load AD emails for autofill
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            using (PrincipalContext pc = new PrincipalContext(System.DirectoryServices.AccountManagement.ContextType.Domain, "ITSERVICES"))
            {
                using (UserPrincipal user = new UserPrincipal(pc))
                {
                    user.EmailAddress = "*";
                    using (PrincipalSearcher ps = new PrincipalSearcher())
                    {
                        ps.QueryFilter = user;
                        ((DirectorySearcher)ps.GetUnderlyingSearcher()).PageSize = 500;
                        PrincipalSearchResult<Principal> psr = ps.FindAll();
                        AD_Users = new string[psr.Count()];

                        int i = 0;
                        foreach (UserPrincipal u in psr)
                        {
                            AD_Users[i++] = u.EmailAddress;
                        }
                    }
                }
            }

            source.AddRange(AD_Users);
            tbEmail.AutoCompleteCustomSource = source;
            tbEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}