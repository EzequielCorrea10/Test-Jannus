USE [Test]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeId] [int] NULL,
	[Name] [varchar](50) NULL,
	[Price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_StockProducto]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_StockProducto] AS
SELECT P.Name, P.Price, PT.description
FROM Stock as S
inner join Product as P
on S.ProductId = P.Id
inner join ProductType as PT
ON P.ProductTypeId= PT.Id

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProduct]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_DeleteProduct]    

    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    -- Verificar si el producto existe
    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @Id) 
    BEGIN
        PRINT 'El producto con el ID especificado no existe.';
        RETURN;
    END;
	--Eliminarlo tanto de la product como de la Stock
    delete from Product
    WHERE Id = @Id;
	delete from Stock
    WHERE ProductId = @Id;
    PRINT 'El producto se ha eliminado correctamente.';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProducts]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetProducts]
AS
BEGIN
	Select Id,Price,Name,ProductTypeId  from Product
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductTypes]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetProductTypes]
AS
BEGIN
    Select id, description from ProductType;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProduct]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertProduct] 
@Name nvarchar(50),
@Price decimal(10,2),
@ProductTypeId int
as
BEGIN
    SET NOCOUNT ON;
Insert into Product (Price,Name, ProductTypeId) values (@Price, @Name, @ProductTypeId)
Insert into Stock(ProductId,Quantity) values (IDENT_CURRENT('Product'), (select COUNT (id) from Stock ))
END;


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProductType]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertProductType]
@Description nvarchar(50)
as
Insert into ProductType(description) values (@Description)
GO
/****** Object:  StoredProcedure [dbo].[sp_ModifyProduct]    Script Date: 3/4/2024 12:30:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModifyProduct]
    @Id INT,
    @NewName NVARCHAR(50),
    @NewPrice DECIMAL(10, 2),
	@NewTypeId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el producto existe
    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @Id)
    BEGIN
        PRINT 'El producto con el ID especificado no existe.';
        RETURN;
    END;

    -- Actualizar el nombre y el precio del producto
    UPDATE Product
    SET Name = @NewName,
        Price = @NewPrice,
		ProductTypeId = @NewTypeId
    WHERE Id = @Id;

    PRINT 'El producto se ha modificado correctamente.';
END;
GO
