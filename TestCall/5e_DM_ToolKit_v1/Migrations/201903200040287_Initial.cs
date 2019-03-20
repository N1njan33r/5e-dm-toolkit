namespace TeamAlpha.GoldenOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Characters",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    RaceSelection = c.Int(nullable: false),
                    SubRaceSelection = c.Int(nullable: false),
                    ClassSelection = c.Int(nullable: false),
                    Strength = c.Int(nullable: false),
                    Dexterity = c.Int(nullable: false),
                    Constitution = c.Int(nullable: false),
                    Intelligence = c.Int(nullable: false),
                    Wisdom = c.Int(nullable: false),
                    Charisma = c.Int(nullable: false),
                    Url = c.String(),
                    Class_ID = c.Int(),
                    SubRaces_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.Class_ID)
                .ForeignKey("dbo.Subraces", t => t.SubRaces_ID)
                .Index(t => t.Class_ID)
                .Index(t => t.SubRaces_ID);

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
                "dbo.Conditions",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    _ID = c.String(),
                    Index = c.String(),
                    Name = c.String(),
                    Desc = c.String(),
                    URL = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Cost",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Quantity = c.String(),
                    Unit = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Damage",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Dice_Count = c.String(),
                    Dice_Value = c.String(),
                    Damage_Type_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DamageType", t => t.Damage_Type_ID)
                .Index(t => t.Damage_Type_ID);

            CreateTable(
                "dbo.DamageType",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Equipment",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    _ID = c.String(),
                    Index = c.String(),
                    Name = c.String(),
                    Equipment_Category = c.String(),
                    Weapon_Category = c.String(),
                    Weapon_Range = c.String(),
                    Category_Range = c.String(),
                    Weight = c.String(),
                    Cost_ID = c.Int(),
                    Damage_ID = c.Int(),
                    Properties_ID = c.Int(),
                    Range_ID = c.Int(),
                    Throw_Range_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cost", t => t.Cost_ID)
                .ForeignKey("dbo.Damage", t => t.Damage_ID)
                .ForeignKey("dbo.Properties", t => t.Properties_ID)
                .ForeignKey("dbo.Range", t => t.Range_ID)
                .ForeignKey("dbo.ThrowRange", t => t.Throw_Range_ID)
                .Index(t => t.Cost_ID)
                .Index(t => t.Damage_ID)
                .Index(t => t.Properties_ID)
                .Index(t => t.Range_ID)
                .Index(t => t.Throw_Range_ID);

            CreateTable(
                "dbo.Properties",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Range",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Normal = c.String(),
                    Long = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.ThrowRange",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Normal = c.String(),
                    Long = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.LegendaryActions",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Attack_Bonus = c.String(),
                    Desc = c.String(),
                    Name = c.String(),
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
                    IsMonster = c.Boolean(nullable: false),
                    URL = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.School",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Url = c.String(),
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

            CreateTable(
                "dbo.Spells",
                c => new
                {
                    ID = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                    Range = c.String(),
                    Material = c.String(),
                    Ritual = c.String(),
                    Duration = c.String(),
                    Concentration = c.String(),
                    CastingTime = c.String(),
                    Level = c.String(),
                    URL = c.String(),
                    School_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.School_ID)
                .Index(t => t.School_ID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spells", "School_ID", "dbo.School");
            DropForeignKey("dbo.Equipment", "Throw_Range_ID", "dbo.ThrowRange");
            DropForeignKey("dbo.Equipment", "Range_ID", "dbo.Range");
            DropForeignKey("dbo.Equipment", "Properties_ID", "dbo.Properties");
            DropForeignKey("dbo.Equipment", "Damage_ID", "dbo.Damage");
            DropForeignKey("dbo.Equipment", "Cost_ID", "dbo.Cost");
            DropForeignKey("dbo.Damage", "Damage_Type_ID", "dbo.DamageType");
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
            DropIndex("dbo.Spells", new[] { "School_ID" });
            DropIndex("dbo.Equipment", new[] { "Throw_Range_ID" });
            DropIndex("dbo.Equipment", new[] { "Range_ID" });
            DropIndex("dbo.Equipment", new[] { "Properties_ID" });
            DropIndex("dbo.Equipment", new[] { "Damage_ID" });
            DropIndex("dbo.Equipment", new[] { "Cost_ID" });
            DropIndex("dbo.Damage", new[] { "Damage_Type_ID" });
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
            DropTable("dbo.Spells");
            DropTable("dbo.SpecialAbilities");
            DropTable("dbo.School");
            DropTable("dbo.Monsters");
            DropTable("dbo.LegendaryActions");
            DropTable("dbo.ThrowRange");
            DropTable("dbo.Range");
            DropTable("dbo.Properties");
            DropTable("dbo.Equipment");
            DropTable("dbo.DamageType");
            DropTable("dbo.Damage");
            DropTable("dbo.Cost");
            DropTable("dbo.Conditions");
            DropTable("dbo.Traits");
            DropTable("dbo.Subraces");
            DropTable("dbo.StartingProficiencyOptions");
            DropTable("dbo.StartingProficiencies");
            DropTable("dbo.Races");
            DropTable("dbo.SavingThrows");
            DropTable("dbo.ProficiencyChoices");
            DropTable("dbo.Proficiencies");
            DropTable("dbo.Classes");
            DropTable("dbo.Characters");
            DropTable("dbo.Actions");
        }
    }
}
