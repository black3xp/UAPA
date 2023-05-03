Algoritmo empleados_fabrica_salario
	Definir dia Como Entero
	Definir turno Como Entero
	Definir salario Como Real
	Definir TARIFA_HORARIA_DIRUNA Como Real
	Definir TARIFA_HORARIA_NOCTURNA Como Real
	dia <- 1
	turno <- 1
	salario <- 0
	TARIFA_HORARIA_DIRUNA <- 5.00
	TARIFA_HORARIA_NOCTURNA <- 8.00
	Mientras dia<>0 O turno<>0 Hacer
		Escribir 'Seleccione el dia: '
		Escribir '1) Lunes'
		Escribir '2) Martes'
		Escribir '3) Miercoles'
		Escribir '4) Jueves'
		Escribir '5) Viernes'
		Escribir '6) Sabado'
		Escribir '7) Domingo'
		Escribir '0) Salir'
		Leer dia
		Escribir 'Seleccione la tanda: '
		Escribir '1) Diurna'
		Escribir '2) Nocturna'
		Escribir '0) Salir'
		Leer tanda
		Si dia<0 O turno<0 Entonces
			Escribir 'Ingrese una opcion valida'
		FinSi
		Si dia=7 Entonces
			TARIFA_HORARIA_DIRUNA <- (TARIFA_HORARIA_DIRUNA+2)
			TARIFA_HORARIA_NOCTURNA <- (TARIFA_HORARIA_NOCTURNA+3)
		FinSi
		Si turno=2 Entonces
			salario <- (TARIFA_HORARIA_NOCTURNA*8)
			Escribir 'turno 2'
		FinSi
		Si turno=1 Entonces
			salario <- (TARIFA_HORARIA_DIRUNA*8)
			Escribir 'turno 1'
		FinSi
		Escribir 'Su salario es de '
		Escribir salario
		TARIFA_HORARIA_DIRUNA <- 5.00
		TARIFA_HORARIA_NOCTURNA <- 8.00
		dia <- 1
		turno <- 1
	FinMientras
FinAlgoritmo
