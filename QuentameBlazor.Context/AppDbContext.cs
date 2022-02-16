using System;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Models.Entities;
using System.Configuration;
using MySql.EntityFrameworkCore;

namespace QuentameBlazor.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<ArqueoCajas> ArqueoCajas { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesAgrup1> ClientesAgrup1 { get; set; }
        public virtual DbSet<ClientesTipodoc> ClientesTipodoc { get; set; }
        public virtual DbSet<ClientesTiporeg> ClientesTiporeg { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<EmpresasResoluciones> EmpresasResoluciones { get; set; }
        public virtual DbSet<Encabezados> Encabezados { get; set; }
        public virtual DbSet<EncabezadosCostos> EncabezadosCostos { get; set; }
        public virtual DbSet<EncabezadosMov> EncabezadosMov { get; set; }
        public virtual DbSet<EncabezadosPagodet> EncabezadosPagodet { get; set; }
        public virtual DbSet<Formaspago> Formaspago { get; set; }
        public virtual DbSet<Inventarios> Inventarios { get; set; }
        public virtual DbSet<InventariosAgrup1> InventariosAgrup1 { get; set; }
        public virtual DbSet<InventariosClasifimpto> InventariosClasifimpto { get; set; }
        public virtual DbSet<InventariosFormulas> InventariosFormulas { get; set; }
        public virtual DbSet<InventariosKardex> InventariosKardex { get; set; }
        public virtual DbSet<InventariosListas> InventariosListas { get; set; }
        public virtual DbSet<InventariosPrecios> InventariosPrecios { get; set; }
        public virtual DbSet<InventariosTipos> InventariosTipos { get; set; }
        public virtual DbSet<InventariosUnidades> InventariosUnidades { get; set; }
        public virtual DbSet<InventariosUnidadesTipos> InventariosUnidadesTipos { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Prefijos> Prefijos { get; set; }
        public virtual DbSet<Puntos> Puntos { get; set; }
        public virtual DbSet<Puntosmov> Puntosmov { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Usuariostipo> Usuariostipo { get; set; }
        public virtual DbSet<UsuarioSystemConfig> UsuarioSystemConfig { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);
            } */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ArqueoCajas>(entity =>
            {
                entity.HasKey(e => e.ArqId);

                entity.ToTable("arqueo_cajas");

                entity.HasIndex(e => e.ArqId)
                    .HasDatabaseName("arq_id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("fk_arqueoencabezado");

                entity.HasIndex(e => e.IdFormaPago)
                    .HasDatabaseName("fk_arqueoformapago");

                entity.HasIndex(e => e.IdUsuario)
                    .HasDatabaseName("fk_arqueousuario");

                entity.Property(e => e.ArqId)
                    .HasColumnName("arq_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArqFecha).HasColumnName("arq_fecha");

                entity.Property(e => e.ArqEsProcesado)
                    .HasColumnName("arq_esprocesado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ArqEsBase)
                    .HasColumnName("arq_esbase")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ArqEsCerrado)
                    .HasColumnName("arq_escerrado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ArqValor)
                    .HasColumnName("arq_valor")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.IdEncab).HasColumnType("int(11)");

                entity.Property(e => e.IdFormaPago).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.ArqueoCajas)
                    .HasForeignKey(d => d.IdEncab)
                    .HasConstraintName("fk_arqueoencabezado");

                entity.HasOne(d => d.Formaspago)
                    .WithMany(p => p.ArqueoCajas)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("fk_arqueoformapago");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.ArqueoCajas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("fk_arqueousuario");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.ToTable("ciudades");

                entity.HasIndex(e => e.IdDpto)
                    .HasDatabaseName("fk_ciudaddpto");

                entity.Property(e => e.IdCiudad)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodMunicipio).HasColumnType("int(11)");

                entity.Property(e => e.EsEspecial)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdDpto).HasColumnType("int(11)");

                entity.Property(e => e.NomCiudad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdDpto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ciudaddpto");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("clientes");

                entity.HasIndex(e => e.IdAgrup1)
                    .HasDatabaseName("fk_clienteagrup1");

                entity.HasIndex(e => e.IdCiudad)
                    .HasDatabaseName("fk_clienteciudad");

                entity.HasIndex(e => e.IdCliente)
                    .HasDatabaseName("IdCliente_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdLista)
                    .HasDatabaseName("fk_clientelista");

                entity.HasIndex(e => e.IdTipoRegimen)
                    .HasDatabaseName("fk_clientetiporegimen");

                entity.HasIndex(e => new { e.IdTipoDoc, e.NumDoc })
                    .HasDatabaseName("XI_Identificacion")
                    .IsUnique();

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CupoCreditoPlazo)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CupoCreditoTiene)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CupoCreditoValor)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Direccion)
                    
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Dvcliente)
                    .HasColumnName("DVCliente")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("1000-01-01 00:00:00");

