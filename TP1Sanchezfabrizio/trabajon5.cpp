/*Un colegio desea saber qu� porcentaje de ni�os y qu� porcentaje de ni�as hay en el
curso actual. Dise�ar un programa para este prop�sito. Recuerda que para calcular el
porcentaje puedes hacer una regla de 3 simple. El programa debe solicitar al usuario
que ingrese la cantidad total de ni�os, y la cantidad total de ni�as que hay en el curso.*/
#include <iostream>
using namespace std;
int main(){
	
	int chicos,chicas,aux,aux2,total;
		cout<<"ingrese la cantidad de chico  "<<endl;
		cin>>chicos;
		cout<<"ingrese la cantidad de chica  "<<endl;
		cin>>chicas;
		total = chicos +chicas;
	aux = (chicos)*total;
	aux2 = (chicas)*total;
	cout<<" la cantidad de alumno es   "<<total<<endl;
	cout<<" la cantidad de chico es  "<<chicas<<" % "<<endl;
	cout<<" la cantidad de chica es  "<<chicos<<" % "<<endl;
	
	
	
	
	
	
	
}
