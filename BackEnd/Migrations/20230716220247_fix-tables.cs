using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class fixtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MovieGenres");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MovieCategories");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreateAt", "Deleted", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1234), false, "Actor famoso de Hollywood", "Brad Pitt" },
                    { 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1243), false, "Actor destacado en múltiples películas", "Leonardo DiCaprio" },
                    { 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1244), false, "Actriz talentosa y versátil", "Meryl Streep" },
                    { 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1245), false, "Actor icónico de la industria cinematográfica", "Tom Hanks" },
                    { 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1246), false, "Actriz conocida por su papel en películas de superhéroes", "Scarlett Johansson" },
                    { 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1246), false, "Actor reconocido por interpretar a Iron Man", "Robert Downey Jr." },
                    { 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1247), false, "Actriz ganadora de premios y reconocida por Los juegos del hambre", "Jennifer Lawrence" },
                    { 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1248), false, "Actor destacado en películas dramáticas", "Denzel Washington" },
                    { 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1248), false, "Actriz talentosa y versátil", "Emma Stone" },
                    { 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1249), false, "Actor conocido por su interpretación de personajes excéntricos", "Johnny Depp" },
                    { 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1250), false, "Actriz versátil y ganadora del premio de la Academia", "Anne Hathaway" },
                    { 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1250), false, "Actor australiano conocido por interpretar a Thor", "Chris Hemsworth" },
                    { 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1251), false, "Actriz versátil y ganadora del premio de la Academia", "Natalie Portman" },
                    { 14, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1252), false, "Actor conocido por películas como El lado bueno de las cosas", "Bradley Cooper" },
                    { 15, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1253), false, "Actriz y activista conocida por su papel en Tomb Raider", "Angelina Jolie" },
                    { 16, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1253), false, "Actordestacado en películas de acción", "Keanu Reeves" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Deleted", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1352), false, "+18" },
                    { 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1353), false, "+21" },
                    { 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1354), false, "+12" },
                    { 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1355), false, "+9" },
                    { 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1355), false, "Todo público" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreateAt", "Deleted", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1367), false, "Acción" },
                    { 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1368), false, "Aventura" },
                    { 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1369), false, "Comedia" },
                    { 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1370), false, "Drama" },
                    { 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1370), false, "Suspenso" },
                    { 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1371), false, "Terror" },
                    { 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1372), false, "Ciencia ficción" },
                    { 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1372), false, "Animación" },
                    { 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1373), false, "Romance" },
                    { 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1373), false, "Documental" },
                    { 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1374), false, "Fantasía" },
                    { 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1375), false, "Histórico" },
                    { 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1375), false, "Misterio" },
                    { 14, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1376), false, "Western" },
                    { 15, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1377), false, "Musical" },
                    { 16, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1377), false, "Deporte" },
                    { 17, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1378), false, "Guerra" },
                    { 18, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1379), false, "Crimen" },
                    { 19, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1381), false, "Aventura espacial" },
                    { 20, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1382), false, "Superhéroes" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreateAt", "Deleted", "LongDescription", "Name", "ShortDescription", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1447), false, "Un exasesino busca venganza después de que le roban lo más preciado que le quedaba: su perro.", "John Wick", "Un hombre en busca de justicia en un mundo de asesinos.", "https://example.com/john-wick.jpg" },
                    { 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1449), false, "El agente Ethan Hunt se enfrenta a su misión más peligrosa hasta ahora cuando una operación sale mal y pone en peligro a millones de personas.", "Mission: Impossible - Fallout", "La misión imposible más intensa y emocionante.", "https://example.com/mission-impossible-fallout.jpg" },
                    { 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1450), false, "Los Vengadores y sus aliados se unen para luchar contra el poderoso Thanos y evitar que obtenga las gemas del infinito y destruya el universo.", "Avengers: Infinity War", "La batalla definitiva por el destino del universo.", "https://example.com/avengers-infinity-war.jpg" },
                    { 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1451), false, "Batman se enfrenta al Joker, un criminal psicótico que amenaza con sumir Gotham City en el caos y la anarquía.", "The Dark Knight", "El caballero oscuro contra el príncipe payaso del crimen.", "https://example.com/the-dark-knight.jpg" },
                    { 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1452), false, "En un mundo postapocalíptico, Max Rockatansky y Furiosa se unen para", "Mad Max: Fury Road", "La película muestra una historia deslumbrante.", "https://example.com/mad-max-fury-road.jpg" },
                    { 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1452), false, "Un policía de Nueva York se enfrenta a un grupo de terroristas en un rascacielos en Los Ángeles.", "Die Hard", "El héroe que salvará la Navidad.", "https://example.com/die-hard.jpg" },
                    { 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1453), false, "Un cyborg asesino del futuro es enviado al pasado para matar a una mujer cuyo hijo se convertirá en la única esperanza de la humanidad contra las máquinas.", "The Terminator", "El futuro está en juego.", "https://example.com/the-terminator.jpg" },
                    { 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1454), false, "El arqueólogo y aventurero Indiana Jones se embarca en una peligrosa misión para encontrar el Arca de la Alianza antes que los nazis.", "Indiana Jones: Raiders of the Lost Ark", "La aventura comienza.", "https://example.com/indiana-jones-raiders-of-the-lost-ark.jpg" },
                    { 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1455), false, "Un parque temático lleno de dinosaurios vivos se convierte en una pesadilla cuando las criaturas escapan y comienzan a causar estragos.", "Jurassic Park", "La maravilla de la prehistoria en la actualidad.", "https://example.com/jurassic-park.jpg" },
                    { 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1456), false, "Un hobbit llamado Frodo se embarca en una épica aventura para destruir un anillo mágico y salvar la Tierra Media de la oscuridad.", "The Lord of the Rings: The Fellowship of the Ring", "El comienzo de una gran guerra.", "https://example.com/the-lord-of-the-rings-the-fellowship-of-the-ring.jpg" },
                    { 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1456), false, "El Capitán Jack Sparrow se embarca en una aventura para recuperar su barco robado y salvar a una gobernadora secuestrada de una maldición pirata.", "Pirates of the Caribbean: The Curse of the Black Pearl", "La vida de un pirata nunca ha sido tan divertida.", "https://example.com/pirates-of-the-caribbean-the-curse-of-the-black-pearl.jpg" },
                    { 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1457), false, "Un grupo de amigos se embarca en una aventura en busca de un tesoro perdido para salvar sus hogares de ser demolidos.", "The Goonies", "La pandilla más divertida en busca de aventuras.", "https://example.com/the-goonies.jpg" },
                    { 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1458), false, "Un aventurero y una arqueóloga luchan contra una antigua maldición y enfrentan criaturas sobrenaturales mientras intentan salvar al mundo.", "The Mummy", "La aventura más emocionante en Egipto.", "https://example.com/the-mummy.jpg" },
                    { 14, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1459), false, "Una niña es poseída por una entidad demoníaca y un sacerdote lucha por salvar su alma.", "The Exorcist", "El clásico del terror que te hará temblar.", "https://example.com/the-exorcist.jpg" },
                    { 15, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1460), false, "Un escritor y su familia se mudan a un hotel aislado donde ocurren sucesos aterradores.", "The Shining", "Una historia de terror psicológico que te mantendrá en vilo.", "https://example.com/the-shining.jpg" },
                    { 16, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1460), false, "Un asesino enmascarado aterroriza a una pequeña ciudad en la noche de Halloween.", "Halloween", "Un clásico del cine slasher que te hará saltar de miedo.", "https://example.com/halloween.jpg" },
                    { 17, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1461), false, "Un grupo de adolescentes es perseguido en sus sueños por un asesino de pesadilla.", "A Nightmare on Elm Street", "No podrás dormir tranquilo después de ver esta película.", "https://example.com/nightmare-on-elm-street.jpg" },
                    { 18, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1462), false, "Una pareja de investigadores paranormales ayuda a una familia a enfrentarse a una presencia malévola en su casa.", "The Conjuring", "Una historia basada en hechos reales que te dejará sin aliento.", "https://example.com/the-conjuring.jpg" },
                    { 19, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1463), false, "Un grupo de niños se enfrenta a un aterrador payaso que aterroriza su ciudad.", "It", "El regreso del payaso más aterrador del cine.", "https://example.com/it.jpg" },
                    { 20, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1464), false, "Un joven negro visita la casa de la familia de su novia blanca y descubre un oscuro secreto.", "Get Out", "Un thriller psicológico que te mantendrá en vilo hasta el final.", "https://example.com/get-out.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId", "CreateAt", "Deleted" },
                values: new object[,]
                {
                    { 16, 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1514), false },
                    { 16, 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1516), false },
                    { 16, 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1517), false },
                    { 16, 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1518), false },
                    { 16, 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1518), false },
                    { 16, 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1519), false },
                    { 16, 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1519), false },
                    { 16, 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1520), false },
                    { 16, 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1521), false },
                    { 16, 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1521), false },
                    { 16, 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1522), false },
                    { 16, 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1523), false },
                    { 16, 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1523), false }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "CategoryId", "MovieId", "CreateAt", "Deleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1496), false },
                    { 1, 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1497), false },
                    { 1, 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1497), false },
                    { 1, 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1498), false },
                    { 1, 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1499), false },
                    { 1, 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1499), false },
                    { 1, 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1500), false },
                    { 1, 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1500), false },
                    { 1, 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1501), false },
                    { 1, 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1502), false },
                    { 1, 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1502), false },
                    { 1, 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1503), false },
                    { 1, 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1504), false }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId", "CreateAt", "Deleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1477), false },
                    { 1, 2, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1478), false },
                    { 1, 3, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1479), false },
                    { 1, 4, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1480), false },
                    { 1, 5, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1481), false },
                    { 1, 6, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1481), false },
                    { 1, 7, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1482), false },
                    { 1, 8, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1483), false },
                    { 1, 9, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1483), false },
                    { 1, 10, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1484), false },
                    { 1, 11, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1484), false },
                    { 1, 12, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1485), false },
                    { 1, 13, new DateTime(2023, 7, 16, 17, 2, 47, 406, DateTimeKind.Local).AddTicks(1486), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "MovieCategories",
                keyColumns: new[] { "CategoryId", "MovieId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MovieGenres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MovieCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
