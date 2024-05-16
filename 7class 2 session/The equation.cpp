// The equation.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
    int Tests,  n;
    std::string ans;
    std::cin >> Tests;
    std::cin >> n;
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> dist_int_samples(0, 10);
    uniform_int_distribution<> dist_int1(0, 100);
    uniform_int_distribution<> dist_int2(-100, 0);
    uniform_int_distribution<> dist_int3(-100, 100);
    uniform_int_distribution<> dist_int5(1, 40);
    int random_number = dist_int5(gen);
    for (int k = 1; k <= Tests;k++)
    {

        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(-1000, 1000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\The equation\\The equation\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\The equation\\The equation\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\The equation\\The equation\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\The equation\\The equation\\" + std::to_string(k) + ".a");
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

        if (k == random_number) {
            input[0] = 1; input[1] = 1; }
        if (k == random_number) { 
            input[0] = 2;input[1] = -6; }
        if (k == random_number) { input[0] = 0;input[1] = 0;}
        int a = input[0];
        int b = input[1];
        if (a == 0 && b == 0) 
        {
            ans = "INF";
        }
        else
        {
            if (a == 0) 
            {
                ans = "NO";
            }
            else 
            {
                if (b == 0)
                {
                    ans = "0";
                }
                else
                {
                    if (fabs(b) < a)
                    {
                        ans = "NO";
                    }
                    else
                    {
                        if (ceil((-a) / b) * a + b == 0)
                        {
                            ans = to_string((-b) / a);
                        }
                        else
                        {
                            ans = "NO";
                        }
                    }
                }
            }
        }
        out1.close();
        // испрльзуем элементы вектора вместо переменной
       
        std::cout << ans << '\n';
        out2 << ans << '\n';
        out2.close();
    }
}
