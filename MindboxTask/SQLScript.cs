
//CREATE TABLE Product
//(
//    Id INT IDENTITY PRIMARY KEY,
//    Name NVARCHAR(30) NOT NULL
//);
//CREATE TABLE Category
//(
//    Id INT IDENTITY PRIMARY KEY,
//    Name NVARCHAR(30) NOT NULL
//);
//CREATE TABLE ProductCategory
//(
//    Id INT IDENTITY PRIMARY KEY,
//    ProductId INT NOT NULL REFERENCES Product(Id) ON DELETE CASCADE,
//    CategoryId INT NOT NULL REFERENCES Category(Id) ON DELETE CASCADE
//);

//SELECT Product.Name, Category.Name
//FROM Product, Category, ProductCategory
//WHERE ProductCategory.ProductId = Product.Id AND ProductCategory.CategoryId = Category.Id
//ORDER BY Product.Name