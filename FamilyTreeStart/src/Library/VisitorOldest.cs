using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
public class VisitorOldest:Visitor
{
    public override string Content()
    {
        return Oldest.Name;
    }
    
    public Person Oldest{get;set;}
    public override void Visit(Person person)
    {
        if (Oldest==null)
        {
            Oldest=person;
        }
        else 
        {
            if (person.Age>Oldest.Age)
            {
                Oldest=person;
            }
            
        }
    }
    public override void Visit(Node node)
    {
        foreach (Node Child in node.Children)
        {
            Child.Accept(this);
            this.Visit(Child.Person);
        }
    }
}
}
