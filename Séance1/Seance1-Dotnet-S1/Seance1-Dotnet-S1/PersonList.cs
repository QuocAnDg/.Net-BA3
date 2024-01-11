using be.ipl.domaine;

namespace be.ipl.domaine;

public class PersonList
{

    private static PersonList instance;
    private Dictionary<String, Person> personMap;

    private PersonList()
    {
        personMap = new Dictionary<String, Person>();
  
    }

    public static PersonList getInstance()
    {

        if (instance == null)
            instance = new PersonList();

        return instance;
    }

    public void addPerson(Person person)
    {
        if (person == null)
            throw new ArgumentException();
        personMap.Add(person.getName(), person);
    }

    public IEnumerator<Person> personList()
    {
        return personMap.Values.GetEnumerator();
    }

}
