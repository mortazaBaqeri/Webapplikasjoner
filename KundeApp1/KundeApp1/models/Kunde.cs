using System; // samme som import på java
namespace KundeApp1.models //viser hvor appen ligger
{
    public class Kunde
    {
        // nullable value, vi skriver ? for at den's defualt value ikke skal
        // være den underliggende defualt valuen til String, men skal kunne
        // være null eller undefined, før den blir oppdatert!
        public string navn { get; set; }
        public string adresse { get; set; }
        
    }
}

