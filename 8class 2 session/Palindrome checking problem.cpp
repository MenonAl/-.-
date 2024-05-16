// Palindrome checking problem.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <cstdint>
#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <chrono>

using namespace std;

std::string Palindrome_checking_problem(int input) 
{
    if (input <= 10) 
    {
        return "No";
    }
    else 
    {
        std::string number = std::to_string(input);
        int j = number.size() - 1;
        int i = 0;
        while (i < floor(number.size() / 2)) 
        {
            if (number[i] == number[j]) 
            {
                i++;
                j--;
            }
            else 
            {
                return "No"; 
            }
        }
        return "Yes";

    }
}

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
        uniform_int_distribution<> dist_int_samples(10, 100);
        uniform_int_distribution<> dist_int1(-100, 100);
        uniform_int_distribution<> dist_int2(1000, 10000);
        uniform_int_distribution<> dist_int3(-10000, 10000);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(-1000000, 1000000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Palindrome checking problem\\Palindrome checking problem\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Palindrome checking problem\\Palindrome checking problem\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Palindrome checking problem\\Palindrome checking problem\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Palindrome checking problem\\Palindrome checking problem\\" + std::to_string(k) + ".a");
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
            if (k > 19 && k <= 39) {

                random_int = dist_int3(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 39 && k <= 50) {
                random_int = dist_int4(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
        }
        if (k == 26) { 
            input[0] = 1111; }
        if (k == 21) { 
            input[0] = 27872; }

        std::cout << input[0] << "\n";
        out1.close();
        // испрльзуем элементы вектора вместо переменной
        std::cout << Palindrome_checking_problem(input[0]) << "\n";
        out2 << Palindrome_checking_problem (input[0]) << '\n';
        out2.close();
    }
}

