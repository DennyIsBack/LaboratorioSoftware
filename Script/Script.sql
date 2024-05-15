-- Tabela AreaAtuacao
CREATE TABLE AreaAtuacao (
    ID INT PRIMARY KEY,
    Nome VARCHAR(100)
);

--Tabela Resultado 
create table Resultado (
	ID int not null primary key,
	Descricao varchar(255) not null,
	DescricaoArquivo varchar(60) not null,
	Arquivo bytea not null
);

CREATE TABLE Pesquisador (
    ID INT PRIMARY KEY,
    Nome VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    Instituicao VARCHAR(100),
    Lattes VARCHAR(255),
    Tipo VARCHAR(20),
    AreaAtuacao_ID INT,
    FOREIGN KEY (AreaAtuacao_ID) REFERENCES AreaAtuacao(ID)
);

CREATE TABLE Orientacoes (
    Orientador_ID INT,
    Orientando_ID INT,
    FOREIGN KEY (Orientador_ID) REFERENCES Pesquisador(ID),
    FOREIGN KEY (Orientando_ID) REFERENCES Pesquisador(ID),
    PRIMARY KEY (Orientador_ID, Orientando_ID)
);

CREATE TABLE Publicacao (
    ID INT PRIMARY KEY,
    Titulo VARCHAR(255),
    Autor VARCHAR(100),
    Ano INT,
    Tipo VARCHAR(50),
    Pesquisador_ID INT,
    FOREIGN KEY (Pesquisador_ID) REFERENCES Pesquisador(ID)
);

-- Tabela Projeto
CREATE TABLE Projeto (
    ID INT PRIMARY KEY,
    Nome VARCHAR(100),
    AreaAtuacao_ID INT,
    Resultado_ID INT,
    Instituicao_ID INT,
    DataInicial Date,
    DataFinal Date,
    Tipo VARCHAR(20),
    FOREIGN KEY (AreaAtuacao_ID) REFERENCES AreaAtuacao(ID),
    FOREIGN KEY (Resultado_ID) REFERENCES Resultado(ID),
    FOREIGN KEY (Instituicao) REFERENCES Instituicao(ID)
);

-- Tabela Projeto_Pesquisador (Relacionamento muitos para muitos entre Projeto e Pesquisador)
CREATE TABLE Projeto_Pesquisador (
    Projeto_ID INT,
    Pesquisador_ID INT,
    FOREIGN KEY (Projeto_ID) REFERENCES Projeto(ID),
    FOREIGN KEY (Pesquisador_ID) REFERENCES Pesquisador(ID),
    PRIMARY KEY (Projeto_ID, Pesquisador_ID)
);

-- Tabela Instituicao
CREATE TABLE Instituicao (
    ID INT PRIMARY KEY,
    Nome VARCHAR(100),
    Sigla VARCHAR(20),
    Endereco VARCHAR(255),
    Site VARCHAR(100)
);