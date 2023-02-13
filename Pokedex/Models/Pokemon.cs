namespace Pokedex.Models
{
    public class Pokemon
    {
        // Atributos
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Especie { get; set; }
        public List<string> Tipo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Iamgem { get; set; }

        //Metodo Construtor
        public Pokemon()
        {
            Tipo = new List<string>();
        }
        
    }
}