#language: pt
#encoding: iso-8859-1

Funcionalidade: Cadastrar Usuário
	Como um usuário da loja de livros
	Eu quero realizar o cadastro de uma conta
	Para que eu possa comprar livros

Esquema do Cenário: Cadastro de usuário com sucesso
	Dado Acessar a página de cadastro de conta de usuário
	E Informar o nome <nome>
	E Informar o sobrenome <sobrenome>
	E Informar o email <email>
	E Informar a senha <senha>
	E Confirmar a senha <senha>
	Quando Executar o cadastro do usuário
	Então Sistema exibe a mensagem "Obrigado por se registrar com LOJA EXEMPLO de Livros"

	Exemplos: 
	| nome      | sobrenome | email                   | senha        |
	| "Sergio"  | "Mendes"  | "sergio.coti@gmail.com" | "adminadmin" |
	| "Raphael" | "Augusto" | "rafadastan02@live.com" | "adminadmin" |