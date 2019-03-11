namespace _5e_DM_ToolKit_v1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dungeon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _ID = c.String(),
                        Index = c.String(),
                        Name = c.String(),
                        Hit_Die = c.String(),
                        Starting_Equipment = c.String(),
                        Class_Levels = c.String(),
                        Subclasses = c.String(),
                        Spellcasting = c.String(),
                        URL = c.String(),
                        Proficiencies_ID = c.Int(),
                        Proficiency_Choices_ID = c.Int(),
                        Saving_Throws_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Proficiencies", t => t.Proficiencies_ID)
                .ForeignKey("dbo.ProficiencyChoices", t => t.Proficiency_Choices_ID)
                .ForeignKey("dbo.SavingThrows", t => t.Saving_Throws_ID)
                .Index(t => t.Proficiencies_ID)
                .Index(t => t.Proficiency_Choices_ID)
                .Index(t => t.Saving_Throws_ID);
            
            CreateTable(
                "dbo.Proficiencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProficiencyChoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SavingThrows",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        _ID = c.String(),
                        Index = c.String(),
                        Name = c.String(),
                        Speed = c.String(),
                        Ability_Bonuses = c.String(),
                        Alignment = c.String(),
                        Age = c.String(),
                        Size = c.String(),
                        Size_Description = c.String(),
                        Languages = c.String(),
                        Language_Desc = c.String(),
                        Starting_Proficiencies_ID = c.Int(),
                        Starting_Proficiency_Options_ID = c.Int(),
                        Traits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Characters", t => t.ID)
                .ForeignKey("dbo.StartingProficiencies", t => t.Starting_Proficiencies_ID)
                .ForeignKey("dbo.StartingProficiencyOptions", t => t.Starting_Proficiency_Options_ID)
                .ForeignKey("dbo.Subraces", t => t.ID)
                .ForeignKey("dbo.Traits", t => t.Traits_ID)
                .Index(t => t.ID)
                .Index(t => t.Starting_Proficiencies_ID)
                .Index(t => t.Starting_Proficiency_Options_ID)
                .Index(t => t.Traits_ID);
            
            CreateTable(
                "dbo.StartingProficiencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StartingProficiencyOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Subraces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        _ID = c.String(),
                        Index = c.String(),
                        Name = c.String(),
                        Desc = c.String(),
                        Ability_Bonuses = c.String(),
                        Starting_Proficiencies = c.String(),
                        Racial_Traits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Traits", t => t.Racial_Traits_ID)
                .Index(t => t.Racial_Traits_ID);
            
            CreateTable(
                "dbo.Traits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Damage_Bonus = c.String(),
                        Damage_Dice = c.String(),
                        Attack_Bonus = c.String(),
                        Desc = c.String(),
                        Name = c.String(),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SpecialAbilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Attack_Bonus = c.String(),
                        Desc = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Characters", "RaceSelection", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "SubRaceSelection", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "ClassSelection", c => c.Int(nullable: false));
            AddColumn("dbo.Characters", "Url", c => c.String());
            AddColumn("dbo.Characters", "Class_ID", c => c.Int());
            AddColumn("dbo.Characters", "SubRaces_ID", c => c.Int());
            AddColumn("dbo.Monsters", "Actions_ID", c => c.Int());
            AddColumn("dbo.Monsters", "Special_Abilities_ID", c => c.Int());
            CreateIndex("dbo.Characters", "Class_ID");
            CreateIndex("dbo.Characters", "SubRaces_ID");
            CreateIndex("dbo.Monsters", "Actions_ID");
            CreateIndex("dbo.Monsters", "Special_Abilities_ID");
            AddForeignKey("dbo.Characters", "Class_ID", "dbo.Classes", "ID");
            AddForeignKey("dbo.Characters", "SubRaces_ID", "dbo.Subraces", "ID");
            AddForeignKey("dbo.Monsters", "Actions_ID", "dbo.Actions", "ID");
            AddForeignKey("dbo.Monsters", "Special_Abilities_ID", "dbo.SpecialAbilities", "ID");
            DropColumn("dbo.Monsters", "Special_Abilities_Attack_Bonus");
            DropColumn("dbo.Monsters", "Special_Abilities_Desc");
            DropColumn("dbo.Monsters", "Special_Abilities_Name");
            DropColumn("dbo.Monsters", "Actions_Damage_Bonus");
            DropColumn("dbo.Monsters", "Actions_Damage_Dice");
            DropColumn("dbo.Monsters", "Actions_Attack_Bonus");
            DropColumn("dbo.Monsters", "Actions_Desc");
            DropColumn("dbo.Monsters", "Actions_Name");
            DropColumn("dbo.Monsters", "Actions_URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Monsters", "Actions_URL", c => c.String());
            AddColumn("dbo.Monsters", "Actions_Name", c => c.String());
            AddColumn("dbo.Monsters", "Actions_Desc", c => c.String());
            AddColumn("dbo.Monsters", "Actions_Attack_Bonus", c => c.String());
            AddColumn("dbo.Monsters", "Actions_Damage_Dice", c => c.String());
            AddColumn("dbo.Monsters", "Actions_Damage_Bonus", c => c.String());
            AddColumn("dbo.Monsters", "Special_Abilities_Name", c => c.String());
            AddColumn("dbo.Monsters", "Special_Abilities_Desc", c => c.String());
            AddColumn("dbo.Monsters", "Special_Abilities_Attack_Bonus", c => c.String());
            DropForeignKey("dbo.Monsters", "Special_Abilities_ID", "dbo.SpecialAbilities");
            DropForeignKey("dbo.Monsters", "Actions_ID", "dbo.Actions");
            DropForeignKey("dbo.Characters", "SubRaces_ID", "dbo.Subraces");
            DropForeignKey("dbo.Races", "Traits_ID", "dbo.Traits");
            DropForeignKey("dbo.Races", "ID", "dbo.Subraces");
            DropForeignKey("dbo.Subraces", "Racial_Traits_ID", "dbo.Traits");
            DropForeignKey("dbo.Races", "Starting_Proficiency_Options_ID", "dbo.StartingProficiencyOptions");
            DropForeignKey("dbo.Races", "Starting_Proficiencies_ID", "dbo.StartingProficiencies");
            DropForeignKey("dbo.Races", "ID", "dbo.Characters");
            DropForeignKey("dbo.Characters", "Class_ID", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Saving_Throws_ID", "dbo.SavingThrows");
            DropForeignKey("dbo.Classes", "Proficiency_Choices_ID", "dbo.ProficiencyChoices");
            DropForeignKey("dbo.Classes", "Proficiencies_ID", "dbo.Proficiencies");
            DropIndex("dbo.Monsters", new[] { "Special_Abilities_ID" });
            DropIndex("dbo.Monsters", new[] { "Actions_ID" });
            DropIndex("dbo.Subraces", new[] { "Racial_Traits_ID" });
            DropIndex("dbo.Races", new[] { "Traits_ID" });
            DropIndex("dbo.Races", new[] { "Starting_Proficiency_Options_ID" });
            DropIndex("dbo.Races", new[] { "Starting_Proficiencies_ID" });
            DropIndex("dbo.Races", new[] { "ID" });
            DropIndex("dbo.Classes", new[] { "Saving_Throws_ID" });
            DropIndex("dbo.Classes", new[] { "Proficiency_Choices_ID" });
            DropIndex("dbo.Classes", new[] { "Proficiencies_ID" });
            DropIndex("dbo.Characters", new[] { "SubRaces_ID" });
            DropIndex("dbo.Characters", new[] { "Class_ID" });
            DropColumn("dbo.Monsters", "Special_Abilities_ID");
            DropColumn("dbo.Monsters", "Actions_ID");
            DropColumn("dbo.Characters", "SubRaces_ID");
            DropColumn("dbo.Characters", "Class_ID");
            DropColumn("dbo.Characters", "Url");
            DropColumn("dbo.Characters", "ClassSelection");
            DropColumn("dbo.Characters", "SubRaceSelection");
            DropColumn("dbo.Characters", "RaceSelection");
            DropTable("dbo.SpecialAbilities");
            DropTable("dbo.Actions");
            DropTable("dbo.Traits");
            DropTable("dbo.Subraces");
            DropTable("dbo.StartingProficiencyOptions");
            DropTable("dbo.StartingProficiencies");
            DropTable("dbo.Races");
            DropTable("dbo.SavingThrows");
            DropTable("dbo.ProficiencyChoices");
            DropTable("dbo.Proficiencies");
            DropTable("dbo.Classes");
        }
    }
}
