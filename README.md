# SCV
Desafio Para Engenheiro de Software Vagas.com

Junto aos arquivos do projeto "SCV-Score Candidato Vaga", desenvolvido em resposta ao Desafio para Engenheiro de Software VAGAS.com, disponibilizei o arquivo SCV.zip com instalador do executável para rodar no Windows 10 Pro.
Observo no entando que para a aplicação SCV-Score Candidato Vaga operar ela necessita da instalação prévia do MongoDB, que pode ser obtido na url "https://www.mongodb.com".
Ao acessar a url https://www.mongodb.com  no canto superior direito encontra-se um botão "Get MongoDB", clique neste botão e na página seguinte escolha a opção da aba "Community Server" prossiga realizando o download do instalador para o SO Windows (no meu caso desenvolvi no Windows 10 Pro 64-bit x64 e utilizei o VS2017 e C#).
Após o Donwload, permita a execução do instalador do MongoDB, aceite os termos e prossiga a instalação.
Na tela seguinte escolha a instalação "Completa" e aceite as opções default "padrão", até finalizar o processo de instalação do MongoDB.
Tendo instalado o MongoDB descompactar o arquivo SCV.zip e execute o aplicativo "setup" contido na pasta SCV/SCV em sequência.
Finalizando estas instalações, a aplicação SCV-Score Candidato Vaga estará completamente operacional no SO Windows, podendo executá-la clicando em um ícon que foi gerado diretamente no desktop ou pelos caminhos normais "padrões" para executar aplicativos instalados no Windows.
Na tela inicial é possivel realizar os registros das vagas "aba Cadastrar Vagas" via textboxes e demais objetos desta tela. Clicando no botão Cadastrar Vaga de Emprego as informações contidas nesta aba são então cadastradas no banco de dados.
Como feedback ao usuário desta aplicação, no painel abaixo do botão "Limpar Campos" todas as entradas dos registros de vagas que estão sendo inseridas no banco MongoDB são retornadas ao usuário.
Nos mesmos moldes dos registros de vagas na "aba Cadastrar Pessoas" são realizados os registros das pessoas no banco MongoDB.
Na "aba Registrar Candidaturas" devido a não haver maiores especificações para simplificar o processo de registro de candidaturas, foram implementados dois GridViews.
Clicando na primeira coluna de uma das linhas de cada um deles "Coluna mais a esquerda sem descrição no cabeçalho" é possível selecionar qual vaga deseja vincular a tal pessoa.
Quando o usuário clicar em uma das linhas na primeira coluna de cada GridView é mostrado abaixo dos Grids os "Ids" da Vaga e da Pessoa selecionados que serão registradas no banco MongoDB.
Finalize o registro de cada candidatura clicando no botão "Cadastrar Pessoa para vaga", e repita esta sequência a cada novo registro de candidatura a ser realizado.
Por fim a "aba Score Candidatura/Vaga" opera semelhante a aba anterior "Registrar Candidaturas" onde apenas ao clicar na primeira  coluna de uma das linhas do GridView superior, "Vagas Registradas" executa-se automaticamente uma pesquisa para retornar os canditatos de uma vaga, ordenados pelo score (de forma decrescente).
O resultado desta pesquisa automática é retornado no GridView "Score dos Candidatos da Vaga Selecionada".
Observamos que este último GridView é atualizado a cada pesquisa realizada, descartando os dados da pesquisa anterior.

Dúvidas - > por favor me contatem via "sergio.e.antonio@gmail.com"



