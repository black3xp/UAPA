Algoritmo control_armamento
	Definir opcion_menu Como Entero
	// Las armas tienen los siguientes atributos
	// Categoria "Blanca o de Fuego"
	// Existencia o cantidad, No. de Inventario, Estado, Si esta en uso, Perdida o Reserva
	// En caso de aramas de fuego: Calibre de bala, Tiene cargador y si tiene cantidad de balas, Alcance del arma, logitud de canon
	// Armas blancas: material, valor del material, peligrosidad del 1 al 10
	// Peso de perdida armas de fuego: cantidad de balas * por calibre de bala
	// Peso de perdida armas blancas: valor del material * peligrosidad
	// categoria, cantidad, no. inventario, estado, en uso, perdida, reserva, calibre, tiene cargador, cantidad balas, alcance, longitud canion, material, valo del material, peligrosidad
	Dimension armas[10,14]
	opcion_menu <- 1
	Mientras opcion_menu<>0 Hacer
		Escribir '1) Ingresar nueva arma'
		Escribir '2) Mostrar armas'
		Escribir '3) Tercero'
		Escribir ''
		Escribir 'Ingrese una opcion:'
		Leer opcion_menu
		Si opcion_menu=1 Entonces
			Definir cantidad Como Entero
			Definir categoria Como Caracter
			Definir tieneCargador Como Caracter
			cantidad <- 0
			Escribir 'Ingrese que cantidad de armas registrara: '
			Leer cantidad
			Para fil<-0 Hasta cantidad-1 Hacer
				Para col<-0 Hasta 14 Hacer
					Si col=0 Entonces
						Escribir 'Categoria: fuego[Arma de fuego]  blanca[Arma blanca]'
						Leer armas[fil,col]
						categoria <- armas[fil,col]
					FinSi
					Si col=1 Entonces
						Escribir 'Cantidad: '
						Leer armas[fil,col]
					FinSi
					Si col=2 Entonces
						Escribir 'No. Inventario: '
						Leer armas[fil,col]
					FinSi
					Si col=3 Entonces
						Escribir 'En uso: S[si] N[no]'
						Leer armas[fil,col]
					FinSi
					Si col=4 Entonces
						Escribir 'Esta perdidia: S[si] N[no]'
						Leer armas[fil,col]
					FinSi
					Si col=5 Entonces
						Escribir 'Es de reserva: S[si] N[no]'
						Leer armas[fil,col]
					FinSi
					Si col=6 Y categoria='fuego' Entonces
						Escribir 'Calibre: '
						Leer armas[fil,col]
					FinSi
					Si col=7 Y categoria='fuego' Entonces
						Escribir 'Tiene cargador: S[si]  N[no]'
						Leer armas[fil,col]
						tieneCargador <- armas[fil,col]
					FinSi
					Si col=8 Y tieneCargador='S' Entonces
						Escribir 'Cantidad de balas: '
						Leer armas[fil,col]
					FinSi
					Si col=9 Y categoria='fuego' Entonces
						Escribir 'Alcance: '
						Leer armas[fil,col]
					FinSi
					Si col=10 Y categoria='fuego' Entonces
						Escribir 'Longitud de canion: '
						Leer armas[fil,col]
					FinSi
					Si col=11 Y categoria='blanca' Entonces
						Escribir 'Material: '
						Leer armas[fil,col]
					FinSi
					Si col=12 Y categoria='blanca' Entonces
						Escribir 'Valor material: '
						Leer armas[fil,col]
					FinSi
					Si col=13 Entonces
						Escribir 'Peligrosidad: '
						Leer armas[fil,col]
					FinSi
				FinPara
				Escribir ''
			FinPara
		FinSi
		Si opcion_menu=2 Entonces
			Para fil<-0 Hasta 9 Hacer
				Escribir 'Arma #',fil+1
				Para col<-0 Hasta 14 Hacer
					Si col=0 Entonces
						Escribir 'Categoria:',armas[fil,col]
					FinSi
					Si col=1 Entonces
						Escribir 'Cantidad: ',armas[fil,col]
					FinSi
					Si col=2 Entonces
						Escribir 'No. Inventario: ',armas[fil,col]
					FinSi
					Si col=3 Entonces
						Escribir 'En uso:',armas[fil,col]
					FinSi
					Si col=4 Entonces
						Escribir 'Esta perdidia:',armas[fil,col]
					FinSi
					Si col=5 Entonces
						Escribir 'Es de reserva:',armas[fil,col]
					FinSi
					Si col=6 Entonces
						Escribir 'Calibre: ',armas[fil,col]
					FinSi
					Si col=7 Entonces
						Escribir 'Tiene cargador:',armas[fil,col]
					FinSi
					Si col=8 Entonces
						Escribir 'Cantidad de balas: ',armas[fil,col]
					FinSi
					Si col=9 Entonces
						Escribir 'Alcance: ',armas[fil,col]
					FinSi
					Si col=10 Entonces
						Escribir 'Longitud de canion: ',armas[fil,col]
					FinSi
					Si col=11 Entonces
						Escribir 'Material: ',armas[fil,col]
					FinSi
					Si col=12 Entonces
						Escribir 'Valor material: ',armas[fil,col]
					FinSi
					Si col=13 Entonces
						Escribir 'Peligrosidad: ',armas[fil,col]
					FinSi
				FinPara
				Escribir ''
			FinPara
		FinSi
	FinMientras
FinAlgoritmo
