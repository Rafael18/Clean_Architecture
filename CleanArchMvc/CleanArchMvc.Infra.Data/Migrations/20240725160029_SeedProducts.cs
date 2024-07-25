using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                   "VALUES ('Carderno espiral', 'Caderno espiral 100 fôlhas', 7.45, 50, 'carderno1.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                   "VALUES ('Estojo escolar', 'Estojo escolar cinza', 5.65, 70, 'estojo1.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                   "VALUES ('Borracha escolar', 'Borracha branca pequena', 3.25, 80, 'borracha1.jpg', 1)");

            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " +
                   "VALUES ('Calculadora escolar', 'Calculadora simples', 15.39, 20, 'calculadora1.jpg', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
