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
    public partial class FormMain : Form
    {
        public static MemberRegistry MemberReg { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void populateListBox()
        {
            listBoxMembers.Items.Clear();
            MemberReg.MemberList.Sort();
            for (var i = 0; i < MemberReg.MemberList.Count; i++)
            {
                listBoxMembers.Items.Add(MemberReg.MemberList[i]);
            }
            listBoxMembers.Visible = true;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            buttonAddMember.Visible = true;
            buttonShowDetails.Visible = true;
            buttonDeleteMember.Visible = true;
            buttonEditMember.Visible = true;
        }

        private void newRegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReg = new MemberRegistry();
            populateListBox();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 4, 4) == ".csv")
                {
                    MemberReg = new MemberRegistry();
                    MemberReg.Load(openFileDialog1.FileName);
                    populateListBox();
                }

                else
                {
                    MessageBox.Show("Felaktigt format på fil!", "Fel!");
                }
            }
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            FormAddMember addNewMember = new FormAddMember();
            DialogResult result = addNewMember.ShowDialog();
            if (result == DialogResult.OK && addNewMember.newMember != null)
            {
                MemberReg.MemberList.Add(addNewMember.newMember);
                populateListBox();
            }
        }

        private void listBoxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMembers.SelectedItem != null)
            {
                buttonShowDetails.Enabled = true;
                buttonDeleteMember.Enabled = true;
                buttonEditMember.Enabled = true;
            }
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            if (listBoxMembers.SelectedItem != null)
            {
                Member selectedMember = listBoxMembers.SelectedItem as Member;
                StringBuilder DetailedInfo = new StringBuilder();
                DetailedInfo.AppendLine(String.Format("Förnamn: {0}", selectedMember.FirstName));
                DetailedInfo.AppendLine(String.Format("Efternamn: {0}", selectedMember.LastName));
                DetailedInfo.AppendLine(String.Format("Telefonnummer: {0}", selectedMember.TelephoneNumber));
                MessageBox.Show(DetailedInfo.ToString(), String.Format("Medlem {0}", selectedMember.IdNumber));
            }
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if (listBoxMembers.SelectedItem != null)
            {
                // Kan behöva lägga in en bekfräfta-kontroll här.
                Member listItem = listBoxMembers.SelectedItem as Member;
                MemberReg.MemberList.Remove(listItem);
                populateListBox();
                buttonShowDetails.Enabled = false;
                buttonDeleteMember.Enabled = false;
                buttonEditMember.Enabled = false;
            }
        }

        private void buttonEditMember_Click(object sender, EventArgs e)
        {
            if (listBoxMembers.SelectedItem != null)
            {
                FormEditMember editMember = new FormEditMember();
                editMember.LoadMember(listBoxMembers.SelectedItem as Member);
                editMember.ShowDialog();
                populateListBox();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MemberReg.FilePath == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

            else
            {
                MemberReg.Save();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MemberReg.FilePath = saveFileDialog1.FileName;
                MemberReg.Save();
            }
        }
    }
}
