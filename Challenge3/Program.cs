using Challenge3;

Alumno[] alumnos = new Alumno[100];
int largo = 5;
alumnos[0] = new Alumno(1, 5.6, 7.1, 9.9, 5.5);
alumnos[1] = new Alumno(3, 7.7, 2.75, 8.45, 10);
alumnos[2] = new Alumno(5, 4.9, 8.88, 8.5, 4.3);
alumnos[3] = new Alumno(9, 6.5, 4.3, 5.5, 3);
alumnos[4] = new Alumno(10, 1.9, 6.66, 10, 7.5);


int[] numeros = new int[5] {1,2,3,4,5};
int i = 0;
/*Alumno a = busqueda(alumnos,largo-1,10);
if(a!=null) 
    Console.WriteLine(a._numero());
else
{
    Console.WriteLine("nulo");
}

//Console.WriteLine(sumaRecur(numeros,i));

Stack<int> pila = new Stack<int>();
pila.Push(2);
pila.Push(1);
pila.Push(5);
pila.Push(3);
foreach (int dato in pila)
{
    Console.WriteLine(dato);
}
Console.WriteLine("////////////////////");
reemplazarPila(pila,7,5);
foreach (int dato in pila)
{
    Console.WriteLine(dato);
}
*/
double[] facturas = new double[100];
facturas[0] = 25;
facturas[1] = 50.33;
facturas[2] = 10.33;
facturas[3] = 90.33;
manejoFacturas(facturas);


Alumno busqueda(Alumno[] alumnos,int k,int num) //primero es 0 y ultimo es k-1 // num a buscar
{
    Alumno pivote;
    int pri, ult, p,ant;
    pri = 0;
    ult = k;
    ant = 0;
    do
    {
        p = ant + (ult - pri) / 2;
        pivote = alumnos[p];
        if (num == pivote._numero())
        {
            return pivote;
        }
        else if (num < pivote._numero())
        {
            ult = p - 1;
            ant = 0;
        }
        else//mayor al pivote
        {
            pri = p + 1;
            ant = p + 1; //redondee para arriba
        }
        
    } while (pri>=0 && ult<=k && pri<ult);
    if (pri == ult && alumnos[pri]._numero() == num)
        return alumnos[pri];
    return null;
}


int sumaRecur(int[] numeros,int i)
{
    if (i>=numeros.Length)
    {
        return 0;
    }
    else
    {
        return numeros[i++] + sumaRecur(numeros, i);
    }
}

void reemplazarPila(Stack<int> pila,int nuevo,int viejo)
{
    Stack<int> aux = new Stack<int>();
    int dato;
    if (pila.Any()) { //si no esta vacia
        dato = pila.Pop();
        while (pila.Any() && dato != viejo)
        {
            aux.Push(dato);
            dato = pila.Pop();
        }
        if(dato == viejo)
        {
            pila.Push(nuevo);
            while (aux.Any())
            {
                dato = aux.Pop();
                pila.Push(dato);
            }
        }
    }
}

void manejoFacturas(double[] facturas)
{
    int cont,contMayor30, i;
    double acum;
    acum = contMayor30 = cont = i = 0;
    while (i<facturas.Length && facturas[i]!=0.00)
    {
        cont++;
        if (facturas[i] > 30) contMayor30++;
        acum += facturas[i++];
    }
    Console.WriteLine("cuantas se realizaron: " + cont);
    Console.WriteLine("promedio de los importes: " + acum/cont);
    Console.WriteLine("cant de facturas mayores a 30: " + contMayor30);
}