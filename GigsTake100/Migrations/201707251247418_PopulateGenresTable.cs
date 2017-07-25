namespace GigsTake100.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT iNTO Genres (Id, Name) Values (1, 'Jazz')");
            Sql("INSERT iNTO Genres (Id, Name) Values (2, 'Rock')");
            Sql("INSERT iNTO Genres (Id, Name) Values (3, 'Blues')");
            Sql("INSERT iNTO Genres (Id, Name) Values (4, 'Pop')");
            Sql("INSERT iNTO Genres (Id, Name) Values (5, 'Reggae')");

        }

        public override void Down()
        {
            Sql("Delete From Genres Where Id in (1,2,3,4,5)");
        }
    }
}
