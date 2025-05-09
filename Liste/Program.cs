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
List<string> copia = new List<string>();
foreach(string par1 in parole)
{
    if(!copia.Contains(par1))
    {
        copia.Add(par1);
    }
}
Console.WriteLine();
foreach(string nuove in copia)
{
    Console.Write(nuove + " ");
}

//5-INTERMEDIO
Console.WriteLine("\nInserisci numero: ");
int numero = Int32.Parse(Console.ReadLine());
if(n.Contains(numero))
{
    for(int i = 0; i < n.Count; i++)
    {
        if(n[i] == numero)
        {
            Console.WriteLine("Indice: " + i);
            n.RemoveAt(i);
        }
    }
}
foreach(int nu in n)
{
    Console.Write(nu + " ");
}

//7-AVANZATO
List<int> seq1 = [7, 77, 777];
List<int> seq2 = [7, 777, 7777];
List<int> comuni = new List<int>();
foreach(int i in seq1)
{
    foreach(int j in seq2)
    {
        if (j == i)
        {
            comuni.Add(i);
        }
    }
}
Console.WriteLine();
foreach (int com in comuni)
{
    Console.Write(com + " ");
}

//8-AVANZATO
int volte = 0;
Console.WriteLine();
foreach(string vol in parole)
{
    foreach(string vol1 in parole)
    {
        if(vol1 ==  vol)
        {
            volte++;
        }
    }
    Console.WriteLine(vol + ": " + volte);
    volte = 0;
}
