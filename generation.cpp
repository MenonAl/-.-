// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
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


extern std::string N_account = "NoName";

random_device rd;
mt19937 gen(rd());

std::string Creating_a_new_account_for_a_client(string N_account, int account_number)
{
	N_account = "User";
	return N_account;
}
void Name_of_account(std::string N_account, int account_number)
{
	std::cout << N_account << '\n';
	out2 << N_account << '\n';
	return;
}
int Depositing_money_into_the_account(int Balance) 
{
	uniform_int_distribution<> dist_int_money_plus(-100, 40000);
	int money_plus = dist_int_money_plus(gen);
	out1 << money_plus << '\n';
	if (money_plus < 0) 
	{
		std::cout << "This isn't possible" << '\n';
		out2 << "This isn't possible" << '\n';
	}
	else {
		Balance += money_plus;

		std::cout << Balance << '\n';
	}
	return Balance;
}
int Withdrawing_money_from_the_account(int Balance) 
{
	uniform_int_distribution<> dist_int_money_minus(-10, 4000);
	int money_minus = dist_int_money_minus(gen);
	out1 << money_minus << '\n';
	if (money_minus < 0) 
	{
		std::cout << "This isn't possible"<<'\n';
		out2 << "This isn't possible" << '\n';
	}
	else {
		if (money_minus > Balance)
		{
			std::cout << "You haven't enough money on your balanse " << N_account<<'\n';
			out2 << "You haven't enough money on your balanse " << N_account << '\n';
		}
		else
		{
			Balance -= money_minus;
			
		}
	}
	return Balance;
}
void Viewing_My_Account_Balance(int Balance,string N_account) 
{
	std::cout << Balance<<'\n';
	out2 << Balance << '\n';
	return;
}
void Shut_down(int Balance) 
{
	Balance = 0;
	N_account = "NoName";
}
int main()
{
	int Balance, account_number,Tests,n, ans;

	std::cin >> Tests;
	std::cin >> n;



	std::vector<std::string>string_comand = { "Creating_a_new_account_for_a_client","Name_of_account","Depositing_money_into_the_account","Withdrawing_money_from_the_account","Viewing_My_Account_Balance","Shut_down" };
	
	
	random_device rd;
	mt19937 gen(rd());
	for (int k = 1; k <= Tests;++k) 
	{
		Balance = 0;
		account_number = 0;
		std::vector<int> input = {};
		int random_int = 0;
		uniform_int_distribution<> dist_int_samples(2, 5);
		uniform_int_distribution<> dist_int1(2, 100);
		uniform_int_distribution<> dist_int2(2, 1000);
		uniform_int_distribution<> dist_int3(2, 5000);
		uniform_int_distribution<> dist_int4(2, 10000);
		if (k < 10)
		{
			out1.open("C:\\Users\\menon\\source\\repos\\Banking system simulation\\Banking system simulation\\0" + std::to_string(k));
			out2.open("C:\\Users\\menon\\source\\repos\\Banking system simulation\\Banking system simulation\\0" + std::to_string(k) + ".a");
		}
		else
		{
			out1.open("C:\\Users\\menon\\source\\repos\\Banking system simulation\\Banking system simulation\\" + std::to_string(k));
			out2.open("C:\\Users\\menon\\source\\repos\\Banking system simulation\\Banking system simulation\\" + std::to_string(k) + ".a");
		}
		for (int i = 0; i < n;i++)
		{
			if (k < 3) {
				random_int = dist_int_samples(gen);
				input.push_back(random_int);
			}
			if (k > 2 && k <= 9) {
				random_int = dist_int1(gen);
				std::cout << random_int << '\n';
				input.push_back(random_int);
			}
			if (k > 9 && k <= 19) {
				random_int = dist_int2(gen);
				input.push_back(random_int);
			}
			if (k > 19 && k <= 29) {

				random_int = dist_int3(gen);
				input.push_back(random_int);
			}
			if (k > 29 && k <= 50) {
				random_int = dist_int4(gen);
				input.push_back(random_int);
			}
		}
		uniform_int_distribution<> dist_int_comand(1, 4);
		std::vector<int>comand = {};
		for (int i = 0; i < input[0];++i) {
			comand.push_back(0);
		}
		for (int i = 0; i < input[0];++i)
		{
			if (i == 0)
			{
				comand[0] = 0;

			}
			else
			{
				if (i == input[0] - 1)
				{
					comand[i] = 5;
				}
				else {
					comand[i] = dist_int_comand(gen);
				}
			}
		}
		for (int p = 0; p < comand.size(); ++p)
		{
			switch (comand[p] + 48)
			{
			case '0':
				std::cout << "Creating_a_new_account_for_a_client" << '\n';
				out1 << "Creating_a_new_account_for_a_client" << '\n';
				N_account = Creating_a_new_account_for_a_client(N_account, account_number);
				break;
			case '1':
				std::cout << "Name_of_account" << '\n';
				out1 << "Name_of_account" << '\n';
				Name_of_account(N_account, account_number);
				break;
			case '2':
				std::cout << "Depositing_money_into_the_account" << '\n';
				out1 << "Depositing_money_into_the_account" << '\n';
				Balance = Depositing_money_into_the_account(Balance);
				break;
			case '3':
				std::cout << "Withdrawing_money_from_the_account" << '\n';
				out1 << "Withdrawing_money_from_the_account" << '\n';
				Balance = Withdrawing_money_from_the_account(Balance);
				break;

			case '4':
				std::cout << "Viewing_My_Account_Balance" << '\n';
				out1 << "Viewing_My_Account_Balance" << '\n';
				Viewing_My_Account_Balance(Balance, N_account);
				break;
			case '5':
				std::cout << "Shut_down" << '\n';
				out1 << "Shut_down" << '\n';
				Shut_down(Balance);
				break;
			}
		}
		out1.close();
		out2.close();
	}//random_int - количество команд для системы
	
}
