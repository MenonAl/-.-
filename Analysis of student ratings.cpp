// Analysis of student ratings.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>  
#include <string>
#include <vector>
#include <chrono>
std::ofstream out1;
std::ofstream out2;
using namespace std;
int A,B,C,D,F;
void Analysis_of_student_ratings(int student, std::vector<int> init) 
{
    A = 0;
    B = 0;
    C = 0;
    D = 0;
    F = 0;
    for (int k = 0; k < init.size();++k) 
    {
        if (init[k] >= 90) 
        {
            A++;
        }
        else 
        {
            if (init[k] >= 80) 
            {
                B++;
            }
            else 
            {
                if (init[k] >= 70) 
                {
                    C++;
                }
                else 
                {
                    if (init[k] >= 60) 
                    {
                        D++;
                    }
                    else 
                    {
                        F++;
                    }
                }
            }
        }
    }
    int summ = 0;
    for (int i = 0; i < init.size();++i)
    {
        summ = summ + init[i];
    }
    double midl = 0;
    midl = summ / (init.size() );
    std::cout <<'\n' << midl << '\n';
    out2<< midl << '\n';
    std::cout << A << " " << B << ' ' << C << " " << D << " " << F << '\n';
    out2 << A << " " << B << ' ' << C << " " << D << " " << F << '\n';

}


int main()
{


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
        uniform_int_distribution<> dist_int_samples(1, 5);
        uniform_int_distribution<> dist_int1(1, 50);
        uniform_int_distribution<> dist_int2(50, 1000);
        uniform_int_distribution<> dist_int3(1000, 10000);
        uniform_int_distribution<> dist_int4(10000, 200000);
        uniform_int_distribution<> dist_int_mark(1, 100);
        int random_int;
        int marks;
        std::vector <int> init = {};
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Analysis of student ratings\\Analysis of student ratings\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Analysis of student ratings\\Analysis of student ratings\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Analysis of student ratings\\Analysis of student ratings\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\Analysis of student ratings\\Analysis of student ratings\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) {
                random_int = dist_int_samples(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
                std::cout << random_int << "\n" << '\n';
                for (int j = 0; j < random_int;++j) 
                {
                    marks = dist_int_mark(gen);
                    init.push_back(marks);
                    std::cout << marks << '\n';
                    out1 << marks << '\n';
                }
            }
            if (k > 2 && k <= 9) {
                random_int = dist_int1(gen); 
                input.push_back(random_int);
                out1 << random_int << '\n';
                std::cout << random_int << "\n" << '\n';
                for (int j = 0; j < random_int;++j)
                {
                    marks = dist_int_mark(gen);
                    init.push_back(marks);
                    std::cout << marks << '\n';
                    out1 << marks << '\n';
                }
            }
            if (k > 9 && k <= 19) {
                random_int = dist_int2(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
                std::cout << random_int << "\n" << '\n';
                for (int j = 0; j < random_int;++j)
                {
                    marks = dist_int_mark(gen);
                    init.push_back(marks);
                    std::cout << marks << '\n';
                    out1 << marks << '\n';
                }
            }
            if (k > 19 && k <= 29) {

                random_int = dist_int3(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
                std::cout << random_int << "\n" << '\n';
                for (int j = 0; j < random_int;++j)
                {
                    marks = dist_int_mark(gen);
                    init.push_back(marks);
                    std::cout << marks << '\n';
                    out1 << marks << '\n';
                }
            }
            if (k > 29 && k <= 50) {
                random_int = dist_int4(gen);
                input.push_back(random_int);
                out1 << random_int << '\n';
                std::cout << random_int << "\n" << '\n';
                for (int j = 0; j < random_int;++j)
                {
                    marks = dist_int_mark(gen);
                    init.push_back(marks);
                    std::cout << marks << '\n';
                    out1 << marks << '\n';
                }
            }
        }

 
        Analysis_of_student_ratings(random_int, init);
        out1.close();
        out2.close();
    }
}

