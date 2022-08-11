using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicStore.Migrations
{
    /// <inheritdoc />
    public partial class PopularCartas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(1,'Miirym, Dragão Sentinela', 'Criatura', 'Multicolorida', 'Criatura Dragão', 'Criatura Dragão 6/6', 31.90, 'https://repositorio.sbrauble.com/arquivos/in/magic/479917/628e4fe98f359-s57bi-lviu7-1569054691628e4fe98f3b3.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479917/628e4fe98f359-s57bi-lviu7-1569054691628e4fe98f3b3.jpg', 1, 0) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(11, 'Herança Honrada', 'Artefato', 'Incolor', 'Artefato Incolor', 'Artefato Incolo que gera mana', .25, 'https://repositorio.sbrauble.com/arquivos/in/magic/479876/6182cf871a7a4-f0vku-eupji-3458174446182cf871a7e8.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479876/6182cf871a7a4-f0vku-eupji-3458174446182cf871a7e8.jpg', 0, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(10, 'Sorte Inesperada', 'Feitiço', 'Azul', 'Feitiço', 'Feitiço que compra card', 11.53, 'https://repositorio.sbrauble.com/arquivos/in/magic/479837/600feeffebf73-feypz-5lwpt-1635089442600feeffebfd1.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479837/600feeffebf73-feypz-5lwpt-1635089442600feeffebfd1.jpg', 0, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(9, 'Xamã da Fauna', 'Criatura', 'Verde', 'Criatura Elfa', 'Criatura Elfa tutora',57.00, 'https://repositorio.sbrauble.com/arquivos/in/magic/479741/5f424428a38b8-w26v18-7txzsf-fa7cdfad1a5aaf8370ebeda47a1ff1c3.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479741/5f424428a38b8-w26v18-7txzsf-fa7cdfad1a5aaf8370ebeda47a1ff1c3.jpg', 1, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(9, 'Pátio Reservado', 'Terreno', 'Incolor', 'Terreno', 'Terreno de criatura', 18.00, 'https://repositorio.sbrauble.com/arquivos/in/magic/479890/61f4504d958cf-ep6d8-enqlm-169969218261f4504d9591a.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479890/61f4504d958cf-ep6d8-enqlm-169969218261f4504d9591a.jpg', 0, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(7, 'Talismã da Curiosidade', 'Artefato', 'Incolor', 'Artefato', 'Artefato que gera mana', 2.1, 'https://repositorio.sbrauble.com/arquivos/in/magic/479760/5f42442dc5daf-1euspl-0p13fg-be83ab3ecd0db773eb2dc1b0a17836a1.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479760/5f42442dc5daf-1euspl-0p13fg-be83ab3ecd0db773eb2dc1b0a17836a1.jpg', 0, 0) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(2, 'Dragão Avérneo do Retrofluxo', 'Criatura', 'Vermelha', 'Criatura Dragão', 'Criatura Dragão 4/4', 12.90, 'https://repositorio.sbrauble.com/arquivos/in/magic/479983/62b1eb9d6b9ab-sqayj-17fxp-140212974162b1eb9d6b9f0.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479983/62b1eb9d6b9ab-sqayj-17fxp-140212974162b1eb9d6b9f0.jpg', 0, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(1, 'Dragão de Prata Ancião', 'Criatura', 'Azul', 'Criatura Dragão', 'Criatura Dragão 8/8', 340.00, 'https://repositorio.sbrauble.com/arquivos/in/magic/479913/628e5036e74fb-uxqop-zrp69-2139738615628e5036e7545.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479913/628e5036e74fb-uxqop-zrp69-2139738615628e5036e7545.jpg', 1, 1) ");
            migrationBuilder.Sql("INSERT INTO Cartas(CategoriaId, Nome, CartaTipo, CartaCor, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsCartaPreferida, EmEstoque) "+
                                 "Values(2, 'Caverna das Almas', 'Terreno', 'Incolor', 'terreno', 'Terreno mágico', 968.00, 'https://repositorio.sbrauble.com/arquivos/in/magic/479984/62acf8a36dc57-04w63-8d9je-133740474962acf8a36dca2.jpg', 'https://repositorio.sbrauble.com/arquivos/in/magic/479984/62acf8a36dc57-04w63-8d9je-133740474962acf8a36dca2.jpg', 0, 1) ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cartas");
        }
    }
}
