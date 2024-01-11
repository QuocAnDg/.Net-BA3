using System.Globalization;
using System;
using be.ipl.domaine;
using System.Runtime.Serialization;

namespace be.ipl.domaine;


[Serializable]

public class Actor : Person {


    private static readonly long serialVersionUID = 1L;
    private readonly int sizeInCentimeter;
    private List<Movie> movies;

public int getSizeInCentimeter()
{
    return sizeInCentimeter;
}



public Actor(String name, String firstname, DateTime birthDate, int sizeInCentimeter) : base(name, firstname, birthDate)
    {
    this.sizeInCentimeter = sizeInCentimeter;
    movies = new List<Movie>();
}

    public override String toString()
{
    return "Actor [name = " + getName() + " firstname = " + getFirstname() + " sizeInCentimeter = " + sizeInCentimeter + " birthdate = " + getBirthDate() + "]";
}

/**
 * 
 * @return list of movies in which the actor has played
 */
public IEnumerator<Movie> Movies()
{
    return movies.GetEnumerator();
}

/**
 * add movie to the list of movies in which the actor has played
 * @param movie
 * @return false if the movie is null or already present
 */
public bool addMovie(Movie movie)
{
    if ((movie == null) || movies.Contains(movie))
        return false;

    if (!movie.containsActor(this))
        movie.addActor(this);
    movies.Add(movie);
    return true;
}

public bool containsMovie(Movie movie)
{
    return movies.Contains(movie);
}

    public override String getName()
{
    return base.getName().ToUpper();
}
}
