/******************************************************************************
En una fábrica de computadoras se planea ofrecer a los clientes un descuento
que dependerá del número de computadoras que compre. Si las computadoras son
menos de cinco se les dará un 10% de descuento sobre el total de la compra; si
el número de computadoras es mayor o igual a cinco pero menos de diez se le
otorga un 20% de descuento; y si son 10 o más se les da un 40% de descuento. El
precio de cada computadora es de $600.
*******************************************************************************/

#include <iostream>

using namespace std;

int main()
{
    int PRECIO_COMPUTADOR = 600;
    int multiplicacion = 0;
    int cantidad =0;
    int total = 0;
    int descuento = 0;
    
    
    cout<<"Digitar cantidad a comprar:"<<endl;
    cin>>cantidad;
    multiplicacion= PRECIO_COMPUTADOR*cantidad;
    
    if(cantidad<5){
        //descuento de 10%
        descuento = (10*multiplicacion)/100;
        total = multiplicacion - descuento;
    }
    
    if(cantidad>=5 && cantidad<10){
        //descuento de 20%
        descuento = (20*multiplicacion)/100;
        total = multiplicacion - descuento;
    }
    
    if(cantidad>=10){
        //descuento de 40%
        descuento = (40*multiplicacion)/100;
        total = multiplicacion - descuento;
    }


    cout<<"===================================================="<<endl;
    cout<<"|                        FACTURA                   |"<<endl;
    cout<<"===================================================="<<endl;
    cout<<"| cant.         precio              total          |"<<endl;
    cout<<"|  "+to_string(cantidad)+"            "+to_string(PRECIO_COMPUTADOR)+"                 "+to_string(total)+"           |"<<endl;
    cout<<"|__________________________________________________|"<<endl;
    

    return 0;
}