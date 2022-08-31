using System;

/*Задание 6
Создайте класс «Магазин». Необходимо хранить в полях класса: название магазина, адрес, описание про-
филя магазина, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через методы класса.*/

namespace HW_3_Task_5
{
    class Shop
    {
        string name;
        string address;
        string description;
        string contactNumber;
        string mail;
        public Shop() { }
        public Shop(string name, string address, string description, string contactNumber, string mail)
        {
            this.Name = name;
            this.address = address;
            this.description = description;
            this.contactNumber = contactNumber;
            this.mail = mail;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Contact
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public void PrintData()
        {
            Console.WriteLine($"Название магазина: {name}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Контактный телефон :{contactNumber}");
            Console.WriteLine($"e-Mail: {mail}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("name", "адрес", "description", "22-22-22", "@mail.fu");
            shop.PrintData();
            shop.Name = "name shop".ToUpper();
            shop.Address = "адрес".ToUpper();
            shop.Description = "description shop".ToUpper();
            shop.Contact = "55-55-55";
            shop.Mail = "shop@mail.com".ToUpper();
            Console.WriteLine();
            shop.PrintData();
        }
    }
}

