-- Tabela AreaAtuacao
CREATE TABLE AreaAtuacao (
    ID INT PRIMARY KEY,
    Nome VARCHAR(100)
);

--Tabela Resultado 
create table Resultado (
	ID int not null primary key,
	id_projeto int,
	arquivo bytea,
	nome_arquivo varchar(150),
    FOREIGN KEY (id_projeto) REFERENCES Projeto(ID)
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
    DataInicial Date,
    DataFinal Date,
    Tipo VARCHAR(20),
    Instituicao_ID INT,
    Finalizado Boolean,
    FOREIGN KEY (AreaAtuacao_ID) REFERENCES AreaAtuacao(ID),
    FOREIGN KEY (Resultado_ID) REFERENCES Resultado(ID),
    FOREIGN KEY (Instituicao_ID) REFERENCES Instituicao(ID)
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

INSERT INTO AreaAtuacao (ID, Nome) VALUES (1, 'Ciências Exatas e da Terra');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (2, 'Matemática');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (3, 'Probabilidade e Estatística');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (4, 'Ciência da Computação');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (5, 'Astronomia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (6, 'Física');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (7, 'Química');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (8, 'Geociências');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (9, 'Ciências Biológicas');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (10, 'Biologia Geral');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (11, 'Biofísica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (12, 'Genética');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (13, 'Botânica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (14, 'Zoologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (15, 'Ecologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (16, 'Morfologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (17, 'Fisiologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (18, 'Bioquímica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (19, 'Imunologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (20, 'Microbiologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (21, 'Parasitologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (22, 'Farmacologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (23, 'Biotecnologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (24, 'Ciências da Saúde');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (25, 'Medicina');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (26, 'Medicina Veterinária');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (27, 'Odontologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (28, 'Farmácia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (29, 'Enfermagem');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (30, 'Nutrição');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (31, 'Saúde Coletiva');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (32, 'Fonoaudiologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (33, 'Educação Física');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (34, 'Ciências Agrárias');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (35, 'Agronomia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (36, 'Recursos Florestais e Engenharia Florestal');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (37, 'Engenharia Agrícola');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (38, 'Zootecnia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (39, 'Recursos Pesqueiros e Engenharia de Pesca');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (40, 'Medicina Veterinária');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (41, 'Ciência e Tecnologia de Alimentos');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (42, 'Engenharia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (43, 'Engenharia Civil');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (44, 'Engenharia de Produção');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (45, 'Engenharia Elétrica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (46, 'Engenharia Mecânica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (47, 'Engenharia Química');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (48, 'Engenharia de Materiais e Metalúrgica');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (49, 'Engenharia Sanitária');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (50, 'Engenharia Nuclear');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (51, 'Engenharia de Transportes');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (52, 'Ciências Sociais Aplicadas');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (53, 'Administração');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (54, 'Ciências Contábeis');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (55, 'Economia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (56, 'Arquitetura e Urbanismo');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (57, 'Planejamento Urbano e Regional');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (58, 'Demografia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (59, 'Direito');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (60, 'Ciência da Informação');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (61, 'Comunicação');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (62, 'Desenho Industrial');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (63, 'Serviço Social');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (64, 'Ciências Humanas');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (65, 'Filosofia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (66, 'Sociologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (67, 'Antropologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (68, 'História');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (69, 'Geografia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (70, 'Psicologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (71, 'Educação');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (72, 'Teologia');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (73, 'Linguística, Letras e Artes');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (74, 'Linguística');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (75, 'Letras');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (76, 'Artes');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (77, 'Artes Visuais');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (78, 'Música');
INSERT INTO AreaAtuacao (ID, Nome) VALUES (79, 'Artes Cênicas');
