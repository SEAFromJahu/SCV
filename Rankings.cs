using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SCV.SCVClassFolder
{
    public class Rankings
    {
        public ObjectId _id { get; set; }
        public string VagaId { get; set; }
        public string Empresa { get; set; }
        public string TituloDaVaga { get; set; }
        public string DescricaoDaVaga { get; set; }
        public string LocalizacaoDaVaga { get; set; }
        public string NivelDaVaga { get; set; }
        public string CandidatoId { get; set; }
        public string NomeDoCandidato { get; set; }
        public string ProfissaoDoCandidato { get; set; }
        public string LocalizacaoDoCanditato { get; set; }
        public string NivelDoCanditato { get; set; }
        public double Score { get; set; }

    }
}
