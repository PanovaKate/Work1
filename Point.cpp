#include<iostream>
using namespace std;
class Employee
{
public:

	void FIO(string c) {
		cout << "What is your FIO?    " << c << endl;
	}
	void salary(double k) {
		cout << "What salary?    " << k << endl;
	}
};
class Menedger
{
public:
	void FIO(string b) {
		cout << "What is your FIO?    " << b << endl;
	}
	void salary(double a) {
		cout << "What salary?    " << a << endl;
	}
};
int main()
{
	Employee obj;
	obj.FIO("Ivanov II");
	cout  << endl;
	obj.salary(125466);
	cout  << endl;
	Menedger obj1;
	obj1.FIO("Beresina NN");
	cout << endl;
	obj1.salary(68413);
	cout  << endl;
	return 0;
}
