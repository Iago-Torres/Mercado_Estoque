using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mercado_Estoque.Model.Models;

public partial class MercadoestoqueContext : DbContext
{
    public MercadoestoqueContext()
    {
    }

    public MercadoestoqueContext(DbContextOptions<MercadoestoqueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acougue> Acougues { get; set; }

    public virtual DbSet<BebidasAdega> BebidasAdegas { get; set; }

    public virtual DbSet<Biscoito> Biscoitos { get; set; }

    public virtual DbSet<Congelado> Congelados { get; set; }

    public virtual DbSet<Enlatado> Enlatados { get; set; }

    public virtual DbSet<FriosELaticinio> FriosELaticinios { get; set; }

    public virtual DbSet<Higiene> Higienes { get; set; }

    public virtual DbSet<Limpeza> Limpezas { get; set; }

    public virtual DbSet<MarcaFornecedor> MarcaFornecedors { get; set; }

    public virtual DbSet<Padarium> Padaria { get; set; }

    public virtual DbSet<TrêsTabelas1> TrêsTabelas1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MERCADOESTOQUE;Trusted_Connection=True;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acougue>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Acougue__9C8800C3ABCA830C");

            entity.ToTable("Acougue");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Acougues)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Acougue");
        });

        modelBuilder.Entity<BebidasAdega>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Bebidas___9C8800C345B2CF3B");

            entity.ToTable("Bebidas_Adega");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.BebidasAdegas)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Bebidas_Adega");
        });

        modelBuilder.Entity<Biscoito>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Biscoito__9C8800C396922F64");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Biscoitos)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Biscoitos");
        });

        modelBuilder.Entity<Congelado>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Congelad__9C8800C3E15DEBCB");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Congelados)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Congelados");
        });

        modelBuilder.Entity<Enlatado>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Enlatado__9C8800C35BB7B20D");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Enlatados)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Enlatados");
        });

        modelBuilder.Entity<FriosELaticinio>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Frios_e___9C8800C38C287890");

            entity.ToTable("Frios_e_Laticinios");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.FriosELaticinios)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Frios_e_Laticinios");
        });

        modelBuilder.Entity<Higiene>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Higiene__9C8800C3559270D2");

            entity.ToTable("Higiene");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Higienes)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Higiene");
        });

        modelBuilder.Entity<Limpeza>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Limpeza__9C8800C3E5A65115");

            entity.ToTable("Limpeza");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Limpezas)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Limpeza");
        });

        modelBuilder.Entity<MarcaFornecedor>(entity =>
        {
            entity.HasKey(e => e.MarcaId).HasName("PK__MarcaFor__D5B1CDEB4ACB7D59");

            entity.ToTable("MarcaFornecedor");

            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Padarium>(entity =>
        {
            entity.HasKey(e => e.ProdutoId).HasName("PK__Padaria__9C8800C37CFB58CB");

            entity.Property(e => e.ProdutoId).HasColumnName("ProdutoID");
            entity.Property(e => e.Condicao)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataFabricacao).HasColumnType("datetime");
            entity.Property(e => e.DataValidade).HasColumnType("datetime");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("money");

            entity.HasOne(d => d.Marca).WithMany(p => p.Padaria)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaID_Padaria");
        });

        modelBuilder.Entity<TrêsTabelas1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TrêsTabelas_1");

            entity.Property(e => e.NomeQuantidade)
                .HasMaxLength(277)
                .IsUnicode(false)
                .HasColumnName("Nome__Quantidade");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
