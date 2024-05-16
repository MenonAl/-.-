// Rook.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//


#include <fstream>
#include <random>
#include <iostream>
#include <cstdlib>
#include <string>

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

    for (int i = 1; i <= Tests;i++)
    {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int(1, 8);
        int random_int = dist_int(gen);
        std::vector<int> input = {};
        if (i < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Rook\\Rook\\0" + std::to_string(i));
            out2.open("C:\\Users\\menon\\source\\repos\\Rook\\Rook\\0" + std::to_string(i) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\Rook\\Rook\\" + std::to_string(i));
            out2.open("C:\\Users\\menon\\source\\repos\\Rook\\Rook\\" + std::to_string(i) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            random_int = dist_int(gen);
            input.push_back(random_int);
            out1 << random_int << '\n';
        }
        std::cout << input[0] << "\n" << input[1] << '\n' << input[2] << '\n'<<input[3]<<'\n';
        out1.close();
        if (input[0] == input[2] || input[1] == input[3])
        {
            ans = "Yes";
        }
        else
        {
            ans = "No";
        }


        // испрльзуем элементы вектора вместо переменной
        std::cout << ans << '\n';
        out2 << ans << '\n';
        out2.close();
    }
}
