using static System.Net.Mime.MediaTypeNames;
using System.Globalization;
using System.Xml.Linq;
using System;

namespace be.ipl.domaine;


[Serializable]
public class Person
{

    
    private static readonly long serialVersionUID = 1L;

    private readonly String name;
    private readonly String firstname;
    private readonly DateTime birthDate;

    public virtual String getName()
    {
        return name;
    }

    public String getFirstname()
    {
        return firstname;
    }

    public String getBirthDate()
    {
        return birthDate.ToString();
    }


public Person(String name, String firstname, DateTime birthDate)
{
    this.name = name;
    this.firstname = firstname;
    this.birthDate = birthDate;
}

    public virtual String toString()
{
    return "Person [name = " + name + ", firstname = " + firstname + ", birthDate =  " + getBirthDate() + "]";
}
	
	
}
