// Finding the smallest number.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>  
#include <string>
#include <vector>
#include <chrono>

using namespace std;


int Finding_the_smallest_number(const std::vector <int> input) 
{
    int ans1 = input[0];
    for (int i = 1;i < input.size() - 1;++i) 
    {
        if (input[i] < ans1) 
        {
            ans1 = input[i];
        }
    }
    return ans1;
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
        double random_int;
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(1, 10);
        uniform_int_distribution<> dist_int1(1, 1000);
        uniform_int_distribution<> dist_int2(1, 10000);
        uniform_int_distribution<> dist_int3(-1000, 10000);
        uniform_int_distribution<> dist_int4(-1000000, 1000000);
        uniform_int_distribution<> dist_int_rols1(2, 5);
        uniform_int_distribution<> dist_int_rols2(5, 100);
        uniform_int_distribution<> dist_int_rols3(100, 5000);
        uniform_int_distribution<> dist_int_rols4(5000, 10000);
        uniform_int_distribution<> dist_int_rols5(10000, 100000);
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Finding the smallest number\\Finding the smallest number\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Finding the smallest number\\Finding the smallest number\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Finding the smallest number\\Finding the smallest number\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Finding the smallest number\\Finding the smallest number\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) {
                int roll = dist_int_rols1(gen);
                for (int i = 0; i <= roll;++i) {
                    if (i == roll) { random_int = 0; input.push_back(random_int); out1 << random_int << '\n'; }
                    else { random_int = dist_int_samples(gen); input.push_back(random_int);std::cout << random_int << '\n';out1 << random_int << '\n';
                    }
                    
                }


            }
            if (k > 2 && k <= 9) {
                int roll = dist_int_rols2(gen);
                for (int i = 0; i <= roll;++i) {
                    if (i == roll) { random_int = 0; input.push_back(random_int);out1 << random_int << '\n'; }
                    else { random_int = dist_int1(gen); input.push_back(random_int);std::cout << random_int << '\n'; out1 << random_int << '\n';
                    }
                    
                }
            }
            if (k > 9 && k <= 19) {
                int roll = dist_int_rols3(gen);
                for (int i = 0; i <= roll;++i) {
                    if (i == roll) {
                        random_int = 0; input.push_back(random_int);out1 << random_int << '\n';
                    }
                    else { random_int = dist_int2(gen); input.push_back(random_int);std::cout << random_int << '\n';out1 << random_int << '\n';
                    }
                }
            }
            if (k > 19 && k <= 29) {

                int roll = dist_int_rols4(gen);
                for (int i = 0; i <= roll;++i) {
                    if (i == roll) { random_int = 0; input.push_back(random_int); out1 << random_int << '\n'; }
                    else {
                        random_int = dist_int3(gen);
                        if (random_int == 0) {
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                            break;
                        }
                        else {
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                        }
                    }
                }
            }
            if (k > 29 && k <= 50) {
                int roll = dist_int_rols5(gen);
                for (int i = 0; i < roll;++i) {

                    if (i == roll) { random_int = 0; input.push_back(random_int); out1 << random_int << '\n'; }
                    else {

                        random_int = dist_int4(gen);
                        if (random_int == 0) {
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                            break;
                        }
                        else {
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                        }
                    }
                }
            }
        }
        out1.close();
        // испрльзуем элементы вектора вместо переменной
        std::cout << Finding_the_smallest_number(input)<<'\n'<<'\n';
        out2 << Finding_the_smallest_number(input) << '\n';
        out2.close();
    }
}

  
