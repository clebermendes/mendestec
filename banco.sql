USE [Mendes_varejo]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeId] [int] NOT NULL,
	[Nome] [varchar](38) NOT NULL,
	[EstadoId] [tinyint] NULL,
	[Capital] [bit] NOT NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CidadeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[EstadoId] [tinyint] NOT NULL,
	[Sigla] [char](2) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[EstadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[codigo] [bigint] NOT NULL,
	[nome] [nvarchar](50) NULL,
	[nomeFantasia] [nvarchar](50) NULL,
	[cnpj] [nvarchar](15) NULL,
	[telefone] [nvarchar](15) NULL,
	[email] [nvarchar](50) NULL,
	[complemento] [nvarchar](100) NULL,
	[bairro] [nvarchar](50) NULL,
	[numero] [nvarchar](20) NULL,
	[cep] [nvarchar](9) NULL,
	[cidade_id] [int] NOT NULL,
	[estado_id] [tinyint] NOT NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pagamento]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento](
	[codigo] [bigint] NOT NULL,
	[descricao] [nvarchar](25) NULL,
 CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produto]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[codigo] [bigint] NOT NULL,
	[cod_ref] [bigint] NOT NULL,
	[codBarras] [nvarchar](20) NOT NULL,
	[produto_nome] [nvarchar](50) NULL,
	[fornecedor_id] [bigint] NOT NULL,
	[qtde] [bigint] NULL,
	[precoFinal] [float] NULL,
	[precoInicial] [float] NULL,
	[tamanho] [nvarchar](10) NOT NULL,
	[tipo_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[codigo] [bigint] NOT NULL,
	[nome_tipo] [nvarchar](20) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[codigo] [bigint] NOT NULL,
	[nome] [nvarchar](50) NULL,
	[login] [nvarchar](20) NULL,
	[cpf] [bigint] NULL,
	[senha] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[codigo] [bigint] NOT NULL,
	[dataEmissao] [date] NULL,
	[valorTotal] [float] NULL,
	[pagamento_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendas_Produtos]    Script Date: 15/10/2015 16:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas_Produtos](
	[codigo_produto] [bigint] NOT NULL,
	[codigo_venda] [bigint] NOT NULL,
	[total] [float] NULL,
	[qtdeItens] [int] NULL,
 CONSTRAINT [PK_vendas_produtos] PRIMARY KEY CLUSTERED 
(
	[codigo_produto] ASC,
	[codigo_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([EstadoId])
REFERENCES [dbo].[Estado] ([EstadoId])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Estado]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Cidade] FOREIGN KEY([cidade_id])
REFERENCES [dbo].[Cidade] ([CidadeId])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Cidade]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Estado] FOREIGN KEY([estado_id])
REFERENCES [dbo].[Estado] ([EstadoId])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Estado]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Fornecedor] FOREIGN KEY([fornecedor_id])
REFERENCES [dbo].[Fornecedor] ([codigo])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Fornecedor]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Tipo] FOREIGN KEY([tipo_id])
REFERENCES [dbo].[Tipo] ([codigo])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Tipo]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [fk_Pagamentos] FOREIGN KEY([pagamento_id])
REFERENCES [dbo].[Pagamento] ([codigo])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [fk_Pagamentos]
GO
ALTER TABLE [dbo].[Vendas_Produtos]  WITH CHECK ADD  CONSTRAINT [Fk_vendas_produtos_code] FOREIGN KEY([codigo_produto])
REFERENCES [dbo].[Produto] ([codigo])
GO
ALTER TABLE [dbo].[Vendas_Produtos] CHECK CONSTRAINT [Fk_vendas_produtos_code]
GO
ALTER TABLE [dbo].[Vendas_Produtos]  WITH CHECK ADD  CONSTRAINT [Fk_vendas_produtos_vendas] FOREIGN KEY([codigo_venda])
REFERENCES [dbo].[Vendas] ([codigo])
GO
ALTER TABLE [dbo].[Vendas_Produtos] CHECK CONSTRAINT [Fk_vendas_produtos_vendas]
GO
