# Gerenciador-de-Academia - TCC - EM DESENVOLVIMENTO
Este projeto contém uma solução para auxiliar profissionais autônomos na rotina de gerenciamento de academias de musculação. Fornecendo ferramentas para cadastro de alunos, medidas musculares, peso e entre outras coisas. Também, auxilia o gestor na tomada de decições de negócio a partir da análise gráfica de informações sobre faturamento, quantidade de alunos, contas a receber, etc.

## Ambiente
O projeto consiste em uma aplicação C# Desktop Windows Forms com uma interface totalmente intuitiva ao gestor.

## DataBase
A seguir você encontrará scripts para a criação das tabelas em SQL.

### Tabela Novo Aluno
```SQL
CREATE TABLE [dbo].[NovoAluno](
	[IDNOVOALUNO] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](50) NOT NULL,
	[DT_NASC] [date] NOT NULL,
	[SEXO] [char](1) NOT NULL,
	[RG] [varchar](12) NOT NULL,
	[CPF] [varchar](15) NOT NULL,
	[TELEFONE] [varchar](15) NOT NULL,
	[WHATSAPP] [varchar](1) NOT NULL,
	[ENDEREÇO] [varchar](100) NOT NULL,
	[NÚMERO] [varchar](5) NOT NULL,
	[BAIRRO] [varchar](10) NOT NULL,
	[UF] [varchar](2) NOT NULL,
	[CEP] [varchar](9) NOT NULL,
	[CIDADE] [varchar](18) NOT NULL,
	[DT_MATRÍC] [date] NOT NULL,
	[MARKETING] [varchar](20) NULL,
	[EMAIL] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNOVOALUNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TELEFONE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
```
### Tabela Pagamento
```SQL
CREATE TABLE [dbo].[Pagamento](
	[IDPAGAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[PLANO] [varchar](10) NOT NULL,
	[VALOR] [varchar](8) NOT NULL,
	[DT_PAG] [date] NULL,
	[STATUS] [varchar](5) NULL,
	[DT_VENC] [date] NOT NULL,
	[PRÓX_PAG] [date] NOT NULL,
	[ID_NOVOALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPAGAMENTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pagamento]  WITH CHECK ADD FOREIGN KEY([ID_NOVOALUNO])
REFERENCES [dbo].[NovoAluno] ([IDNOVOALUNO])
GO
```
### Tabela Pagamentos Para Receber
```SQL
CREATE TABLE [dbo].[PagamentosParaReceber](
	[IDPagamentosParaReceber] [int] IDENTITY(1,1) NOT NULL,
	[PLANO] [varchar](10) NOT NULL,
	[VALOR] [varchar](8) NOT NULL,
	[DT_PAG] [date] NULL,
	[STATUS] [varchar](5) NOT NULL,
	[DT_VENC] [date] NOT NULL,
	[ID_NOVOALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPagamentosParaReceber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PagamentosParaReceber]  WITH CHECK ADD FOREIGN KEY([ID_NOVOALUNO])
REFERENCES [dbo].[NovoAluno] ([IDNOVOALUNO])
GO
```
### Tabela Medidas Aluno
```SQL
CREATE TABLE [dbo].[MedidasAluno](
	[IDMEDIDASALUNO] [int] IDENTITY(1,1) NOT NULL,
	[ALTURA] [varchar](6) NULL,
	[TÓRAX] [varchar](6) NULL,
	[ABDÔMEN] [varchar](6) NULL,
	[CINTURA] [varchar](6) NULL,
	[QUADRIL] [varchar](6) NULL,
	[BRAÇO_DIREITO] [varchar](6) NULL,
	[BRAÇO_ESQUERDO] [varchar](6) NULL,
	[ANTEBRAÇO_DIREITO] [varchar](6) NULL,
	[ANTEBRAÇO_ESQUERDO] [varchar](6) NULL,
	[COXA_DIREITA_P] [varchar](6) NULL,
	[COXA_DIREITA_M] [varchar](6) NULL,
	[COXA_DIREITA_D] [varchar](6) NULL,
	[COXA_ESQUERDA_P] [varchar](6) NULL,
	[COXA_ESQUERDA_M] [varchar](6) NULL,
	[COXA_ESQUERDA_D] [varchar](6) NULL,
	[PERNA_DIREITA] [varchar](6) NULL,
	[PERNA_ESQUERDA] [varchar](6) NULL,
	[OMBROS] [varchar](6) NULL,
	[PESCOÇO] [varchar](6) NULL,
	[PUNHO] [varchar](6) NULL,
	[JOELHO] [varchar](6) NULL,
	[TORNOZELO] [varchar](6) NULL,
	[DT_COLETA] [date] NULL,
	[ID_NOVOALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMEDIDASALUNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MedidasAluno]  WITH CHECK ADD FOREIGN KEY([ID_NOVOALUNO])
REFERENCES [dbo].[NovoAluno] ([IDNOVOALUNO])
GO
```
### Tabela Ficha de Treino
```SQL
CREATE TABLE [dbo].[FichaDeTreino](
	[IDFICHATREINO] [int] IDENTITY(1,1) NOT NULL,
	[DT_COLETA] [date] NULL,
	[A_MUSC] [varchar](40) NULL,
	[A_DIA] [varchar](40) NULL,
	[B_MUSC] [varchar](40) NULL,
	[B_DIA] [varchar](40) NULL,
	[C_MUSC] [varchar](40) NULL,
	[C_DIA] [varchar](40) NULL,
	[D_MUSC] [varchar](40) NULL,
	[D_DIA] [varchar](40) NULL,
	[E_MUSC] [varchar](40) NULL,
	[E_DIA] [varchar](40) NULL,
	[ID_NOVOALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFICHATREINO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ID_NOVOALUNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[FichaDeTreino]  WITH CHECK ADD FOREIGN KEY([ID_NOVOALUNO])
REFERENCES [dbo].[NovoAluno] ([IDNOVOALUNO])
GO
```
### Tabela Peso
```SQL
CREATE TABLE [dbo].[Peso](
	[IDPESO] [int] IDENTITY(1,1) NOT NULL,
	[DT_COLETA] [date] NOT NULL,
	[PESO] [decimal](18, 2) NOT NULL,
	[ID_NOVOALUNO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPESO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Peso]  WITH CHECK ADD FOREIGN KEY([ID_NOVOALUNO])
REFERENCES [dbo].[NovoAluno] ([IDNOVOALUNO])
GO
```
