// End of the lesson.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
    int Tests, ans1, ans2, n, lesson, time;
    std::ofstream out1;
    std::ofstream out2;

    //генератор чисел(шаблон)
      /**/
    std::cout << "How many times to run the solution?" << "\n";
    std::cin >> Tests;
    std::cin >> n;

    for (int k = 1; k <= Tests;k++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(1, 3);
        uniform_int_distribution<> dist_int1(1, 5);
        uniform_int_distribution<> dist_int2(1, 10);
        uniform_int_distribution<> dist_int3(5, 13);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(10, 16);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\End of the lesson\\End of the lesson\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\End of the lesson\\End of the lesson\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\End of the lesson\\End of the lesson\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\End of the lesson\\End of the lesson\\" + std::to_string(k) + ".a");
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
        }        out1.close();
        time = 0;;
        lesson = input[0] * 45;
        for (int i = 1; i < input[0]; ++i) 
        {
            
            if (i % 2 == 0) 
            {
                time += 15;
            }
            else 
            {
                time += 5;
            }
        }
        ans1 = floor((lesson + time)/60) + 9 ;
        ans2 = (lesson + time) - (floor((lesson + time) / 60) * 60);

        std::cout <<input[0] << "\n" << ans1 << " " << ans2 << "\n";
        // испрльзуем элеме0нты вектора вместо переменной
        out2 << ans1 << " " << ans2;
        out2.close();
    }
}

