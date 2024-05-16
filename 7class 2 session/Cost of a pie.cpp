﻿// cost of a pie.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
    int Tests, ans1, ans2, n;
    std::cin >> Tests;
    std::cin >> n;

    for (int k = 1; k <= Tests;k++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(0, 10);
        uniform_int_distribution<> dist_int1(0, 100);
        uniform_int_distribution<> dist_int2(0, 500);
        uniform_int_distribution<> dist_int3(0, 1000);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
        system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(0, 10000);
        double random_int;
        std::vector <__int64> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<__int64> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\cost of a pie\\cost of a pie\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\cost of a pie\\cost of a pie\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\cost of a pie\\cost of a pie\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\cost of a pie\\cost of a pie\\" + std::to_string(k) + ".a");
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
        std::cout << input[0] << "\n" << input[1] << "\n" << input[2] << "\n";
        ans1 = input[0] * input[2];
        ans2 = input[1] * input[2];
        if (ans2 >= 100) 
        {
            ans1 += floor(ans2 / 100);
            ans2 = ans2 - (floor(ans2 / 100) * 100);
        }
        out1.close();
        out2 << ans1 << " " << ans2;    
        // испрльзуем элементы вектора вместо переменной
        std::cout << ans1 << " " << ans2 << "\n";
        out2.close();
    }

}