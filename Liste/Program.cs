List<int> return_indici(List<string> parole, string p)
{
    int numero_p = 0;
    List<int> indici = new List<int>();
    for(int i = 0; i < parole.Count; i++)
    {
        if (parole[i] == p)
        {
            numero_p++;
            indici.Add(i);
        }
    }
    Console.WriteLine("\nNumero di volte in cui è presente " + p + ": " + numero_p);
    return indici;
}

//1

List<int> numeri = new List<int>();
numeri.Add(10);
numeri.Add(20);
numeri.Add(30);
numeri.Add(40);
for (int i = 0; i < numeri.Count; i++)
{
    Console.Write(numeri[i] + " ");
}

//data una lista di parole e una parola p determinare quante volte p è dentro la lista e restituire la lista di indici in cui trovo p

List<string> parole = ["angelica", "pazzagli", "angelica", "angi"];
string p = "angelica";
List<int> indici = return_indici(parole, p);
foreach (int i in indici)
{
    Console.Write(i + " ");
}

//1-BASE
List<int> primi = new List<int>();
for(int i = 0; i < 11; i++)
{
    primi.Add(i);
}
Console.WriteLine();
for (int i = 0; i < primi.Count; i++)
{
    Console.Write(primi[i] + " ");
}

//2/3-BASE
List<int> n = [3, 7, 9, 10, 15, 17, 18, 21, 49];
List<int> pari_n = new List<int>();
int somma = 0;
foreach(int i in n)
{
    somma += i;
    if(i % 2 == 0)
    {
        pari_n.Add(i);
    }
}
Console.WriteLine("\nSomma lista n: " + somma);
foreach (int pa in pari_n)
{
    Console.Write(pa + " ");
}

//4-INTERMEDIO
int volte = 0;
List<string> copia = parole;
foreach(string par in parole)
{
    foreach(string par2 in parole)
    {
        if(par == par2)
        {
            volte++;
        }
    }
    if(volte > 1)
    {
        copia.Remove(par);
    }
    volte = 0;
}
foreach(string nuove in copia)
{
    Console.Write(nuove + " ");
}
