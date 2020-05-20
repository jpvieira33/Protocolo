
CREATE TABLE Cargo (
       Cd_Cargo             numeric(2) NOT NULL,
       Nm_Cargo             varchar(60) NOT NULL
)
go


ALTER TABLE Cargo
       ADD CONSTRAINT PK_Cargo PRIMARY KEY CLUSTERED (Cd_Cargo ASC)
go


CREATE TABLE Categoria_Menu (
       Id_Categoria         integer NOT NULL,
       Nm_Categoria         varchar(60) NOT NULL,
       Ativo                bit NOT NULL
)
go


ALTER TABLE Categoria_Menu
       ADD CONSTRAINT PK_Categoria_Menu PRIMARY KEY CLUSTERED (
              Id_Categoria ASC)
go


CREATE TABLE Cliente (
       Id_Cliente           integer IDENTITY(1,1),
       Tp_Cliente           char(1) NOT NULL,
       Dt_Cadastro          datetime NOT NULL,
       Logradouro           varchar(255) NOT NULL,
       Bairro               varchar(60) NOT NULL,
       Numero               varchar(10) NOT NULL,
       Cidade               varchar(60) NOT NULL,
       UF                   char(2) NOT NULL,
       CEP                  char(8) NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Cliente ON Cliente
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Cliente
       ADD CONSTRAINT PK_Cliente PRIMARY KEY CLUSTERED (Id_Cliente ASC)
go


CREATE TABLE Cliente_Pessoa_Fisica (
       Id_Cliente           integer NOT NULL,
       Nm_Cliente           varchar(60) NOT NULL,
       CPF                  integer NOT NULL,
       Email                varchar(60) NULL
)
go


ALTER TABLE Cliente_Pessoa_Fisica
       ADD CONSTRAINT PK_Cliente_Pessoa_Fisica PRIMARY KEY CLUSTERED (
              Id_Cliente ASC)
go


CREATE TABLE Cliente_Pessoa_Juridica (
       Id_Cliente           integer NOT NULL,
       Razao_Social         varchar(100) NOT NULL,
       Nm_Fantasia          varchar(100) NOT NULL,
       CNPJ                 integer NULL,
       Inscricao_Estadual   integer NOT NULL,
       Inscricao_Municipal  integer NOT NULL,
       Cd_Ramo              numeric(1) NOT NULL
)
go

CREATE INDEX XIF2Cliente_Pessoa_Juridica ON Cliente_Pessoa_Juridica
(
       Cd_Ramo                        ASC
)
go


ALTER TABLE Cliente_Pessoa_Juridica
       ADD CONSTRAINT PK_Cliente_Pessoa_Juridica PRIMARY KEY CLUSTERED (
              Id_Cliente ASC)
go


CREATE TABLE Cliente_Telefone (
       Id_Cliente           integer NOT NULL,
       Id_Telefone          integer NOT NULL,
       DDD                  char(3) NOT NULL,
       Telefone             char(8) NOT NULL,
       Cd_Tipo_Telefone     numeric(1) NOT NULL
)
go

CREATE INDEX XIF1Cliente_Telefone ON Cliente_Telefone
(
       Id_Cliente                     ASC
)
go

CREATE INDEX XIF2Cliente_Telefone ON Cliente_Telefone
(
       Cd_Tipo_Telefone               ASC
)
go


ALTER TABLE Cliente_Telefone
       ADD CONSTRAINT PK_Cliente_Telefone PRIMARY KEY CLUSTERED (
              Id_Telefone ASC)
go


CREATE TABLE Contato_Cliente (
       Id_Contato           integer NOT NULL,
       Nm_Contato           varchar(60) NOT NULL,
       Funcao               varchar(60) NULL,
       Email                varchar(100) NULL,
       Id_Cliente           integer NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Contato_Cliente ON Contato_Cliente
(
       Id_Cliente                     ASC
)
go

CREATE INDEX XIF2Contato_Cliente ON Contato_Cliente
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Contato_Cliente
       ADD CONSTRAINT PK_Contato_Cliente PRIMARY KEY CLUSTERED (
              Id_Contato ASC)
go


CREATE TABLE Contato_Cliente_Telefone (
       Id_Telefone          integer NOT NULL,
       DDD                  char(3) NOT NULL,
       Telefone             char(8) NOT NULL,
       Id_Contato           integer NOT NULL,
       Cd_Tipo_Telefone     numeric(1) NOT NULL
)
go

CREATE INDEX XIF1Contato_Cliente_Telefone ON Contato_Cliente_Telefone
(
       Id_Contato                     ASC
)
go

CREATE INDEX XIF2Contato_Cliente_Telefone ON Contato_Cliente_Telefone
(
       Cd_Tipo_Telefone               ASC
)
go


ALTER TABLE Contato_Cliente_Telefone
       ADD CONSTRAINT PK_Contato_Cliente_Telefone PRIMARY KEY CLUSTERED (
              Id_Telefone ASC)
go


CREATE TABLE Contato_Fornecedor (
       Id_Contato           integer NOT NULL,
       Nm_Contato           varchar(60) NOT NULL,
       Funcao               varchar(60) NULL,
       Email                varchar(100) NULL,
       Id_Fornecedor        integer NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Contato_Fornecedor ON Contato_Fornecedor
(
       Id_Fornecedor                  ASC
)
go

CREATE INDEX XIF2Contato_Fornecedor ON Contato_Fornecedor
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Contato_Fornecedor
       ADD CONSTRAINT PK_Contato_Fornecedor PRIMARY KEY CLUSTERED (
              Id_Contato ASC)
go


CREATE TABLE Contato_Fornecedor_Telefone (
       Id_Telefone          integer NOT NULL,
       Id_Contato           integer NOT NULL,
       DDD                  char(3) NOT NULL,
       Telefone             char(8) NOT NULL,
       Cd_Tipo_Telefone     numeric(1) NOT NULL
)
go

CREATE INDEX XIF2Contato_Fornecedor_Telefone ON Contato_Fornecedor_Telefone
(
       Id_Contato                     ASC
)
go

CREATE INDEX XIF3Contato_Fornecedor_Telefone ON Contato_Fornecedor_Telefone
(
       Cd_Tipo_Telefone               ASC
)
go


ALTER TABLE Contato_Fornecedor_Telefone
       ADD CONSTRAINT PK_Contato_Fornecedor_Telefone PRIMARY KEY CLUSTERED (
              Id_Telefone ASC)
go


CREATE TABLE Departamento (
       Cd_Departamento      numeric(2) NOT NULL,
       Nm_Departamento      varchar(60) NOT NULL
)
go


ALTER TABLE Departamento
       ADD CONSTRAINT PK_Departamento PRIMARY KEY CLUSTERED (
              Cd_Departamento ASC)
go


CREATE TABLE Endereco_Entrega (
       Id_Endereco          integer NOT NULL,
       Logradouro           varchar(255) NOT NULL,
       Numero               varchar(10) NOT NULL,
       Bairro               varchar(60) NOT NULL,
       Cidade               varchar(60) NOT NULL,
       UF                   char(2) NOT NULL,
       CEP                  char(8) NOT NULL,
       Id_Cliente           integer NOT NULL
)
go

CREATE INDEX XIF1Endereco_Entrega ON Endereco_Entrega
(
       Id_Cliente                     ASC
)
go


ALTER TABLE Endereco_Entrega
       ADD CONSTRAINT PK_Endereco_Entrega PRIMARY KEY CLUSTERED (
              Id_Endereco ASC)
go


CREATE TABLE Forma_Pagamento (
       Cd_Forma_Pagamento   numeric(1) NOT NULL,
       Ds_Forma_Pagamento   varchar(60) NOT NULL
)
go


ALTER TABLE Forma_Pagamento
       ADD CONSTRAINT PK_Forma_Pagamento PRIMARY KEY CLUSTERED (
              Cd_Forma_Pagamento ASC)
go


CREATE TABLE Fornecedor (
       Id_Fornecedor        integer NOT NULL,
       Dt_Cadastro          datetime NOT NULL,
       Razao_Social         varchar(100) NOT NULL,
       Nm_Fantasia          varchar(100) NOT NULL,
       CNPJ                 integer NOT NULL,
       Inscricao_Estadual   integer NOT NULL,
       Inscricao_Municipal  integer NOT NULL,
       Logradouro           varchar(255) NOT NULL,
       Numero               varchar(10) NOT NULL,
       Bairro               varchar(60) NOT NULL,
       Cidade               varchar(60) NOT NULL,
       UF                   char(2) NOT NULL,
       CEP                  char(8) NOT NULL,
       Cd_Ramo              numeric(1) NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Fornecedor ON Fornecedor
(
       Cd_Ramo                        ASC
)
go

CREATE INDEX XIF2Fornecedor ON Fornecedor
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Fornecedor
       ADD CONSTRAINT PK_Fornecedor PRIMARY KEY CLUSTERED (
              Id_Fornecedor ASC)
go


CREATE TABLE Fornecedor_Materia_Prima (
       Id_Fornecedor        integer NOT NULL,
       Id_Materia_Prima     integer NOT NULL
)
go

CREATE INDEX XIF1Fornecedor_Materia_Prima ON Fornecedor_Materia_Prima
(
       Id_Fornecedor                  ASC
)
go

CREATE INDEX XIF2Fornecedor_Materia_Prima ON Fornecedor_Materia_Prima
(
       Id_Materia_Prima               ASC
)
go


ALTER TABLE Fornecedor_Materia_Prima
       ADD CONSTRAINT PK_Fornecedor_Materia_Prima PRIMARY KEY CLUSTERED (
              Id_Fornecedor ASC, Id_Materia_Prima ASC)
go


CREATE TABLE Fornecedor_Telefone (
       Id_Telefone          integer NOT NULL,
       Telefone             char(8) NOT NULL,
       DDD                  char(3) NOT NULL,
       Id_Fornecedor        integer NOT NULL,
       Cd_Tipo_Telefone     numeric(1) NOT NULL
)
go

CREATE INDEX XIF1Fornecedor_Telefone ON Fornecedor_Telefone
(
       Id_Fornecedor                  ASC
)
go

CREATE INDEX XIF2Fornecedor_Telefone ON Fornecedor_Telefone
(
       Cd_Tipo_Telefone               ASC
)
go


ALTER TABLE Fornecedor_Telefone
       ADD CONSTRAINT PK_Fornecedor_Telefone PRIMARY KEY CLUSTERED (
              Id_Telefone ASC)
go


CREATE TABLE Funcionario (
       Id_Matricula         integer NOT NULL,
       Nm_Funcionario       varchar(60) NOT NULL,
       Dt_Admissao          datetime NOT NULL,
       Dt_Ent_Sistema       datetime NOT NULL,
       Cd_Departamento      numeric(2) NOT NULL,
       Cd_Cargo             numeric(2) NOT NULL
)
go

CREATE INDEX XIF1Funcionario ON Funcionario
(
       Cd_Departamento                ASC
)
go

CREATE INDEX XIF2Funcionario ON Funcionario
(
       Cd_Cargo                       ASC
)
go


ALTER TABLE Funcionario
       ADD CONSTRAINT PK_Funcionario PRIMARY KEY CLUSTERED (
              Id_Matricula ASC)
go


CREATE TABLE Item_NF_Compra (
       Id_NF_Compra         integer NOT NULL,
       Nu_Item_NF_Compra    integer NOT NULL,
       Id_Materia_Prima     integer NOT NULL,
       Qt_Item              integer NOT NULL,
       Vl_Unitario          numeric(8,2) NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL
)
go

CREATE INDEX XIF1Item_NF_Compra ON Item_NF_Compra
(
       Id_NF_Compra                   ASC
)
go

CREATE INDEX XIF2Item_NF_Compra ON Item_NF_Compra
(
       Id_Materia_Prima               ASC
)
go


ALTER TABLE Item_NF_Compra
       ADD CONSTRAINT PK_Item_NF_Compra PRIMARY KEY CLUSTERED (
              Nu_Item_NF_Compra ASC, Id_NF_Compra ASC)
go


CREATE TABLE Item_NF_Venda (
       Qt_Item              integer NOT NULL,
       Vl_Unitario          numeric(8,2) NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Nu_Item_NF_Venda     integer NOT NULL,
       Nu_NF_Venda          integer NOT NULL,
       Id_Produto           integer NOT NULL
)
go

CREATE INDEX XIF1Item_NF_Venda ON Item_NF_Venda
(
       Nu_NF_Venda                    ASC
)
go

CREATE INDEX XIF2Item_NF_Venda ON Item_NF_Venda
(
       Id_Produto                     ASC
)
go


ALTER TABLE Item_NF_Venda
       ADD CONSTRAINT PK_Item_NF_Venda PRIMARY KEY CLUSTERED (
              Nu_Item_NF_Venda ASC, Nu_NF_Venda ASC)
go


CREATE TABLE Item_Pedido (
       Nu_Item_Pedido       integer NOT NULL,
       Qt_Item              integer NOT NULL,
       Pc_Desconto          numeric(3,1) NULL,
       Nu_Pedido            integer NOT NULL,
       Vl_Unitario          numeric(8,2) NOT NULL,
       Id_Produto           integer NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Qt_Atendida          integer NOT NULL,
       Qt_Pendente          integer NOT NULL
)
go

CREATE INDEX XIF1Item_Pedido ON Item_Pedido
(
       Nu_Pedido                      ASC
)
go

CREATE INDEX XIF2Item_Pedido ON Item_Pedido
(
       Id_Produto                     ASC
)
go


ALTER TABLE Item_Pedido
       ADD CONSTRAINT PK_Item_Pedido PRIMARY KEY CLUSTERED (
              Nu_Item_Pedido ASC, Nu_Pedido ASC)
go


CREATE TABLE Item_Pedido_Fornecedor (
       Id_Item_Pedido       integer NOT NULL,
       Qt_Item              integer NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Pc_Desconto          numeric(3,1) NOT NULL,
       Id_Pedido            integer NOT NULL,
       Id_Materia_Prima     integer NOT NULL,
       Vl_Unitario          numeric(8,2) NOT NULL,
       Qt_Atendida          integer NOT NULL,
       Qt_Pendente          integer NOT NULL
)
go

CREATE INDEX XIF1Item_Pedido_Fornecedor ON Item_Pedido_Fornecedor
(
       Id_Pedido                      ASC
)
go

CREATE INDEX XIF2Item_Pedido_Fornecedor ON Item_Pedido_Fornecedor
(
       Id_Materia_Prima               ASC
)
go


ALTER TABLE Item_Pedido_Fornecedor
       ADD CONSTRAINT PK_Item_Pedido_Fornecedor PRIMARY KEY CLUSTERED (
              Id_Item_Pedido ASC, Id_Pedido ASC)
go


CREATE TABLE Item_Producao (
       Id_Produto           integer NOT NULL,
       Nu_Item_Producao     integer NOT NULL,
       Qt_Produzido         integer NOT NULL
)
go

CREATE INDEX XIF1Item_Producao ON Item_Producao
(
       Id_Produto                     ASC
)
go

CREATE INDEX XIF2Item_Producao ON Item_Producao
(
       Nu_Item_Producao               ASC
)
go


ALTER TABLE Item_Producao
       ADD CONSTRAINT PK_Item_Producao PRIMARY KEY CLUSTERED (
              Nu_Item_Producao ASC, Id_Produto ASC)
go


CREATE TABLE Item_Req_Materia_Prima (
       Id_Item_Req_Mat_Prima integer NOT NULL,
       Id_Req_Materia_Prima integer NOT NULL,
       Qt_Item              integer NOT NULL,
       Id_Materia_Prima     integer NOT NULL
)
go

CREATE INDEX XIF1Item_Req_Materia_Prima ON Item_Req_Materia_Prima
(
       Id_Req_Materia_Prima           ASC
)
go

CREATE INDEX XIF2Item_Req_Materia_Prima ON Item_Req_Materia_Prima
(
       Id_Materia_Prima               ASC
)
go


ALTER TABLE Item_Req_Materia_Prima
       ADD CONSTRAINT PK_Item_Req_Materia_Prima PRIMARY KEY CLUSTERED (
              Id_Item_Req_Mat_Prima ASC, Id_Req_Materia_Prima ASC)
go


CREATE TABLE Materia_Prima (
       Id_Materia_Prima     integer NOT NULL,
       Nm_Materia_Prima     varchar(80) NOT NULL,
       Ds_Mat_Prima         varchar(255) NOT NULL,
       Qt_Mat_Prima         integer NOT NULL,
       Qt_Minima_Mat_Prima  integer NOT NULL
)
go


ALTER TABLE Materia_Prima
       ADD CONSTRAINT PK_Materia_Prima PRIMARY KEY CLUSTERED (
              Id_Materia_Prima ASC)
go


CREATE TABLE Menu (
       Id_Menu              integer NOT NULL,
       Nm_Menu              varchar(60) NOT NULL,
       Ativo                bit NOT NULL,
       Id_Categoria         integer NOT NULL
)
go

CREATE INDEX XIF1Menu ON Menu
(
       Id_Categoria                   ASC
)
go


ALTER TABLE Menu
       ADD CONSTRAINT PK_Menu PRIMARY KEY CLUSTERED (Id_Menu ASC)
go


CREATE TABLE NF_Compra (
       Id_NF_Compra         integer NOT NULL,
       Nu_NF_Compra         integer NOT NULL,
       Id_Fornecedor        integer NOT NULL,
       Dt_Emissao           datetime NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1NF_Compra ON NF_Compra
(
       Id_Fornecedor                  ASC
)
go

CREATE INDEX XIF2NF_Compra ON NF_Compra
(
       Id_Matricula                   ASC
)
go


ALTER TABLE NF_Compra
       ADD CONSTRAINT PK_NF_Compra PRIMARY KEY CLUSTERED (
              Id_NF_Compra ASC)
go


CREATE TABLE NF_Venda (
       Nu_NF_Venda          integer NOT NULL,
       Id_Cliente           integer NOT NULL,
       Dt_Emissao           datetime NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1NF_Venda ON NF_Venda
(
       Id_Cliente                     ASC
)
go

CREATE INDEX XIF2NF_Venda ON NF_Venda
(
       Id_Matricula                   ASC
)
go


ALTER TABLE NF_Venda
       ADD CONSTRAINT PK_NF_Venda PRIMARY KEY CLUSTERED (Nu_NF_Venda ASC)
go


CREATE TABLE Pagamento (
       Id_Pagamento         integer NOT NULL,
       Dt_Prevista_Pagamento datetime NOT NULL,
       Dt_Pagamento         datetime NOT NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Id_NF_Compra         integer NOT NULL,
       Id_Matricula         integer NOT NULL,
       Cd_Forma_Pagamento   numeric(1) NOT NULL
)
go

CREATE INDEX XIF1Pagamento ON Pagamento
(
       Id_NF_Compra                   ASC
)
go

CREATE INDEX XIF2Pagamento ON Pagamento
(
       Id_Matricula                   ASC
)
go

CREATE INDEX XIF3Pagamento ON Pagamento
(
       Cd_Forma_Pagamento             ASC
)
go


ALTER TABLE Pagamento
       ADD CONSTRAINT PK_Pagamento PRIMARY KEY CLUSTERED (
              Id_Pagamento ASC)
go


CREATE TABLE Pedido (
       Nu_Pedido            integer NOT NULL,
       Dt_Pedido            datetime NOT NULL,
       Dt_Entrega           datetime NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Dt_Prevista_Entrega  datetime NOT NULL,
       Pc_Desconto          numeric(3,1) NOT NULL,
       Cd_Situacao          numeric(1) NOT NULL,
       Id_Cliente           integer NOT NULL,
       Id_Endereco          integer NOT NULL,
       Id_Matricula         integer NOT NULL,
       Nu_NF_Venda          integer NULL
)
go

CREATE INDEX XIF1Pedido ON Pedido
(
       Cd_Situacao                    ASC
)
go

CREATE INDEX XIF2Pedido ON Pedido
(
       Id_Cliente                     ASC
)
go

CREATE INDEX XIF3Pedido ON Pedido
(
       Id_Endereco                    ASC
)
go

CREATE INDEX XIF4Pedido ON Pedido
(
       Id_Matricula                   ASC
)
go

CREATE INDEX XIF5Pedido ON Pedido
(
       Nu_NF_Venda                    ASC
)
go


ALTER TABLE Pedido
       ADD CONSTRAINT PK_Pedido PRIMARY KEY CLUSTERED (Nu_Pedido ASC)
go


CREATE TABLE Pedido_Fornecedor (
       Id_Pedido            integer NOT NULL,
       Dt_Pedido            datetime NOT NULL,
       Dt_Entrega           datetime NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Cd_Situacao          numeric(1) NOT NULL,
       Pc_Desconto          numeric(3,1) NOT NULL,
       Id_Fornecedor        integer NOT NULL,
       Id_Matricula         integer NOT NULL,
       Id_NF_Compra         integer NULL,
       Dt_Prevista_Entrega  datetime NOT NULL
)
go

CREATE INDEX XIF1Pedido_Fornecedor ON Pedido_Fornecedor
(
       Cd_Situacao                    ASC
)
go

CREATE INDEX XIF2Pedido_Fornecedor ON Pedido_Fornecedor
(
       Id_Fornecedor                  ASC
)
go

CREATE INDEX XIF3Pedido_Fornecedor ON Pedido_Fornecedor
(
       Id_Matricula                   ASC
)
go

CREATE INDEX XIF4Pedido_Fornecedor ON Pedido_Fornecedor
(
       Id_NF_Compra                   ASC
)
go


ALTER TABLE Pedido_Fornecedor
       ADD CONSTRAINT PK_Pedido_Fornecedor PRIMARY KEY CLUSTERED (
              Id_Pedido ASC)
go


CREATE TABLE Producao (
       Dt_Producao          datetime NOT NULL,
       Id_Producao          integer NOT NULL,
       Id_Req_Materia_Prima integer NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Producao ON Producao
(
       Id_Req_Materia_Prima           ASC
)
go

CREATE INDEX XIF2Producao ON Producao
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Producao
       ADD CONSTRAINT PK_Producao PRIMARY KEY CLUSTERED (Id_Producao ASC)
go


CREATE TABLE Produto (
       Id_Produto           integer NOT NULL,
       Nm_Produto           varchar(80) NOT NULL,
       Ds_Produto           varchar(255) NOT NULL,
       Vl_Produto           numeric(8,2) NOT NULL,
       Qt_Produto           integer NOT NULL,
       Qt_Minima            integer NOT NULL,
       Qt_Comprometida      integer NOT NULL,
       Peso                 varchar(20) NULL,
       Tamanho              varchar(60) NULL
)
go


ALTER TABLE Produto
       ADD CONSTRAINT PK_Produto PRIMARY KEY CLUSTERED (Id_Produto ASC)
go


CREATE TABLE Ramo_Atividade (
       Cd_Ramo              numeric(1) NOT NULL,
       Nm_Ramo              varchar(40) NOT NULL
)
go


ALTER TABLE Ramo_Atividade
       ADD CONSTRAINT PK_Ramo_Atividade PRIMARY KEY CLUSTERED (
              Cd_Ramo ASC)
go


CREATE TABLE Recebimento (
       Id_Recebimento       integer NOT NULL,
       Dt_Prevista_Recebimento datetime NOT NULL,
       Dt_Recebimento       datetime NULL,
       Vl_Total             numeric(8,2) NOT NULL,
       Nu_NF_Venda          integer NOT NULL,
       Id_Matricula         integer NOT NULL,
       Cd_Forma_Pagamento   numeric(1) NOT NULL
)
go

CREATE INDEX XIF1Recebimento ON Recebimento
(
       Nu_NF_Venda                    ASC
)
go

CREATE INDEX XIF2Recebimento ON Recebimento
(
       Id_Matricula                   ASC
)
go

CREATE INDEX XIF3Recebimento ON Recebimento
(
       Cd_Forma_Pagamento             ASC
)
go


ALTER TABLE Recebimento
       ADD CONSTRAINT PK_Recebimento PRIMARY KEY CLUSTERED (
              Id_Recebimento ASC)
go


CREATE TABLE Requisicao_Materia_Prima (
       Id_Req_Materia_Prima integer NOT NULL,
       Dt_Req_Materia_Prima datetime NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Requisicao_Materia_Prima ON Requisicao_Materia_Prima
(
       Id_Matricula                   ASC
)
go

CREATE INDEX XIF2Requisicao_Materia_Prima ON Requisicao_Materia_Prima
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Requisicao_Materia_Prima
       ADD CONSTRAINT PK_Requisicao_Materia_Prima PRIMARY KEY CLUSTERED (
              Id_Req_Materia_Prima ASC)
go


CREATE TABLE Situacao_Pedido (
       Cd_Situacao          numeric(1) NOT NULL,
       Nm_Situacao          varchar(60) NOT NULL
)
go


ALTER TABLE Situacao_Pedido
       ADD CONSTRAINT PK_Situacao_Pedido PRIMARY KEY CLUSTERED (
              Cd_Situacao ASC)
go


CREATE TABLE Sub_Menu (
       Id_Sub_Menu          integer NOT NULL,
       Nm_Sub_Menu          varchar(60) NOT NULL,
       Ativo                bit NOT NULL,
       Id_Menu              integer NOT NULL
)
go

CREATE INDEX XIF1Sub_Menu ON Sub_Menu
(
       Id_Menu                        ASC
)
go


ALTER TABLE Sub_Menu
       ADD CONSTRAINT PK_Sub_Menu PRIMARY KEY CLUSTERED (Id_Sub_Menu ASC)
go


CREATE TABLE Tipo_Telefone (
       Cd_Tipo_Telefone     numeric(1) NOT NULL,
       Ds_Tipo_Telefone     varchar(20) NOT NULL
)
go


ALTER TABLE Tipo_Telefone
       ADD CONSTRAINT PK_Tipo_Telefone PRIMARY KEY CLUSTERED (
              Cd_Tipo_Telefone ASC)
go


CREATE TABLE Usuario_Sistema (
       Login                varchar(8) NOT NULL,
       Senha                char(8) NOT NULL,
       Id_Matricula         integer NOT NULL
)
go

CREATE INDEX XIF1Usuario_Sistema ON Usuario_Sistema
(
       Id_Matricula                   ASC
)
go


ALTER TABLE Usuario_Sistema
       ADD CONSTRAINT PK_Usuario_Sistema PRIMARY KEY CLUSTERED (Login ASC)
go


CREATE TABLE Usuario_Sistema_Sub_Menu (
       Login                varchar(8) NOT NULL,
       Id_Sub_Menu          integer NOT NULL
)
go

CREATE INDEX XIF1Usuario_Sistema_Sub_Menu ON Usuario_Sistema_Sub_Menu
(
       Login                          ASC
)
go

CREATE INDEX XIF2Usuario_Sistema_Sub_Menu ON Usuario_Sistema_Sub_Menu
(
       Id_Sub_Menu                    ASC
)
go


ALTER TABLE Usuario_Sistema_Sub_Menu
       ADD CONSTRAINT PK_Usuario_Sistema_Sub_Menu PRIMARY KEY CLUSTERED (
              Login ASC, Id_Sub_Menu ASC)
go


ALTER TABLE Cliente
       ADD CONSTRAINT FK_FUNCIONARIO_CLIENTE
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Cliente_Pessoa_Fisica
       ADD CONSTRAINT FK_CLIENTE_PF_CLIENTE
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Cliente_Pessoa_Juridica
       ADD CONSTRAINT FK_RAMO_ATIVIDADE_CLIENTE_PJ
              FOREIGN KEY (Cd_Ramo)
                             REFERENCES Ramo_Atividade  (Cd_Ramo)
go


ALTER TABLE Cliente_Pessoa_Juridica
       ADD CONSTRAINT FK_CLIENTE_PJ_CLIENTE
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Cliente_Telefone
       ADD CONSTRAINT FK_TIPO_TELEFONE_CLIENTE_TELEFONE
              FOREIGN KEY (Cd_Tipo_Telefone)
                             REFERENCES Tipo_Telefone  (
              Cd_Tipo_Telefone)
go


ALTER TABLE Cliente_Telefone
       ADD CONSTRAINT FK_CLIENTE_CLIENTE_TELEFONE
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Contato_Cliente
       ADD CONSTRAINT FK_FUNCIONARIO_CONTATO_CLIENTE
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Contato_Cliente
       ADD CONSTRAINT FK_CLIENTE_CONTATO_CLIENTE
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Contato_Cliente_Telefone
       ADD CONSTRAINT FK_TIPO_TELEFONE_CONTATO_CLIENTE_TELEFONE
              FOREIGN KEY (Cd_Tipo_Telefone)
                             REFERENCES Tipo_Telefone  (
              Cd_Tipo_Telefone)
go


ALTER TABLE Contato_Cliente_Telefone
       ADD CONSTRAINT FK_CONTATO_CLIENTE_CONTATO_CLI_TELEFONE
              FOREIGN KEY (Id_Contato)
                             REFERENCES Contato_Cliente  (Id_Contato)
go


ALTER TABLE Contato_Fornecedor
       ADD CONSTRAINT FK_FUNCIONARIO_CONTATO_FORNECEDOR
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Contato_Fornecedor
       ADD CONSTRAINT FK_FORNECEDOR_CONTATO_FORNECEDOR
              FOREIGN KEY (Id_Fornecedor)
                             REFERENCES Fornecedor  (Id_Fornecedor)
go


ALTER TABLE Contato_Fornecedor_Telefone
       ADD CONSTRAINT FK_TIPO_TELEFONE_CONTATO_FORNECEDOR_TELEFONE
              FOREIGN KEY (Cd_Tipo_Telefone)
                             REFERENCES Tipo_Telefone  (
              Cd_Tipo_Telefone)
go


ALTER TABLE Contato_Fornecedor_Telefone
       ADD CONSTRAINT FK_CONTATO_FORNECEDOR_CONTATO_FORN_TELEFONE
              FOREIGN KEY (Id_Contato)
                             REFERENCES Contato_Fornecedor  (
              Id_Contato)
go


ALTER TABLE Endereco_Entrega
       ADD CONSTRAINT FK_CLIENTE_ENDERECO_ENTREGA
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Fornecedor
       ADD CONSTRAINT FK_FUNCIONARIO_FORNECEDOR
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Fornecedor
       ADD CONSTRAINT FK_RAMO_ATIVIDADE_FORNECEDOR
              FOREIGN KEY (Cd_Ramo)
                             REFERENCES Ramo_Atividade  (Cd_Ramo)
go


ALTER TABLE Fornecedor_Materia_Prima
       ADD CONSTRAINT FK_MATERIA_PRIMA_FORNEC_MAT_PRIMA
              FOREIGN KEY (Id_Materia_Prima)
                             REFERENCES Materia_Prima  (
              Id_Materia_Prima)
go


ALTER TABLE Fornecedor_Materia_Prima
       ADD CONSTRAINT FK_FORNECEDOR_FORNEC_MAT_PRIMA
              FOREIGN KEY (Id_Fornecedor)
                             REFERENCES Fornecedor  (Id_Fornecedor)
go


ALTER TABLE Fornecedor_Telefone
       ADD CONSTRAINT FK_TIPO_TELEFONE_FORNECEDOR_TELEFONE
              FOREIGN KEY (Cd_Tipo_Telefone)
                             REFERENCES Tipo_Telefone  (
              Cd_Tipo_Telefone)
go


ALTER TABLE Fornecedor_Telefone
       ADD CONSTRAINT FK_FORNECEDOR_FORNECEDOR_TELEFONE
              FOREIGN KEY (Id_Fornecedor)
                             REFERENCES Fornecedor  (Id_Fornecedor)
go


ALTER TABLE Funcionario
       ADD CONSTRAINT FK_CARGO_FUNCIONARIO
              FOREIGN KEY (Cd_Cargo)
                             REFERENCES Cargo  (Cd_Cargo)
go


ALTER TABLE Funcionario
       ADD CONSTRAINT FK_DEPARTAMENTO_FUNCIONARIO
              FOREIGN KEY (Cd_Departamento)
                             REFERENCES Departamento  (
              Cd_Departamento)
go


ALTER TABLE Item_NF_Compra
       ADD CONSTRAINT FK_MATERIA_PRIMA_ITEM_NF_COMPRA
              FOREIGN KEY (Id_Materia_Prima)
                             REFERENCES Materia_Prima  (
              Id_Materia_Prima)
go


ALTER TABLE Item_NF_Compra
       ADD CONSTRAINT FK_NF_COMPRA_ITEM_NF_COMPRA
              FOREIGN KEY (Id_NF_Compra)
                             REFERENCES NF_Compra  (Id_NF_Compra)
go


ALTER TABLE Item_NF_Venda
       ADD CONSTRAINT FK_PRODUTO_ITEM_NF_VENDA
              FOREIGN KEY (Id_Produto)
                             REFERENCES Produto  (Id_Produto)
go


ALTER TABLE Item_NF_Venda
       ADD CONSTRAINT FK_NF_VENDA_ITEM_NF_VENDA
              FOREIGN KEY (Nu_NF_Venda)
                             REFERENCES NF_Venda  (Nu_NF_Venda)
go


ALTER TABLE Item_Pedido
       ADD CONSTRAINT FK_PRODUTO_ITEM_PEDIDO
              FOREIGN KEY (Id_Produto)
                             REFERENCES Produto  (Id_Produto)
go


ALTER TABLE Item_Pedido
       ADD CONSTRAINT FK_PEDIDO_ITEM_PEDIDO
              FOREIGN KEY (Nu_Pedido)
                             REFERENCES Pedido  (Nu_Pedido)
go


ALTER TABLE Item_Pedido_Fornecedor
       ADD CONSTRAINT FK_MATERIA_PRIMA_ITEM_PED_FORNEC
              FOREIGN KEY (Id_Materia_Prima)
                             REFERENCES Materia_Prima  (
              Id_Materia_Prima)
go


ALTER TABLE Item_Pedido_Fornecedor
       ADD CONSTRAINT FK_PEDIDO_FORNECEDOR_ITEM_PED_FORNEC
              FOREIGN KEY (Id_Pedido)
                             REFERENCES Pedido_Fornecedor  (Id_Pedido)
go


ALTER TABLE Item_Producao
       ADD CONSTRAINT FK_PRODUCAO_ITEM_PRODUCAO
              FOREIGN KEY (Nu_Item_Producao)
                             REFERENCES Producao  (Id_Producao)
go


ALTER TABLE Item_Producao
       ADD CONSTRAINT FK_PRODUTO_ITEM_PRODUCAO
              FOREIGN KEY (Id_Produto)
                             REFERENCES Produto  (Id_Produto)
go


ALTER TABLE Item_Req_Materia_Prima
       ADD CONSTRAINT FK_MATERIA_PRIMA_ITEM_REQ_MAT_PRIMA
              FOREIGN KEY (Id_Materia_Prima)
                             REFERENCES Materia_Prima  (
              Id_Materia_Prima)
go


ALTER TABLE Item_Req_Materia_Prima
       ADD CONSTRAINT FK_REQUISICAO_MAT_PRIMA_ITEM_REQ_MAT_PRIMA
              FOREIGN KEY (Id_Req_Materia_Prima)
                             REFERENCES Requisicao_Materia_Prima  (
              Id_Req_Materia_Prima)
go


ALTER TABLE Menu
       ADD CONSTRAINT FK_CATEGORIA_MENU_CATEGORIA
              FOREIGN KEY (Id_Categoria)
                             REFERENCES Categoria_Menu  (Id_Categoria)
go


ALTER TABLE NF_Compra
       ADD CONSTRAINT FK_FUNCIONARIO_NF_COMPRA
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE NF_Compra
       ADD CONSTRAINT FK_FORNECEDOR_NF_COMPRA
              FOREIGN KEY (Id_Fornecedor)
                             REFERENCES Fornecedor  (Id_Fornecedor)
go


ALTER TABLE NF_Venda
       ADD CONSTRAINT FK_FUNCIONARIO_NF_VENDA
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE NF_Venda
       ADD CONSTRAINT FK_CLIENTE_NF_VENDA
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Pagamento
       ADD CONSTRAINT FK_FORMA_PAGAMENTO_PAGAMENTO
              FOREIGN KEY (Cd_Forma_Pagamento)
                             REFERENCES Forma_Pagamento  (
              Cd_Forma_Pagamento)
go


ALTER TABLE Pagamento
       ADD CONSTRAINT FK_FUNCIONARIO_PAGAMENTO
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Pagamento
       ADD CONSTRAINT FK_NF_COMPRA_PAGAMENTO
              FOREIGN KEY (Id_NF_Compra)
                             REFERENCES NF_Compra  (Id_NF_Compra)
go


ALTER TABLE Pedido
       ADD CONSTRAINT FK_NF_VENDA_PEDIDO
              FOREIGN KEY (Nu_NF_Venda)
                             REFERENCES NF_Venda  (Nu_NF_Venda)
go


ALTER TABLE Pedido
       ADD CONSTRAINT FK_FUNCIONARIO_PEDIDO
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Pedido
       ADD CONSTRAINT FK_ENDERECO_ENTREGA_PEDIDO
              FOREIGN KEY (Id_Endereco)
                             REFERENCES Endereco_Entrega  (
              Id_Endereco)
go


ALTER TABLE Pedido
       ADD CONSTRAINT FK_CLIENTE_PEDIDO
              FOREIGN KEY (Id_Cliente)
                             REFERENCES Cliente  (Id_Cliente)
go


ALTER TABLE Pedido
       ADD CONSTRAINT FK_SITUACAO_PEDIDO_PEDIDO
              FOREIGN KEY (Cd_Situacao)
                             REFERENCES Situacao_Pedido  (Cd_Situacao)
go


ALTER TABLE Pedido_Fornecedor
       ADD CONSTRAINT FK_NF_COMPRA_PEDIDO_FORNECEDOR
              FOREIGN KEY (Id_NF_Compra)
                             REFERENCES NF_Compra  (Id_NF_Compra)
go


ALTER TABLE Pedido_Fornecedor
       ADD CONSTRAINT FK_FUNCIONARIO_PEDIDO_FORNECEDOR
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Pedido_Fornecedor
       ADD CONSTRAINT FK_FORNECEDOR_PEDIDO_FORNECEDOR
              FOREIGN KEY (Id_Fornecedor)
                             REFERENCES Fornecedor  (Id_Fornecedor)
go


ALTER TABLE Pedido_Fornecedor
       ADD CONSTRAINT FK_SITUACAO_PEDIDO_PEDIDO_FORNECEDOR
              FOREIGN KEY (Cd_Situacao)
                             REFERENCES Situacao_Pedido  (Cd_Situacao)
go


ALTER TABLE Producao
       ADD CONSTRAINT FK_FUNCIONARIO_PRODUCAO
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Producao
       ADD CONSTRAINT FK_REQUISICAO_MAT_PRIMA_PRODUCAO
              FOREIGN KEY (Id_Req_Materia_Prima)
                             REFERENCES Requisicao_Materia_Prima  (
              Id_Req_Materia_Prima)
go


ALTER TABLE Recebimento
       ADD CONSTRAINT FK_FORMA_PAGAMENTO_RECEBIMENTO
              FOREIGN KEY (Cd_Forma_Pagamento)
                             REFERENCES Forma_Pagamento  (
              Cd_Forma_Pagamento)
go


ALTER TABLE Recebimento
       ADD CONSTRAINT FK_FUNCIONARIO_RECEBIMENTO
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Recebimento
       ADD CONSTRAINT FK_NF_VENDA_RECEBIMENTO
              FOREIGN KEY (Nu_NF_Venda)
                             REFERENCES NF_Venda  (Nu_NF_Venda)
go


ALTER TABLE Requisicao_Materia_Prima
       ADD CONSTRAINT FK_FUNCIONARIO_REQUIS_MAT_PRIMA
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Requisicao_Materia_Prima
       ADD CONSTRAINT FK_FUNCIONARIO_REQUISICAO_MAT_PRIMA
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Sub_Menu
       ADD CONSTRAINT FK_MENU_SUB_MENU
              FOREIGN KEY (Id_Menu)
                             REFERENCES Menu  (Id_Menu)
go


ALTER TABLE Usuario_Sistema
       ADD CONSTRAINT FK_FUNCIONARIO_USUARIO_SISTEMA
              FOREIGN KEY (Id_Matricula)
                             REFERENCES Funcionario  (Id_Matricula)
go


ALTER TABLE Usuario_Sistema_Sub_Menu
       ADD CONSTRAINT FK_SUB_MENU_USUARIO_SISTEMA_SUB_MENU
              FOREIGN KEY (Id_Sub_Menu)
                             REFERENCES Sub_Menu  (Id_Sub_Menu)
go


ALTER TABLE Usuario_Sistema_Sub_Menu
       ADD CONSTRAINT FK_USUARIO_SISTEMA_USUARIO_SISTEMA_SUB_MENU
              FOREIGN KEY (Login)
                             REFERENCES Usuario_Sistema  (Login)
go



