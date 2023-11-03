drop table if exists tb_paciente cascade;
drop table if exists usuario cascade;
drop table if exists medico cascade;
drop table if exists consulta cascade;

drop table if exists tb_paciente;
drop table if exists usuario;
drop table if exists medico;
drop table if exists consulta;



ALTER SEQUENCE id_pacientesqc RESTART WITH 1;

CREATE SEQUENCE id_pacientesqc;

CREATE TABLE tb_paciente (
	id_paciente INT NOT NULL DEFAULT (NEXTVAL('id_pacientesqc')) ,
	nome_paciente CHARACTER VARYING(60),
	nmr_cpf CHARACTER VARYING NOT NULL ,
	genero CHARACTER VARYING(2),
	data_nascimento CHARACTER VARYING(50),
	telefone CHARACTER VARYING(40),
	bairro CHARACTER VARYING(40),
	cidade CHARACTER VARYING,
	cep CHARACTER VARYING NOT NULL , 
	nome_rua CHARACTER VARYING(40),
	nmr_casa CHARACTER VARYING not null,
	CONSTRAINT sequence PRIMARY KEY(id_paciente),
	CONSTRAINT uncpf UNIQUE (nmr_cpf),
	excluido_paciente INT NOT NULL
);

SELECT nmr_cpf FROM tb_paciente;

INSERT INTO tb_paciente
VALUES (nextval('id_pacientesqc'),  'Gabriel Henrique Alves Pereira', 44959730889 , 'M', '11/01/1997', 32432246, 'Nobuji Nagasawa', 'Bauru', 17026833, 'Admar Leopoldo Ghellardi', 3125);

SELECT * FROM tb_paciente;



CREATE SEQUENCE id_usuariosqc;

ALTER SEQUENCE id_usuariosqc RESTART WITH 1;

CREATE TABLE usuario (
	id_usuario INT NOT NULL DEFAULT (NEXTVAL('id_usuariosqc')),
	nome CHARACTER VARYING (60) NOT NULL,
	nomeusuario CHARACTER VARYING(20) NOT NULL,
	senha CHARACTER VARYING NOT NULL,
	PRIMARY KEY(id_usuario),
	CONSTRAINT unnomeusuario UNIQUE (nomeusuario)
);


INSERT INTO usuario
VALUES (DEFAULT, 'maria', 'mariagabriela', 123);


INSERT INTO usuario
VALUES (DEFAULT,  'joaquina','joaquina', 123);


INSERT INTO usuario
VALUES (DEFAULT,  'adm','admin', 12345);

INSERT INTO usuario
VALUES (DEFAULT,  'a','a', 1);

INSERT INTO usuario
VALUES (DEFAULT,  'teste','teste', 55);

SELECT * FROM usuario;



CREATE SEQUENCE id_consultasqc;

ALTER SEQUENCE id_consultasqc RESTART WITH 1;

CREATE TABLE consulta (
	id_consulta INT NOT NULL UNIQUE DEFAULT (NEXTVAL('id_consultasqc')),
	nmr_cpf CHARACTER VARYING(60),
	nome_paciente CHARACTER VARYING(60),
	genero CHARACTER VARYING(2),
	data_nascimento CHARACTER VARYING(50),
	telefone CHARACTER VARYING(40),
	hora_consulta VARCHAR(600) NOT NULL,
	observacoes CHARACTER VARYING (600),
	data_consulta CHARACTER VARYING(60) not null,
	PRIMARY KEY(id_consulta),
	CONSTRAINT unconsulta UNIQUE (id_consulta),
	id_medico VARCHAR,
	preco CHARACTER VARYING NOT NULL,
	especialidade CHARACTER VARYING (50),
	crm_medico VARCHAR (5), 
	FOREIGN KEY (nmr_cpf) REFERENCES tb_paciente (nmr_cpf),
	excluido_consulta INT NOT NULL
);

INSERT INTO consulta
VALUES (1,44959730889, 2350,'estou muito mal',11/01/97);

SELECT * FROM consulta



CREATE SEQUENCE id_medicosqc;

ALTER SEQUENCE id_medicosqc RESTART WITH 1;

CREATE TABLE medico (
	id_medico INT NOT NULL DEFAULT (NEXTVAL('id_medicosqc')),
	nome_medico CHARACTER VARYING(60),
	especialidade CHARACTER VARYING(40),
	preco VARCHAR,
	crm_medico VARCHAR(5) UNIQUE,
	PRIMARY KEY(id_medico),
	excluido_medico INT NOT NULL
);

INSERT INTO medico 
VALUES ( 2, 'rodoladsfo','otorpedista', '7asd');

INSERT INTO medico 
VALUES ( 3, 'rodoasd','otorpesssdista', '111sd2');



SELECT * FROM tb_paciente, usuario, consulta, medico