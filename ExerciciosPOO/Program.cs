using ExerciciosPOO;
using PilaresPOO;

// Exercício I - Sistema de veículos
/*
Carro c = new Carro();
c.Marca = "Chevrolet";
c.Modelo = "Impala";
c.QuantidadePortas = 4;

c.ExibirInformações();

Motocicleta m = new Motocicleta();
m.Marca = "Kawasaki";
m.Modelo = "Ninja 400";
m.Cilindradas = 399;

m.ExibirInformações();
*/


//////


// Exercício II - Sistema de produtos digitais
/*
Ebook e = new Ebook();
e.Nome = "It: A Coisa";
e.Preco = 39.90m;
e.QuantidadePaginas = 1014;

e.ExibirInformações();

CursoOnline c = new CursoOnline();
c.Nome = "Excel Completo";
c.Preco = 500m;
c.CargaHoraria = "10 horas semanais";

c.ExibirInformações();
*/


//////


// Exercício III - Sistema de jogos
/*
JogoDigital jd = new JogoDigital("Among Us", "PC");
jd.ExibirInformações();

JogoFisico jf = new JogoFisico("Pokémon Scarlet", "Nintendo Switch");
jf.ExibirInformações();
*/


//////


// Exercício 4 - Sistema de notificações
/*
NotificacaoEmail ne = new NotificacaoEmail();
ne.Enviar("=========== EMAIL ===========\n\nOlá, tudo bem?\nGostaria de solicitar algumas informações sobre o assunto mencionado. Quando possível, poderia me retornar com os detalhes?\n\nAgradeço desde já pela atenção.\nAtenciosamente, Megan.");

NotificacaoPush np = new NotificacaoPush();
np.Enviar("\n\n\n=========== PUSH ===========\n\nNovidade disponível!\nNão perca as atualizações. Acesse o aplicativo e confira as novidades agora!");

NotificacaoSMS ns = new NotificacaoSMS();
ns.Enviar("\n\n\n=========== SMS ===========\n\nOlá! Tudo bem? Gostaria de saber se você tem alguma atualização sobre o assunto. Quando puder, me dê um retorno. Obrigado(a)!");
*/


//////


// Exercício 5 - Sistema de cálculo de frete

EntregaExpressa ex = new EntregaExpressa(5, 25);
ex.CalcularFrete();