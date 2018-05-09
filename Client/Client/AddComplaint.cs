﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AddComplaint : Form
    {
        private AddComplaint()
        {
            InitializeComponent();
        }
        private static AddComplaint L = null;

        public static AddComplaint GetInstance()
        {
            if (L == null)
            {
                return new AddComplaint();
            }
            return L;
        }
        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            localhost.Complaint complaint = new localhost.Complaint();
            complaint.Name = txtName.Text;
            complaint.Cell = txtMobileNo.Text;
            complaint.Email = txtEmail.Text;
            complaint.Complaint_Text = txtComplaint.Text;

            localhost.Service1 s = new localhost.Service1();
            s.AddComplaint(complaint);


            MessageBox.Show("Your complaint has been sent.");

            
        }

        private void AddComplaint_Load(object sender, EventArgs e)
        {

        }
    }
}
