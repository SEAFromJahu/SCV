using System;
using MongoDB.Driver;
using SCV.SCVClassFolder;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;

namespace SCV
{
    public partial class Form1 : Form
    {
   
        public IMongoCollection<Vagas> colecaoDasVagas { get; private set; }
        public IMongoCollection<Pessoas> colecaoDasPessoas { get; private set; }
        public IMongoCollection<Candidaturas> colecaoDasCandidaturas { get; private set; }
        public IMongoCollection<Rankings> colecaoDosRankings { get; private set; }
        public Dictionary<String, int> dictValD = new Dictionary<string, int>();
        public String[] Vagas;
        public String[] Pessoas;

        public Form1()
        {
            InitializeComponent();

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///

            this.StartPosition = FormStartPosition.CenterScreen;

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///

            this.dtGViewVagasTabRegistraCandidaturas.AllowUserToResizeColumns = true;
            this.dtGViewVagasTabRegistraCandidaturas.BorderStyle = BorderStyle.Fixed3D;
            this.dtGViewVagasTabRegistraCandidaturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewVagasTabRegistraCandidaturas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewVagasTabRegistraCandidaturas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewVagasTabRegistraCandidaturas.GridColor = Color.BlueViolet; //Color.BlueViolet;SystemColors.ActiveBorder; 
            this.dtGViewVagasTabRegistraCandidaturas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewVagasTabRegistraCandidaturas.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8);
            this.dtGViewVagasTabRegistraCandidaturas.RowHeadersWidth = 60;

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///

            this.dtGViewPessoasTabRegistraCandidaturas.AllowUserToResizeColumns = true;
            this.dtGViewPessoasTabRegistraCandidaturas.BorderStyle = BorderStyle.Fixed3D;
            this.dtGViewPessoasTabRegistraCandidaturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewPessoasTabRegistraCandidaturas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewPessoasTabRegistraCandidaturas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewPessoasTabRegistraCandidaturas.GridColor = Color.BlueViolet; //Color.BlueViolet;SystemColors.ActiveBorder; 
            this.dtGViewPessoasTabRegistraCandidaturas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewPessoasTabRegistraCandidaturas.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8);
            this.dtGViewPessoasTabRegistraCandidaturas.RowHeadersWidth = 60;

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///

