CREATE DATABASE PracticeInClassDB
GO
USE PracticeInClassDB
GO
CREATE TABLE Products (
  Id INT PRIMARY KEY IDENTITY(1,1),
  CreatedBy INT NULL,
  UpdateBy INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME NULL,
    DeletedDate DATETIME NULL,
    IsDeleted BIT DEFAULT 0,
       Name NVARCHAR(255) NOT NULL,
    Type NVARCHAR(100) NOT NULL,
    Barcode NVARCHAR(50) NOT NULL UNIQUE,
    Price DECIMAL(18,2) NOT NULL,
    OpenPrice BIT NOT NULL DEFAULT 0,
    ButtonColor NVARCHAR(20) NOT NULL,
    TextColor NVARCHAR(20) NOT NULL,
    InvoiceNumber NVARCHAR(100) NULL
)

GO 
CREATE TABLE Ingredients (
    Id INT PRIMARY KEY IDENTITY(1,1),
    
    
    CreatedBy INT NULL,
    UpdatedBy INT NULL,
    DeletedBy INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME NULL,
    DeletedDate DATETIME NULL,
    IsDeleted BIT DEFAULT 0,

   
    Name NVARCHAR(255) NOT NULL,
    Type NVARCHAR(100) NOT NULL,
    Barcode NVARCHAR(50) NOT NULL UNIQUE,
    Price DECIMAL(18,2) NOT NULL,
    OpenPrice BIT NOT NULL DEFAULT 0,
    ButtonColor NVARCHAR(20) NOT NULL,
    TextColor NVARCHAR(20) NOT NULL,
    InvoiceNumber NVARCHAR(100) NULL,

   
    MinimumCount INT NOT NULL,
    MaksimumCount INT NOT NULL,
    FreeIngredientCount INT NOT NULL
);

GO
CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY(1,1),

    
    CreatedBy INT NULL,
    UpdatedBy INT NULL,
    DeletedBy INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME NULL,
    DeletedDate DATETIME NULL,
    IsDeleted BIT DEFAULT 0,

    
    Name NVARCHAR(255) NOT NULL UNIQUE
);

GO 
CREATE TABLE AllergenGroups (
    Id INT PRIMARY KEY IDENTITY(1,1),

   
    CreatedBy INT NULL,
    UpdatedBy INT NULL,
    DeletedBy INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME NULL,
    DeletedDate DATETIME NULL,
    IsDeleted BIT DEFAULT 0,

    
    Name NVARCHAR(255) NOT NULL UNIQUE,
    Code NVARCHAR(50) NOT NULL UNIQUE
);

GO

CREATE TABLE IngredientAllergenGroups(
  IngredinetId INT NOT NULL,
  AllergenGroupId INT NOT NULL,
  PRIMARY KEY (IngredinetId,AllergenGroupId),
  FOREIGN KEY (IngredinetId) REFERENCES Ingredients(Id) ON DELETE CASCADE,
  FOREIGN KEY (AllergenGroupId) REFERENCES AllergenGroups(Id) ON DELETE CASCADE
)

GO
CREATE TABLE IngredientDepartaments(
  IngredinetId INT NOT NULL,
  DepartmentId INT NOT NULL,
  PRIMARY KEY (IngredinetId,DepartmentId),
  FOREIGN KEY (IngredinetId) REFERENCES Ingredients(Id) ON DELETE CASCADE,
  FOREIGN KEY (DepartmentId) REFERENCES Departments(Id) ON DELETE CASCADE
)

GO
CREATE TABLE IngredientProducts(
  IngredinetId INT NOT NULL,
  ProductId INT NOT NULL,
  PRIMARY KEY (IngredinetId,ProductId),
  FOREIGN KEY (IngredinetId) REFERENCES Ingredients(Id) ON DELETE CASCADE,
  FOREIGN KEY (ProductId) REFERENCES Products(Id) ON DELETE CASCADE
)

GO
CREATE TABLE ProductDepartments
(
  DeparmentId INT NOT NULL,
  ProductId INT NOT NULL,
  PRIMARY KEY (DeparmentId,ProductId),
  FOREIGN KEY (DeparmentId) REFERENCES Departments(Id) ON DELETE CASCADE,
  FOREIGN KEY (ProductId) REFERENCES Products(Id) ON DELETE CASCADE
)





