namespace Sample.Repositary.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SocialMedia : DbContext
    {
        public SocialMedia()
            : base("name=SocialMediaEntity")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<ModelBase> ModelBase { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Post> Post { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
