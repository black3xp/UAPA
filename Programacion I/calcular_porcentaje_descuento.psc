Algoritmo calcular_porcentaje_descuento
	Definir cantidad,multiplicacion,PRECIO_COMPUTADOR,total,descuento Como Entero
	cantidad <- 0
	multiplicacion <- 0
	PRECIO_COMPUTADOR <- 600
	total <- 0
	descuento <- 0
	Escribir 'Digitar la cantidad a comprar:'
	Leer cantidad
	multiplicacion <- PRECIO_COMPUTADOR*cantidad
	Si cantidad<5 Entonces
		descuento <- (10*multiplicacion)/100
		total <- multiplicacion-descuento
	FinSi
	Si cantidad>=5 Y cantidad<10 Entonces
		descuento <- (20*multiplicacion)/100
		total <- multiplicacion-descuento
	FinSi
	Si cantidad>=10 Entonces
		descuento <- (40*multiplicacion)/100
		total <- multiplicacion-descuento
	FinSi
	Escribir 'Total a pagar es: '
	Escribir total
FinAlgoritmo
