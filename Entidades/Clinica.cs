namespace Entidades
{
    public class Clinica
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Usuario>? Users { get; set; }
    }
}
