using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr15
{
    internal class Program
    {
        // Задание 1
        class Car
        {
            public string mark;
            public int count_cylinder;
            public int power;
            internal int new_power;
            public void show_info_car()
            {
                Console.WriteLine("Марка автомобиля: " + mark);
                Console.WriteLine("Число цилиндров: " + count_cylinder);
                Console.WriteLine("Мощность двигрателя: " + power);
            }
            public void change_power()
            {
                power = new_power;
                Console.WriteLine("Изменение мощности двигателя: " + new_power);
            }
        }
            class Lorry : Car
            {
                public double gruzopodiemnost;
                public void show_info_Lorry()
                {
                    Console.WriteLine("Грузоподъемность кузова(в тоннах)" + gruzopodiemnost);
                }
            }
        // Задание 2
        class Liquid
        {
            public string name;
            public double plotnost;
            internal double new_plotnost;
            public void show_info_Liquid()
            {
                Console.WriteLine("Название жидкости" + name);
                Console.WriteLine("Плотность жидкости" + plotnost);
            }
            public void change_plotnost()
            {
                plotnost = new_plotnost;
                Console.WriteLine("Изменение полтности жидкости: " + new_plotnost);
            }
        }
        class Alcohol : Liquid
        {
            public int strength;
            public void show_Alcohol_strength()
            {
                Console.WriteLine("Крпеость алкоголя" + strength);
            }
        }
        // Задание 3
        class Man
        {
            public string name;
            public string familia;
            public int age;
            public int weight;
            internal int new_age;
            internal int new_weight;
            public void show_info_man()
            {
                Console.WriteLine("Имя:"+name);
                Console.WriteLine("Фамилия:"+familia);
                Console.WriteLine("Возраст:"+age);
                Console.WriteLine("Вес:"+weight);
            }
            public void change_age_and_weight()
            {
                age = new_age;
                weight = new_weight;
                Console.WriteLine("Новый возраст:"+new_age);
                Console.WriteLine("Новый вес:"+new_weight);
            }
        }
        class Student : Man
        {
            public int year;
            public string specialty;
            public void show_info_student()
            {
                Console.WriteLine($"Года обучения: {year} и специальность обучения: {specialty}");
            }
        }

        static void Main(string[] args)
        {
        // Задание 1
        m1:
            try
            {
                Car car = new Car();
                Lorry gruzvoik = new Lorry();
                Console.WriteLine("Введите характеристики для автомобиля");
                Console.WriteLine("Марка:");  string car_mark = Console.ReadLine();
                Console.WriteLine("Количетсво цилиндров:");  int count_car_cylinder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Мощность двигателя:"); int car_power = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Переназначте мощность двигателя:"); int new_car_power = Convert.ToInt32(Console.ReadLine());
                car.mark = car_mark;
                car.count_cylinder = count_car_cylinder;
                car.power = car_power;
                car.new_power = new_car_power;
                car.show_info_car();
                car.change_power();
                Console.WriteLine();
                Console.WriteLine("Введите характеристики для Грузовика");
                Console.WriteLine("Марка:"); string Lorry_mark = Console.ReadLine();
                Console.WriteLine("Количетсво цилиндров:"); int count_Lorry_cylinder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Мощность двигателя:"); int Lorry_power = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Переназначте мощность двигателя:"); int new_Lorry_power = Convert.ToInt32(Console.ReadLine());
                gruzvoik.mark = Lorry_mark;
                gruzvoik.count_cylinder = count_Lorry_cylinder;
                gruzvoik.power = Lorry_power;
                gruzvoik.new_power = new_Lorry_power;
                gruzvoik.show_info_car();
                gruzvoik.change_power();
            }
            catch (Exception ex) 
            { Console.WriteLine(ex.Message); goto m1; }
        // Задание 2
        m2:
            try
            {
                Liquid liquid = new Liquid();
                Alcohol alcohol = new Alcohol();
                Console.WriteLine("Введите характеристики для жидкости");
                Console.WriteLine("Название жидкости"); string liquid_name = Console.ReadLine();
                Console.WriteLine("Плотность жидкости"); int liauid_plotnost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Измененная плотность жидкости"); int new_liauid_plotnost = Convert.ToInt32(Console.ReadLine());
                liquid.name = liquid_name;
                liquid.plotnost = liauid_plotnost;
                liquid.new_plotnost = new_liauid_plotnost;
                liquid.show_info_Liquid();
                liquid.change_plotnost();

                Console.WriteLine("Название жидкости"); string alcohol_name = Console.ReadLine();
                Console.WriteLine("Плотность жидкости"); int alcohol_plotnost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Измененная плотность жидкости"); int new_alcohol_plotnost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Крепость алкоголя"); int alcohol_strength = Convert.ToInt32(Console.ReadLine());

                alcohol.name = alcohol_name;
                alcohol.plotnost = alcohol_plotnost;
                alcohol.new_plotnost = new_alcohol_plotnost;
                alcohol.strength = alcohol_strength;
                alcohol.show_info_Liquid();
                alcohol.change_plotnost();
                alcohol.show_Alcohol_strength();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); goto m2; }
        // Задание 3
        m3:
            try
            {
                Man human = new Man();
                Student student = new Student();
                Console.WriteLine("Введите характеристики для человека");
                Console.WriteLine("Имя:"); string human_name = Console.ReadLine();
                Console.WriteLine("Фамилия:"); string human_familia = Console.ReadLine();
                Console.WriteLine("Возраст:"); int human_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вес:"); int human_weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Возраст(new):"); int human_new_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вес(new):"); int human_new_weight = Convert.ToInt32(Console.ReadLine());
                human.name = human_name;
                human.familia = human_familia;
                human.age = human_age;
                human.weight = human_weight;
                human.new_age = human_new_age;
                human.new_weight = human_new_weight;
                human.show_info_man();
                human.change_age_and_weight();

                Console.WriteLine("Введите характеристики для студента");
                Console.WriteLine("Имя:"); string student_name = Console.ReadLine();
                Console.WriteLine("Фамилия:"); string student_familia = Console.ReadLine();
                Console.WriteLine("Возраст:"); int student_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вес:"); int student_weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Возраст(new):"); int student_new_age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вес(new):"); int student_new_weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Года обучения:"); int student_year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Специальность обучения:"); string student_specialty = Console.ReadLine();
                student.name = student_name;
                student.familia = student_familia;
                student.age = student_age;
                student.weight = human_weight;
                student.new_age = student_new_age;
                student.new_weight = student_new_weight;
                student.year = student_year;
                student.specialty = student_specialty;
                student.show_info_man();
                student.change_age_and_weight();
                student.show_info_student();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); goto m3; }
        }
    }
}
