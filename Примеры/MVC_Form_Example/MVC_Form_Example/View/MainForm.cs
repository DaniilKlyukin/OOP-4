using MVC_Form_Example.Interfaces;
using MVC_Form_Example.Model;

namespace MVC_Form_Example
{
    // View/ContactsForm.cs
    public partial class MainForm : Form, IContactView
    {
        public event Action<string, string> ContactAdded;
        public event Action<string> ContactRemoved;

        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateContactList(List<Contact> contacts)
        {
            listBoxContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add($"{contact.Name} - {contact.PhoneNumber}");
            }
        }

        private void buttonAdd_Click(object? sender, EventArgs? e)
        {
            ContactAdded?.Invoke(textBoxName.Text, textBoxPhoneNumber.Text);
        }

        private void buttonRemove_Click(object? sender, EventArgs? e)
        {
            if (listBoxContacts.SelectedItem != null)
            {
                string selectedContact = listBoxContacts.SelectedItem.ToString();
                string name = selectedContact.Split('-')[0].Trim();
                ContactRemoved?.Invoke(name);
            }
        }
    }
}
