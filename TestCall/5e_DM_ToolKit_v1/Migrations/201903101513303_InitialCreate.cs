namespace _5e_DM_ToolKit_v1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Strength = c.Int(nullable: false),
                        Dexterity = c.Int(nullable: false),
                        Constitution = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Wisdom = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _ID = c.String(),
                        Index = c.String(),
                        Name = c.String(),
                        Size = c.String(),
                        Type = c.String(),
                        Subtype = c.String(),
                        Alignment = c.String(),
                        Armor_Class = c.String(),
                        Hit_Points = c.String(),
                        Hit_Dice = c.String(),
                        Speed = c.String(),
                        Strength = c.String(),
                        Dexterity = c.String(),
                        Constitution = c.String(),
                        Intelligence = c.String(),
                        Wisdom = c.String(),
                        Charisma = c.String(),
                        Dexterity_Save = c.String(),
                        Constitution_Save = c.String(),
                        Intelligence_Save = c.String(),
                        Acrobatics = c.String(),
                        Wisdom_Save = c.String(),
                        History = c.String(),
                        Charisma_Save = c.String(),
                        Arcana = c.String(),
                        Deception = c.String(),
                        Insight = c.String(),
                        Medicine = c.String(),
                        Religion = c.String(),
                        Perception = c.String(),
                        Persuasion = c.String(),
                        Stealth = c.String(),
                        Damage_Vulnerabilities = c.String(),
                        Damage_Resistances = c.String(),
                        Damage_Immunities = c.String(),
                        Condition_Immunities = c.String(),
                        Senses = c.String(),
                        Languages = c.String(),
                        Challenge_Rating = c.String(),
                        Special_Abilities_Attack_Bonus = c.String(),
                        Special_Abilities_Desc = c.String(),
                        Special_Abilities_Name = c.String(),
                        Actions_Damage_Bonus = c.String(),
                        Actions_Damage_Dice = c.String(),
                        Actions_Attack_Bonus = c.String(),
                        Actions_Desc = c.String(),
                        Actions_Name = c.String(),
                        Actions_URL = c.String(),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monsters");
            DropTable("dbo.Characters");
        }
    }
}
