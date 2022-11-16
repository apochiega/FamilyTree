using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1=new Person("Ana",5);
            Person p2=new Person("Enrique",9);
            Person p3=new Person("Pijuan",21);
            Person p4=new Person("Animal",28);
            Person p5=new Person("Mariano",20);
            Person p6=new Person("José",95);
            Person p7=new Person("Martin",32);
            Person p8=new Person("Matias",40);
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n5.AddChildren(n8);
            

            VisitorTotalAge vTotalAge = new VisitorTotalAge();
            vTotalAge.Visit(n1);
            Console.WriteLine("La edad de todos sumada es: "+vTotalAge.Content()); 
            VisitorLargestName vLargestName = new VisitorLargestName();
            vLargestName.Visit(n1);
            Console.WriteLine("la persona con el nombre más largo es: "+vLargestName.Content());
            VisitorOldest vFB = new VisitorOldest();
            vFB.Visit(n1);
            Console.WriteLine("La persona más vieja es: "+vFB.Content());

        }
    }
}
