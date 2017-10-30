namespace AutoLotDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            DropForeignKey("dbo.Orders", "CustId", "dbo.Customers");
            RenameColumn(table: "dbo.Orders", name: "CustId", newName: "CustomerId");
            RenameIndex(table: "dbo.Orders", name: "IX_CustId", newName: "IX_CustomerId");
            DropPrimaryKey("dbo.Inventory");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.CreditRisks");
            DropColumn("dbo.Inventory", "CarId");
            DropColumn("dbo.Orders", "OrderId");
            DropColumn("dbo.Customers", "CustID");
            DropColumn("dbo.CreditRisks", "CustID");
            AddColumn("dbo.Inventory", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Inventory", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Orders", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Orders", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.CreditRisks", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CreditRisks", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddPrimaryKey("dbo.Inventory", "Id");
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.CreditRisks", "Id");
            CreateIndex("dbo.CreditRisks", new[] { "LastName", "FirstName" }, unique: true, name: "IDX_CreditRisk_Name");
            AddForeignKey("dbo.Orders", "CarId", "dbo.Inventory", "Id");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            //DropColumn("dbo.Inventory", "CarId");
            //DropColumn("dbo.Orders", "OrderId");
            //DropColumn("dbo.Customers", "CustID");
            //DropColumn("dbo.CreditRisks", "CustID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            DropColumn("dbo.CreditRisks", "Timestamp");
            DropColumn("dbo.CreditRisks", "Id");
            DropColumn("dbo.Customers", "Timestamp");
            DropColumn("dbo.Customers", "Id");
            DropColumn("dbo.Orders", "Timestamp");
            DropColumn("dbo.Orders", "Id");
            DropColumn("dbo.Inventory", "Timestamp");
            DropColumn("dbo.Inventory", "Id");
            AddColumn("dbo.CreditRisks", "CustID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "CustID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Inventory", "CarId", c => c.Int(nullable: false, identity: true));
            //DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            //DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            DropIndex("dbo.CreditRisks", "IDX_CreditRisk_Name");
            DropPrimaryKey("dbo.CreditRisks");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Inventory");
            //DropColumn("dbo.CreditRisks", "Timestamp");
            //DropColumn("dbo.CreditRisks", "Id");
            //DropColumn("dbo.Customers", "Timestamp");
            //DropColumn("dbo.Customers", "Id");
            //DropColumn("dbo.Orders", "Timestamp");
            //DropColumn("dbo.Orders", "Id");
            //DropColumn("dbo.Inventory", "Timestamp");
            //DropColumn("dbo.Inventory", "Id");
            AddPrimaryKey("dbo.CreditRisks", "CustID");
            AddPrimaryKey("dbo.Customers", "CustID");
            AddPrimaryKey("dbo.Orders", "OrderId");
            AddPrimaryKey("dbo.Inventory", "CarId");
            RenameIndex(table: "dbo.Orders", name: "IX_CustomerId", newName: "IX_CustId");
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "CustId");
            AddForeignKey("dbo.Orders", "CustId", "dbo.Customers", "CustID", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CarId", "dbo.Inventory", "CarId");
        }
    }
}
