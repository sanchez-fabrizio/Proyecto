/*1- Solicitar al usuario que ingrese la base y altura de un rectángulo, y calcular y mostrar
por pantalla el área y perímetro del mismo*/
#include <iostream>

using namespace std;

int main(){
	
	int base,altura,area,perimetro;
	
	cout<<"ingrese la base de un rectangulo"<<endl;
	cin>>base;
		cout<<"ingrese la altura de un rectangulo"<<endl;
	cin>>altura;
	area = base * altura;
	perimetro = 2 * altura + 2 * base;
	cout<<"el area  de un rectangulo es   "<<    area    <<endl;
	cout<<"el perimetro  de un rectangulo es  "<< perimetro  <<endl;
	
	
	
	
	
	
}
