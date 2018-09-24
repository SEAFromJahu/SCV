# SCV
Desafio Para Engenheiro de Software Vagas.com

Junto aos arquivos do projeto "SCV-Score Candidato Vaga", desenvolvido em resposta ao Desafio para Engenheiro de Software VAGAS.com, disponibilizei o arquivo SCV.zip com instalador do executável para rodar no Windows 10 Pro.
Observo no entando que para a aplicação SCV-Score Candidato Vaga operar ela necessita da instalação prévia do MongoDB, que pode ser obtido na url "https://www.mongodb.com".
Ao acessar a url https://www.mongodb.com  no canto superior direito encontra-se um botão "Get MongoDB", clique neste botão e na página seguinte escolha a opção da aba "Community Server" prossiga realizando o download do instalador para o SO Windows (no meu caso desenvolvi no Windows 10 Pro 64-bit x64 e utilizei o VS2017 e C#).
Após o Donwload permita a execução do instalador do MongoDB, aceite os termos e prossiga a instalação.
Na tela seguinte escolha a instalação "Completa" e aceite as opções default "padrão", até finalizar o processo de instalação do MongoDB.
Tendo instalado o MongoDB descompactar o arquivo SCV.zip e executar o aplicativo "setup" contido na pasta SCV/SCV em sequência.
Finalizando estas instalações a aplicação SCV - Score Candidato Vaga estará completamente opeeracional no SO Windows, podendo-se executá-la clicando-se em um ícon que foi gerado diretamenteo no desktop ou pelos caminhos normais "padrões" para executar applicativos instalados no Windows.
Na tela inicial é possivel realizar os registros das vagas "aba Cadastrar Vagas" via textbox e demais objetos desta tela e clicando-se no botão Cadastrar Vaga de Emprego.
Como feedback ao usuário da aplicação, no painel abaixo todas as entradas dos registros de vagas que estão sendo inseridas no banco MongoDB são retornadas ao usuário.
Nos mesmos moldes dos registros de vagas na "aba Cadastrar Pessoas" são realizados os registros das pessoas no banco MongoDB.
Na "aba Registrar Candidaturas" devido a não haver maiores especificações, para simplificar o processo de registro de candidaturas foram implementados dois GridView onde selecionando-se "clicando-se na primeira coluna de cada um deles é possível selecionar qual vaga deseja-se vincular a tal pessoa. Quando o usuário clicar na primeira coluna de cada GridView é mostrado abaixo dos Grids os ids da Vaga e da Pessoa que foi registrada no banco MongoDB.
Por fim a "aba Score Candidatura/Vaga" opera semelhante a aba anterior "Registrar Candidaturas" onde apenas e somente apenas ao clicar na primeira coluna do GridView superior, "Vagas Registradas" executa-se imediatamente a querie para retornar os canditatos de uma vaga, ordenados pelo score (de forma decrescente).

Dúvidas - > por favor me contatem via "sergio.e.antonio@gmail.com"



