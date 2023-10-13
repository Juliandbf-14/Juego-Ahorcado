using System;

class Program
{
    static void Main()
    {
        //Palabra secreta que el jugador debe adivinar
        string palabraSecreta = "mantecado";
        // Número máximo de intentos antes de perder
        int intentosMaximos = 6;

        char[] palabraAdivinada = new char[palabraSecreta.Length];
        for (int i = 0; i < palabraAdivinada.Length; i++)
        {
            palabraAdivinada[i] = '_';
        }

        int intentos = 0;

        Console.WriteLine("¡Bienvenido al juego del ahorcado!");
        Console.WriteLine($"La palabra tiene {palabraSecreta.Length} letras: {string.Join(" ", palabraAdivinada)}");

        while (intentos < intentosMaximos)
        {
            Console.Write("Ingresa una letra: ");
            char letra = Console.ReadLine()[0];

            bool letraAdivinada = false;
            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letra)
                {
                    palabraAdivinada[i] = letra;
                    letraAdivinada = true;
                }
            }

            if (letraAdivinada)
            {
                Console.WriteLine($"¡Bien hecho! Letra encontrada: {string.Join(" ", palabraAdivinada)}");
            }
            else
            {
                intentos++;
                Console.WriteLine($"Letra incorrecta. Te quedan {intentosMaximos - intentos} intentos.");
            }

            if (string.Join("", palabraAdivinada) == palabraSecreta)
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra correctamente.");
                break;
            }
        }

        if (intentos == intentosMaximos)
        {
            Console.WriteLine($"Lo siento, has agotado todos tus intentos. La palabra era: {palabraSecreta}");
        }
    }
}
