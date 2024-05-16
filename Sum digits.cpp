// Sum digits.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>
#include <stdlib.h>
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
        uniform_int_distribution<> dist_int_samples(0, 100);
        uniform_int_distribution<> dist_int1(0, 10000);
        uniform_int_distribution<> dist_int2(-10000, 0);
        uniform_int_distribution<> dist_int3(0, 100000);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(-100000, 100000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Sum digits\\Sum digits\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Sum digits\\Sum digits\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Sum digits\\Sum digits\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Sum digits\\Sum digits\\" + std::to_string(k) + ".a");
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
            int h;
            ans = 0;
            std::string s = std::to_string(input[0]);
            if(input[0]>= 0)
            {
                for (int i = 0;i < s.length();i++)
                {
                    h = s[i] - 48;  
                    ans = ans + h;
                }
            }
            else 
            {
                for (int i = 1;i < s.length();i++)
                {
                    h = s[i] - 48;
                    ans = ans + h;
                }
            }

            out1.close();
            // испрльзуем элементы вектора вместо переменной
            out2 << ans << '\n';
            std::cout << input[0] << "\n" << ans << "\n";
            out2.close();
    }

}