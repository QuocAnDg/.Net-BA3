﻿using System.IO;
using System.Linq;
using System;

namespace be.ipl.domaine;


public class Movie
{

    private String title;
    private int releaseYear;
    private List<Actor> actors;
    private Director director;

    public Movie(String title, int releaseYear)
    {
        actors = new List<Actor>();
        this.title = title;
        this.releaseYear = releaseYear;
    }

    public Director getDirector()
    {
        return director;
    }
    public void setDirector(Director director)
    {
        if (director == null)
            return;
        this.director = director;
        director.addMovie(this);
    }

    public String getTitle()
    {
        return title;
    }
    public void setTitle(String title)
    {
        this.title = title;
    }
    public int getReleaseYear()
    {
        return releaseYear;
    }
    public void setReleaseYear(int releaseYear)
    {
        this.releaseYear = releaseYear;
    }

    public bool addActor(Actor actor)
    {
        if (actors.Contains(actor))
            return false;

        actors.Add(actor);
        if (!actor.containsMovie(this))
            actor.addMovie(this);

        return true;
    }

    public bool containsActor(Actor actor)
    {
        return actors.Contains(actor);
    }


    public String toString()
    {
        return "Movie [title=" + title + ", releaseYear=" + releaseYear + "]";
    }



}
