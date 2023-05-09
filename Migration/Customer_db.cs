
using System.Reflection.Emit;



namespace Cerebral_Palsy.Migration
{
    {
    [DbContext(typeof(CustomerDB_Context))]
    partial class CustomerDB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Zasham_Enterprises.Model.Customer", b =>
            {
                b.Property<string>("Customer_phone")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Customer_address")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Customer_email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Customer_name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Customer_phone");

                b.ToTable("customer");
            });

            modelBuilder.Entity("Zasham_Enterprises.Model.Product", b =>
            {
                b.Property<string>("productname")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("productdescription")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("productid")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("productprice")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("productname");

                b.ToTable("products");
            });
#pragma warning restore 612, 618
        }
    }

}
