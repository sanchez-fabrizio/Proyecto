/*A partir de una conocida cantidad de días que el usuario ingresa a través del teclado,
escriba un programa para convertir los días en horas, en minutos y en segundos.*/
#include <iostream>
using namespace std;
int main(){
	int dias , horas , minutos,segundos,aux1 ;
	cout<<"ingrese dias"<<endl;
	cin>>dias;
	
	
	horas = dias *24;
	minutos = horas *60;
	segundos = minutos *60;
	
	cout<<"los dias es       "<<dias<<endl;
	cout<<"los horas es      "<<horas<<endl;
	cout<<"los minutos es    "<<minutos<<endl;
	cout<<"los segundos es   "<<segundos<<endl;
	
	
	
	
}
