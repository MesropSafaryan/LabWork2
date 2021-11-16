using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;//змінюємо кодування консолі
            Console.InputEncoding = Encoding.Unicode;
            //Product product
            Product product1 = new Product();
            product1.ProductName = "A";
            product1.ProductDateOfManufacture = "10.01.2021";
            product1.ProductCode = "4823475832980";
            product1.ExpirationDate = 30;         
            //product1.EndDateOfConsumption();
            Product product2 = new Product();
            product2.ProductName = "B";
            product2.ProductDateOfManufacture = "24.03.2021";
            product2.ProductCode = "4874563789402";
            product2.ExpirationDate = 335;            
            //product2.EndDateOfConsumption();
            Product product3 = new Product();
            product3.ProductName = "C";
            product3.ProductDateOfManufacture = "30.12.2019";
            product3.ExpirationDate = 63;
            product3.ProductCode = "4783749508234";
            var tree = new Tree<long>();
            tree.Add(Convert.ToInt64(product1.ProductCode));
            tree.Add(Convert.ToInt64(product2.ProductCode));
            tree.Add(Convert.ToInt64(product3.ProductCode));
            Console.WriteLine("Список:\n ");
            List<string> prod = new List<string>();
            prod.Add(product1.ProductCode);
            prod.Add(product2.ProductCode);
            prod.Add(product3.ProductCode);
            IEnumerable<string> ienum = (IEnumerable<string>)prod;
            foreach(string i in ienum)
            {
                if (i == product1.ProductCode)
                {
                    //Console.Write(item + " ");
                    Console.WriteLine("Назва товару: " + product1.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product1.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product1.ProductCode);
                    Console.WriteLine("Термін придатності: " + product1.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product1.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if (product1.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
                else if (i == product2.ProductCode)
                {
                    Console.WriteLine("Назва товару: " + product2.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product2.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product2.ProductCode);
                    Console.WriteLine("Термін придатності: " + product2.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product2.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if (product2.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
                else if (i == product3.ProductCode)
                {
                    Console.WriteLine("Назва товару: " + product3.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product3.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product3.ProductCode);
                    Console.WriteLine("Термін придатності: " + product3.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product3.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if (product3.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
            }
            Console.WriteLine("Дерево:\n ");
            foreach (var item in tree.Preorder())
            {

                if (item == Convert.ToInt64(product1.ProductCode))
                {
                    //Console.Write(item + " ");
                    Console.WriteLine("Назва товару: " + product1.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product1.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product1.ProductCode);
                    Console.WriteLine("Термін придатності: " + product1.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product1.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if(product1.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
                else if (item == Convert.ToInt64(product2.ProductCode))
                {
                    Console.WriteLine("Назва товару: " + product2.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product2.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product2.ProductCode);
                    Console.WriteLine("Термін придатності: " + product2.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product2.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if (product2.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
                else if (item == Convert.ToInt64(product3.ProductCode))
                {
                    Console.WriteLine("Назва товару: " + product3.ProductName);
                    Console.WriteLine("Дата виготовлення: " + product3.ProductDateOfManufacture);
                    Console.WriteLine("Код товару: " + product3.ProductCode);
                    Console.WriteLine("Термін придатності: " + product3.ExpirationDate);
                    Console.WriteLine("Кінцева дата споживання: " + product3.EndDateOfConsumption());
                    Console.Write("Чи придатний товар для споживання: ");
                    if (product3.WhetherFitForConsumption() == true)
                    {
                        Console.WriteLine("так");
                    }
                    else
                    {
                        Console.WriteLine("ні");
                    }
                    Console.WriteLine("=======================================");
                }
            }
            Product[] product = new Product[1000];
            for (int i = 0; i < 1;)
            {
                Console.Write("Бажаєте додати новий об'єкт? Введіть так або ні: ");
                string answer1 = Console.ReadLine();
                if(answer1 == "так")
                {                    
                    Console.WriteLine("===========================================");
                    Console.Write("Введіть назву товару: ");
                    string val1 = Console.ReadLine();
                    product[i] = new Product();
                    product[i].ProductName = val1;
                    Console.Write("Введіть дату виготовлення товару: ");
                    string val2 = Console.ReadLine();
                    product[i].ProductDateOfManufacture = val2;
                    Console.Write("Введіть термін придатності товару: ");
                    string val3 = Console.ReadLine();
                    product[i].ExpirationDate = Convert.ToInt32(val3);
                    Console.Write("Введіть код товару: ");
                    string val4 = Console.ReadLine();
                    product[i].ProductCode = val4;
                    Console.Write("Ви бажаєте додати об'єкт у дерево чи у список? ");
                    string answer2 = Console.ReadLine();
                    if(answer2 == "у список")
                    {
                        prod.Add(product[i].ProductCode);
                    }
                    else if(answer2 == "у дерево")
                    {
                        tree.Add(Convert.ToInt64(product[i].ProductCode));
                    }
                    int j = 0;
                    int jj = 0;
                    Console.Clear();
                    Console.WriteLine("Список:\n ");
                    foreach (string ii in ienum)
                    {
                        
                        if (ii == product1.ProductCode)
                        {
                            //Console.Write(item + " ");
                            Console.WriteLine("Назва товару: " + product1.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product1.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product1.ProductCode);
                            Console.WriteLine("Термін придатності: " + product1.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product1.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product1.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (ii == product2.ProductCode)
                        {
                            Console.WriteLine("Назва товару: " + product2.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product2.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product2.ProductCode);
                            Console.WriteLine("Термін придатності: " + product2.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product2.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product2.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (ii == product3.ProductCode)
                        {
                            Console.WriteLine("Назва товару: " + product3.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product3.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product3.ProductCode);
                            Console.WriteLine("Термін придатності: " + product3.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product3.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product3.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (ii == product[j].ProductCode)
                        {
                            Console.WriteLine("Назва товару: " + product[j].ProductName);
                            Console.WriteLine("Дата виготовлення: " + product[j].ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product[j].ProductCode);
                            Console.WriteLine("Термін придатності: " + product[j].ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product[j].EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product[j].WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                            j++;
                        }
                        
                    }
                    Console.WriteLine("Дерево:\n ");
                    foreach (var item in tree.Preorder())
                    {

                        if (item == Convert.ToInt64(product1.ProductCode))
                        {
                            //Console.Write(item + " ");
                            Console.WriteLine("Назва товару: " + product1.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product1.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product1.ProductCode);
                            Console.WriteLine("Термін придатності: " + product1.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product1.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product1.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (item == Convert.ToInt64(product2.ProductCode))
                        {
                            Console.WriteLine("Назва товару: " + product2.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product2.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product2.ProductCode);
                            Console.WriteLine("Термін придатності: " + product2.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product2.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product2.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (item == Convert.ToInt64(product3.ProductCode))
                        {
                            Console.WriteLine("Назва товару: " + product3.ProductName);
                            Console.WriteLine("Дата виготовлення: " + product3.ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product3.ProductCode);
                            Console.WriteLine("Термін придатності: " + product3.ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product3.EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product3.WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                        }
                        else if (item == Convert.ToInt64(product[jj].ProductCode))
                        {
                            Console.WriteLine("Назва товару: " + product[jj].ProductName);
                            Console.WriteLine("Дата виготовлення: " + product[jj].ProductDateOfManufacture);
                            Console.WriteLine("Код товару: " + product[jj].ProductCode);
                            Console.WriteLine("Термін придатності: " + product[jj].ExpirationDate);
                            Console.WriteLine("Кінцева дата споживання: " + product[jj].EndDateOfConsumption());
                            Console.Write("Чи придатний товар для споживання: ");
                            if (product[jj].WhetherFitForConsumption() == true)
                            {
                                Console.WriteLine("так");
                            }
                            else
                            {
                                Console.WriteLine("ні");
                            }
                            Console.WriteLine("=======================================");
                            jj++;
                        }
                    }
                }
                else if(answer1 == "ні")
                {
                    i++;
                }
            }

        }
    }
}
