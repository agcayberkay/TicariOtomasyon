﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class frmAgcayTicariOtomasyon : DevExpress.XtraEditors.XtraForm
    {

        public frmAgcayTicariOtomasyon()
        {
            InitializeComponent();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

        }

        frmProducts frmProducts;
        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProducts==null)
            {
                frmProducts = new frmProducts();
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            
        }
    }
}
