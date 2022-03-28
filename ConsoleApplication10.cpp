#include <iostream>
using namespace std;

class Dog
{
public:
	string breed;
	string size;
	string age;
	string color;

public:

	void show_emp_details() {
		cout << "\n\n**** Details of  Dog ****";
		cout << "\nDog breed          :  " << breed;
		cout << "\nDog size           :  " << size;
		cout << "\nDog age            :  " << age;
		cout << "\nDog color          :  " << color;
		cout << "\n-------------------------------\n\n";
	}

};
class HomeDog:public Dog

{

private:
	string name;
	string oname;
	
public:
	void setoname(string oname) {
		this->oname = oname;
	}
	void setname(string name) {
		this->name = name;

	}
private:
	void show_emp_details() {
		
		cout << "Name master          :" << name;
		cout << "Name dog           :" << oname;
	}
public:
	void show_emp_details1() 
	
	{
		show_emp_details();
		cout << "\n\n**** Details of  Home Dog ****";
		cout << "\nDog breed          :  " << breed;
		cout << "\nDog size           :  " << size;
		cout << "\nDog age            :  " << age;
		cout << "\nDog color          :  " << color;
		cout << "\nDog name           :  " << oname;
		cout << "\nName master        :  " << name;
		cout << "\n-------------------------------\n\n";
	}
};




int main()
{


	Dog emp;
	emp.breed = "Neapolitan Mastiff";
	emp.size = "Large";
	emp.age = "5 years";
	emp.color = "Black";
	emp.show_emp_details();
	Dog emp1;
	emp1.breed = "Maltese";
	emp1.size = "Small";
	emp1.age = "2 years";
	emp1.color = "White";
	emp1.show_emp_details();
	Dog emp2;
	emp2.breed = "Chow Chow";
	emp2.size = "Midium";
	emp2.age = "3 years";
	emp2.color = "Brown";
	emp2.show_emp_details();
	HomeDog emp3;
	emp3.breed = "Bigl";
	emp3.size = "large";
	emp3.age = "10 years";
	emp3.color = "Black";
	emp3.setoname("Chiri");
    emp3.setname ( "Vasya");
	emp3.show_emp_details1();

return 0;
}

