create table pesquisador (
	id int not null primary key,
	nome varchar(60) not null,
	area varchar(60) not null
);

create table resultado (
	id int not null primary key,
	descricao varchar(255) not null,
	descricao_arquivo varchar(60) not null,
	arquivo bytea not null
);

create table projeto (
	id int not null primary key,
	titulo varchar(255) not null,
	data_inicial date not null,
	data_final date,
	id_resultado int references resultado(id)
);

create table projeto_pesquisador (
	id_projeto int references projeto(id) not null,
	id_pesquisador int references pesquisador(id) not null,
	primary key (id_projeto, id_pesquisador)
);