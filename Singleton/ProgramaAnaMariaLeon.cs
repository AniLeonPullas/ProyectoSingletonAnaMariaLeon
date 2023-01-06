namespace Singleton
{
    class ProgramaAnaMariaLeon
    {
        static void Main(string[] arga)
        {
            Console.WriteLine(ClaseSingletonAnaMariaLeon.Instance.mensaje);
            ClaseSingletonAnaMariaLeon.Instance.mensaje = "Hola soy Maria";
            Console.WriteLine(ClaseSingletonAnaMariaLeon.Instance.mensaje);
        }
    }
}