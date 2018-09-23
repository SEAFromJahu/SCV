using MongoDB.Bson;

namespace SCV.SCVClassFolder
{
    public class Vagas
    {
        public ObjectId _id { get; set; }
        public string Empresa { get; set; }
        public string TituloDaVaga { get; set; }
        public string DescricaoDaVaga { get; set; }
        public string LocalizacaoDaVaga { get; set; }
        public int NivelDaVaga { get; set; }
    }
    class VVagas
    {
        public static string _id = "";
        public static string Empresa = "";
        public static string TituloDaVaga = "";
        public static string DescricaoDaVaga = "";
        public static string LocalizacaoDaVaga = "";
        public static string NivelDaVaga = "";
    }
}
