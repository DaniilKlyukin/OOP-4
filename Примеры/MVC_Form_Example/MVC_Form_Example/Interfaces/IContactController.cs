namespace MVC_Form_Example.Interfaces
{
    // Interfaces/IContactController.cs
    public interface IContactController
    {
        void AddContact(string name, string phoneNumber);
        void RemoveContact(string name);
    }
}
