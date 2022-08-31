using System;

/*Задание 5
Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания, описа-
ние журнала, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через методы класса.*/

namespace HW_3_Task_5
{
    class Journal
    {
        string name;
        string yearOfFoundation;
        string description;
        string contactNumber;
        string mail;
        public Journal() { }
        public Journal(string name, string yearOfFoundation, string description, string contactNumber, string mail)
        {
            this.Name = name;
            this.yearOfFoundation = yearOfFoundation;
            this.description = description;
            this.contactNumber = contactNumber;
            this.mail = mail;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Year
        {
            get { return yearOfFoundation; }
            set { yearOfFoundation = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public void PrintData()
        {
            Console.WriteLine($"Название журнала: {name}");
            Console.WriteLine($"Год основания: {yearOfFoundation}");
            Console.WriteLine($"Контактный телефон :{contactNumber}");
            Console.WriteLine($"e-Mail: {mail}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal("name", "2000", "description", "22-22-22", "mail@.fu");
            journal.PrintData();
            journal.Name = "name journal";
            journal.Year = "1990";
            journal.Description = "description journal";
            Console.WriteLine();
            journal.PrintData();
        }
    }
}
