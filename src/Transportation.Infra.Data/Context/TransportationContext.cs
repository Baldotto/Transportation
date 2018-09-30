using System.Data.Entity;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Transportation.Domain.Entities;
using Transportation.Infra.Data.EntityConfig;

namespace Transportation.Infra.Data.Context
{
    public class TransportationContext : DbContext 
    {

        public TransportationContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Ferrovia> Ferrovias { get; set; }
        public DbSet<ClasseVagao> ClassesVagoes { get; set; }
        public DbSet<SerieVagao> SeriesVagoes { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
        public DbSet<AreaOperacional> AreasOperacionais { get; set; }
        public DbSet<Carregamento> Carregamentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Corredor> Corredores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Fluxo> Fluxos { get; set; }
        public DbSet<GrupoFluxo> GruposFluxos { get; set; }
        public DbSet<Locomotiva> locomotivas { get; set; }
        public DbSet<Mercadoria> Mercadorias { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<SerieCarregamento> SeriesCarregamentos { get; set; }
        public DbSet<SerieLocomotiva> SeriesLocomotivas { get; set; }
        public DbSet<Trem> Trens { get; set; }
        public DbSet<UnidadeMedida> UnidadesMedidas { get; set; }
        public DbSet<Composicao> Composicoes { get; set; }
        public DbSet<ComposicaoVagao> ComposicoesVagoes { get; set; }
        public DbSet<ComposicaoLocomotiva> ComposicoesLocomotivas { get; set; }
        public DbSet<ItemCarregamento> ItensCarregamentos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            
            modelBuilder.Configurations.Add(new FerroviaConfig());

            modelBuilder.Configurations.Add(new ClasseVagaoConfig());

            modelBuilder.Configurations.Add(new SerieVagaoConfig());

            modelBuilder.Configurations.Add(new VagaoConfig());

            modelBuilder.Configurations.Add(new AbastecimentosConfig());

            modelBuilder.Configurations.Add(new AreaOperacionalConfig());

            modelBuilder.Configurations.Add(new CarregamentoConfig());

            modelBuilder.Configurations.Add(new ClienteConfig());

            modelBuilder.Configurations.Add(new CorredorConfig());

            modelBuilder.Configurations.Add(new EnderecoConfig());

            modelBuilder.Configurations.Add(new EstadoConfig());

            modelBuilder.Configurations.Add(new FluxoConfig());

            modelBuilder.Configurations.Add(new GrupoFluxoConfig());

            modelBuilder.Configurations.Add(new LocomotivaConfig());

            modelBuilder.Configurations.Add(new MercadoriaConfig());

            modelBuilder.Configurations.Add(new MovimentacaoConfig());

            modelBuilder.Configurations.Add(new NotaFiscalConfig());

            modelBuilder.Configurations.Add(new ParadaConfig());

            modelBuilder.Configurations.Add(new PedidoConfig());

            modelBuilder.Configurations.Add(new RotaConfig());

            modelBuilder.Configurations.Add(new SerieCarregamentoConfig());

            modelBuilder.Configurations.Add(new SerieLocomotivaConfig());

            modelBuilder.Configurations.Add(new TremConfig());

            modelBuilder.Configurations.Add(new UnidadeMedidaConfig());

            modelBuilder.Configurations.Add(new ComposicaoConfig());

            modelBuilder.Configurations.Add(new ComposicaoVagaoConfig());

            modelBuilder.Configurations.Add(new ComposicaoLocomotivaConfig());

            modelBuilder.Configurations.Add(new ItemCarregamentoConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            } 
            return base.SaveChanges();
        }

    }
}
