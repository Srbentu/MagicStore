using MagicStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Carta> Cartas { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    
    public DbSet<Pedido> Pedidos { get; set; }
    
    public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
}