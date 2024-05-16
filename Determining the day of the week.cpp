// Determining the day of the week.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>  
#include <string>
#include <vector>
#include <chrono>

using namespace std;

std::string Determining_the_day_of_the_week(int day) 
{
    std::string ans;
    switch (day+48)
    {
        case '1':
            ans = "Monday";
            break;
        case '2':
            ans = "Tuesday";
            break;
        case '3':
            ans = "Wednesday";
            break;
        case '4':
            ans = "Fhursday";
            break;
        case '5':
            ans = "Friday";
            break;
        case '6':
            ans = "Saturday";
            break;
        case '7':
            ans = "Sunday";
            break;
        default:
            ans = "Wrong input";
    }
    return ans;
}


int main()
{

    std::ofstream out1;
    std::ofstream out2;

    //генератор чисел(шаблон)
      /**/
    std::cout << "How many times to run the solution?" << "\n";
    int Tests, n;
    std::cin >> Tests;
    std::cin >> n;

    for (int k = 1; k <= Tests;k++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(1, 3);
        uniform_int_distribution<> dist_int1(1, 5);
        uniform_int_distribution<> dist_int2(0, 7);
        uniform_int_distribution<> dist_int3(-1, 7);
        double from = -1.235;
        double to = 157.456;
        using namespace std::chrono;
        std::default_random_engine engine(
            system_clock::to_time_t(system_clock::now()));
        std::uniform_real_distribution<> distr(from, to);
        auto gen_number = [&engine, &distr]() { return distr(engine); };
        uniform_int_distribution<> dist_int4(-100, 1000);
        double random_int;
        std::vector <double> init(20);
        for (int j = 0; j < 20; ++j)
        {
            init[j] = gen_number();
        }
        std::vector<char> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Determining the day of the week\\Determining the day of the week\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Determining the day of the week\\Determining the day of the week\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Determining the day of the week\\Determining the day of the week\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Determining the day of the week\\Determining the day of the week\\" + std::to_string(k) + ".a");
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

        std::cout << random_int << "\n";
        out1.close();
        // испрльзуем элементы вектора вместо переменной
        std::cout << Determining_the_day_of_the_week(input[0])<<'\n';
        out2 << Determining_the_day_of_the_week(input[0]) << '\n';
        out2.close();
    }
}

