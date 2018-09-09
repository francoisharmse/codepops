namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreDataList2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (0 ,1 ,'Aerospace')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (1 ,2 ,'Biography')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (2 ,3 ,'BuddyCop')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (3 ,4 ,'Burlesque')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (4 ,5 ,'ChickFlick')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (5 ,6 ,'Circus')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (6 ,7 ,'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (7 ,8 ,'Blackcomedy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (8 ,9 ,'Gross-out')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (9 ,10,'Romanticcomedy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (10,11,'Screwballcomedy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (11,12,'WackyComedy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (12,13,'Stoner')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (13,14,'Coming-of-ages')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (14,15,'ComicBook-superhero')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (15,16,'Concert')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (16,17,'Courtroomdrama')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (17,18,'CurrentEvents')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (18,19,'Detective')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (19,20,'Disaster')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (20,21,'Drama')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (21,22,'RomanticDrama')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (22,23,'Educational')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (23,24,'Ephemeral')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (24,25,'Exploitation')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (25,26,'Blaxploitation')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (26,27,'Fantasy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (27,28,'fantastique')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (28,29,'Gangster')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (29,30,'Gaymovies')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (30,31,'Gothic')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (31,32,'Heist')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (32,33,'History')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (33,34,'Horror')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (34,35,'Slasher')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (35,36,'Jungle')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (36,37,'Martialarts')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (37,38,'WuXia')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (38,39,'Medieval')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (39,40,'Military')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (40,41,'Mountie')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (41,42,'Mystery')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (42,43,'Nature')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (43,44,'Police')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (44,45,'Politics')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (45,46,'Pornographic')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (46,47,'Prison')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (47,48,'Propaganda')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (48,49,'Psycho')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (49,50,'Religion')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (50,51,'Revolution')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (51,52,'Roadmovie')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (52,53,'Romance')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (53,54,'Science')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (54,55,'Sciencefiction')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (55,56,'Sex')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (56,57,'Sitcom')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (57,58,'Socialguidance')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (58,59,'Spiritual')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (59,60,'Sports')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (60,61,'Baseball')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (61,62,'Spy')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (62,63,'SwordandSandal(akaPeplum)')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (63,64,'Teen')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (64,65,'Travelogue')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (65,66,'Variety')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (66,67,'War')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (67,68,'Submarine')");
            Sql("INSERT INTO MovieGenres (Id, GenreType, GenreDescription) VALUES (68,69,'Western')");
        }
        
        public override void Down()
        {
        }
    }
}
