Algoritmo Ejercicio2Clase
	Escribir "FAST CALCULATOR"
	Escribir "Dime 2 números y una opción, y te diré el resultado."
	Definir num1, num2, sum, resta, div, mult Como Real
	Escribir "Opción 1: Suma"
	Escribir "Opción 2: Resta"
	Escribir "Opción 3: División"
	Escribir "Opción 4: Multiplicación"
	
	Definir op Como Entero
	Escribir "Número 1: " Sin Saltar
	Leer num1
	Escribir "Número 2: " Sin Saltar
	Leer num2
	Escribir "Opción: " Sin Saltar
	Leer op
	
	Segun op Hacer
		1:
			sum = num1 + num2
			Escribir "El resultado de la suma es: ", sum
		2:
			resta = num1 - num2
			Escribir "El resultado de la resta es: ", resta
		3:
			div = num1 / num2
			Escribir "El resultado de la división es: ", div
		4:
			mult = num1 * num2
			Escribir "El resultado de la multiplicación es: ", mult
		De Otro Modo:
			Escribir "Ingrese una opción dentro del rango."
	FinSegun
	
FinAlgoritmo