            this.dtGViewVagasTabScoreCandidatosVaga.AllowUserToResizeColumns = true;
            this.dtGViewVagasTabScoreCandidatosVaga.BorderStyle = BorderStyle.Fixed3D;
            this.dtGViewVagasTabScoreCandidatosVaga.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewVagasTabScoreCandidatosVaga.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewVagasTabScoreCandidatosVaga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewVagasTabScoreCandidatosVaga.GridColor = Color.BlueViolet; //Color.BlueViolet;SystemColors.ActiveBorder; 
            this.dtGViewVagasTabScoreCandidatosVaga.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewVagasTabScoreCandidatosVaga.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8);
            this.dtGViewVagasTabScoreCandidatosVaga.RowHeadersWidth = 60;

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///

            this.dtGViewScoreTabScoreCandidatosVaga.AllowUserToResizeColumns = true;
            this.dtGViewScoreTabScoreCandidatosVaga.BorderStyle = BorderStyle.Fixed3D;
            this.dtGViewScoreTabScoreCandidatosVaga.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewScoreTabScoreCandidatosVaga.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewScoreTabScoreCandidatosVaga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGViewScoreTabScoreCandidatosVaga.GridColor = Color.BlueViolet; //Color.BlueViolet;SystemColors.ActiveBorder; 
            this.dtGViewScoreTabScoreCandidatosVaga.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dtGViewScoreTabScoreCandidatosVaga.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8);
            this.dtGViewScoreTabScoreCandidatosVaga.RowHeadersWidth = 60;

            /// <summary>
            /// ///////////////////////////////////////// //////////////////////////////////////
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            ///









            inicializadictValD();

            iniciaAcessoAoBanco();

        }

        private void inicializadictValD()
        {
            dictValD.Add("AA", 100);
            dictValD.Add("AB", 100);
            dictValD.Add("AC", 50);
            dictValD.Add("AD", 75);
            dictValD.Add("AE", 25);
            dictValD.Add("AF", 25);
            dictValD.Add("BA", 100);
            dictValD.Add("BB", 100);
            dictValD.Add("BC", 75);
            dictValD.Add("BD", 100);
            dictValD.Add("BE", 50);
            dictValD.Add("BF", 50);
            dictValD.Add("CA", 50);
            dictValD.Add("CB", 75);
            dictValD.Add("CC", 100);
            dictValD.Add("CD", 75);
            dictValD.Add("CE", 100);
            dictValD.Add("CF", 25);
            dictValD.Add("DA", 75);
            dictValD.Add("DB", 100);
            dictValD.Add("DC", 75);
            dictValD.Add("DD", 100);
            dictValD.Add("DE", 75);
            dictValD.Add("DF", 75);
            dictValD.Add("EA", 25);
            dictValD.Add("EB", 50);
            dictValD.Add("EC", 100);
            dictValD.Add("ED", 75);
            dictValD.Add("EE", 100);
            dictValD.Add("EF", 25);
            dictValD.Add("FA", 25);
            dictValD.Add("FB", 50);
            dictValD.Add("FC", 25);
            dictValD.Add("FD", 75);
            dictValD.Add("FE", 25);
            dictValD.Add("FF", 100);
        }

        /// <summary>
        /// ///////////////////////////////////////// //////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///

        private void iniciaAcessoAoBanco()
        {
                //            var settings = new MongoClientSettings
                //            {
                //                ServerSelectionTimeout = new TimeSpan(0,0,30), 
                //                Server = new MongoServerAddress("localhos",27017),
                //#pragma warning disable CS0618 // Type or member is obsolete
                //                Credentials = new[] { MongoCredential.CreateCredential("NomeDoBanco","Usuário","Password") }
                //#pragma warning restore CS0618 // Type or member is obsolete
                //            };

            //Conectar no Servidor MongoDB
            //Conectando ao Servidor
            var client = new MongoClient("mongodb://localhost:27017");

            //Conectar no Banco de Dados de nome Agenda dentro do Servidor MongodB
            //Conectando ao Banco de Dados
            var database = client.GetDatabase("DbVagas");

            //Obtendo as Coleções contidas no Banco de Dados Agenda
            //Obtendo acesso a "ColDasVagas" onde estão os dados das vagas registradas
            colecaoDasVagas = database.GetCollection<Vagas>("ColDasVagas");
            //Obtendo acesso a "ColDasPessoas" onde estão os dados das pessoas registradas
            colecaoDasPessoas = database.GetCollection<Pessoas>("ColDasPessoas");
            //Obtendo acesso a "ColDasCandidaturas" onde estão os dados das candidaturas registradas
            colecaoDasCandidaturas = database.GetCollection<Candidaturas>("ColDasCandidaturas");
            //Obtendo acesso a "ColDosRankings" onde estão os dados das candidaturas registradas
            colecaoDosRankings = database.GetCollection<Rankings>("ColDosRankings");
        }

        /// <summary>
        /// //////////////////////////////////////
        /// //////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //
        // Início do Cadastro das vagas de emprego
        //
        private void bttTabVagasCadastrarVaga_Click(object sender, EventArgs e)
        {
            //
            // Declara as variáveis abaixo
            //
            //

            StringBuilder msg = new StringBuilder();
            StringBuilder txtTorichtxbTabVagas = new StringBuilder();
            Vagas vg = new Vagas();
            //
            // Verifica o correto preenchimento de cada um dos campos abaixo //
            //
            if ((txbTabVagasEmpresa.Text) != null && Regex.IsMatch((txbTabVagasEmpresa.Text), "[0-9a-zA-Z]"))
            {
                vg.Empresa = txbTabVagasEmpresa.Text;
            }
            else
            {
                msg.Append("Empresa, ");
            }

            if ((txbTabVagasTituloDaVaga.Text) != null && Regex.IsMatch((txbTabVagasTituloDaVaga.Text), "[0-9a-zA-Z]"))
            {
                vg.TituloDaVaga = txbTabVagasTituloDaVaga.Text;
            }
            else
            {
                msg.Append("Titulo da Vaga, ");
            }
            
            if ((txbTabVagasDescricaoDaVaga.Text) != null && Regex.IsMatch((txbTabVagasDescricaoDaVaga.Text), "[0-9a-zA-Z]"))
            {
                vg.DescricaoDaVaga = txbTabVagasDescricaoDaVaga.Text;
            }
            else
            {
                msg.Append("Descricao da Vaga, ");
            }

            if ((cbxTabVagasLocalizacaoDaVaga.Text) != null && Regex.IsMatch((cbxTabVagasLocalizacaoDaVaga.Text), "[0-9a-zA-Z]"))
            {
                vg.LocalizacaoDaVaga = cbxTabVagasLocalizacaoDaVaga.Text;
            }
            else
            {
                msg.Append("Localizacao da Vaga, ");
            }

            if (Regex.IsMatch(((int)nudTabVagasNiveldaVaga.Value).ToString(), "[1-5]"))
            {
                vg.NivelDaVaga = (int)nudTabVagasNiveldaVaga.Value;
            }
            else
            {
                msg.Append("Nível da Vaga");

            }
            //
            // Não encontrando problemas nos campos acima
            //
            if (string.IsNullOrEmpty(msg.ToString()))
            {
                // Registra a vaga na coleção "ColVagas" do Banco de Dados MongoDB "DbVagas"
                colecaoDasVagas.InsertOne(vg);

                // Apresenta o Feedback ao usuário que as informações já foram registradas.
                txtTorichtxbTabVagas.Append("[" + txbTabVagasEmpresa.Text + "]");
                txtTorichtxbTabVagas.Append("["+ txbTabVagasTituloDaVaga.Text + "]");
                txtTorichtxbTabVagas.Append("["+ txbTabVagasDescricaoDaVaga.Text + "]");
                txtTorichtxbTabVagas.Append("["+ cbxTabVagasLocalizacaoDaVaga.Text + "]");
                txtTorichtxbTabVagas.Append("["+ ((int)nudTabVagasNiveldaVaga.Value).ToString() + "]");
                richtxbTabVagas.Text = txtTorichtxbTabVagas.ToString() + Environment.NewLine + richtxbTabVagas.Text;

                // Limpa todos os campos acima para evitar duplicação do último registro
                txbTabVagasEmpresa.Text = "";
                txbTabVagasTituloDaVaga.Text = "";
                txbTabVagasDescricaoDaVaga.Text = "";
                cbxTabVagasLocalizacaoDaVaga.Text = "";
                nudTabVagasNiveldaVaga.Value = 0;

            }
            else
            {
                string message = msg.ToString();
                string caption = "Verificar o preenchimento do(s) campo(s):";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }
        private void bttTabVagasLimparCampos_Click(object sender, EventArgs e)
        {
            txbTabVagasEmpresa.Text = "";
            txbTabVagasTituloDaVaga.Text = "";
            txbTabVagasDescricaoDaVaga.Text = "";
            cbxTabVagasLocalizacaoDaVaga.Text = "";
            nudTabVagasNiveldaVaga.Value = 0;
        }
        //
        // Término do Cadastro das vagas de emprego
        //
        /// <summary>
        /// //////////////////////////////////////
        /// //////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //
        // Início do Cadastro das pessoas/candidatos
        //
        private void bttTabPessoasCadastrarPessoa_Click(object sender, EventArgs e)
        {
            //
            // Declara a variável msg -> auxilia a verificação do correto preenchimento dos campos
            // Declara a variável txtTorichtxbTabPessoas -> para apresentar o Feedback ao usuário
            //
            StringBuilder msg = new StringBuilder();
            StringBuilder txtTorichtxbTabPessoas = new StringBuilder();
            Pessoas ps = new Pessoas();
            //
            // Verifica o correto preenchimento de cada um dos campos abaixo //
            //
            if ((txbTabPessoasNomeDaPessoa.Text) != null && Regex.IsMatch((txbTabPessoasNomeDaPessoa.Text), "[0-9a-zA-Z]"))
            {
                ps.NomeDoCandidato = txbTabPessoasNomeDaPessoa.Text;
            }
            else
            {
                msg.Append("Nome, ");
            }

            if ((txbTabPessoasProfissaoDaPessoa.Text) != null && Regex.IsMatch((txbTabPessoasProfissaoDaPessoa.Text), "[0-9a-zA-Z]"))
            {
                ps.ProfissaoDoCandidato = txbTabPessoasProfissaoDaPessoa.Text;
            }
            else
            {
                msg.Append("Profissao, ");
            }

            if ((cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text) != null && Regex.IsMatch((cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text), "[0-9a-zA-Z]"))
            {
                ps.LocalizacaoDoCanditato = cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text;
            }
            else
            {
                msg.Append("Localidade da Residência, ");
            }

            if (Regex.IsMatch(((int)nudTabPessoasNiveldeExperienciaDaPessoa.Value).ToString(), "[1-5]"))
            {
                ps.NivelDoCanditato = (int)nudTabPessoasNiveldeExperienciaDaPessoa.Value;
            }
            else
            {
                msg.Append("Nivel de Experiência");
            }
            //
            // Não encontrando problemas nos campos acima
            //
            if (string.IsNullOrEmpty(msg.ToString()))
            {
                // Registra a vaga na coleção "ColPessoas" do Banco de Dados MongoDB "DbVagas"
                colecaoDasPessoas.InsertOne(ps);

                // Apresenta o Feedback ao usuário que as informações já foram registradas.
                txtTorichtxbTabPessoas.Append("[" + txbTabPessoasNomeDaPessoa.Text + "]");
                txtTorichtxbTabPessoas.Append("[" + txbTabPessoasProfissaoDaPessoa.Text + "]");
                txtTorichtxbTabPessoas.Append("[" + cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text + "]");
                txtTorichtxbTabPessoas.Append("[" + ((int)nudTabPessoasNiveldeExperienciaDaPessoa.Value).ToString() + "]");
                richtxbTabPessoas.Text = txtTorichtxbTabPessoas.ToString() + Environment.NewLine + richtxbTabPessoas.Text;

                // Limpa todos os campos acima para evitar duplicação do último registro
                txbTabPessoasNomeDaPessoa.Text = "";
                txbTabPessoasProfissaoDaPessoa.Text = "";
                cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text = "";
                nudTabPessoasNiveldeExperienciaDaPessoa.Value = 0;
            }
            else
            {
                string message = msg.ToString();
                string caption = "Verificar o preenchimento do(s) campo(s):";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

        }
        private void bttTabPessoasLimparCampos_Click_1(object sender, EventArgs e)
        {
            txbTabPessoasNomeDaPessoa.Text = "";
            txbTabPessoasProfissaoDaPessoa.Text = "";
            cbxTabPessoasLocalidadedaResidenciaDaPessoa.Text = "";
            nudTabPessoasNiveldeExperienciaDaPessoa.Value = 0;
        }
        //
        // Término do Cadastro das pessoas/candidatos
        //
        /// <summary>
        /// //////////////////////////////////////
        /// //////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //
        // Início do Cadastro das candidaturas as vagas
        //
        // Preenche os DataGrids de Vagas e Pessoas 
        private void tabRegistrarCandidaturas_Enter(object sender, EventArgs e)
        {
            PreencheGridVagas();
            PreencheGridPessoas();
        }
        public void PreencheGridVagas()
        {
            // Limpa informações anteriores do DataGridView
            this.dtGViewVagasTabRegistraCandidaturas.Rows.Clear();

            //FILTRO:
            string[] RgVaga = new string[6];
            var filtrovagas = Builders<Vagas>.Filter.Empty;
            var vagas = colecaoDasVagas.Find<Vagas>(filtrovagas).ToList();
            vagas.ForEach(v =>
            {
                RgVaga[0] = v._id.ToString();
                RgVaga[1] = v.NivelDaVaga.ToString();
                RgVaga[2] = v.TituloDaVaga;
                RgVaga[3] = v.LocalizacaoDaVaga;
                RgVaga[4] = v.DescricaoDaVaga;
                RgVaga[5] = v.Empresa;
                dtGViewVagasTabRegistraCandidaturas.Rows.Add(RgVaga);
            });

            foreach (DataGridViewRow dgvr in this.dtGViewVagasTabRegistraCandidaturas.Rows)
            {
                dgvr.HeaderCell.Value = String.Format("{0}", dgvr.Index + 1);
            }
        }
        public void PreencheGridPessoas()
        {

            // Limpa informações anteriores do DataGridView
            this.dtGViewPessoasTabRegistraCandidaturas.Rows.Clear();

            //FILTRO:
            string[] RgPessoa = new string[5];
            var filtro = Builders<Pessoas>.Filter.Empty;
            var pessoas = colecaoDasPessoas.Find<Pessoas>(filtro).ToList();
            pessoas.ForEach(p =>
            {
                RgPessoa[0] = p._id.ToString();
                RgPessoa[1] = p.NivelDoCanditato.ToString();
                RgPessoa[2] = p.ProfissaoDoCandidato;
                RgPessoa[3] = p.LocalizacaoDoCanditato;
                RgPessoa[4] = p.NomeDoCandidato;
                dtGViewPessoasTabRegistraCandidaturas.Rows.Add(RgPessoa);
            });

            foreach (DataGridViewRow dgvr in this.dtGViewPessoasTabRegistraCandidaturas.Rows)
            {
                dgvr.HeaderCell.Value = String.Format("{0}", dgvr.Index + 1);
            }
        }
        private void dtGViewVagasTabRegistraCandidaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow newDataRow = dtGViewVagasTabRegistraCandidaturas.Rows[e.RowIndex];
                lblTabRegistrarCandidaturasVaga_Id.Text = newDataRow.Cells[0].Value.ToString();
                VVagas._id = newDataRow.Cells[0].Value.ToString();
                VVagas.NivelDaVaga = newDataRow.Cells[1].Value.ToString();
                VVagas.TituloDaVaga = newDataRow.Cells[2].Value.ToString();
                VVagas.LocalizacaoDaVaga = newDataRow.Cells[3].Value.ToString();
                VVagas.DescricaoDaVaga = newDataRow.Cells[4].Value.ToString();
                VVagas.Empresa = newDataRow.Cells[5].Value.ToString();

            }
            catch (Exception)
            {
                //throw;+ definir alguma mensagem posteriormente
            }
        }
        private void dtGViewPessoasTabRegistraCandidaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow newDataRow = dtGViewPessoasTabRegistraCandidaturas.Rows[e.RowIndex];
                lblTabRegistrarCandidaturasPessoa_Id.Text = newDataRow.Cells[0].Value.ToString();
                VPessoas._id = newDataRow.Cells[0].Value.ToString();
                VPessoas.NivelDoCanditato = newDataRow.Cells[1].Value.ToString();
                VPessoas.ProfissaoDoCandidato = newDataRow.Cells[2].Value.ToString();
                VPessoas.LocalizacaoDoCanditato = newDataRow.Cells[3].Value.ToString();
                VPessoas.NomeDoCandidato = newDataRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                //throw;+ definir alguma mensagem posteriormente
            }
        }
        private void bttTabRegistrarCandidaturasRegistrarCandidatura_Click(object sender, EventArgs e)
        {
            //
            // Declara as variáveis abaixo
            //
            StringBuilder msg = new StringBuilder();
            StringBuilder txtTorichtxbTabCandidaturas = new StringBuilder();
            Candidaturas cddtura = new Candidaturas();
            //
            // Verifica o correto preenchimento de cada um dos campos abaixo //
            //
            if ((lblTabRegistrarCandidaturasVaga_Id.Text) != null && Regex.IsMatch((lblTabRegistrarCandidaturasVaga_Id.Text), "[1-5]"))
            {
                cddtura.IdVaga = lblTabRegistrarCandidaturasVaga_Id.Text;
            }
            else
            {
                msg.Append("Vagas Registradas, ");
            }
            if ((lblTabRegistrarCandidaturasPessoa_Id.Text) != null && Regex.IsMatch((lblTabRegistrarCandidaturasPessoa_Id.Text), "[0-9a-zA-Z]"))
            {
                cddtura.IdPessoa = lblTabRegistrarCandidaturasPessoa_Id.Text;
            }
            else
            {
                msg.Append("Pessoas Registradas, ");
            }
            //
            // Não encontrando problemas nos campos acima// Insere o documento na coleção Vagas
            //
            if (string.IsNullOrEmpty(msg.ToString()))
            {
                // Registra a candidatura na coleção "ColCandidaturas" do Banco de Dados MongoDB "DbVagas"
                colecaoDasCandidaturas.InsertOne(cddtura);
               
                // Apresenta o Feedback ao usuário que as informações já foram registradas.
                txtTorichtxbTabCandidaturas.Append("[" + lblTabRegistrarCandidaturasVaga_Id.Text + "]");
                txtTorichtxbTabCandidaturas.Append("[" + lblTabRegistrarCandidaturasPessoa_Id.Text + "]");
                richtxbTabCandidaturas.Text = txtTorichtxbTabCandidaturas.ToString() + Environment.NewLine + richtxbTabCandidaturas.Text;

                // Limpa todos os campos acima para evitar duplicação do último registro
                lblTabRegistrarCandidaturasVaga_Id.Text = "";
                lblTabRegistrarCandidaturasPessoa_Id.Text = "";

                // Registra Calcula o Score do candidato a vaga
                // E registra as informações para posterior consulta.
                CalculaScore();

            }
            else
            {
                string message = msg.ToString();
                string caption = "Verificar o preenchimento do(s) campo(s):";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }
        private void CalculaScore()
        {

            Rankings rank = new Rankings();
            // Calcula o Score do canditato à vaga
            int NvVaga = Convert.ToInt32(VVagas.NivelDaVaga);
            int NvPessoa = Convert.ToInt32(VPessoas.NivelDoCanditato);
            int N = 100 - 25 * (NvVaga >= NvPessoa ? (NvVaga - NvPessoa) : (0));
            int D = dictValD[VVagas.LocalizacaoDaVaga + VPessoas.LocalizacaoDoCanditato];
            float Score = (((float)(N + D)) / 2);

            // Prepara os dados para serem registrados na coleção ColDosRankings
            rank.VagaId = VVagas._id;
            rank.CandidatoId = VPessoas._id;
            rank.Empresa = VVagas.Empresa;
            rank.TituloDaVaga = VVagas.TituloDaVaga;
            rank.DescricaoDaVaga = VVagas.DescricaoDaVaga;
            rank.LocalizacaoDaVaga = VVagas.LocalizacaoDaVaga;
            rank.NivelDaVaga = VVagas.NivelDaVaga;
            rank.NomeDoCandidato = VPessoas.NomeDoCandidato;
            rank.ProfissaoDoCandidato = VPessoas.ProfissaoDoCandidato;
            rank.LocalizacaoDoCanditato = VPessoas.LocalizacaoDoCanditato;
            rank.NivelDoCanditato = VPessoas.NivelDoCanditato;
            rank.Score = Score;

            // Registra a candidatura na coleção "ColDosRankings" do Banco de Dados MongoDB "DbVagas"
            colecaoDosRankings.InsertOne(rank);

        }
        private void bttTabRegistrarCandidaturasLimparCampos_Click(object sender, EventArgs e)
        {
            lblTabRegistrarCandidaturasVaga_Id.Text = "";
            lblTabRegistrarCandidaturasPessoa_Id.Text = "";
        }
        //
        // Término do Cadastro das candidaturas as vagas
        //
        /// <summary>
        /// //////////////////////////////////////
        /// //////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //
        // Início para retornar os candidatos de uma vaga, ordenados decrescente pelo Score
        //
        private void tabScoreCandidatosVaga_Enter(object sender, EventArgs e)
        {
            // Limpa informações anteriores do DataGridView
            this.dtGViewVagasTabScoreCandidatosVaga.Rows.Clear();

            //FILTRO:
            string[] RgVaga = new string[6];
            var filtrovagas = Builders<Vagas>.Filter.Empty;
            var vagas = colecaoDasVagas.Find<Vagas>(filtrovagas).ToList();
            vagas.ForEach(v =>
            {
                RgVaga[0] = v._id.ToString();
                RgVaga[1] = v.NivelDaVaga.ToString();
                RgVaga[2] = v.TituloDaVaga;
                RgVaga[3] = v.LocalizacaoDaVaga;
                RgVaga[4] = v.DescricaoDaVaga;
                RgVaga[5] = v.Empresa;
                dtGViewVagasTabScoreCandidatosVaga.Rows.Add(RgVaga);
            });

            foreach (DataGridViewRow dgvr in this.dtGViewVagasTabScoreCandidatosVaga.Rows)
            {
                dgvr.HeaderCell.Value = String.Format("{0}", dgvr.Index + 1);
            }

        }
        private void dtGViewVagasTabScoreCandidatosVaga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow newDataRow = dtGViewVagasTabScoreCandidatosVaga.Rows[e.RowIndex];
                VVagas._id = newDataRow.Cells[0].Value.ToString();
                VVagas.NivelDaVaga = newDataRow.Cells[1].Value.ToString();
                VVagas.TituloDaVaga = newDataRow.Cells[2].Value.ToString();
                VVagas.LocalizacaoDaVaga = newDataRow.Cells[3].Value.ToString();
                VVagas.DescricaoDaVaga = newDataRow.Cells[4].Value.ToString();
                VVagas.Empresa = newDataRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                //throw;+ definir alguma mensagem posteriormente
            }

            // Ao selecionar uma vaga específica retorna o Gride com o Score.
            PreencheGridScore();

        }
        private void PreencheGridScore()
        {
            // Limpa informações anteriores do DataGridView
            this.dtGViewScoreTabScoreCandidatosVaga.Rows.Clear();

            //FILTRO:
            string[] RgPessoa = new string[6];
            //var filtro = Builders<Rankings>.Filter.Empty;     //.Where(x => x.NomeCandidato == "Fernanda");
            var filtro = Builders<Rankings>.Filter.Where(x => x.VagaId == VVagas._id);      //"5ba6d10fbd11f839606f1e66");
            //var rankcandvag = colecaoDosRankings.Find<Rankings>(filtro).ToList();
            var sort = Builders<Rankings>.Sort.Descending("Score");
            //var sort = Builders<Rankings>.Sort.Ascending("Score");
            var rankcandvag = colecaoDosRankings.Find<Rankings>(filtro).Sort(sort).ToList();
            rankcandvag.ForEach(c =>
            {
                RgPessoa[0] = c.CandidatoId;
                RgPessoa[1] = c.NomeDoCandidato;
                RgPessoa[2] = c.ProfissaoDoCandidato;
                RgPessoa[3] = c.LocalizacaoDoCanditato;
                RgPessoa[4] = c.NivelDoCanditato;
                RgPessoa[5] = c.Score.ToString();
                dtGViewScoreTabScoreCandidatosVaga.Rows.Add(RgPessoa);
            });

            foreach (DataGridViewRow dgvr in this.dtGViewScoreTabScoreCandidatosVaga.Rows)
            {
                dgvr.HeaderCell.Value = String.Format("{0}", dgvr.Index + 1);
            }
        }
        //
        // Término para retornar os candidatos de uma vaga, ordenados decrescente pelo Score
        //
    }
}