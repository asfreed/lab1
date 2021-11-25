using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLibrary1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneInfo person1 = new PhoneInfo(" ", " ", 89432005822, " ");
            person1.GetInfo();
            person1.DelPhoneInfo();
            person1.ShowFullInfo();
        }
    }

    public class PhoneInfo
    {
        public string last_name;
        public string first_name;
        public string second_name = "";
        public long phone_number;
        public string country;
        public string born_day = "";
        public string organisation = "";
        public string post = "";
        public string another_info = "";

        public PhoneInfo(string last_name, string first_name, long phone_number, string country)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.phone_number = phone_number;
            this.country = country;
        }

        public void ShowFullInfo()
        {
            string a = $"Фамилия: {last_name} Имя: {first_name}";
            if (second_name != "")
            {
                a +=  $" Отчество: {second_name}";
            }
            if (phone_number != 1000000000)
            {
                a += $"\nНомер телефона: {phone_number}";
            }
            if (country != "")
            {
                a += $"\nСтрана: {country}";
            }
            if (born_day != "")
            {
                a += $"\nДата рождения: {born_day}";
            }
            if (organisation != "")
            {
                a += $"\nОрганизация: {organisation}";
            }
            if (post != "")
            {
                a += $"\nДолжность {post}";
            }
            if (another_info != "")
            {
                a += $"\nПрочая информация: {another_info}";
            }
            Console.WriteLine(a);
        }
        public void DelPhoneInfo()
        {
            Console.WriteLine("\n\nИнформация, которую можно удалить:\nотчество, дата рождения, организация, должность, прочая информация.\n\n");
            Console.WriteLine("Введите тип информации, которую хотите удалить(Введите EXIT для выхода): ");
            string a = Console.ReadLine();
            while (a != "EXIT")
            {
                switch (a)
                {
                    case "отчество":
                        second_name = "";
                        break;
                    case "дата рождения":
                        born_day = "";
                        break;
                    case "организация":
                        organisation = "";
                        break;
                    case "должность":
                        post = "";
                        break;
                    case "прочая информация":
                        another_info = "";
                        break;
                    default:
                        Console.WriteLine("Недоступное значение, попробуйте снова!");
                        break;
                }

                a = Console.ReadLine();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("\n\nИнформация, которую можно добавить или изменить:\nимя, фамилия, отчество, дата рождения, номер телефона, страна," +
                " организация, должность, прочая информация.\n\n");
            Console.WriteLine("Введите тип информации, которую хотите добавить или изменить(Введите EXIT для выхода): ");
            string a = Console.ReadLine();
            while (a != "EXIT")
            {
                switch (a)
                {
                    case "отчество":
                        Console.WriteLine("Введите новое или измененное отчество: ");
                        second_name = Console.ReadLine();
                        break;
                    case "дата рождения":
                        Console.WriteLine("Введите новую или измененную дату рождения: ");
                        born_day = Console.ReadLine();
                        break;
                    case "страна":
                        Console.WriteLine("Введите новую или измененную страну: ");
                        country = Console.ReadLine();
                        break;
                    case "организация":
                        Console.WriteLine("Введите новую или измененную организацию: ");
                        organisation = Console.ReadLine();
                        break;
                    case "должность":
                        Console.WriteLine("Введите новую или измененную должность: ");
                        post = Console.ReadLine();
                        break;
                    case "прочая информация":
                        Console.WriteLine("Дополните или введите новую прочую информацию(если хотите дополнить информацию введите +, в противном случае -): ");
                        string sign = Console.ReadLine();
                        if (sign == "+")
                        {
                            another_info += Console.ReadLine();
                        }
                        else
                        {
                            another_info = Console.ReadLine();
                        }
                        break;
                    case "имя":
                        Console.WriteLine("Введите новое имя: ");
                        first_name = Console.ReadLine();
                        break;
                    case "фамилия":
                        Console.WriteLine("Введите новую фамилию: ");
                        last_name = Console.ReadLine();
                        break;
                    case "номер телефона":
                        Console.WriteLine("Введите новый телефона: ");
                        phone_number = Convert.ToInt64(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Недоступное значение, попробуйте снова!");
                        break;
                }

                Console.WriteLine("\n\nВведите информацию, которую хотите добавить или изменить(Введите EXIT для выхода): ");
                a = Console.ReadLine();
            }
        }
    }
}
