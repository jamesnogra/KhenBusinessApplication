using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Business_Application
{
    public partial class locationClearance : Form
    {
        public string csvFileName = "DATA/Applications.csv";
        public string csvFileNameBackup = "DATA/ApplicationsBackup.csv"; //no editing and deleting
        public char commaDelimiterForData = '､'; //in the CSV file, the commas in strings are encoded as ､ (U+FF64 HALFWIDTH IDEOGRAPHIC COMMA)
        Login tempLogin;
        bool isLoggedIn = false;

        public locationClearance()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(620, 500);
            enableTab(allBusinessApplicationsTab, false);
            enableTab(addBusinessApplicationTab, false);
            enableTab(editBusinessApplcationTab, false);
            businessApplicationsTab.SelectedIndex = 3; //login on first load
            maskPasswordFields();
            loadCSVFromFile();
        }

        private void addBusinessApplicationButton_Click(object sender, EventArgs e)
        {
            string businessDetails = "";
            businessDetails += "ID-" + getUniqueID(16) + ",";
            if (!checkAddBusinessApplicationFields())
            {
                return;
            }
            businessDetails += nameOfApplicantText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += businessNameText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += applicationNoText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += decisionNoText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += projectTypeText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += locationText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += orNoText.Text.Replace(',', commaDelimiterForData) + ",";
            businessDetails += amountPaidText.Text.Replace(",", "") + "\n";
            if (!File.Exists(csvFileName))
            {
                MessageBox.Show("Something went wrong reading the file "+ csvFileName + ".");
                return;
            }
            File.AppendAllText(csvFileName, businessDetails);
            File.AppendAllText(csvFileNameBackup, businessDetails);
            DialogResult dr = MessageBox.Show("New locational clearance has been added. Do you want to clear the form?", "Saved Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                clearAddBusinessApplicationForm();
            }
            //businessApplicationsTab.SelectedIndex = 0;
        }

        private bool checkAddBusinessApplicationFields()
        {
            if (nameOfApplicantText.Text.Length < 2)
            {
                MessageBox.Show("Name of applicant must be filled.");
                return false;
            }
            return true;
        }


        private void loadCSVFromFile()
        {
            if (!isLoggedIn)
            {
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(csvFileName))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i].Replace(commaDelimiterForData, ',');
                        }
                        dt.Rows.Add(dr);
                    }
                    allBusinessApplicationsDataGrid.DataSource = dt;
                    allBusinessApplicationsDataGrid.Columns[0].Visible = false; //hide ID Column
                    sr.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File "+csvFileName+" is now found. Maybe you have deleted this file.");
            }
        }

        private void allBusinessApplicationsDataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult usersChoice = MessageBox.Show("Are you sure you want to delete this locational clearance?", "Deleting Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (usersChoice == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            DataGridViewRow row = allBusinessApplicationsDataGrid.CurrentRow;
            string businessApplicationID = row.Cells["ID"].Value.ToString();
            editDeleteInCSVByID(businessApplicationID, "DELETE", "");
        }

        private void editDeleteInCSVByID(string businessApplicationID, string method, string editedLine)
        {
            List<String> lines = new List<String>();
            StreamReader reader = new StreamReader(System.IO.File.OpenRead(@csvFileName));
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(","))
                {
                    String[] split = line.Split(',');
                    if (split[0] != businessApplicationID)
                    {
                        lines.Add(line);
                    }
                    else if (split[0] == businessApplicationID && method == "EDIT")
                    {
                        lines.Add(editedLine);
                    }
                }
            }
            reader.Dispose();
            try
            {
                using (StreamWriter writer = new StreamWriter(csvFileName, false))
                {
                    foreach (String tempLines in lines)
                    {
                        writer.WriteLine(tempLines);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deleting the locational clearance. Please close the " + csvFileName+" file.");
            }
        }

        private void allBusinessApplicationsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = allBusinessApplicationsDataGrid.CurrentRow;
            if (!row.IsNewRow)
            {
                enableTab(editBusinessApplcationTab, true);
                businessApplicationsTab.SelectedIndex = 2;
                idEditText.Enabled = false;
                idEditText.Text = row.Cells["ID"].Value.ToString();
                nameOfApplicantEditText.Text = row.Cells["Name of Applicant"].Value.ToString();
                businessNameEditText.Text = row.Cells["Business Name"].Value.ToString();
                applicationNoEditText.Text = row.Cells["Application No."].Value.ToString();
                decisionNoEditText.Text = row.Cells["Decision No."].Value.ToString();
                projectTypeEditText.Text = row.Cells["Project Type"].Value.ToString();
                locationEditText.Text = row.Cells["Location"].Value.ToString();
                orNoEditText.Text = row.Cells["OR No."].Value.ToString();
                amountPaidEditText.Text = row.Cells["Amount Paid"].Value.ToString();
            }
        }

        private void editBusinessApplicationButton_Click(object sender, EventArgs e)
        {
            string editedLine = "";
            editedLine += idEditText.Text + ",";
            editedLine += nameOfApplicantEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += businessNameEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += applicationNoEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += decisionNoEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += projectTypeEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += locationEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += orNoEditText.Text.Replace(',', commaDelimiterForData) + ",";
            editedLine += amountPaidEditText.Text.Replace(",", "") + ",";
            editDeleteInCSVByID(idEditText.Text, "EDIT", editedLine);
            MessageBox.Show("Locational clearance has been edited.");
            enableTab(editBusinessApplcationTab, false);
            businessApplicationsTab.SelectedIndex = 0;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            string tempQuery = "`Name of Applicant` LIKE '%{0}%' ";
            tempQuery += "OR `Business Name` LIKE '%{0}%' ";
            tempQuery += "OR `Application No.` LIKE '%{0}%' ";
            tempQuery += "OR `Decision No.` LIKE '%{0}%' ";
            tempQuery += "OR `Project Type` LIKE '%{0}%' ";
            tempQuery += "OR `Location` LIKE '%{0}%' ";
            tempQuery += "OR `OR No.` LIKE '%{0}%' ";
            tempQuery += "OR `Amount Paid` LIKE '%{0}%' ";
            (allBusinessApplicationsDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format(tempQuery, searchText.Text, searchText.Text);
        }

        private void businessApplicationsTabs_Selected(object sender, TabControlEventArgs e)
        {
            //every time the all locational clearances tab is opened, load again tje CSV File
            if (businessApplicationsTab.SelectedIndex == 0)
            {
                loadCSVFromFile();
            }
        }

        private void clearAddBusinessApplicationForm()
        {
            nameOfApplicantText.Text = "";
            businessNameText.Text = "";
            applicationNoText.Text = "";
            decisionNoText.Text = "";
            projectTypeText.Text = "";
            locationText.Text = "";
            orNoText.Text = "";
            amountPaidText.Text = "";
        }

        //from https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
        public static string getUniqueID(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static void enableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            tempLogin = new Login();
            if (tempLogin.checkLoginUser(userText.Text, passwordText.Text))
            {
                isLoggedIn = true;
                userText.Text = "";
                passwordText.Text = "";
                enableTab(allBusinessApplicationsTab, true);
                enableTab(addBusinessApplicationTab, true);
                businessApplicationsTab.SelectedIndex = 0;
                businessApplicationsTab.TabPages.Remove(loginTab);
            }
            else
            {
                isLoggedIn = false;
                MessageBox.Show("Invalid login credentials!");
            }
        }
       
        private void maskPasswordFields()
        {
            char tempPasswordChar = '■';
            passwordText.PasswordChar = tempPasswordChar;
        }

        private void locationClearance_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            businessApplicationsTab.Width = control.Size.Width - 40;
            businessApplicationsTab.Height = control.Size.Height - 65;
            allBusinessApplicationsDataGrid.Width = businessApplicationsTab.Width - 25;
            allBusinessApplicationsDataGrid.Height = businessApplicationsTab.Height - 80;
        }

        private void addNewUserLink_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please login first!");
                return;
            }
            var tempForm = new CreateUserForm();
            tempForm.Show(this);
        }
    }
}
