using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;


class UniversalClass
{
    public int size;
    public bool[] bits;
    public string typename;
    // конструктор для short'a
    public UniversalClass(short value)
    {
        typename = "short";
        bits = new bool[16];
        if (value < 0)
        {
            value = (short)(value * -1);
            for (int i = 0; i < 16; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
                value = (short)(value / 2);
            }
            bits[0] = true;
        }
        else
        {
            for (int i = 0; i < 16; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = false;
                }
                else
                {
                    bits[i] = true;
                }
                value = (short)(value / 2);
            }
        }

        //... (место для вашего кода)
    }
    // конструктор для short'a
    public UniversalClass(ushort value)
    {
        bits = new bool[16];
        typename = "unsigned short";
        for (int i = 0; i < 16; ++i)
        {
            if (value % 2 == 0)
            {
                bits[i] = false;
            }
            else
            {
                bits[i] = true;
            }
            value = (ushort)(value / 2);
        }
        //... (место для вашего кода)
    }
    // конструктор для int'a
    public UniversalClass(int value)
    {
        bits = new bool[32];
        typename = "int";
        if (value < 0)
        {
            value = value * -1;
            for (int i = 0; i < 32; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
                value = value / 2;
            }
            bits[0] = true;
        }
        else
        {
            for (int i = 0; i < 32; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = false;
                }
                else
                {
                    bits[i] = true;
                }
                value = value / 2;
            }
        }
        //... (место для вашего кода)
    }
    // конструктор для int'a
    public UniversalClass(uint value)
    {
        bits = new bool[32];
        typename = "unsigned int";
        for (int i = 0; i < 32; ++i)
        {
            if (value % 2 == 0)
            {
                bits[i] = false;
            }
            else
            {
                bits[i] = true;
            }
            value = value / 2;
        }
        //... (место для вашего кода)
    }
    // конструктор для long'a
    public UniversalClass(long value)
    {
        typename = "long";
        bits = new bool[64];
        if (value < 0)
        {
            value = value * -1;
            for (int i = 0; i < 64; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
                value = value / 2;
            }
            bits[0] = true;
        }
        else
        {
            for (int i = 0; i < 64; ++i)
            {
                if (value % 2 == 0)
                {
                    bits[i] = false;
                }
                else
                {
                    bits[i] = true;
                }
                value = value / 2;
            }
        }
        //... (место для вашего кода)
    }
    // конструктор для unsigned long'a
    public UniversalClass(ulong value)
    {
        bits = new bool[64];
        typename = "unsigned long";
        for (int i = 0; i < 64; ++i)
        {
            if (value % 2 == 0)
            {
                bits[i] = false;
            }
            else
            {
                bits[i] = true;
            }
            value = value / 2;
        }
    }
    public UniversalClass(char value)
    {
        typename = "char";
        bits = new bool[32];
        int value_int = Convert.ToInt32(value);
        for (int i = 0; i < 32; ++i)
        {
            if (value_int % 2 == 0)
            {
                bits[i] = false;
            }
            else
            {
                bits[i] = true;
            }
            value_int = value_int / 2;
        }
        //... (место для вашего кода)
    }
    // возврат short'a
    public short returnValShort()
    {
        short res = 0;
        int h = 1;
        for (int i = 1; i < 16; ++i)
        {
            if (bits[i] == true)
            {
                res = (short)(res + h);
            }
            h = h * 2;
        }
        if (bits[0] == true) 
        {
            res = (short)(res * -1);
        }
        //... (место для вашего кода)
        return res;
    }
    // возврат short'a
    public ushort returnValUShort()
    {
        ushort res = 0;
        int h = 1;
        for (int i = 0; i < 16; ++i)
        {
            if (bits[i] == true)
            {
                res = (ushort)(res + h);
            }
            h = h * 2;
        }
        //... (место для вашего кода)
        return res;
    }
    // возврат int'a
    public int returnValInt()
    {
        int res = 0;
        //... (место для вашего кода)
        int h = 1;
        for (int i = 1; i < 32; ++i)
        {
            if (bits[i] == true)
            {
                res = (res + h);
            }
            h = h * 2;
        }
        if (bits[0] == true) 
        {
            res = res * -1;
        }
        return res;
    }
    // возврат int'a
    public uint returnValUInt()
    {
        uint res = 0;
        int h = 1;
        for (int i = 0; i < 32; ++i)
        {
            if (bits[i] == true)
            {
                res = (uint)(res + h);
            }
            h = h * 2;
        }
        //... (место для вашего кода)
        return res;
    }
    // возврат long'a
    public long returnValLong()
    {
        long res = 0;
        int h = 1;
        //... (место для вашего кода)\
        for (int i = 1; i < 64; ++i)
        {
            if (bits[i] == true)
            {
                res = (res + h);
            }
            h = h * 2;
        }
        if (bits[0] == true)
        {
            res = res * -1;
        }
        return res;
    }
    // возврат long'a
    public ulong returnValULong()
    {
        ulong res = 0;
        ulong h = 1;
        for (int i = 0; i < 64; ++i)
        {
            if (bits[i] == true)
            {
                res = res + h;
            }
            h = h * 2;
        }
        //... (место для вашего кода)
        return res;
    }
    // возврат char'a
    public char returnValChar()
    {
        char res_1 = '0';
        int res = 0;
        int h = 1;
        for (int i = 0; i < 16; ++i)
        {
            if (bits[i] == true)
            {
                res = (int)(res + h);
            }
            h = h * 2;
        }
        //... (место для вашего кода)
        res_1 = (char)(res);
        return res_1;
    }
    // возврат массива битов.
    public bool[] getBits()
    {
        // место для потенциального кода (вспоммните ссылочные типы...)
        bool[] res = new bool[bits.Length];
        Array.Copy(bits, res, bits.Length);
        return res;
    }
    // Метод, обрабатывающий сложение двух чисел. (записывает результат в bits)
    public void addFrom(UniversalClass addedVal)
    {
        if (typename == addedVal.typename)
        {
            int bitochek = bits.Length;
            int[] first = new int[bitochek];
            int[] second = new int[bitochek];
            int[] ans = new int[bitochek];
            for (int i = 0; i < bitochek; ++i)
            {
                if (bits[i] == true)
                {
                    first[i] += 1;
                }
                else
                {
                    first[i] += 0;
                }
            } // first
            for (int i = 0; i < bitochek; ++i)
            {
                if (addedVal.bits[i] == true)
                {
                    second[i] += 1;
                }
                else
                {
                    second[i] += 0;
                }
            } // second

            if (bits[0] == false && addedVal.bits[0] == false)
            {
                for (int i = bitochek - 1; i > 0; --i)
                {
                    ans[i] = first[i] + second[i];
                }
                for (int i = bitochek - 1; i > 0; --i)
                {
                    if (ans[i] > 1)
                    {
                        ans[i] = ans[i] - 2;
                        ans[i - 1]++;
                    }
                }
            } // OK
            else if (bits[0] == true && bits[0] == true)
            {
                for (int i = bitochek - 1; i > 0; --i)
                {
                    ans[i] = first[i] + second[i];
                }
                for (int i = bitochek - 1; i > 0; --i)
                {
                    if (ans[i] > 1)
                    {
                        ans[i] = ans[i] - 2;
                        ans[i - 1]++;
                    }
                }
                ans[0] = 1;
            } // OK
            else if (bits[0] == true && addedVal.bits[0] == false)
            {
                int res = 0, h = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (this.bits[i] == true)
                    {
                        res += h;
                    }
                    h = h * 2;
                } // res 1
                int res_sec = 0; int h_sec = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (addedVal.bits[i] == true)
                    {
                        res_sec += h_sec;
                    }
                    h_sec = h_sec * 2;
                } // res 2
                if (res > res_sec) // 1 - 2  *-1
                {
                    for (int i = bitochek; i > 0; --i)
                    {
                        if (first[i] < second[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (first[j] == 1)
                                {
                                    break;
                                }
                            }
                            first[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                first[j] = 1;
                            }
                            second[j] = 0;
                        }
                        ans[i] = first[i] - second[i];
                    }
                    ans[0] = 1;
                }
                else if (res == res_sec)
                {
                    for (int i = 0; i < bitochek; ++i)
                    {
                        ans[i] = 0;
                    }
                }
                else // 2 - 1
                {
                    for (int i = bitochek - 1; i > 0; --i)
                    {
                        if (second[i] < first[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (second[j] == 1)
                                {
                                    break;
                                }
                            }
                            second[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                second[j] = 1;
                            }
                            first[j] = 0;
                        }
                        ans[i] = second[i] - first[i];
                    }
                }
            } // OK
            else if (bits[0] == false && addedVal.bits[0] == true)
            {
                int res = 0, h = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (this.bits[i] == true)
                    {
                        res += h;
                    }
                    h = h * 2;
                } // res 1
                int res_sec = 0; int h_sec = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (addedVal.bits[i] == true)
                    {
                        res_sec += h_sec;
                    }
                    h_sec = h_sec * 2;
                } // res 2
                if (res > res_sec) // 1 - 2
                {
                    for (int i = bitochek; i > 0; --i)
                    {
                        if (first[i] < second[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (first[j] == 1)
                                {
                                    break;
                                }
                            }
                            first[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                first[j] = 1;
                            }
                            second[j] = 0;
                        }
                        ans[i] = first[i] - second[i];
                    } // bits - addedVal.bits
                }
                else if (res == res_sec)
                {
                    for (int i = 1; i < bitochek; ++i)
                    {
                        ans[i] = 0;
                    }
                }
                else // (2 - 1) *-1
                {
                    for (int i = bitochek - 1; i > 0; --i)
                    {
                        if (second[i] < first[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (second[j] == 1)
                                {
                                    break;
                                }
                            }
                            second[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                second[j] = 1;
                            }
                            first[j] = 0;
                        }
                        ans[i] = second[i] - first[i];
                    }
                    ans[0] = 1;
                }
            } // OK
            else
            {
                
                return;
            }
            for (int i = 0; i < bitochek; ++i)
            {
                if (ans[i] == 1)
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
            } // OK
        }
    }
    // Метод, обрабатывающий разность двух чисел. (записывает результат в bits)
    public void substractFrom(UniversalClass addedVal)
    {
        if (typename == addedVal.typename)
        {
            int bitochek = bits.Length;
            int[] first = new int[bitochek];
            int[] second = new int[bitochek];
            int[] ans = new int[bitochek];
            for (int i = 0; i < bitochek; ++i)
            {
                if (bits[i] == true)
                {
                    first[i] += 1;
                }
                else
                {
                    first[i] += 0;
                }
            }                       //first
            for (int i = 0; i < bitochek; ++i)
            {
                if (addedVal.bits[i] == true)
                {
                    second[i] += 1;
                }
                else
                {
                    second[i] += 0;
                }
            }                       //second
            if (bits[0] == false && addedVal.bits[0] == false)
            {
                // + - 
                // Проверка на то какое число больше 
                // Вычетаем из большего меньшее
                // елси 2 больше то 2 больше 0 и  2 минус 1 и ответ -1
                int res = 0, h = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (this.bits[i] == true)
                    {
                        res += h;
                    }
                    h = h * 2;
                }
                int res_sec = 0; int h_sec = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (addedVal.bits[i] == true)
                    {
                        res_sec += h_sec;
                    }
                    h_sec = h_sec * 2;
                }
                if (res > res_sec) // 1 > 2 +-
                {
                    for (int i = bitochek-1; i > 0; --i)
                    {
                        if (first[i] < second[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (first[j] == 1)
                                {
                                    break;
                                }
                            }
                            first[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                first[j] = 1;
                            }
                            second[j] = 0;
                        }
                        ans[i] = first[i] - second[i];
                    }
                }
                else if (res == res_sec)
                {
                    for (int i = 1; i < bitochek; ++i)
                    {
                        ans[i] = 0;
                    }
                }
                else // 2 > 1 +- -> 2-1 *-1
                {
                    for (int i = bitochek - 1; i > 0; --i)
                    {
                        if (second[i] < first[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (second[j] == 1)
                                {
                                    break;
                                }
                            }
                            second[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                second[j] = 1;
                            }
                            first[j] = 0;
                        }
                        ans[i] = second[i] - first[i];
                    }
                    ans[0] = 1;
                }
            }       // OK 
            else if (bits[0] == false && addedVal.bits[0] == true)
            {
                /*
                1.  Изменяем addedVal.bits[0] на 0
                2.  Складываем два числда записываем результат в bits 
                */
                second[0] = 0;
                for (int i = bitochek - 1; i > 0; --i)
                {
                    ans[i] = first[i] + second[i];
                    if (ans[i] > 1)
                    {
                        if (ans[i] == 2)
                        {
                            ans[i] = 0;
                            ans[i - 1] += 1;
                        }
                        if (ans[i] == 3)
                        {
                            ans[i] = 1;
                            ans[i - 1] += 1;
                        }
                    }

                }
            }   // OK 
            else if (bits[0] == true && addedVal.bits[0] == true)
            {
                // - +
                //если 2 > 1 то 2 - 1 иначе 1*-1 - 2 и ответ -1
                int res = 0, h = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (this.bits[i] == true)
                    {
                        res += h;
                    }
                    h = h * 2;
                }
                int res_sec = 0; int h_sec = 1;
                for (int i = 1; i < bitochek; ++i)
                {
                    if (addedVal.bits[i] == true)
                    {
                        res_sec += h_sec;
                    }
                    h_sec = h_sec * 2;
                }
                if (res > res_sec) // 1 > 2 
                {
                    for (int i = bitochek - 1; i > 0; --i)
                    {
                        if (first[i] < second[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (first[j] == 1)
                                {
                                    break;
                                }
                            }
                            first[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                first[j] = 1;
                            }
                            second[j] = 0;
                        }
                        ans[i] = first[i] - second[i];
                    }
                    ans[0] = 1;
                }
                else if (res == res_sec)
                {
                    for (int i = 1; i < bitochek; ++i)
                    {
                        bits[i] = false;
                    }
                }
                else // 2 > 1
                {
                    for (int i = bitochek - 1; i > 0; --i)
                    {
                        if (second[i] < first[i])
                        {
                            int j = 0;
                            for (j = i - 1; j > 0; --j)
                            {
                                if (second[j] == 1)
                                {
                                    break;
                                }
                            }
                            second[j] = 0;
                            for (j = j + 1; j <= i; j++)
                            {
                                second[j] = 1;
                            }
                            first[j] = 0;
                        }
                        ans[i] = second[i] - first[i];
                    }
                }
            }    // OK 
            else if (bits[0] == true && addedVal.bits[0] == false)
            {
                /*
                1. Изменяем параметр знака на 0
                2. Складываем побитово
                3.Изменяем первый знак на 1, записываем в bits
                */
                second[0] = 0;
                for (int i = bitochek - 1; i > 0; --i)
                {
                    ans[i] = first[i] + second[i];
                    if (ans[i] > 1)
                    {
                        if (ans[i] == 2)
                        {
                            ans[i] = 0;
                            ans[i - 1] += 1;
                        }
                        if (ans[i] == 3)
                        {
                            ans[i] = 1;
                            ans[i - 1] += 1;
                        }
                    }

                }
            }   // OK 
            else
            {
                

            }                                                     //?
            for (int i = 0; i < bitochek; ++i)
            {
                if (ans[i] == 1)
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
            }
        }
    }
    // Метод, обрабатывающий перемножение двух чисел. (записывает результат в bits)
    public void multiplyFrom(UniversalClass addedVal)// сделать на основе цикла в цикле где влияет на степень 10 для суммы при умножении, спросить про ссылку на метод summ
    {
        int bitochek;
        if (typename == addedVal.typename && typename != "char")
        {
            bitochek = bits.Length;
            int res = 0, h = 1;
            for (int i = 0; i < bitochek; ++i)
            {
                if (this.bits[i] == true)
                {
                    res += h;
                }
                h = h * 2;
            }
            int res_sec = 0; int h_sec = 1;
            for (int i = 0; i < bitochek; ++i)
            {
                if (addedVal.bits[i] == true)
                {
                    res_sec += h_sec;
                }
                h_sec = h_sec * 2;
            }
            res = res * res_sec;
            for (int i = 0; i < bitochek; ++i)
            {
                if (res % 2 == 0)
                {
                    bits[i] = false;
                }
                else
                {
                    bits[i] = true;
                }
                res = res / 2;
            }

        }
        else 
        {
            
        }
    }
    // Метод, обрабатывающий операцию побитового "и" двух чисел. (записывает результат в bits)
    public void customAnd(UniversalClass addedVal)
    {
        if (typename == addedVal.typename)
        {
            int bitochek = bits.Length;
            for (int i = 0; i < bitochek; ++i)
            {
                bits[i] = bits[i] & addedVal.bits[i];
            }
        }
    }
    // Метод, обрабатывающий операцию побитового "или" двух чисел. (записывает результат в bits)
    public void customOr(UniversalClass addedVal)
    {
        if (typename == addedVal.typename)
        {
            int bitochek = bits.Length;
            for (int i = 0; i < bitochek; ++i) 
            {
                bits[i] = bits[i] | addedVal.bits[i];
            }
        }
    }
    // Метод, обрабатывающий операцию побитового "не" к числу. (записывает результат в bits)
    public void customNo()
    {
        int bitochek = bits.Length;
        for (int i = 0; i < bitochek; ++i) 
        {
            bits[i] = !bits[i];
        }
    }
}

