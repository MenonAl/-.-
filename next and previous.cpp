// next and previous.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <chrono>

using namespace std;

int main()
{
    auto a = path("tests") / path("myfile.txt");
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
        uniform_int_distribution<> dist_int1(0, 1000);
        uniform_int_distribution<> dist_int2(-1000, 0);
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
            out1.open("0" + std::to_string(k));
            out2.open("0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open( std::to_string(k));
            out2.open( std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) { random_int = dist_int_samples(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 2 && k <= 9) { random_int = dist_int1(gen); input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 9 && k <= 19) { random_int = dist_int2(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
            if (k > 19 && k <= 29) {

                std::cout << init[k - 20+n] << '\n';
                input.push_back(init[k-20+n]);
                out1 << init[k-20] << '\n';
            }
            if (k > 29 && k <= 50) { random_int = dist_int4(gen);input.push_back(random_int);out1 << random_int << '\n';
            }
            
        }

        int ans1, ans2;
        ans1 = trunc(input[0]) + 1;
        ans2 = ceil(input[0]) - 1;
        out1.close();
        // испрльзуем элементы вектора вместо переменно
        out2 << "The next number for the number " << input[0] << " is " << ans1 << "\n" << "The previous number for the number " << input[0] << " is " << ans2 << '\n';
        out2.close();
        std::cout << "The next number for the number " << input[0] << " is " << ans1 << "\n";
        std::cout << "The previous number for the number " << input[0] << " is " << ans2 << '\n';

    }
}