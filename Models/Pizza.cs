namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Foto { get; set; }
        public double Prezzo { get; set; }

        public Pizza(string Nome, string Descrizione, string Foto, double Prezzo)
        {
            this.Nome = Nome;
            this.Descrizione = Descrizione;
            this.Foto = Foto;
            this.Prezzo = Prezzo;
        }

        public class ListaPizze
        {
            public List<Pizza> lsPizze { get; set; }

            public ListaPizze()
            {
                lsPizze = new();
            }
        }
    }
}
