namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRemainingRowsInMembership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'Quaterly' WHERE id = 3 ");
            Sql("UPDATE MemberShipTypes SET Name = 'Annual' WHERE id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
