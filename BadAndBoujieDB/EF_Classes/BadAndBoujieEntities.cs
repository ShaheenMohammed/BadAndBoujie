namespace BadAndBoujieMain.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BadAndBoujieEntities : DbContext
    {
        public BadAndBoujieEntities()
            : base("name=BadAndBoujieConnection")
        {
        }

        public virtual DbSet<basket_contents_line> basket_contents_line { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<P_cat> P_cat { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<product_name> product_name { get; set; }
        public virtual DbSet<shopping_basket> shopping_basket { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<basket_contents_line>()
                .Property(e => e.P_ID)
                .IsUnicode(false);

            modelBuilder.Entity<basket_contents_line>()
                .HasMany(e => e.shopping_basket)
                .WithRequired(e => e.basket_contents_line)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.C_ID)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Per_ID)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.shopping_basket)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<P_cat>()
                .Property(e => e.P_cat_ID)
                .IsUnicode(false);

            modelBuilder.Entity<P_cat>()
                .Property(e => e.P_cat_name)
                .IsUnicode(false);

            modelBuilder.Entity<P_cat>()
                .HasMany(e => e.products)
                .WithRequired(e => e.P_cat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_ID)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_firstname)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_lastname)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_phone)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_addr)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_usrn)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_PW)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.Per_type)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .HasMany(e => e.customers)
                .WithRequired(e => e.person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<person>()
                .HasMany(e => e.staffs)
                .WithRequired(e => e.person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .Property(e => e.P_ID)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.P_cat_ID)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.P_price)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.P_sale)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.basket_contents_line)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasOptional(e => e.product_name)
                .WithRequired(e => e.product);

            modelBuilder.Entity<product_name>()
                .Property(e => e.P_ID)
                .IsUnicode(false);

            modelBuilder.Entity<product_name>()
                .Property(e => e.P_name)
                .IsUnicode(false);

            modelBuilder.Entity<shopping_basket>()
                .Property(e => e.C_ID)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.stf_ID)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.Per_ID)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.S_ID)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.W_ID)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.S_name)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.S_addr)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.S_phone)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .HasMany(e => e.products)
                .WithRequired(e => e.supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.W_ID)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.W_name)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.W_addr)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.W_phone)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.suppliers)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);
        }
    }
}
