using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace WebApplication1
{
    public partial class student_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            ClearErrorLabels();
            Label1.Text = string.Empty;

            bool isValid = true;

            // 1. Student ID Validation
            string studentId = TextBox1.Text.Trim();
            if (string.IsNullOrEmpty(studentId))
            {
                lblErrorId.Text = "Student ID is required.";
                isValid = false;
            }

            // 2. First Name Validation
            string firstName = TextBox2.Text.Trim();
            if (string.IsNullOrEmpty(firstName))
            {
                lblErrorFirstName.Text = "First Name is required.";
                isValid = false;
            }

            // 3. Last Name Validation
            string lastName = TextBox3.Text.Trim();
            if (string.IsNullOrEmpty(lastName))
            {
                lblErrorLastName.Text = "Last Name is required.";
                isValid = false;
            }

            // 4. Email Validation
            string email = TextBox4.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                lblErrorEmail.Text = "Email is required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblErrorEmail.Text = "Enter a valid email address.";
                isValid = false;
            }

            // 5. Department Validation
            string department = "";
            if (RadioButton1.Checked) department = RadioButton1.Text;
            else if (RadioButton2.Checked) department = RadioButton2.Text;
            else if (RadioButton3.Checked) department = RadioButton3.Text;
            else if (RadioButton4.Checked) department = RadioButton4.Text;

            if (string.IsNullOrEmpty(department))
            {
                lblErrorDept.Text = "Select a Department.";
                isValid = false;
            }

            // 6. Gender Validation
            string gender = "";
            if (RadioButton5.Checked) gender = RadioButton5.Text;
            else if (RadioButton6.Checked) gender = RadioButton6.Text;

            if (string.IsNullOrEmpty(gender))
            {
                lblErrorGender.Text = "Select a Gender.";
                isValid = false;
            }

            // 7. Skills Validation
            List<string> skills = new List<string>();
            if (CheckBox1.Checked) skills.Add(CheckBox1.Text);
            if (CheckBox2.Checked) skills.Add(CheckBox2.Text);
            if (CheckBox3.Checked) skills.Add(CheckBox3.Text);
            if (CheckBox4.Checked) skills.Add(CheckBox4.Text);

            if (skills.Count == 0)
            {
                lblErrorSkills.Text = "Select at least one skill.";
                isValid = false;
            }

            // 8. Address Validation
            string address = TextBox5.Text.Trim();
            if (string.IsNullOrEmpty(address))
            {
                lblErrorAddress.Text = "Address is required.";
                isValid = false;
            }

            // 9. Terms and Conditions Validation
            if (!CheckBox5.Checked)
            {
                lblErrorTerms.Text = "You must agree to terms.";
                isValid = false;
            }

            // If all fields are valid, show success details
            if (isValid)
            {
                Label1.Text = $"<b>Registration Successful!</b><br/>" +
                              $"<b>ID:</b> {studentId}<br/>" +
                              $"<b>Name:</b> {firstName} {lastName}<br/>" +
                              $"<b>Email:</b> {email}<br/>" +
                              $"<b>Department:</b> {department}<br/>" +
                              $"<b>Gender:</b> {gender}<br/>" +
                              $"<b>Skills:</b> {string.Join(", ", skills)}<br/>" +
                              $"<b>Address:</b> {address}";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // Reset TextBoxes
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;

            // Reset RadioButtons
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            RadioButton5.Checked = false;
            RadioButton6.Checked = false;

            // Reset CheckBoxes
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;

            // Clear Error and Success Labels
            ClearErrorLabels();
            Label1.Text = string.Empty;
        }

        private void ClearErrorLabels()
        {
            lblErrorId.Text = string.Empty;
            lblErrorFirstName.Text = string.Empty;
            lblErrorLastName.Text = string.Empty;
            lblErrorEmail.Text = string.Empty;
            lblErrorDept.Text = string.Empty;
            lblErrorGender.Text = string.Empty;
            lblErrorSkills.Text = string.Empty;
            lblErrorAddress.Text = string.Empty;
            lblErrorTerms.Text = string.Empty;
        }
    }
}