//Пример тестовой программы.
class Program
{
    static bool tests0()
    {
        try 
        {
            short number_1 = 12;
            long number_2 = 123;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            test1.addFrom(test2);
            return true;
        }

        catch { return false; }
    }
    static bool tests1()
    {
        try
        {
            int number_1 = -45;
            uint numner_2 = 99;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(numner_2);
            test1.returnValInt();
            test2.returnValUInt();
            test1.getBits();
            test2.getBits();
            return true; 
        }
        catch { return false; }
    }
    static bool tests2()
    {
        try
        {
            int number_1 = -45;
            uint numner_2 = 99;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(numner_2);
            test1.returnValInt();
            test2.returnValUInt();
            test1.getBits();
            test2.getBits();
            return true;
        }
        catch { return false; }
    }
    static bool tests3()
    {
        try 
        {
            short number_1 = -16000;
            ushort number_2 = 16745;
            UniversalClass test1= new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            test1.returnValShort();
            test2.returnValUShort();
            test1.getBits();
            test2.getBits();
            return true;
        }
        catch { return false; }
    }
    static bool tests4()
    {
        try 
        {
            ulong number_1= 238746523;
            long number_2 = -131231411;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            test1.returnValULong();
            test2.returnValLong();
            test1.getBits();
            test2.getBits();
            return true;
        }
        catch { return false; }
    }
    static bool tests5()
    {
        try 
        {
            char simvol_1 = '2';
            char simvol_2 = '/';
            UniversalClass test1 = new UniversalClass(simvol_1);
            UniversalClass test2 = new UniversalClass(simvol_2);
            test1.returnValChar();
            test2.returnValChar();
            test1.getBits();
            test2.getBits();
            return true; 
        }
        catch{return false; }
    }
    static bool tests6()
    {
        try 
        {
            int number_1 = 12;
            int number_2 = 120;
            short number_3 = -16;
            long number_4 = 41232;
            long number_5 = -32;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            UniversalClass test3 = new UniversalClass(number_3);
            UniversalClass test4 = new UniversalClass(number_4);
            UniversalClass test5 = new UniversalClass(number_5);
            test1.addFrom(test2);
            test3.customAnd(test3);
            test4.customAnd(test5);
            return true; 
        }
        catch { return false; }
    }
    static bool tests7()
    {
        try 
        {
            int number_1 = 190;
            int number_2 = 14;
            short number_3 = -16;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            UniversalClass test3 = new UniversalClass(number_3);
            test1.substractFrom(test2);
            test1.substractFrom(test3);
            test1.getBits();
            test3.getBits();
            return true; 
        }
        catch { return false; }
    }
    static bool tests8()
    {
        try
        {
            int number_1 = 190;
            int number_2 = 14;
            short number_3 = -16;
            long number_4 = -162345;
            long number_5 = 1234151;
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            UniversalClass test3 = new UniversalClass(number_3);
            UniversalClass test4 = new UniversalClass(number_4);
            UniversalClass test5 = new UniversalClass(number_5);
            test4.multiplyFrom(test5);
            test4.multiplyFrom(test3);
            test1.substractFrom(test2);
            test1.substractFrom(test3);
            test4.getBits();
            test1.getBits();
            test3.getBits();
            return true;
        }
        catch { return false; }
    }
    static bool tests9()
    {
        try
        {
            int number_1 = 190;
            int number_2 = 14;
            short number_3 = -16;
            long number_4 = -162345;
            long number_5 = 1234151;
            char number_6 = 'a';
            UniversalClass test1 = new UniversalClass(number_1);
            UniversalClass test2 = new UniversalClass(number_2);
            UniversalClass test3 = new UniversalClass(number_3);
            UniversalClass test4 = new UniversalClass(number_4);
            UniversalClass test5 = new UniversalClass(number_5);
            UniversalClass test6 = new UniversalClass(number_6);
            test6.multiplyFrom(test5);
            test4.multiplyFrom(test5);
            test4.multiplyFrom(test3);
            //test1.substractFrom(test2);
            //test1.substractFrom(test3);
            //test4.getBits();
            //test1.getBits();
            //test3.getBits();
            return true;
        }
        catch { return false; }
    }
    public static void Main(string[] args)
    {
        UniversalClass ex7 = new UniversalClass('/');
        //Console.WriteLine(tests0());
        //Console.WriteLine(tests1());
        //Console.WriteLine(tests2());
        //Console.WriteLine(tests3());
        //Console.WriteLine(tests4());
        //Console.WriteLine(tests5());
        //Console.WriteLine(tests6());
        //Console.WriteLine(tests7()); 
        //Console.WriteLine(tests8()); // OK
        Console.WriteLine(tests9()); // False
        Console.ReadLine();
    }
}
