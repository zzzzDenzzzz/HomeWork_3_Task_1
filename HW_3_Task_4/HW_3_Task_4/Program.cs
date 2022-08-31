using System;

/*Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.*/

namespace HW_3_Task_4
{
    class WebSite
    {
        string name; // название сайта
        string path; // путь к сайту
        string description; // описание сайта
        string ip;
        public WebSite() { }
        public WebSite(string name, string path, string description, string ip)
        {
            this.name = name;
            this.path = path;
            this.description = description;
            this.ip = ip;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public void GetData()
        {
            Console.WriteLine($"Название сайта: {name}");
            Console.WriteLine($"Путь к сайту: {path}");
            Console.WriteLine($"Описание сайта: {description}");
            Console.WriteLine($"ip сайта: {ip}\n");
        }
        public void SetData()
        {
            Console.WriteLine("Опишите сайт");
            description = Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite webSite1 = new WebSite();
            webSite1.GetData();
            webSite1.Name = "name1";
            webSite1.Description = "Lesson3";
            Console.WriteLine($"Название сайта: {webSite1.Name}");
            Console.WriteLine($"Описание сайта: {webSite1.Description}\n");
            WebSite webSite2 = new WebSite("name2", @"C:\Programm\WebSite\name2", "Lesson3", "0.0.0.0");
            webSite2.GetData();
            webSite2.SetData();
            webSite2.GetData();
        }
    }
}
