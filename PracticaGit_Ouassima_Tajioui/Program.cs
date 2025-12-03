namespace PracticaGit_Ouassima_Tajioui
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Jaume");
            Salutador salutador = new Salutador();

            salutador.Saluda(persona);
        }
    }
}
