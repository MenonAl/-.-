// Cow.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>
#include <chrono>

using namespace std;

int main()
{
    std::ofstream out1;
    std::ofstream out2;

    //генератор чисел(шаблон)
      /**/
    std::cout << "How many times to run the solution?" << "\n";
    int Tests, ans, n;
    std::cin >> Tests;
    std::cin >> n;

    for (int k = 1; k <= Tests;k++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(0, 10);
        uniform_int_distribution<> dist_int1(0, 100);
        uniform_int_distribution<> dist_int2(0, 1000);
        uniform_int_distribution<> dist_int3(0, 10000);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(0, 100000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Cow\\Cow\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Cow\\Cow\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Cow\\Cow\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Cow\\Cow\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) {
                random_int = dist_int_samples(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 2 && k <= 9) {
                random_int = dist_int1(gen); input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 9 && k <= 19) {
                random_int = dist_int2(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 19 && k <= 29) {

                random_int = dist_int3(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 29 && k <= 50) {
                random_int = dist_int4(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
        }
        out1.close();
        int a = input[0];
        std::string cow = to_string(input[0]);
        if (a%10 == 0)
        {
            std::cout <<a <<" " << "korov" << "\n";
            out2 << a << " " << "korov" << "\n";
            out2.close();
        }
        else 
        {
            if (a % 10 == 1 && input[0] != 11)
            {
                std::cout << input[0] << " " << "korova" << "\n";
                out2 << input[0] << " " << "korova" << "\n";
                out2.close();
            }
            else 
            {
                if (a % 10 > 4 || input[0] >= 10 && input[0] < 21 || a % 10 == 0) 
                {
                    std::cout << input[0] << ' ' << "korov" << "\n";
                    out2 << input[0] << " " << "korov" << "\n";
                    out2.close();
                }
                else 
                {
                    if (a % 10 >= 2 && a % 1 <= 4) 
                    {
                        std::cout << input[0] << " " << "korovy" << "\n";
                        out2 << input[0] << " " << "korovy" << "\n";
                        out2.close();
                    }
                    else 
                    {
                        std::cout << "What";
                    }
                }
            }
        }
        // испрльзуем элементы вектора вместо переменной

    }
}

