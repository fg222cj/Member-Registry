using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberRegistry
{
    public partial class FormAddMember : Form
    {
        public Member newMember { get; set; }

        public FormAddMember()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool badInput = false;

            if (textBoxFirstName.Text == "")
            {
                errorFirstName.Text = "Du måste fylla i ett förnamn!";
                errorFirstName.Visible = true;
                badInput = true;
            }

            else
            {
                errorFirstName.Visible = false;
            }

            if (textBoxLastName.Text == "")
            {
                errorLastName.Text = "Du måste fylla i ett efternamn!";
                errorLastName.Visible = true;
                badInput = true;
            }

            else
            {
                errorLastName.Visible = false;
            }

            if (textBoxTelephone.Text == "")
            {
                errorTelephone.Text = "Du måste fylla i ett telefonnummer!";
                errorTelephone.Visible = true;
                badInput = true;
            }

            else
            {
                errorTelephone.Visible = false;
            }

            if (!badInput)
            {
                int id = FormMain.MemberReg.MemberList.Count + 1;
                newMember = new Member(textBoxFirstName.Text, textBoxLastName.Text, textBoxTelephone.Text, id);
            }

            else
            {
                DialogResult = DialogResult.None;
            }

        }


    }
}
