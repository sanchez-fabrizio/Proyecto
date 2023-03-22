/*Crear un programa que solicite al usuario que ingrese el precio de un producto al
inicio del año, y el precio del mismo producto al finalizar el año. El programa debe
calcular cuál fue el porcentaje de aumento que tuvo ese producto en el año y
mostrarlo por pantalla.*/


#include <iostream>
using namespace std;
int main(){
	int producto, productofinal,aux,aux2;
	cout<<"ingrese el precio inicial del producto "<<endl;
	cin>>producto;
	cout<<"ingrese el precio final del producto  "<<endl;
	cin>>productofinal;
	aux = (productofinal-producto);
	aux2 = (aux/producto)*100;
		cout<<"el aumento que tuvo el producto es de ===  "<<aux2<<endl;
	
	
	
	
	
	
	
	
	
}
