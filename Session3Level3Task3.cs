using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


class Square
{
    // Поля.
    char type;
    string owner;
    public Square(string owner)
    {
        this.owner = owner;
    }

    public char getType()//
    {
        return type;
    }

    public string getOwner()
    {
        return owner;
    }

    public void changeType(char newSymbol)
    {
        type = newSymbol;
    }
}

class Circle : Square
{
    // Поля.
    public Circle(string owner) : base(owner)
    {
        changeType('o');
    }
}

class Cross : Square
{
    // Поля.
    public Cross(string owner) : base(owner)
    {
        changeType('x');
    }
}

class Map
{
    Square[,] map;
    int amountOfMoves;
    Circle ethalonCircle;
    Cross ethalonCross;

    public Map(Circle ethalonCircle, Cross ethalonCross)
    {
       
        this.ethalonCircle = ethalonCircle;
        this.ethalonCross = ethalonCross;
        map = new Square[3, 3];
        for (int x = 0; x < 3; ++x) 
        {
            for (int y = 0; y < 3; ++y) 
            {
                map[x, y] = null;
            }
        }
        
        // место для вашего кода
    }
    public int moves = 0;
    public bool putSquare(int x, int y)//???????
    {
        // место для вашего кода
        moves++;
        if (x > 2 || x < 0 || y > 2 || y < 0) 
        {
            return false;
        }
        else
        {
            if (map[x, y] == null)
            {
                if (moves % 2 == 0)
                {
                    map[x, y] = ethalonCross;
                }
                else
                {
                    map[x, y] = ethalonCircle;
                }
                return true;
            }
            else { return false; }
        }
        
    }

    public void printMap()
    {
        for (int y = 0; y < 3; ++y)
        {
            for(int x = 0; x <3; ++x)
            {
                if (map[x, y] == null)
                {
                    Console.Write($"None  ");
                }
                else 
                { 
                    Console.Write($"{map[x, y].getType()}  ");
                }
                if (x == 2) 
                {
                    Console.WriteLine(" ");
                }
                
            }
        }
        // место для вашего кода
    }
    public bool checkWin()
    {
        int series_cross = 0;
        int series_circ = 0;
        
        for (int  y= 0; y < 3; ++y) 
        {
            for (int x = 0; x < 3; ++x) 
            {
                
                if (map[x,y]== ethalonCross)
                {
                    series_cross++;
                }
                else 
                {
                    series_circ++;
                }
                if (x == 3) 
                {
                    if (series_circ == 3)
                    {
                        return true;
                    }
                    if (series_cross == 3) 
                    {
                        return false;
                    }
                }
            }
        }

        for (int x = 0; x < 3; ++x)
        {
            for (int y = 0; y < 3; ++y)
            {
                
                if (map[x, y] == ethalonCross)
                {
                    series_cross++;
                }
                else
                {
                    series_circ++;
                }
                if (x == 3)
                {
                    if (series_circ == 3)
                    {
                        return true;
                    }
                    if (series_cross == 3)
                    {
                        return false;
                    }
                }
            }
        }
        if ((map[0, 0] == map[1, 1] && map[2, 2] == map[1, 1]) || (map[1, 1] == map[0, 2] && map[1, 1] == map[2, 0]))
        {
            if (map[0, 0] == ethalonCross)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else 
        {
            Console.WriteLine("DRAW");
            return false;
        }
        // место для вашего кода
    }
}

class Program
{
    static bool tests0 ()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests1()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests2()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests3()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            Console.WriteLine(map.putSquare(2, 3));
            Console.WriteLine(map.putSquare(3, 2));
            Console.WriteLine(map.putSquare(3, 3));
            Console.WriteLine(map.putSquare(-1, 2));
            Console.WriteLine(map.putSquare(-1, -1));
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests4()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            Console.WriteLine(map.putSquare(-1, -1));
            map.printMap();
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests5()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            Console.WriteLine(map.putSquare(-1, -1));
            ethalonCirc.changeType('ы');
            ethalonCirc.changeType('U');
            map.printMap();
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
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            Console.WriteLine(map.putSquare(-1, -1));
            ethalonCirc.changeType('ы');
            ethalonCirc.changeType('U');
            map.printMap();
            ethalonCross.changeType('P');
            map.printMap();
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests7()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            Console.WriteLine(map.putSquare(-1, -1));
            ethalonCirc.changeType('ы');
            ethalonCirc.changeType('U');
            map.printMap();
            ethalonCross.changeType('^');
            map.printMap();
            ethalonCross.changeType('u');
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests8()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(1, 0));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 0));
            
            ethalonCirc.changeType('ы');
            ethalonCirc.changeType('U');
            map.printMap();
            ethalonCross.changeType('^');
            map.printMap();
            ethalonCross.changeType('u');
            Console.WriteLine(map.checkWin());//
            return true;
        }
        catch
        {
            return false;
        }
    }
    static bool tests9()
    {
        try
        {
            Circle ethalonCirc = new Circle("User1");
            Cross ethalonCross = new Cross("User2");
            Map map = new Map(ethalonCirc, ethalonCross);
            Console.WriteLine(map.putSquare(0, 0));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 1));
            Console.WriteLine(map.putSquare(0, 2));
            Console.WriteLine(map.putSquare(2, 2));
            ethalonCirc.changeType('ы');
            ethalonCirc.changeType('U');
            map.printMap();
            ethalonCross.changeType('^');
            map.printMap();
            ethalonCross.changeType('u');
            Console.WriteLine(map.checkWin());//
            return true;
        }
        catch
        {
            return false;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(tests0());
        Console.WriteLine(tests1());
        Console.WriteLine(tests2());
        Console.WriteLine(tests3());
        Console.WriteLine(tests4());
        Console.WriteLine(tests5());
        Console.WriteLine(tests6());
        Console.WriteLine(tests7());
        Console.WriteLine(tests8());
        Console.WriteLine(tests9());
        Console.ReadLine();
    }
}
