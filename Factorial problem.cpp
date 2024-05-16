// Factorial problem.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <cstdint>
#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <chrono>

std::string output = "Wrong input";


unsigned long long int Factorial (unsigned long long int input)
{
    unsigned long long int ans = 1;
    if (input < 0)
    {
        return -1;
    }
    else
    {
        if (input == 0)
        {
            return 1;
        }
        else
        {
            ans = input * Factorial(input - 1);
            return ans;
        }
    }

}



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
        uniform_int_distribution<> dist_int_samples(0, 5);
        uniform_int_distribution<> dist_int1(0, 10);
        uniform_int_distribution<> dist_int2(0, 15);
        uniform_int_distribution<> dist_int3(15, 20);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(20, 30);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Factorial problem\\Factorial problem\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Factorial problem\\Factorial problem\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Factorial problem\\Factorial problem\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Factorial problem\\Factorial problem\\" + std::to_string(k) + ".a");
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

        std::cout << input[0] << "\n";
        out1.close();
        // испрльзуем элементы вектора вместо переменной
        std::cout << Factorial(input[0])<<"\n";
        out2 << Factorial(input[0]) << '\n';
        out2.close();
    }
}

