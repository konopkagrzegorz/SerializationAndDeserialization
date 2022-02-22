using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationAndDeserialization
{
    public partial class mainForm : Form
    {

        Person person = null;

        public mainForm()
        {
            InitializeComponent();
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {
            try
            {
                person = PersonMapper.deserialize(textArea.Text);
                firstnameText.Text = person.GetFirstname();
                lastnameText.Text = person.GetLastname();
                agePicker.Value = person.GetAge();
                emailText.Text = person.GetEmail();
            } catch (Exception exception)
            {
                textArea.Clear();
                textArea.Text = "Nie można zdeserializować obiektu!";
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            firstnameText.Clear();
            lastnameText.Clear();
            agePicker.Value = agePicker.Minimum;
            emailText.Clear();
            textArea.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (firstnameText.Text.Trim().Length > 0
                && lastnameText.Text.Trim().Length > 0
                && emailText.Text.Trim().Length > 0)
            {
                person.SetFirstname(firstnameText.Text);
                person.SetLastname(lastnameText.Text);
                person.SetAge(Convert.ToInt32(agePicker.Value));
                person.SetEmail(emailText.Text);
            }
        }

        private void serializeButton_Click(object sender, EventArgs e)
        {
            textArea.Text = PersonMapper.serialize(person);
        }
    }
}
