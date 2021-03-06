// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Proyecto_Final_Repuesto.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211118180819_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Entidades.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("NoCedula")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rnc")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Entidades.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Total")
                        .HasColumnType("Money");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Entidades.CobrosDetalle", b =>
                {
                    b.Property<int>("CobroDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("Money");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CobroDetalleId");

                    b.HasIndex("CobroId");

                    b.ToTable("CobrosDetalle");
                });

            modelBuilder.Entity("Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<float>("Descuento")
                        .HasColumnType("REAL");

                    b.Property<int>("EstadoProducto")
                        .HasColumnType("Bit");

                    b.Property<float>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<float>("Impuesto")
                        .HasColumnType("REAL");

                    b.Property<float>("PrecioUnit")
                        .HasColumnType("Money");

                    b.Property<int>("TipoProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Entidades.TiposProducto", b =>
                {
                    b.Property<int>("TipoProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoProductoId");

                    b.ToTable("TiposProductos");
                });

            modelBuilder.Entity("Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<int>("EsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("TEXT");

                    b.Property<float>("Itbis")
                        .HasColumnType("Money");

                    b.Property<string>("Ncf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<float>("PendientePagar")
                        .HasColumnType("Money");

                    b.Property<int>("TipoVenta")
                        .HasColumnType("Bit");

                    b.Property<float>("Total")
                        .HasColumnType("Money");

                    b.Property<int>("UsuarioModificador")
                        .HasColumnType("INTEGER");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Entidades.VentasDetalle", b =>
                {
                    b.Property<int>("DetalleVentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Total")
                        .HasColumnType("Money");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleVentaId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("Entidades.CobrosDetalle", b =>
                {
                    b.HasOne("Entidades.Cobros", null)
                        .WithMany("DetalleCobro")
                        .HasForeignKey("CobroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.VentasDetalle", b =>
                {
                    b.HasOne("Entidades.Ventas", null)
                        .WithMany("DetalleVenta")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Cobros", b =>
                {
                    b.Navigation("DetalleCobro");
                });

            modelBuilder.Entity("Entidades.Ventas", b =>
                {
                    b.Navigation("DetalleVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
