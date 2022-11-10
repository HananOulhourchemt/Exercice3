using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    private int x, y; // declarer l'abscisse x et l'ordonnée y
    public void setx(int x)// la méthode setter de x
    {
        this.x = x;
    }
    public int getx()// la méthode getter de x
    {
        return x;
    }
    public void sety(int y) // la méthode setter de y
    {
        this.y = y;
    }
    public int gety() //la méthode getter de y
    {
        return y;
    }
    public Point(int x = 0, int y = 0) // le consteucteur par défaut 
    {
        this.x = x;
        this.y = y;
    }
    public double Distance() // Calculer la distance
    {
        
        return Math.Sqrt((x*x)+(y*y));
    }
   
    
        public void translate(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;
        }
    }


class Program
{
    static void Main(string[] args)
    {
        Point P = new Point();
        Action<string> msgr = s => Console.WriteLine(s);
        Action<string> msg = s => Console.Write(s);
        //-------------------------------------------------
        msgr("Calcul de la distance d'un point dans le plan :");
        msg("Entrez l'abscisse (x) du point: "); P.setx(int.Parse(Console.ReadLine()));
        msg("Entrez l'ordonnée (y) du point: "); P.sety(int.Parse(Console.ReadLine()));
        msgr("La distance du point est: " + P.Distance());
       

        Console.ReadKey();
    }
}