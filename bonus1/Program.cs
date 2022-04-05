// See https://aka.ms/new-console-template for more information
/*************************funzioni*********************************/
//stampa array
void stampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

//funzione al quadrato
int funzioneAlQuadrato(int numero1)
{
    numero1 = numero1 * numero1;
    return numero1;
}

//funzione copia array elevato al quadrato

int[] arrayAlQuadrato(int[] array1)
{
    int[] copiaArray = (int[])array1.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}

//funzione somma
int arraySommato(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma += array[i];
    }
    return somma;
}

//funzione di assegnazione degli elementi dell'array
void valoriArray(int[] arrayNumeri)
{

    for (int i = 0; i < arrayNumeri.Length; i++)
    {
        Console.WriteLine("inesrisci il valore " + (i + 1) + " dell'array: \n");
        arrayNumeri[i] = int.Parse(Console.ReadLine());
        Console.Clear();
    }
}

/****************PROGRAMMA PRINCIPALE*******************/
//dichiaro il mio array
Console.WriteLine("Quanti elementi contiene il tuo array?\n ");
int[] arrayDiNumeri = new int [int.Parse(Console.ReadLine())];

//assegno gli elementi del mio array con una funzione
valoriArray(arrayDiNumeri);

//stampo il mio array
Console.WriteLine("Questo è il mio array originale: ");
stampaArray(arrayDiNumeri);

//array di numeri di cui bisogna fare al quadrato
Console.WriteLine("\nQuesto è il mio array elevato al quadrato: ");
int[] arrayDiNumeriAlQuadrato = arrayAlQuadrato(arrayDiNumeri);
stampaArray(arrayDiNumeriAlQuadrato);

//ristampo array originale
Console.WriteLine("\n\nQuesto è il mio array originale: ");
stampaArray(arrayDiNumeri);

//somma di tutti i numeri nel array originale
int somma;
somma = arraySommato(arrayDiNumeri);
Console.WriteLine("\n\nLa somma del mio array originale è " + somma);

//somma di numeri del array al quadrato
int sommaAlQuadrato;
sommaAlQuadrato = arraySommato(arrayDiNumeriAlQuadrato);
Console.WriteLine("\nLa somma del mio array al quadrato è " + sommaAlQuadrato);

//quadrato del mio numero
Console.Write("\ninserisci un numero di cui vuoi effettuare il quadrato: ");
int numero = int.Parse(Console.ReadLine());
numero = funzioneAlQuadrato(numero);
Console.WriteLine("\n\nil quadrato del mio numero è " + numero);
Console.ReadKey();
