namespace TruongLamHuuLoc_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (1,'Development')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (2,'Buiness')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (3,'Marketing')");
            Sql("INSERT INTO CATEGORIES(ID,NAME) VALUES (4,'Information Technology')");
        }
        
        public override void Down()
        {
        }
    }
}
