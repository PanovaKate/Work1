#include <iostream>
#include <string>
#include <fstream>

using namespace std;
struct Employee {
	string fio; //ФИО
	int medcard; //мед.карта
	int inspolicy; //страховой полис
	int place; //адрес
	
};
int main();

void printInformation(Employee employee){
	int k;
	for (int i = 0; i < k; i++);
	{
		cout << "ФИО: " << employee.fio << "\n";
		cout << "Введите номер медицинской карты: " << employee.medcard << "\n";
		cout << "Введите номер страхового полиса: " << employee.inspolicy << "\n";
		cout << "Введите адрес:" << employee.place << "\n";
	}
		
}



	ofstream Fail;
	
	Fail.open("proekt.txt");

	for (int i = 0; i < k; i++) {
		Fail << "\n Сведения о пациенте №" << i + 1 << " " << endl;
		Fail << "Фамилия: " << pat[i].surname << "\n";
		Fail << "Имя: " << pat[i].name << "\n";
		Fail << "Отчество: " << pat[i].midname << "\n";
		Fail << "Место проживания: " << pat[i].place << "\n";
		Fail << "Номер медицинской карты: " << pat[i].num.medcard << "\n";
		Fail << "Номер страхового полиса: " << pat[i].num.inspolicy << "\n";
		Fail << "---------------------------------------------\n";
	}
	Fail.close();

}
void readf()
{
	char S[200] = { "" }; //В S будут считываться строки 

	ifstream Fail("C:\\Users\\yurlovann\\Desktop\\Мои документы\\test.txt"); //Открыли файл для чтения
	if (!Fail.is_open()) {
		cout << "Файл не может быть открыт\n";
		exit(1);
	}
	while (!Fail.eof()) {
		Fail.getline(S, 50);
		cout << S << endl;
	}
	Fail.close();  //Закрыли открытый файл
}



	readf();
}
