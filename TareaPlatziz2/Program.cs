
var opcion = 0;
var opcion2 = 0;

do
{
    try
    {
        // No sale del bucle hasta que el usuario de una opción válida.
        do
        {
            // Mensaje de bienvenida al usuario
            Console.WriteLine("¡Hola!, Cuál operación quisieras hacer (Coloca el número de la operacion)\n1.Operadores lógicos\n2.operadores relacionales\n3.Manipulación de strings");
            opcion = int.Parse(Console.ReadLine());

            // En caso de que no se coloque una opción válida entonces da un mensaje de error.
            if (opcion != 1 && opcion != 2 && opcion != 3)
            {
                Console.WriteLine("Lo sentimos, intente otra opción.");
            }

        } while (opcion != 1 && opcion != 2 && opcion != 3);

        // PARTE DE OPERADORES LÓGICOS
        if (opcion == 1)
        {
            // Variables 
            bool valor1, valor2;
            bool resultadoLogico1, resultadoLogico2, resultadoLogico3a, resultadoLogico3b, resultadoLogico4;

            // Mensaje de bienvenida 
            Console.WriteLine("Hola, escribe los valores true o false y después se comprueba ambos con operadores lógicos.");


            // Inputs del usuario
            Console.Write("\nValor 1:");
            valor1 = bool.Parse(Console.ReadLine());
            Console.Write("\nValor 2:");
            valor2 = bool.Parse(Console.ReadLine());

            // Comprobaciones de operadores logicos
            resultadoLogico1 = valor1 && valor2;
            resultadoLogico2 = valor1 || valor2;
            resultadoLogico3a = !valor1;
            resultadoLogico3b = !valor2;
            resultadoLogico4 = valor1 ^ valor2;

            // Mensaje de resultados
            Console.WriteLine("El resultado de la operacion AND es " + resultadoLogico1);
            Console.WriteLine("El resultado de la operacion OR es " + resultadoLogico2);
            Console.WriteLine("El resultado de la operacion NOT en el valor 1 es " + resultadoLogico3a);
            Console.WriteLine("El resultado de la operacion NOT en el valor 2 es " + resultadoLogico3b);
            Console.WriteLine("El resultado de la operacion XOR es " + resultadoLogico4);

        }

        // PARTE DE OPERADORES RELACIONALES
        if (opcion == 2)
        {
            // Variables
            int num1, num2, opcionRelacionales;
            bool resultadoRelacionales = false;

            Console.WriteLine("Bienvenidos a operadores lógicos, ingresa los números para poder realizar las operaciones");
            Console.Write("\nNúmero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nNúmero 2:");
            num2 = int.Parse(Console.ReadLine());

            // Preguntas de las opciones para las operaciones
            Console.WriteLine("Selecciona una operación para comparar los números." +
            "\n1.Igual (==)\n2.Diferente (!=)\n3.Mayor que (>)\n4.Menor que (<)\n5.Mayor o igual que (>=)\n6.Menor o igual que (<=)\n");
            Console.Write("\nOpción a elegir:");
            opcionRelacionales = int.Parse(Console.ReadLine());

            // Dependiendo de la opción se ejecuta una comparación u otra.
            if (opcionRelacionales == 1)
            { // Operacion 1
                if (num1 == num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else if (opcionRelacionales == 2)
            { // Operacion 2
                if (num1 != num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else if (opcionRelacionales == 3)
            { // Operacion 3
                if (num1 > num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else if (opcionRelacionales == 4)
            { // Operacion 4
                if (num1 < num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else if (opcionRelacionales == 5)
            { // Operacion 5
                if (num1 >= num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else if (opcionRelacionales == 6)
            { // Operacion 6
                if (num1 <= num2) resultadoRelacionales = true; else resultadoRelacionales = false;
            }
            else
            { // En caso de no haber otra opción lo reintenta 
                Console.WriteLine("Lo sentimos, no ha elegido una opción válida.\n");
            }

            // Mensaje de resultados
            Console.WriteLine("El resultado de la operacion ha sido que la comparación ha resultado en :" + resultadoRelacionales);

        }

        // PARTE DE MANIPULACION DE STRINGS
        if (opcion == 3)
        {
            // Variables
            string nombre, id;
            int edad;

            // Mensaje de bienvenida
            Console.WriteLine("Buenas, para esta operación se le pedirá su nombre completo y su edad, para después crear una identificación personalizada.");

            // Inputs del usuario
            Console.Write("\nIngrese su nombre completo:");
            nombre = Console.ReadLine();
            Console.Write("\nAhora ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            // Mensaje de respuesta, se crea una identificacion con su nombre y edad
            Console.WriteLine($"Hola {nombre}, su identificación es {nombre}{edad}-{opcion}");

        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Ha ocurrido un error. error:" + e.Message)
    }

    // Imprime un mensaje de salida, se puede regresar de nuevo a la misma operación ( No se puede cambiar la operación)
    Console.WriteLine("\nQuieres ingresar otra operación?\n1.Reintentar\n2.Salir");
    opcion2 = int.Parse(Console.ReadLine());

} while (opcion2 == 1);