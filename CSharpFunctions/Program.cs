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



/****************PROGRAMMA PRINCIPALE*******************/
//dichiaro il mio array
int[] arrayDiNumeri = { 2, 5, 6, 8, 9, 1 };
stampaArray(arrayDiNumeri);


//quadrato del mio numero
int numero = 5;
numero = funzioneAlQuadrato(numero);
Console.WriteLine("\nil quadrato del mio numero è " + numero);

//array di numeri di cui bisogna fare al quadrato
arrayAlQuadrato(arrayDiNumeri);

//


