// Complex equation.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
    int Tests, n;
    std::string ans;
    std::cin >> Tests;
    std::cin >> n;
    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> dist_int_samples(0, 10);
    uniform_int_distribution<> dist_int1(0, 100);
    uniform_int_distribution<> dist_int2(-100, 0);
    uniform_int_distribution<> dist_int3(-1000, 1000);
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
        uniform_int_distribution<> dist_int4(-10000, 10000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Complex equation\\Complex equation\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Complex equation\\Complex equation\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Complex equation\\Complex equation\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Complex equation\\Complex equation\\" + std::to_string(k) + ".a");
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
            input[0] = 1; input[1] = 1;input[2] = 2;input[3] = 2;
        }
        if (k == random_number) {
            input[0] = 2;input[1] = -4;input[2] = 7; input[3] = 1;
        }
        if (k == random_number) 
        { input[0] = 1;input[1] = 0; input[2] = 1;input[3] = 0; }
        int a = input[0];
        int b = input[1];
        int c = input[2];
        int d = input[3];
        out1.close();

        if (input[2] == 0 && input[3] == 0) 
        {
            ans = "No";
        }
        else 
        {
            if (input[0] == 0 && input[1] == 0) 
            {
                ans = "INF";
            }
            else 
            {
                if (input[0] == 0) 
                {
                    ans = "No";
                }
                else 
                {
                    if (input[1] == 0) 
                    {
                        ans = "0";
                    }
                    else 
                    {
                        if (floor(input[1] / input[0]) * input[0] == input[1]) 
                        {
                            ans = to_string(-b / a);
                            if (c * stoi(ans) + d == 0) 
                            {
                                ans = "No";
                            }
                            else 
                            {
                                if (a * stoi(ans) + b == 0) {
                                    ans = ans;
                                }
                            }
                        }
                        else 
                        {
                            ans = "No";
                        }
                        
                    }
                }
            }
        }

        std::cout << ans << '\n';
        out2 << ans << '\n';
        out2.close();
    }
}