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
 int[] copiaArray = (int[]) array1.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    stampaArray(copiaArray);
    return copiaArray;
}

//funzione somma
int arraySommato(int[]array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    { 
    somma = somma += array[i] ;
    }
    return somma;
}


/****************PROGRAMMA PRINCIPALE*******************/
//dichiaro il mio array
int[] arrayDiNumeri = { 2, 5, 6, 8, 9, 1 };
Console.WriteLine("Questo è il mio array originale: ");
stampaArray(arrayDiNumeri);


//quadrato del mio numero
int numero = 5;
numero = funzioneAlQuadrato(numero);
Console.WriteLine("\n\nil quadrato del mio numero è " + numero);

//array di numeri di cui bisogna fare al quadrato
Console.WriteLine("\nQuesto è il mio array elevato al quadrato: ");
arrayAlQuadrato(arrayDiNumeri);

//ristampo array originale
Console.WriteLine("\n\nQuesto è il mio array originale: ");
stampaArray(arrayDiNumeri);

//somma di tutti i numeri
int somma;
somma = arraySommato(arrayDiNumeri);
Console.WriteLine("\n\n La somma del mio array originale è " + somma);

Console.ReadKey();
