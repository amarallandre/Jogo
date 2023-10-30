﻿// <auto-generated />
using Jogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jogo.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20231030001314_attCharCreator")]
    partial class attCharCreator
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Jogo.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Dano")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DanoBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defesa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DefesaBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Exp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HPBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MPBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nivel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
