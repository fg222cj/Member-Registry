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
    public partial class FormEditMember : Form
    {
        public Member Member { get; set; }
        public FormEditMember()
        {
            InitializeComponent();
        }

        internal void LoadMember(Member member)
        {
            Member = member;
            textBoxFirstName.Text = member.FirstName;
            textBoxLastName.Text = member.LastName;
            textBoxTelephone.Text = member.TelephoneNumber;
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
                Member.FirstName = textBoxFirstName.Text;
                Member.LastName = textBoxLastName.Text;
                Member.TelephoneNumber = textBoxTelephone.Text;
            }

            else
            {
                DialogResult = DialogResult.None;
            }

        }
    }
}
