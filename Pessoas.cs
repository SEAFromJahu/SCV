using MongoDB.Bson;
using System.Collections.Generic;

namespace SCV.SCVClassFolder
{
    public class Pessoas
    {
        public ObjectId _id { get; set; }
        public string NomeDoCandidato { get; set; }
        public string ProfissaoDoCandidato { get; set; }
        public string LocalizacaoDoCanditato { get; set; }
        public int NivelDoCanditato { get; set; }
    }
    class VPessoas
    {
        public static string _id = "";
        public static string NomeDoCandidato = "";
        public static string ProfissaoDoCandidato = "";
        public static string LocalizacaoDoCanditato = "";
        public static string NivelDoCanditato = "";
    }
}