                entity.Property(e => e.FechaUltModificacion).HasDefaultValueSql("1000-01-01 00:00:00");

                entity.Property(e => e.IdAgrup1).HasColumnType("int(11)");

                entity.Property(e => e.IdCiudad).HasColumnType("int(11)");
                entity.Property(e => e.IdDpto).HasColumnType("int(11)");
                entity.Property(e => e.IdTipoDoc).HasColumnType("int(11)");

                entity.Property(e => e.IdLista).HasColumnType("int(11)");

                entity.Property(e => e.IdTipoRegimen).HasColumnType("int(11)");

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumDoc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientesAgrup1)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdAgrup1)
                    .HasConstraintName("fk_clienteagrup1");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("fk_clienteciudad");

                entity.HasOne(d => d.Dpto)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdDpto)
                    .HasConstraintName("fk_clientedpto");

                entity.HasOne(d => d.Lista)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("fk_clientelista");

                entity.HasOne(d => d.TipoRegimen)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoRegimen)
                    .HasConstraintName("fk_clientetiporegimen");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDoc)
                    .HasConstraintName("fk_clientetipodoc");
            });

            modelBuilder.Entity<ClientesAgrup1>(entity =>
            {
                entity.HasKey(e => e.IdAgrup1);

                entity.ToTable("clientes_agrup1");

                entity.HasIndex(e => e.IdAgrup1)
                    .HasDatabaseName("IdAgrup1_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdAgrup1).HasColumnType("int(11)");

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.NomAgrup1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientesTipodoc>(entity =>
            {
                entity.HasKey(e => e.IdTipoDoc);

                entity.ToTable("clientes_tipodoc");

                entity.Property(e => e.IdTipoDoc).HasColumnType("int(11)");

                entity.Property(e => e.DescripTipoDoc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoDoc)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TipoDoc).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ClientesTiporeg>(entity =>
            {
                entity.HasKey(e => e.IdTipoReg);

                entity.ToTable("clientes_tiporeg");

                entity.Property(e => e.IdTipoReg).HasColumnType("int(11)");

                entity.Property(e => e.EsActivo).HasColumnType("tinyint(4)");

                entity.Property(e => e.NomTipoReg)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.IdDpto);

                entity.ToTable("departamentos");

                entity.HasIndex(e => e.IdPais)
                    .HasDatabaseName("fk_dptopais");

                entity.Property(e => e.IdDpto)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsEspecial)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdPais).HasColumnType("int(11)");

                entity.Property(e => e.NomDpto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_dptopais");
            });

            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.HasKey(e => e.IdDoc);

                entity.ToTable("documentos");

                entity.HasIndex(e => e.IdDoc)
                    .HasDatabaseName("IdDoc_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdDoc).HasColumnType("int(11)");

                entity.Property(e => e.CodDoc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo).HasColumnType("tinyint(4)");

                entity.Property(e => e.NomDoc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnType("enum('FACTURA','INVENTARIO','CONTABILIDAD')");
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("empresas");

                entity.HasIndex(e => e.IdCiudad)
                    .HasDatabaseName("fk_empresaciudad");

                entity.HasIndex(e => e.IdDpto)
                    .HasDatabaseName("fk_empresadpto");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasDatabaseName("IdEmpresa_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdTipoRegimen)
                    .HasDatabaseName("fk_empresatiporegimen");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dv)
                    .HasColumnName("DV")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdCiudad).HasColumnType("int(11)");

                entity.Property(e => e.IdDpto).HasColumnType("int(11)");

                entity.Property(e => e.IdTipoRegimen).HasColumnType("int(11)");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PagWeb)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepLegalApe1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepLegalApe2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepLegalDoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RepLegalNom1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RepLegalNom2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_empresaciudad");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdDpto)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_empresadpto");

                entity.HasOne(d => d.TipoRegimen)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdTipoRegimen)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_empresatiporegimen");
            });

            modelBuilder.Entity<EmpresasResoluciones>(entity =>
            {
                entity.HasKey(e => e.IdResol);

                entity.ToTable("empresas_resoluciones");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasDatabaseName("fk_resolucionempresa");

                entity.HasIndex(e => e.IdResol)
                    .HasDatabaseName("IdResolFact_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdResol).HasColumnType("int(11)");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("AUTORIZA");

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.NumActual).HasColumnType("int(11)");

                entity.Property(e => e.NumAlerta).HasColumnType("int(11)");

                entity.Property(e => e.NumFinal).HasColumnType("int(11)");

                entity.Property(e => e.NumInicial).HasColumnType("int(11)");

                entity.Property(e => e.NumResol).HasColumnType("int(11)");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empresas)
                    .WithMany(p => p.EmpresasResoluciones)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("fk_resolucionempresa");
            });

            modelBuilder.Entity<Encabezados>(entity =>
            {
                entity.HasKey(e => e.IdEncab);

                entity.ToTable("encabezados");

                entity.HasIndex(e => e.IdCliente)
                    .HasDatabaseName("XI_IdClienteExterno");

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("IdEncab_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdUsuario)
                    .HasDatabaseName("fk_encabresolucion");

                entity.HasIndex(e => e.NumDocumento)
                    .HasDatabaseName("XI_NumDocumento");

                entity.HasIndex(e => new { e.Fecha, e.IdEncab })
                    .HasDatabaseName("XI_Fecha");

                entity.HasIndex(e => new { e.IdDocumento, e.IdEncab })
                    .HasDatabaseName("XI_IdDocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.NumDocumento, e.IdCliente })
                    .HasDatabaseName("XI_Unico");

                entity.Property(e => e.IdEncab).HasColumnType("int(11)");

                entity.Property(e => e.EsAnulado)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.IdDocumento).HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.IdFormaPago).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.Nota)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorPago).HasColumnType("decimal(28,6)");

                entity.HasOne(d => d.Clientes)
                    .WithMany(p => p.Encabezados)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("fk_encabcliente");

                entity.HasOne(d => d.Documentos)
                    .WithMany(p => p.Encabezados)
                    .HasForeignKey(d => d.IdDocumento)
                    .HasConstraintName("fk_encabdocumento");

                entity.HasOne(d => d.Empresas)
                    .WithMany(p => p.Encabezados)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("fk_encabempresa");

                entity.HasOne(d => d.Formaspago)
                    .WithMany(p => p.Encabezados)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("fk_encabformapago");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Encabezados)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_encabusuario");
            });

            modelBuilder.Entity<EncabezadosCostos>(entity =>
            {
                entity.HasKey(e => e.IdEncabCosto);

                entity.ToTable("encabezados_costos");

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("fk_costosencab");

                entity.HasIndex(e => e.IdInventario)
                    .HasDatabaseName("fkcostosinventario");

                entity.Property(e => e.IdEncabCosto).HasColumnType("int(11)");

                entity.Property(e => e.Costo).HasColumnType("decimal(10,6)");

                entity.Property(e => e.EsActivo).HasColumnType("tinyint(4)");

                entity.Property(e => e.IdEncab).HasColumnType("int(11)");

                entity.Property(e => e.IdInventario).HasColumnType("int(11)");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.EncabezadosCostos)
                    .HasForeignKey(d => d.IdEncab)
                    .HasConstraintName("fk_costosencab");

                entity.HasOne(d => d.Inventarios)
                    .WithMany(p => p.EncabezadosCostos)
                    .HasForeignKey(d => d.IdInventario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fkcostosinventario");
            });

            modelBuilder.Entity<EncabezadosMov>(entity =>
            {
                entity.HasKey(e => e.IdEncabMov);

                entity.ToTable("encabezados_mov");

                entity.HasIndex(e => e.IdCliente)
                    .HasDatabaseName("fk_movcliente");

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("fk_movencab");

                entity.HasIndex(e => e.IdEncabMov)
                    .HasDatabaseName("IdEncabMov_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdInventario)
                    .HasDatabaseName("fk_movinventario");

                entity.Property(e => e.IdEncabMov).HasColumnType("int(11)");

                entity.Property(e => e.Cant).HasColumnType("decimal(28,6)");

                entity.Property(e => e.Dcto).HasColumnType("decimal(28,6)");

                entity.Property(e => e.FactorCant).HasColumnType("decimal(28,6)");

                entity.Property(e => e.FactorMov).HasColumnType("tinyint(4)");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.IdEncab).HasColumnType("int(11)");

                entity.Property(e => e.IdInventario).HasColumnType("int(11)");

                entity.Property(e => e.Iva).HasColumnType("int(5)");

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIva).HasColumnType("decimal(28,6)");

                entity.Property(e => e.ValorSubTotal).HasColumnType("decimal(28,6)");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(28,6)");

                entity.Property(e => e.ValorUnit).HasColumnType("decimal(28,6)");

                entity.HasOne(d => d.Clientes)
                    .WithMany(p => p.EncabezadosMov)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("fk_movcliente");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.EncabezadosMov)
                    .HasForeignKey(d => d.IdEncab)
                    .HasConstraintName("fk_movencab");

                entity.HasOne(d => d.Inventarios)
                    .WithMany(p => p.EncabezadosMov)
                    .HasForeignKey(d => d.IdInventario)
                    .HasConstraintName("fk_movinventario");
            });

            modelBuilder.Entity<EncabezadosPagodet>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.ToTable("encabezados_pagodet");

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("fk_pagodetencab");

                entity.HasIndex(e => e.IdFormaPago)
                    .HasDatabaseName("fk_pagodetformapago");

                entity.HasIndex(e => e.IdPago)
                    .HasDatabaseName("IdPago_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdPago).HasColumnType("int(11)");

                entity.Property(e => e.FactorSuma).HasColumnType("smallint(6)");

                entity.Property(e => e.IdEncab).HasColumnType("int(11)");

                entity.Property(e => e.IdFormaPago).HasColumnType("int(11)");

                entity.Property(e => e.NumDoc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIva)
                    .HasColumnName("ValorIVA")
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ValorPago).HasColumnType("decimal(28,6)");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.EncabezadosPagodet)
                    .HasForeignKey(d => d.IdEncab)
                    .HasConstraintName("fk_pagodetencab");

                entity.HasOne(d => d.FormasPago)
                    .WithMany(p => p.EncabezadosPagodet)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("fk_pagodetformapago");
            });

            modelBuilder.Entity<Formaspago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago);

                entity.ToTable("formaspago");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.NomFormaPago)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventarios>(entity =>
            {
                entity.HasKey(e => e.IdInventario);

                entity.ToTable("inventarios");

                entity.HasIndex(e => e.IdAgrup1)
                    .HasDatabaseName("fk_inventarioagrup1");

                entity.HasIndex(e => e.IdClasifImpto)
                    .HasDatabaseName("fk_inventarioclasifimpto");

                entity.HasIndex(e => e.IdTipoInv)
                    .HasDatabaseName("fk_inventariotipo");

                entity.HasIndex(e => e.IdUnidad)
                    .HasDatabaseName("fk_inventariounidad");

                entity.Property(e => e.IdInventario).HasColumnType("int(11)");

                entity.Property(e => e.CantMaxima)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.CantMinima)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.CantFisica)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.CostoPromedio)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.CodInventario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EsFactSinExistencia)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsFactorMov)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FactorEscala1).HasColumnType("decimal(28,6)");

                entity.Property(e => e.FactorEscala2).HasColumnType("decimal(28,6)");

                entity.Property(e => e.IdAgrup1).HasColumnType("int(11)");

                entity.Property(e => e.IdClasifImpto)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdTipoInv).HasColumnType("int(11)");

                entity.Property(e => e.IdUnidad).HasColumnType("int(11)");

                entity.Property(e => e.Iva)
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NomInventario)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoReorden)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TipoVentaKit)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.InventariosAgrup1)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdAgrup1)
                    .HasConstraintName("fk_inventarioagrup1");

                entity.HasOne(d => d.InventariosClasifimpto)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdClasifImpto)
                    .HasConstraintName("fk_inventarioclasifimpto");

                entity.HasOne(d => d.InventariosTipos)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdTipoInv)
                    .HasConstraintName("fk_inventariotipo");

                entity.HasOne(d => d.InventariosUnidades)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("fk_inventariounidad");

            });

            modelBuilder.Entity<InventariosAbc>(entity =>
            {
                entity.HasKey(e => e.AbcId);

                entity.ToTable("inventarios_abc", "quentame");

                entity.HasIndex(e => e.Idinventario)
                    .HasDatabaseName("fc_abcinventario");

                entity.Property(e => e.AbcId)
                    .HasColumnName("abc_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AbcAcumulado)
                    .HasColumnName("abc_acumulado")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.AbcClasificacion)
                    .IsRequired()
                    .HasColumnName("abc_clasificacion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AbcCosto)
                    .HasColumnName("abc_costo")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.AbcFechafin).HasColumnName("abc_fechafin");

                entity.Property(e => e.AbcFechaini).HasColumnName("abc_fechaini");

                entity.Property(e => e.AbcParticipacion)
                    .HasColumnName("abc_participacion")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.AbcRotacion)
                    .HasColumnName("abc_rotacion")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.AbcTotalcostoventa)
                    .HasColumnName("abc_totalcostoventa")
                    .HasColumnType("decimal(28,6)");

                entity.Property(e => e.Idinventario)
                    .HasColumnName("idinventario")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Inventarios)
                    .WithMany(p => p.InventariosAbc)
                    .HasForeignKey(d => d.Idinventario)
                    .HasConstraintName("fk_abcinventario");
            });

            modelBuilder.Entity<InventariosAgrup1>(entity =>
            {
                entity.HasKey(e => e.IdAgrup1);

                entity.ToTable("inventarios_agrup1");

                entity.HasIndex(e => e.IdAgrup1)
                    .HasDatabaseName("IdAgrup1_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdAgrup1).HasColumnType("int(11)");

                entity.Property(e => e.CodigoAgrup1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NomAgrup1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventariosClasifimpto>(entity =>
            {
                entity.HasKey(e => e.IdClasifImpto);

                entity.ToTable("inventarios_clasifimpto");

                entity.HasIndex(e => e.IdClasifImpto)
                    .HasDatabaseName("IdClasifImpto_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdClasifImpto).HasColumnType("int(11)");

                entity.Property(e => e.NomClasifImpto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventariosFormulas>(entity =>
            {
                entity.HasKey(e => e.IdFormula);

                entity.ToTable("inventarios_formulas");

                entity.HasIndex(e => e.IdInventario1)
                    .HasDatabaseName("fk_formulainv1");

                entity.HasIndex(e => e.IdInventario2)
                    .HasDatabaseName("fk_formulainv2");

                entity.Property(e => e.IdFormula).HasColumnType("int(11)");

                entity.Property(e => e.Factor)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.SaldoProd)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.IdInventario1)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdInventario2)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Inventario1)
                    .WithMany(p => p.Inventario1)
                    .HasForeignKey(d => d.IdInventario1)
                    .HasConstraintName("fk_formulainv1");

                entity.HasOne(d => d.Inventario2)
                    .WithMany(p => p.Inventario2)
                    .HasForeignKey(d => d.IdInventario2)
                    .HasConstraintName("fk_formulainv2");
            });

            modelBuilder.Entity<InventariosKardex>(entity =>
            {
                entity.HasKey(e => e.KardexId);

                entity.ToTable("inventarios_kardex");

                entity.HasIndex(e => e.IdEncab)
                    .HasDatabaseName("fk_karexencab");

                entity.HasIndex(e => e.IdInventario)
                    .HasDatabaseName("fk_kardexinv");

                entity.Property(e => e.KardexId).HasColumnName("kardex_id");

                entity.Property(e => e.IdEncab).HasColumnName("id_encab");

                entity.Property(e => e.IdInventario).HasColumnName("id_inventario");

                entity.Property(e => e.KardexCant).HasColumnName("kardex_cant");

                entity.Property(e => e.KardexSaldo).HasColumnName("kardex_saldo");

                entity.Property(e => e.KardexFecha).HasColumnName("kardex_fecha");

                entity.Property(e => e.KardexMov)
                    .IsRequired()
                    .HasColumnName("kardex_mov")
                    .HasColumnType("enum('ENTRADA','SALIDA')");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.InventariosKardex)
                    .HasForeignKey(d => d.IdEncab)
                    .HasConstraintName("fk_karexencab");

                entity.HasOne(d => d.Inventarios)
                    .WithMany(p => p.InventariosKardex)
                    .HasForeignKey(d => d.IdInventario)
                    .HasConstraintName("fk_kardexinv");
            });

            modelBuilder.Entity<InventariosListas>(entity =>
            {
                entity.HasKey(e => e.IdLista);

                entity.ToTable("inventarios_listas");

                entity.HasIndex(e => e.IdLista)
                    .HasDatabaseName("IdLista_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdLista).HasColumnType("int(11)");

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EsExtranjero)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsImptoConsumo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsIvaIncluido)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NomLista)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventariosPrecios>(entity =>
            {
                entity.HasKey(e => e.IdInvP);

                entity.ToTable("inventarios_precios");

                entity.HasIndex(e => e.IdInvP)
                    .HasDatabaseName("IdInvP_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdLista, e.IdInventario })
                    .HasDatabaseName("IdLista_IdInv_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.IdInventario)
                    .HasDatabaseName("fk_preciosinventario");

                entity.HasIndex(e => e.IdLista)
                    .HasDatabaseName("fk_precioslista");

                entity.Property(e => e.IdInvP).HasColumnType("int(11)");

                entity.Property(e => e.IdInventario).HasColumnType("int(11)");

                entity.Property(e => e.IdLista).HasColumnType("int(11)");

                entity.Property(e => e.Porcentaje).HasColumnType("int(11)");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("0.000000");

                entity.HasOne(d => d.Inventarios)
                    .WithMany(p => p.InventariosPrecios)
                    .HasForeignKey(d => d.IdInventario)
                    .HasConstraintName("fk_preciosinventario");

                entity.HasOne(d => d.InventariosListas)
                    .WithMany(p => p.InventariosPrecios)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("fk_precioslista");
            });

            modelBuilder.Entity<InventariosTipos>(entity =>
            {
                entity.HasKey(e => e.IdInvenTipo);

                entity.ToTable("inventarios_tipos");

                entity.HasIndex(e => e.IdInvenTipo)
                    .HasDatabaseName("IdInvenTipo_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdInvenTipo).HasColumnType("int(11)");

                entity.Property(e => e.NomTipoInven)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<InventariosUnidades>(entity =>
            {
                entity.HasKey(e => e.IdUnidad);

                entity.ToTable("inventarios_unidades");

                entity.HasIndex(e => e.IdTipoUnidad)
                    .HasDatabaseName("fk_unidadtipounidad");

                entity.HasIndex(e => e.IdUnidad)
                    .HasDatabaseName("IdUnidad_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdUnidad).HasColumnType("int(11)");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EsDinamica)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsEspecial)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FactorEscala)
                    .HasColumnType("decimal(28,6)")
                    .HasDefaultValueSql("1.000000");

                entity.Property(e => e.IdTipoUnidad).HasColumnType("int(11)");

                entity.Property(e => e.NomUnidad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.InventariosUnidadesTipos)
                    .WithMany(p => p.InventariosUnidades)
                    .HasForeignKey(d => d.IdTipoUnidad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_unidadtipounidad");
            });

            modelBuilder.Entity<InventariosUnidadesTipos>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidad);

                entity.ToTable("inventarios_unidades_tipos");

                entity.HasIndex(e => e.IdTipoUnidad)
                    .HasDatabaseName("IdTipoUnidad_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdTipoUnidad).HasColumnType("int(11)");

                entity.Property(e => e.NomTipoUnidad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.MonedaId);

                entity.ToTable("monedas");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.MonedaActivo)
                    .HasColumnName("moneda_activo")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MonedaNombre)
                    .IsRequired()
                    .HasColumnName("moneda_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("paises");

                entity.Property(e => e.IdPais)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodPais).HasColumnType("char(2)");

                entity.Property(e => e.CodigoDian)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInterno).HasColumnType("smallint(6)");

                entity.Property(e => e.Iso3)
                    .HasColumnName("ISO3")
                    .HasColumnType("char(3)");

                entity.Property(e => e.NomPais1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomPais2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomPais2Imp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prefijos>(entity =>
            {
                entity.HasKey(e => e.IdPrefijo);

                entity.ToTable("prefijos");

                entity.Property(e => e.IdPrefijo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.NomPrefijo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Puntos>(entity =>
            {
                entity.HasKey(e => e.TarId);

                entity.ToTable("puntos");

                entity.HasIndex(e => e.IdCliente)
                    .HasDatabaseName("fk_puntoscliente");

                entity.Property(e => e.TarId)
                    .HasColumnName("tar_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.TarCliente)
                    .IsRequired()
                    .HasColumnName("tar_cliente")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TarCodigo)
                    .IsRequired()
                    .HasColumnName("tar_codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TarEstado)
                    .HasColumnName("tar_estado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.TarFecha).HasColumnName("tar_fecha");

                entity.Property(e => e.TarObservacion)
                    .IsRequired()
                    .HasColumnName("tar_observacion")
                    .HasColumnType("longtext");

                entity.Property(e => e.TarPuntosMultiplicar)
                    .HasColumnName("tar_puntos_multiplicar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TarPuntosRedimido)
                    .HasColumnName("tar_puntos_redimido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TarPuntosTotal)
                    .HasColumnName("tar_puntos_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TarPuntosXCompra)
                    .HasColumnName("tar_puntos_x_compra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TarValorCompra)
                    .HasColumnName("tar_valor_compra")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.Clientes)
                    .WithMany(p => p.Puntos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("fk_puntoscliente");
            });

            modelBuilder.Entity<Puntosmov>(entity =>
            {
                entity.HasKey(e => e.MovId);

                entity.ToTable("puntosmov");

                entity.HasIndex(e => e.IdEncabezado)
                    .HasDatabaseName("fk_movpuntosencab");

                entity.HasIndex(e => e.IdUsuario)
                    .HasDatabaseName("fk_movpuntosusuario");

                entity.Property(e => e.MovId)
                    .HasColumnName("mov_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEncabezado).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.MovEstado)
                    .HasColumnName("mov_estado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MovFecha).HasColumnName("mov_fecha");

                entity.Property(e => e.MovObservacion)
                    .IsRequired()
                    .HasColumnName("mov_observacion")
                    .HasColumnType("longtext");

                entity.Property(e => e.MovPuntos)
                    .HasColumnName("mov_puntos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovPuntosRedimido)
                    .HasColumnName("mov_puntos_redimido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovPuntosTotal)
                    .HasColumnName("mov_puntos_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovTipo)
                    .IsRequired()
                    .HasColumnName("mov_tipo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MovValor)
                    .HasColumnName("mov_valor")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TarId)
                    .HasColumnName("tar_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Encabezados)
                    .WithMany(p => p.Puntosmov)
                    .HasForeignKey(d => d.IdEncabezado)
                    .HasConstraintName("fk_movpuntosencab");

                entity.HasOne(d => d.Usuarios)
                    .WithMany(p => p.Puntosmov)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("fk_movpuntosusuario");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdUsuario)
                    .HasDatabaseName("IdUsuario_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdUsuarioTipo)
                    .HasDatabaseName("fk_usuariostipo");

                entity.HasIndex(e => e.NomUsuario)
                    .HasDatabaseName("XI_NomUsuario")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsActivo)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdUsuarioTipo).HasColumnType("int(11)");

                entity.Property(e => e.NomUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsuariosTipo)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdUsuarioTipo)
                    .HasConstraintName("fk_usuariostipo");
            });

            modelBuilder.Entity<Usuariostipo>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioTipo);

                entity.ToTable("usuariostipo");

                entity.Property(e => e.IdUsuarioTipo)
                    .HasColumnName("idUsuarioTipo")
                    .HasColumnType("int(5)");

                entity.Property(e => e.NomUsuarioTipo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            
            modelBuilder.Entity<UsuarioSystemConfig>(entity =>
            {
                entity.HasKey(u => u.ScId);

                entity.ToTable("usuario_systemconfig");

                entity.HasIndex(e => e.IdUsuario)
                    .HasDatabaseName("fk_scusuario");

                entity.Property(u => u.ScId)
                    .HasColumnName("sc_id")
                    .HasColumnType("int(11)");

                entity.Property(u => u.ScEsImprimir)
                    .HasColumnName("sc_esimprimir")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(u => u.ScEsWindowsPrint)
                    .HasColumnName("sc_eswindowsprint")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(u => u.ScCantCopPrint)
                    .HasColumnName("sc_cantcopprint")
                    .HasColumnType("smallint");

                entity.HasOne(u => u.Usuarios)
                    .WithMany(s => s.UsuarioSystemConfigs)
                    .HasForeignKey(u => u.IdUsuario)
                    .HasConstraintName("fk_scusuario");

                entity.Property(u => u.ScEsCodInvPrefix)
                    .HasColumnName("sc_escodinvprefix")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(u => u.ScCodInvPrefix)
                    .HasColumnName("sc_codinvprefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(u => u.ScEsBascula)
                    .HasColumnName("sc_esbascula")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(u => u.ScPuertoBascula)
                    .HasColumnName("sc_puertobascula")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });
        }
    }
}
