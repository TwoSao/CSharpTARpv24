namespace CSharpTARpv24;

public class Isesevtoo
{
    
}

public class Film
{
    public string Name { get; set; }
    public int Aasta { get; set; }
    public string zanr { get; set; }
    public Film(string name, int aasta, string zanr)
    {
        Name = name;
        Aasta = aasta;
        this.zanr = zanr;
    }
    
}
public class Filmid
{
    public List<Film> Films { get; set; }

    public Filmid(List<Film> films)
    {
        Films = films;
    }
    
    
    public List<Film> GetFilmsByGenre(string genre)
    {
        return Films.Where(f => f.zanr == genre).ToList();
    }
    
    public Film GetNewestFilm()
    {
        return Films.OrderByDescending(f => f.Aasta).FirstOrDefault();
    }
    
    public Dictionary<string, List<Film>> GroupByGenre()
    {
        return Films.GroupBy(f => f.zanr).ToDictionary(g => g.Key, g => g.ToList());
    }

    public void Print()
    {
        foreach (var film in Films)
        {
            Console.WriteLine(film.Name + " " + film.Aasta + " " + film.zanr);
        }
    }
}
public class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }

    public double GetAverage()
    {
        return Grades.Count > 0 ? Grades.Average() : 0;
    }

    public string SortByGrade()
    {
        Student student = new Student(Name, Grades.OrderBy(x => x).ToList());
        
        return student.Name + " " + student.Grades;
    }
    
}