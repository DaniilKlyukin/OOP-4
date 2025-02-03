using MVC_Form_Example.Interfaces;
using MVC_Form_Example.Model;

namespace MVC_Form_Example.Controller
{
    // Controller/ContactController.cs
    public class ContactController : IContactController
    {
        private List<Contact> contacts;
        private IContactView view;

        public ContactController(IContactView view)
        {
            this.view = view;
            contacts = new List<Contact>();

            this.view.ContactAdded += OnContactAdded;
            this.view.ContactRemoved += OnContactRemoved;
        }

        private void OnContactAdded(string name, string phoneNumber)
        {
            AddContact(name, phoneNumber);
        }

        private void OnContactRemoved(string name)
        {
            RemoveContact(name);
        }

        public void AddContact(string name, string phoneNumber)
        {
            contacts.Add(new Contact(name, phoneNumber));
            view.UpdateContactList(contacts);
        }

        public void RemoveContact(string name)
        {
            contacts.RemoveAll(c => c.Name == name);
            view.UpdateContactList(contacts);
        }
    }
}
