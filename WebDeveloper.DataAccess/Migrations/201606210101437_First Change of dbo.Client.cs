namespace WebDeveloper.DataAccess.Migrations
{
   
    using System.Data.Entity.Migrations;
    
    public partial class FirstChangeofdboClient : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName");
           
        }
        
        public override void Down()
        {
            
           
            RenameColumn("dbo.Client", "LastName", "Apellidos");
        }
    }
}
