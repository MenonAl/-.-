// Banking system simulation.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

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

extern int a = 0;
void Hello_world() 
{
    a = 1;
    std::cout << "Hello world";
}
 

int main()
{
    std::cout << "How many times to run the solution?" << "\n";
    int Tests, ans, n;
    std::cin >> Tests;
    std::cin >> n;

/*  
    for (int k = 1; k <= Tests;k++)
    {
        int random_int;
        std::vector<double> input = {};
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(0, 10);
        uniform_int_distribution<> dist_int1(0, 1000);
        uniform_int_distribution<> dist_int2(-1000, 0);
        uniform_int_distribution<> dist_int3(-1000, 1000);
        uniform_int_distribution<> dist_int4(-10000, 10000);
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Name\\Name\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Name\\Name\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Name\\Name\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Name\\Name\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) {
                random_int = dist_int_samples(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 2 && k <= 9) {
                random_int = dist_int1(gen); 
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 9 && k <= 19) {
                random_int = dist_int2(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 19 && k <= 29) {

                random_int = dist_int3(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
            if (k > 29 && k <= 50) {
                random_int = dist_int4(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
            }
        }
        out1.close();
        std::cout << input[0] << "\n";
        std::cout << ans;
        out2 << ans << '\n';
        out2.close();
    }
    */
    std::vector<string> Hello = {};
    Hello.push_back("Hello_world");
    Hello.push_back("HHello");
    if (Hello[1] == "HHello") 
    {
        std::cout << Hello[0];
    }
    Hello_world();
    std::cout << a;
}
