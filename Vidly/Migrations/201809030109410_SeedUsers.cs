namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class SeedUsers : DbMigration
	{
		public override void Up()
		{
			Sql(@"
				INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dc8c3546-46c5-4963-8c74-f89835f063d3', N'guest@vidly.com', 0, N'AEoAvUEUxN+R34/sRahzQYDNYGoLUJJ+1e8kLqut1cJa4rbQfqMSLMdvmWFbDcFG4Q==', N'3d659d93-3198-4667-8d3e-444da683d11d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
				INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'de5162dc-5198-4c57-85ac-3c3adc328888', N'admin@vidly.com', 0, N'AAv92FLMlNag4VUWnDT+iI+moWJahz8f4MFnnwx71FMFHmt+GsyfRHjPASL5InKoKg==', N'7c96dcec-f4c2-42c9-9e42-f09c4db39c31', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
				INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6f16f97a-6e6a-4b89-b89e-d0c651d0b148', N'CanManageMovies')
				INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'de5162dc-5198-4c57-85ac-3c3adc328888', N'6f16f97a-6e6a-4b89-b89e-d0c651d0b148')
			");
		}
		
		public override void Down()
		{
		}
	}
}
