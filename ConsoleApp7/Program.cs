using System;


namespace ConsoleApp7;

class Program
{
    static void Main()
    {
        Users?[] users = new Users[5]
        {
           new Users("Mirtalib","Huseynzade" ,new Card("1234","1234567023454567","313","12/23",1000)),
           new Users("Eltac","Memmedov" ,new Card("4444","4937586920045679","869","01/24",5000)),
           new Users("Ibadulla","Eliyev" ,new Card("2245","1567234244443454","123","03/23",101)),
           new Users("Elvin","Hesenli" ,new Card("3564","3754645665972346","945","09/22",1667)),
           new Users("Kamran","Rizayev" ,new Card("7689","3435465232342899","789","11/25",550)),
        };

        string sonEmeliyyet = "";
        
         
        
        bool st = true;
        int i = 0;
        while (st)
        {
            Console.WriteLine("\t\t\t  Pin-i Daxil Edin:");
            string? pin_Check = Console.ReadLine();

            for (i = 0; i < users.Length; i++)
            {
                if (pin_Check == users[i]!.CreditCard!.Pin)
                {
                    Console.Clear();
                    Console.WriteLine($"{users[i]!.Name} {users[i]!.Surname} xos gelmisiniz zehmet olmasa asagidakilardan birini secerdiniz");
                    st = false;
                    break;
                }
            }
        }

        byte select = 0;
        ConsoleKeyInfo keyInfo;
        bool start = true;
        while (true)
        {
            start = true;
            while (start)
            {
                if (select == 0)
                {
                    Console.WriteLine("\t\t\t<< Balans >>");
                    Console.WriteLine("\t\t\t   Nagd Pul Cixarmaq");
                    Console.WriteLine("\t\t\t   Edilen emeliyyatlarin siyahisi");
                    Console.WriteLine("\t\t\t   Kartdan karta kocurme ");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 1)
                {
                    Console.WriteLine("\t\t\t   Balans");
                    Console.WriteLine("\t\t\t<< Nagd Pul Cixarmaq >>");
                    Console.WriteLine("\t\t\t   Edilen emeliyyatlarin siyahisi");
                    Console.WriteLine("\t\t\t   Kartdan karta kocurme ");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 2)
                {
                    Console.WriteLine("\t\t\t   Balans ");
                    Console.WriteLine("\t\t\t   Nagd Pul Cixarmaq");
                    Console.WriteLine("\t\t\t<< Edilen emeliyyatlarin siyahisi >>");
                    Console.WriteLine("\t\t\t   Kartdan karta kocurme ");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 3)
                {
                    Console.WriteLine("\t\t\t   Balans");
                    Console.WriteLine("\t\t\t   Nagd Pul Cixarmaq");
                    Console.WriteLine("\t\t\t   Edilen emeliyyatlarin siyahisi");
                    Console.WriteLine("\t\t\t<< Kartdan karta kocurme >>");
                    Console.WriteLine("\t\t\t   Cixish");
                }
                else if (select == 4)
                {
                    Console.WriteLine("\t\t\t   Balans");
                    Console.WriteLine("\t\t\t   Nagd Pul Cixarmaq");
                    Console.WriteLine("\t\t\t   Edilen emeliyyatlarin siyahisi");
                    Console.WriteLine("\t\t\t   Kartdan karta kocurme");
                    Console.WriteLine("\t\t\t<< Cixish >>");
                }

                keyInfo = Console.ReadKey();
                Console.Clear();
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (select != 0)
                            select--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (select + 1 < 5)
                            select++;
                        break;
                    case ConsoleKey.Enter:
                        start = false;
                        break;
                    default:
                        break;
                }
            }

            if (select == 0)
            {
                ConsoleKeyInfo keyInfo2;
                while (true)
                {
                    Console.WriteLine("\t\t\t  Sizin Balansiniz {0}",users[i]!.CreditCard!.Balance);
                    Console.WriteLine("\t\t\t  Cixmaq Ucun Enter Basin");
                    keyInfo2 = Console.ReadKey();
                    if (keyInfo2.Key is ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (select is 1)
            {
                bool start1 = true;
                byte select1 = 0;
                ConsoleKeyInfo keyInfo3;
                while (start1)
                {
                    if (select1 == 0)
                    {
                        Console.WriteLine("\t\t\t<< 10 >>");
                        Console.WriteLine("\t\t\t   20");
                        Console.WriteLine("\t\t\t   50");
                        Console.WriteLine("\t\t\t   100");
                        Console.WriteLine("\t\t\t   Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)");
                        Console.WriteLine("\t\t\t   Cixish");

                    }
                    else if (select1 == 1)
                    {
                        Console.WriteLine("\t\t\t   10");
                        Console.WriteLine("\t\t\t<< 20 >>");
                        Console.WriteLine("\t\t\t   50");
                        Console.WriteLine("\t\t\t   100");
                        Console.WriteLine("\t\t\t   Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)");
                        Console.WriteLine("\t\t\t   Cixish");
                    }
                    else if (select1 == 2)
                    {
                        Console.WriteLine("\t\t\t   10");
                        Console.WriteLine("\t\t\t   20");
                        Console.WriteLine("\t\t\t<< 50 >>");
                        Console.WriteLine("\t\t\t   100");
                        Console.WriteLine("\t\t\t   Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)");
                        Console.WriteLine("\t\t\t   Cixish");
                    }
                    else if (select1 == 3)
                    {
                        Console.WriteLine("\t\t\t   10");
                        Console.WriteLine("\t\t\t   20");
                        Console.WriteLine("\t\t\t   50");
                        Console.WriteLine("\t\t\t<< 100>>");
                        Console.WriteLine("\t\t\t   Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)");
                        Console.WriteLine("\t\t\t   Cixish");
                    }
                    else if (select1 == 4)
                    {
                        Console.WriteLine("\t\t\t   10");
                        Console.WriteLine("\t\t\t   20");
                        Console.WriteLine("\t\t\t   50");
                        Console.WriteLine("\t\t\t   100");
                        Console.WriteLine("\t\t\t<< Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)>>");
                        Console.WriteLine("\t\t\t   Cixish");
                    }
                    else if (select1 == 4)
                    {
                        Console.WriteLine("\t\t\t   10");
                        Console.WriteLine("\t\t\t   20");
                        Console.WriteLine("\t\t\t   50");
                        Console.WriteLine("\t\t\t   100");
                        Console.WriteLine("\t\t\t   Diger (Istediyi meblegi ozunuz qeyd ede bilersiniz)");
                        Console.WriteLine("\t\t\t<< Cixish >>");
                    }
                    keyInfo3 = Console.ReadKey();
                    Console.Clear();

                    switch (keyInfo3.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (select1 != 0)
                                select1--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (select1 + 1 < 6)
                                select1++;
                            break;
                        case ConsoleKey.Enter:
                            start1 = false;
                            break;
                        default:
                            break;
                    }
                }

                if(select1 is 0)
                {
                    if(users[i]!.CreditCard!.Balance - 10 >= 0) { 
                        users[i]!.CreditCard!.Balance -= 10;
                        sonEmeliyyet += $"\nTarix {DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-10 manat \n";
                    }
                    else
                    {
                        try
                        {
                            throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                        }
                    }
                }
                else if (select1 is 1)
                {
                    if (users[i]!.CreditCard!.Balance - 20 >= 0)
                    {
                        users[i]!.CreditCard!.Balance -= 20;
                        sonEmeliyyet += $"\nTarix {DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-20 manat \n";
                    }
                    else
                    {
                        try
                        {
                            throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                        }
                    }
                }
                else if (select1 is 2)
                {
                    if (users[i]!.CreditCard!.Balance - 50 >= 0) { 
                        users[i]!.CreditCard!.Balance -= 50;
                        sonEmeliyyet += $"\nTarix {DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-50 manat \n";
                    }
                    else
                    {
                        try
                        {
                            throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                        }
                    }
                }
                else if (select1 is 3)
                {
                    if (users[i]!.CreditCard!.Balance - 100 >= 0) { 
                        users[i]!.CreditCard!.Balance -= 100;
                        sonEmeliyyet += $"\nTarix {DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-100 manat \n";
                    }
                    else
                    {
                        try
                        {
                            throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                        }
                    }
                }
                else if (select1 is 4)
                {
                    int mebleq = 0;
                    Console.WriteLine("\t\t\t   Mebleqi Daxil Edin:");
                    mebleq = int.Parse(Console.ReadLine());

                    if (users[i]!.CreditCard!.Balance - mebleq >= 0)
                    {
                        users[i]!.CreditCard!.Balance -= mebleq;
                        sonEmeliyyet += $"\nTarix { DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-{mebleq} manat\n";
                    }

                else
                    {
                        try
                        {
                            throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.Source);
                        }
                    }
                }
                else if (select1 is 5)
                {

                }
                Console.Clear();
            }
            else if (select is 2)
            {
                ConsoleKeyInfo keyInfo4;
                while (true)
                {
                    Console.WriteLine(sonEmeliyyet);
                    Console.WriteLine("\t\t\t  Cixmaq Ucun Enter Basin");
                    keyInfo4 = Console.ReadKey();
                    if (keyInfo4.Key is ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if(select is 3)
            {
                bool st1 = true;
                int i1 = 0;
                ConsoleKeyInfo keyInfo5;
                while (st1)
                {
                    Console.WriteLine("\t\t\t   Pin-i Daxil Edin:");
                    string? pin_Check1 = Console.ReadLine();
                    for (i1 = 0; i1 < users.Length; i1++)
                    {
                        if (pin_Check1 == users[i1]!.CreditCard!.Pin)
                        {
                            Console.Clear();
                            Console.WriteLine($"\t\t\t   {users[i1]!.Name} {users[i1]!.Surname}");
                            Console.WriteLine("\t\t\t   Eger Ad Duzdurse Enter \n\t\t\t   Eks halda Tab basin");

                            keyInfo5 = Console.ReadKey();
                            if (keyInfo5.Key is ConsoleKey.Tab)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (keyInfo5.Key is ConsoleKey.Enter)
                            {
                                Console.Clear();
                                Console.WriteLine("Gondermek istediyiniz meblegi yazin:");

                                int mebleq1 = 0;
                                
                                mebleq1 = int.Parse(Console.ReadLine());

                                if (users[i]!.CreditCard!.Balance - mebleq1 >= 0)
                                {
                                    users[i]!.CreditCard!.Balance -= mebleq1;
                                    sonEmeliyyet += $"\nTarix { DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss")} \n-{mebleq1} manat\n";
                                    users[i1]!.CreditCard!.Balance += mebleq1;
                                }
                                else
                                {
                                    try
                                    {
                                        throw new Exception("\t\t\t   Balansda bu qeder mebleg yoxdu");

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine(ex.Source);
                                    }
                                }
                                st1 = false;
                                break;
                            }
                        }
                    }
                }
            }
            else if (select is 4)
            {
                
                Console.WriteLine("\t\t\t   Sag Olun");
                break;
            }
        }
    }
}


public class Card
{

    public string? Pin { get;}
    public string? Pan { get;}
    public string? Cvc { get;}
    public string? Expire_Date { get;}
    public decimal Balance { get; set; }


    public Card()
    {
        Pin = null;
        Pan = null;
        Cvc = null;
        Expire_Date = null;
        Balance = 0;
    }
    public Card(string _pin , string _pan, string _cvc , string _expire_Date , decimal _balance)
    {
        Pin = _pin;
        Pan = _pan;
        Cvc = _cvc;
        Expire_Date = _expire_Date;
        Balance = _balance;
    }

    public override string ToString()
    {
        return $"{Pin} , {Pan} , {Cvc} , {Balance} , {Expire_Date}";
    }
}


public class Users
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Card? CreditCard { get; set; }

    public Users()
    {
        Name = null;
        Surname = null;
        CreditCard = null;
    }

    public Users(string _name , string _Surname , Card card)
    {
        Name = _name;
        Surname = _Surname;
        CreditCard = card;
    }

    public override string ToString()
    {
        return $"{Name} , {Surname} , {CreditCard}";
    }
}