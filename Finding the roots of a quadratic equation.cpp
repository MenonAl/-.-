// Finding the roots of a quadratic equation.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
std::ofstream out1;
std::ofstream out2;

void Finding_the_roots_of_a_quadratic_equation(int a, int b, int c) 
{
    double discriminant = b * b - 4 * a * c;

    if (discriminant == 0) 
    {
        double ans = -b/(2*a);
        std::cout << ans << '\n';
        out2 << ans << '\n';
        return;
    }
    if (a == 0) 
    {
        double j = -c /b;
        std::cout << j << '\n';
        out2 << j << '\n';
        return;
    }
    if (discriminant > 0) 
    {
        double ans1 = (( - 1 * b + sqrt(discriminant)) / (2 * a));
        double ans2 = ((- 1 * b - sqrt(discriminant)) / (2 * a));
        std::cout << "----------------" << '\n';
        std::cout << ans1 << '\n' << ans2 << '\n';
        out2 << ans1 << "\n" << ans2;
        return;
    }

}

int main()
{


    //генератор чисел(шаблон)
      /**/
    std::cout << "How many times to run the solution?" << "\n";
    int Tests,  n;
    std::cin >> Tests;
    std::cin >> n;

    for (int k = 1; k <= Tests;k++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(1, 100);
        uniform_int_distribution<> dist_int1(-100, 0);
        uniform_int_distribution<> dist_int2(-1000, 1000);
        uniform_int_distribution<> dist_int3(-10000, 0);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(0, 10000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Finding the roots of a quadratic equation\\Finding the roots of a quadratic equation\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Finding the roots of a quadratic equation\\Finding the roots of a quadratic equation\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Finding the roots of a quadratic equation\\Finding the roots of a quadratic equation\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Finding the roots of a quadratic equation\\Finding the roots of a quadratic equation\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) {
                random_int = dist_int_samples(gen);input.push_back(random_int);
            }
            if (k > 2 && k <= 9) {
                random_int = dist_int1(gen); input.push_back(random_int);
            }
            if (k > 9 && k <= 19) {
                random_int = dist_int2(gen);input.push_back(random_int);
            }
            if (k > 19 && k <= 39) {

                random_int = dist_int3(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 39 && k <= 50) {
                random_int = dist_int4(gen);input.push_back(random_int);
            }
        }
        if (k == 1) {
            input[0] = 1;
            input[1] = 4;
            input[2] = 4;
        }
        if (k == 17) {
            input[0] = 1;
            input[1] = 5;
            input[2] = 4;
        }
        out1 << input[0] << '\n' << input[1] << '\n' << input[2] << '\n';
        std::cout << input[0] << '\n' << input[1] << '\n'<<input[2] << "\n";
        out1.close();
        double discriminant = input[1] * input[1] - 4 * input[0] * input[2];
        if (discriminant < 0)
        {
            std::cout << "No solution" << "\n";
            out2 << "No solution" << '\n';
            out2.close();
        }
        else 
        {
            Finding_the_roots_of_a_quadratic_equation(input[0], input[1], input[2]);
            out2.close();
        }
        // испрльзуем элементы вектора вместо переменной

    }
}
