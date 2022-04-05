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






/****************PROGRAMMA PRINCIPALE*******************/
int[] arrayDiNumeri = { 2, 5, 6, 8, 9, 1 };
stampaArray(arrayDiNumeri);