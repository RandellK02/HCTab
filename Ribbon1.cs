﻿using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCTab
{
    public partial class HCRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void btnskypeNotify_Click(object sender, RibbonControlEventArgs e)
        {
            using (GetUserForm form = new GetUserForm())
            {
                System.Windows.Forms.DialogResult result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string user = form.User;
                }
            }
        }
    }
}