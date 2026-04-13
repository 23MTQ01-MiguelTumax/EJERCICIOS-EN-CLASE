//Un programa que solicite un numero del 1 al 7
//Mostrar en pantalla los dias de la seamana segun el numero
Algoritmo DiasSemana
	Escribir "================================="
	Escribir "DÍAS DE LA SEMANA "
	Escribir "================================="
	//variable
	Definir x Como Entero
	Escribir "Dame un número del 1 al 7 y te diré el día."
	Leer x
	
	Segun x Hacer
		1:
			Escribir "Lunes"
		2:
			Escribir "Martes"
		3:
			Escribir "Miércoles"
		4:
			Escribir "Jueves"
		5:
			Escribir "Viernes"
		6:
			Escribir "Sábado"
		7:
			Escribir "Domingo"
		De Otro Modo:
			Escribir "Ingresa un número dentro del parámetro por favor."
	FinSegun
	
FinAlgoritmo
