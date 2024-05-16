// Sum and arithmetic mean.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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
void Sum_and_arithmetic_mean(const std::vector<double>& input)
{
    double ans1 = 0;
    double ans2 = 0;
    for (int i = 0; i < input.size() - 1; ++i) 
    {
        ans1 = ans1 + input[i];
    }
    ans2 = ans1 / (input.size()-1);
    std::cout << ans1 << '\n' << ans2 << '\n'<<'\n';
    out2 << ans1 << '\n' << ans2 << '\n';
    out2.close();
    return;
}

int main()
{


    //генератор чисел(шаблон)
      /**/
    std::cout << "How many times to run the solution?" << "\n";
    int Tests, n;
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
        uniform_int_distribution<> dist_int3(-1000, 1000);
        uniform_int_distribution<> dist_int4(-10000, 10000);
        uniform_int_distribution<> dist_int_rols1(2, 5);
        uniform_int_distribution<> dist_int_rols2(5, 100);
        uniform_int_distribution<> dist_int_rols3(100, 500);
        uniform_int_distribution<> dist_int_rols4(500, 1000);
        uniform_int_distribution<> dist_int_rols5(1000, 1000);
        std::vector<double> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Sum and arithmetic mean\\Sum and arithmetic mean\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Sum and arithmetic mean\\Sum and arithmetic mean\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Sum and arithmetic mean\\Sum and arithmetic mean\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Sum and arithmetic mean\\Sum and arithmetic mean\\" + std::to_string(k) + ".a");
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
                    if (i == roll) { random_int = 0; input.push_back(random_int);out1 << random_int << '\n';}
                    else { random_int = dist_int1(gen); input.push_back(random_int);std::cout << random_int << '\n'; out1 << random_int << '\n';
                    }
                    
                }
            }
            if (k > 9 && k <= 19) {
                int roll = dist_int_rols3(gen);
                for (int i = 0; i <= roll;++i) {
                    if (i == roll) { random_int = 0; input.push_back(random_int);out1 << random_int << '\n';
                    }
                    else { random_int = dist_int2(gen); input.push_back(random_int);std::cout << random_int << '\n'; out1 << random_int << '\n';
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

                    if (i == roll) { random_int = 0; input.push_back(random_int); out1 << random_int << '\n';}
                    else {
                        
                        random_int = dist_int4(gen);
                        if (random_int == 0) {
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                            break;
                        }
                        else{
                            input.push_back(random_int);
                            std::cout << random_int << '\n';
                            out1 << random_int << '\n';
                        }
                    }
                }
            }
        }
        out1.close();
        Sum_and_arithmetic_mean(input);
        

    }
}

