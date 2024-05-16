// hypotenuse.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <fstream>
#include <random>
#include <cstdlib>
#include <string>
#include <iostream>
#include <cmath>
#include <vector>;

using namespace std;

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
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dist_int_samples(0, 10);
        uniform_int_distribution<> dist_int1(0, 1000);
        uniform_int_distribution<> dist_int2(-1000, 0);
        uniform_int_distribution<> dist_int3(0, 10000);
        uniform_int_distribution<> dist_int4(-10000, 10000);
        int random_int;
        std::vector <int> init (5);
        init[0] = dist_int_samples(gen);
        init[1] = dist_int1(gen);
        init[2] = dist_int2(gen);
        init[3] = dist_int3(gen);
        init[4] = dist_int4(gen);
        std::vector<int> input = {};
        if (k < 10)
        {
            out1.open("C:\\Users\\menon\\source\\repos\\hypotenuse\\hypotenuse\\0" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\hypotenuse\\hypotenuse\\0" + std::to_string(k) + ".a");
        }
        else
        {
            out1.open("C:\\Users\\menon\\source\\repos\\hypotenuse\\hypotenuse\\" + std::to_string(k));
            out2.open("C:\\Users\\menon\\source\\repos\\hypotenuse\\hypotenuse\\" + std::to_string(k) + ".a");
        }
        for (int i = 0; i < n;i++)
        {
            if (k < 3) { random_int = dist_int_samples(gen); }
            if (k > 2 && k <= 9) { random_int = dist_int1(gen); }
            if (k > 9 && k <= 19) { random_int = dist_int2(gen); }
            if (k > 19 && k <= 29) { random_int = dist_int3(gen); }
            if (k > 29 && k <= 50) { random_int = dist_int4(gen); }
            input.push_back(random_int);
            out1 << random_int << '\n';
        }
        std::cout << input[0] << '\n' << input[1] << '\n';
        out1.close();
        double ans;
        out2.open("C:\\Users\\menon\\source\\repos\\hypotenuse\\hypotenuse\\0" + std::to_string(k) + ".a");
        if (input[0] <= 0 || input[1] <= 0) {
            std::cout << "Wrong input" << '\n';
            out2 << "Wrong input" << "\n";
            out2.close();
        }
        else {
            ans = sqrt(input[0] * input[0] + input[1] * input[1]);
            std::cout << ans << "\n";
            out2 << ans << '\n';
            out2.close();
        }
        
        // испрльзуем элементы вектора вместо переменной
        

    }
}

