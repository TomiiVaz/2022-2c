internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una pregunta de Si/No");
        string respuesta = Console.ReadLine();

        Console.WriteLine(responder());
    }

    private static string responder()
    {
        Random random = new Random();
        int tipoRespuesta = random.Next(0, 2);
        int tipoRespuestaEspecifica = random.Next(0, 2);
        string respuesta = "";

        List<string> afirmativaList = new List<string>();
        afirmativaList.Add("Es cierto.");
        afirmativaList.Add("Sin lugar a dudas.");
        afirmativaList.Add("Puedes confiar en ello.");
        List<string> comprometidaList = new List<string>();
        comprometidaList.Add("Respuesta confusa, vuelve a intentarlo");
        comprometidaList.Add("Mejor no decirte ahora");
        comprometidaList.Add("Concentrate y vuelve a preguntar");
        List<string> negativaList = new List<string>();
        negativaList.Add("No cuentes con ello");
        negativaList.Add("Mi respuesta es no");
        negativaList.Add("Muy dudoso");

        switch (tipoRespuesta)
        {
            case 0: return afirmativaList[tipoRespuestaEspecifica];
            case 1: return comprometidaList[tipoRespuestaEspecifica];
            case 2: return negativaList[tipoRespuestaEspecifica];

        }
        return respuesta;
    }
}
