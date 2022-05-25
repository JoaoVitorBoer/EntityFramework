using DemoEFCoreConsole.Models;

using(var db = new FilmesDBContext())
{
    var todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} - {f.Ano}"));
    /*
    Filme f1 = new Filme{Titulo = "Titanic", Ano=1997};
    db.Filmes.Add(f1);
    Filme f2 = new Filme{Titulo = "8 mile", Ano=2002};
    db.Filmes.Add(f2);
    Filme f3 = new Filme{Titulo = "Kilshot", Ano=2014};
    db.Filmes.Add(f3);
    db.SaveChanges();
    */
  /*
    var umfilme = db.Filmes.Find(5);
    if (umfilme is not null)
    {
        umfilme.Duracao = 30;
    }
    db.SaveChanges();
    
    todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} - {f.Ano}"));
    */
     var umfilme = db.Filmes.Find(11);
    if (umfilme is not null)
    {
        db.Remove(umfilme);
        db.SaveChanges();
    }
}
