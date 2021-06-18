IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [ClienteID] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Apellido] nvarchar(max) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteID])
);
GO

CREATE TABLE [Mozos] (
    [MozoID] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Mozos] PRIMARY KEY ([MozoID])
);
GO

CREATE TABLE [PedidoProducto] (
    [PedidoProductoID] int NOT NULL IDENTITY,
    [ProductoID] int NOT NULL,
    [PedidoID] int NOT NULL,
    [Cantidad] int NOT NULL,
    [Precio] int NOT NULL,
    CONSTRAINT [PK_PedidoProducto] PRIMARY KEY ([PedidoProductoID])
);
GO

CREATE TABLE [Pedidos] (
    [PedidoID] int NOT NULL IDENTITY,
    [ClienteID] int NULL,
    [MozoID] int NULL,
    [Fecha] datetime2 NOT NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([PedidoID])
);
GO

CREATE TABLE [Productos] (
    [ProductoID] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY ([ProductoID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210618182207_1', N'5.0.7');
GO

COMMIT;
GO

