using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test_Practic_3_level_3_session_Task_2
{
    public sealed class Car
    {
        public int size;
        public int speed;
        public string name;

        public Car(int size, int speed, string name)//
        {
                this.size = size;
                this.speed = speed;
                this.name = name;
        }

        public Car(Car from)//
        {
            this.size = from.size;
            this.speed = from.speed;
            this.name = from.name;
        }

        // Меняем имя тачки
        public void changeName(string newName)//
        {
            this.name = newName;
        }

    }

    // Класс "ручнной массив"
    class CustomArray
    {
        public Car[][] Cars;
        public Car copy;
        public Car[] useless;
        public int[] amountInColumn;
        // поля
        public CustomArray(int sizex, int[] sizey)//
        {
            this.Cars = new Car[sizex][];
            for (int i = 0; i < sizex; ++i) 
            {
                this.Cars[i] = new Car[sizey[i]];
                this.amountInColumn[i] = 0;
            }
            // Место для кода.
        }

        // Метод добавления машины в массив. Если не поместился - увеличиваем размер массива на 2, добавляем туда, и возвращаем false, иначе - возвращаем true.
        public bool addElement(Car addedCar, int columnIndex)
        {
            bool flag;
            if (flag = (amountInColumn[columnIndex] == this.Cars[columnIndex].Length))
            {
                resize(columnIndex);
            }
            Cars[columnIndex][amountInColumn[columnIndex]] = addedCar;
            amountInColumn[columnIndex]++;
            return !flag;

        }

        // Возвращает true, если под этим индексом лежала машина.
        public bool removeElement(int index_x, int index_y)
        {
            if (index_y == amountInColumn[index_x - 1])// сделать через размерзубца проверку на существование, а потом перетащить остальные машинки
            {
                for (int i = index_y-1; i < amountInColumn[index_x]-1; i++) 
                {
                    this.Cars[index_x][i] = this.Cars[index_x][i+1];
                }
                this.Cars[index_x][amountInColumn[index_x]++] = null;
                return true;
            }
            else 
            {
                return false;
            }
            
        }


        // Метод, возвращающий копию машины, расположенной по координатам (x, y). Если там нет машины - возвращает null.
        public Car returnCopy(int x, int y)//
        {
            if ((y >= amountInColumn[x-1]) || (this.Cars[x][y] == null))
            {
                return null;
            }
            else
            {
                return new Car(Cars[x - 1][y]);
            }
            
        }

        // Метод, увеличивающий размер выбранного зубца на 2.
        public void resize(int indexToResize)//
        {
            if (amountInColumn[indexToResize] == this.Cars[indexToResize].Length)
            {
                
                Car[] useless = new Car[amountInColumn[indexToResize] * 2];
                for (int i = 0; i < this.Cars[indexToResize].Length; ++i) {
                    //Перенос значений
                    useless[i] = this.Cars[indexToResize][i];
                }
                this.Cars[indexToResize] = useless;
                
            }
        }
    }

    internal class Program
    {
        // проверка тестави в которые ника не связаны между собой => в каждом тесте надо самостоятельно и заново вызывать разные методы(ручками)
        //10 тестов, каждый должен провирять больше предыдущего
        static bool test0() {
            try
            {
                CustomArray mass = new CustomArray(3, new int[] { 3, 3, 3 });
                return true;
            }
            catch
            {
                return false;
            }
        }
        static bool test1()
        {
            try {
                CustomArray mass = new CustomArray(3, new int[] { 1, 2, 3 });
                return true;
            } catch {
                return false;
            }
        }
        static bool test2()
        {
            try
            {
                CustomArray mass = new CustomArray(3, new int[] { 1, 2, 3 });
                Car[][] a = mass.Cars;//проверка на существование - просто вызвать метод с нулевыми параметрами
                return true;
            }
            catch
            {
                return false;
            }
        }
        static bool test3() 
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                lada.changeName("lada_V.2");
                return true;
            }
            catch { return false; }
            
        }
        static bool tests4() 
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                return true;
            }
            catch { return false; }
        }
        static bool tests5() 
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                mass.resize(1);
                return true;
            } 
            catch 
            {
                return false;
            }
        }
        static bool tests6() 
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                Car Uazic = new Car(24, 50, "Uazic");
                Car niva = new Car(15, 55, "niva");
                mass.addElement(Uazic, 1);
                mass.addElement(niva, 1);
                return true;
            }
            catch { return false; }
        }
        static bool tests7() 
        {
            try {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                Car Uazic = new Car(24, 50, "Uazic");
                Car niva = new Car(15, 55, "niva");
                mass.addElement(Uazic, 1);
                mass.addElement(niva, 1);
                mass.resize(0);
                return true;
            } catch { return false; }
        }
        static bool tests8()
        {
            try {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                Car Uazic = new Car(24, 50, "Uazic");
                Car niva = new Car(15, 55, "niva");
                mass.addElement(Uazic, 1);
                mass.addElement(niva, 1);
                mass.resize(0);
                lada.size = 17;
                niva.changeName("moscvich");
                return true;
            } catch { return false; }
        }
        static bool tests9()
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                Car Uazic = new Car(24, 50, "Uazic");
                Car niva = new Car(15, 55, "niva");
                mass.addElement(Uazic, 1);
                mass.addElement(niva, 2);
                mass.resize(0);
                lada.size = 17;
                niva.changeName("moscvich");
                mass.removeElement(2, 1);
                mass.removeElement(3, 1);
                return true;
            }
            catch { return false; }
        }
        static bool tests10()
        {
            try 
            {
                CustomArray mass = new CustomArray(3, new int[] { 123, 2, 3 });
                Car[][] Cars = mass.Cars;
                Car lada = new Car(12, 60, "Lada");
                mass.addElement(lada, 1);
                Car Uazic = new Car(24, 50, "Uazic");
                Car niva = new Car(15, 55, "niva");
                mass.addElement(Uazic, 1);
                mass.addElement(niva, 1);
                mass.resize(0);
                lada.size = 17;
                niva.changeName("moscvich");
                mass.removeElement(2, 1);
                mass.returnCopy(2, 1);
                return true; 
            } 
            catch { return false; }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {

            }
            Console.WriteLine("Hello World");
            // запрос на выполнение метадов клсассов
            int sizex = Convert.ToInt32(Console.ReadLine());
            int[] sizey = new int[sizex];
            for (int i = 0; i < sizex; ++i) 
            {
                sizey[i] = Convert.ToInt32(Console.ReadLine());
            }

            int indexToResize = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int size = Convert.ToInt32(Console.ReadLine());
            int speed = Convert.ToInt32(Console.ReadLine());    
            string name = Console.ReadLine();
            Car lada = new Car(size, speed , name);

            string Newname = Console.ReadLine();    

            int columnIndex = Convert.ToInt32(Console.ReadLine());
            int size_add = Convert.ToInt32(Console.ReadLine());
            int speed_add = Convert.ToInt32(Console.ReadLine());
            string name_add = Console.ReadLine();
            Car added_car = new Car(size_add, speed_add, name_add);


            Console.WriteLine((sizex, sizey));
            Console.WriteLine((size, speed, name));
            lada.changeName(Newname);
            CustomArray mass = new CustomArray(sizex, sizey);
            Console.WriteLine(mass.addElement(added_car, columnIndex));
            Console.WriteLine(mass);
            int index_x = Convert.ToInt32(Console.ReadLine());
            int index_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mass.removeElement(index_x, index_y));//
            Console.WriteLine(mass.returnCopy(x,y));//
            mass.resize(indexToResize);// 
        }
    }
}
