using MVC_Form_Example.Model;
// Interfaces/IContactView.cs

namespace MVC_Form_Example.Interfaces
{
    public interface IContactView
    {
        event Action<string, string> ContactAdded;
        event Action<string> ContactRemoved;

        void UpdateContactList(List<Contact> contacts);
    }
}
