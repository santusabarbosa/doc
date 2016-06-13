# Padrão de banco de dados

Siga as instruções neste documento ao criar um novo banco de dados ou alterar algum existente.

## SQL Server

Assegure que seus scripts suportem SQL Server, mínimo versão 2008 e máximo versão 2012.

## Palavras-chave

Coloque palavras-chave (`CREATE`, `INT`, `IDENTITY`, `GO`, ...) em maiúsculo em seus scripts.

## Scripts limpos

Ao utilizar alguma ferramenta que gere scripts, lembre-se de "limpar" instruções desnecessárias.

Troque:

```sql
CREATE TABLE [dbo].[tb_USUARIO](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](200) NOT NULL,
	[ID_TipoUsuario] [int] NOT NULL,
	[CpfOuCnpj] [nvarchar](14) NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tb_USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_TIPO_USUARIO] FOREIGN KEY([ID_TipoUsuario])
REFERENCES [dbo].[tbt_TIPO_USUARIO] ([ID_TipoUsuario])
GO

ALTER TABLE [dbo].[tb_USUARIO] CHECK CONSTRAINT [FK_USUARIO_TIPO_USUARIO]
GO
```

Por:

```sql
CREATE TABLE tb_USUARIO (
	ID_Usuario INT NOT NULL CONSTRAINT PK_USUARIO PRIMARY KEY IDENTITY,
	Nome NVARCHAR(200) NOT NULL,
	ID_TipoUsuario INT NOT NULL CONSTRAINT FK_USUARIO_TIPO_USUARIO FOREIGN KEY REFERENCES tbt_TIPO_USUARIO(ID_TipoUsuario),
	CpfOuCnpj NVARCHAR(14) NOT NULL
);
GO
```

## Prefixos

Utilize os prefixos a abaixo ao nomear seus objetos do banco de dados.
Os prefixos devem estar em minúsculo e o restante do nome após o caractere underline em maiúsculo.

* **Tabelas**: `tb_` para tabelas que a aplicação edita registros e `tbt_` para tabelas que a aplicação não edita
registros (tabelas de tipo).
* **Stored procedures**: `sp_`.
* **Views**: `vw_`.
* **Functions**: `fn_`.
* **Job**: `job_`.
* **Triggers**: `tr_`.
* **Chaves primárias**: `pk_`.
* **Chaves estrangeiras**: `fk_`.
* **Índices**: `ix_`.
* **Constraints unique**: `un_`.
* **Contraints default**: `df_`.
* **Jobs**: Comece com o nome da base seguido por `_`.

## Nome de tabelas

Além do prefixo mencionado (`tb_` ou `tbt_`), defina o nome de suas tabelas no singular (e não no plural).

## Nome de colunas

Utilize um nome descritivo em camel case (`NomeDaColuna`).
Procure não colocar o tipo do dado no nome da coluna.

Colunas que são chave (PK ou FK) deve começar com `ID_`.
Colunas que são apenas uma data e hora de referência (timestamp) utilize apenas `Data` como nome.

## Nome de constraints

Além dos prefixos mencionados, coloque no nome das constraints os nomes das tabelas envolvidas em maiúsculo separadas
por underline.
Não deixa de nomear as suas constraints, caso contrário um nome aleatório é gerado pelo banco de dados o que dificulta a
manutenção.

## Data e hora

Prefira `DATETIME2` ao invés de `DATETIME`.

Se fizer sentido salvar apenas a hora utilize o tipo `TIME`, e no caso de somente data utilize o tipo `DATE` (não
utilize `DATETIME2` sem necessidade).

## Unicode

Utilizar Unicode evita uma série de problemas de encoding, use `NVARCHAR` ao invés de `VARCHAR`.

## Auto-incremento

Utilize `IDENTITY` (auto-incremento) somente se necessário.
Tabelas `tbt_` não devem possuí-lo.

## Senhas

Salvar senhas de usuários no banco não só é uma falha de segurança como também um desrespeito com o usuário, nunca
salve-as como texto limpo.

O ideal é que seja gerado um sal para cada usuário e que a senha seja um hash gerado por algum algoritmo de
criptografia.
O hash é gerado com a senha informada pelo usuário concatenada ao sal gerado.

## Máscaras

Salve registros como CPF ou RG como string e sem máscara (`'48519496938'` ao invés de `'485.194.969-38'` ou
`48519496938` por exemplo).

## Chaves naturais e UUID como chave

Alinhe com a equipe de banco de dados antes de utilizar chaves naturais (chaves compostas) e `UNIQUEIDENTIFIER`
([UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier)) como chave.

## Lógica no banco de dados

Crie triggers, views e stored procedures somente em último caso, o ideal é que toda a regra de negócio esteja no código
da aplicação.

## Exemplo

```sql
CREATE TABLE tbt_TIPO_USUARIO (
	ID_TipoUsuario INT NOT NULL CONSTRAINT PK_TIPO_USUARIO PRIMARY KEY,
	Descricao NVARCHAR(50) NOT NULL
);
GO

INSERT INTO tbt_TIPO_USUARIO VALUES (1, 'Pessoa Física');
INSERT INTO tbt_TIPO_USUARIO VALUES (2, 'Pessoa Jurídica');
GO

CREATE TABLE tb_USUARIO (
	ID_Usuario INT NOT NULL CONSTRAINT PK_USUARIO PRIMARY KEY IDENTITY,
	Nome NVARCHAR(200) NOT NULL,
	ID_TipoUsuario INT NOT NULL CONSTRAINT FK_USUARIO_TIPO_USUARIO FOREIGN KEY REFERENCES tbt_TIPO_USUARIO(ID_TipoUsuario),
	CpfOuCnpj NVARCHAR(14) NOT NULL
);
GO

CREATE TABLE tb_PRODUTO (
	ID_Produto INT NOT NULL CONSTRAINT PK_PRODUTO PRIMARY KEY IDENTITY,
	Nome NVARCHAR(200) NOT NULL,
	Preco SMALLMONEY NOT NULL
);
GO

CREATE TABLE tb_VENDA (
	ID_Venda INT NOT NULL CONSTRAINT PK_VENDA PRIMARY KEY IDENTITY,
	ID_Usuario INT NOT NULL CONSTRAINT FK_VENDA_USUARIO FOREIGN KEY REFERENCES tb_Usuario(ID_Usuario)
);
GO

CREATE TABLE tb_VENDA_PRODUTO (
	ID_Venda INT NOT NULL CONSTRAINT FK_VENDA_PRODUTO_VENDA FOREIGN KEY REFERENCES tb_Venda(ID_Venda),
	ID_Produto INT NOT NULL CONSTRAINT FK_VENDA_PRODUTO_PRODUTO FOREIGN KEY REFERENCES tb_Produto(ID_Produto),
	Quantidade SMALLINT NOT NULL,
	CONSTRAINT PK_VENDA_PRODUTO PRIMARY KEY (ID_Venda, ID_Produto)
);
GO
```
