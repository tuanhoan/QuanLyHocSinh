﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyHocSinh.Models;

namespace QuanLyHocSinh.Migrations
{
    [DbContext(typeof(QuanLyHocSinhContext))]
    [Migration("20211127080008_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyHocSinh.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SchoolYear")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Comment", b =>
                {
                    b.Property<int>("NewsFeedId")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsFeedId", "StudentId", "CreatedAt");

                    b.HasIndex("StudentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TimeStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.NewsFeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_newFeed");

                    b.ToTable("NewsFeeds");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("Week")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.ScheduleDetail", b =>
                {
                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("LessonId", "ScheduleId", "SubjectId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ScheduleDetails");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Score", b =>
                {
                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TestTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<double>("Point")
                        .HasColumnType("float");

                    b.HasKey("SemesterId", "StudentId", "TestTypeId", "SubjectId")
                        .HasName("pk_score");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TestTypeId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TimeEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStart")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_semester");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CMND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameParent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumberParent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfIssue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_subject");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CMND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Folk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PlaceOfIssue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.TestType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ScoreFactor")
                        .HasColumnType("float");

                    b.Property<string>("TestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_testType");

                    b.ToTable("testTypes");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Class", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Teacher", "TeacherNavigation")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_Class_Teacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Comment", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.NewsFeed", "NewsFeedNavigation")
                        .WithMany("Comments")
                        .HasForeignKey("NewsFeedId")
                        .HasConstraintName("fk_newFeed_Comment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHocSinh.Models.Student", "StudentNavigation")
                        .WithMany("Comments")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("fk_newFeed_Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsFeedNavigation");

                    b.Navigation("StudentNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Schedule", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Class", "ClassNavigation")
                        .WithMany("Schedules")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("fk_Schedule_Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.ScheduleDetail", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Lesson", "LessonNavigation")
                        .WithMany("ScheduleDetails")
                        .HasForeignKey("LessonId")
                        .HasConstraintName("FK_ScheduleDetail_Lesson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHocSinh.Models.Schedule", "ScheduleNavigation")
                        .WithMany("ScheduleDetails")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK_ScheduleDetail_Schedule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHocSinh.Models.Subject", "SubjectNavigation")
                        .WithMany("ScheduleDetails")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("fk_ScheduleDetail_Class")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LessonNavigation");

                    b.Navigation("ScheduleNavigation");

                    b.Navigation("SubjectNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Score", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Semester", "SemesterNavigation")
                        .WithMany("Scores")
                        .HasForeignKey("SemesterId")
                        .HasConstraintName("fk_score_semester")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHocSinh.Models.Subject", "SubjectNavigation")
                        .WithMany("Scores")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("fk_score_subject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHocSinh.Models.TestType", "TestTypeNavigation")
                        .WithMany("Scores")
                        .HasForeignKey("TestTypeId")
                        .HasConstraintName("fk_score_testtype")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SemesterNavigation");

                    b.Navigation("SubjectNavigation");

                    b.Navigation("TestTypeNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Student", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Class", "ClassNavigation")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK_Student_Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Teacher", b =>
                {
                    b.HasOne("QuanLyHocSinh.Models.Subject", "SubjectNavigation")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_Teacher_Subject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubjectNavigation");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Class", b =>
                {
                    b.Navigation("Schedules");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Lesson", b =>
                {
                    b.Navigation("ScheduleDetails");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.NewsFeed", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Schedule", b =>
                {
                    b.Navigation("ScheduleDetails");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Semester", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Student", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Subject", b =>
                {
                    b.Navigation("ScheduleDetails");

                    b.Navigation("Scores");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.Teacher", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("QuanLyHocSinh.Models.TestType", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
