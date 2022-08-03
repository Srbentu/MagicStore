using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicStore.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Batalha por Portal de Baldur', 'Coleção baseada em D&D') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Double Masters 2022', 'Coleção de Double Masters') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Ruas de Nova Capenna', 'Coleção de Ruas de Nova Capenna') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('A Guerra da Centelha', 'Coleção de A Guerra da Centelha') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Commander Anthology 2018', 'Coleção de Commander Anthology 2018') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Commander 2019', 'Coleção de Commander 2019') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Modern Horizons', 'Coleção de Modern Horizons') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Kamigawa: Dinastia Neon', 'Coleção de Kamigawa: Dinastia Neon') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Ultimate Masters', 'Coleção de Ultimate Masters') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Kaldheim Commander', 'Coleção de Kaldheim Commander') ");
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, Description) "+
                                 "Values('Innistrad: Voto Carmesim', 'Coleção de Innistrad: Voto Carmesim') ");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
