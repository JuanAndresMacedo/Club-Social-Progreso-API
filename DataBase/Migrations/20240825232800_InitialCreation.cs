using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerticalImage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsContents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NewsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Paragraph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsContents_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsContents_NewsId",
                table: "NewsContents",
                column: "NewsId");
            
                        var news1Id = Guid.NewGuid().ToString();
            var news2Id = Guid.NewGuid().ToString();
            var news3Id = Guid.NewGuid().ToString();
            var news4Id = Guid.NewGuid().ToString();
            var news5Id = Guid.NewGuid().ToString();
            var news6Id = Guid.NewGuid().ToString();
            var news7Id = Guid.NewGuid().ToString();
            
            migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news1Id,
        "Volleyball: se juega la 13a fecha del apertura",
        "Se jugara en el polideportivo de las piedras contra el equipo de Enfoque.",
        "../../../assets/images/news/partidoVolley.jpg",
        "27/08",
        "volleyball",
        true
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news2Id,
        "¡Campeones del apertura!",
        "Descripción 2",
        "../../../assets/images/news/mayores.jpg",
        "20/08",
        "handball",
        false
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news3Id,
        "Remodelación del club",
        "El club ha renovado su fachada con una nueva capa de pintura vibrante.",
        "../../../assets/images/club.jpg",
        "12/08",
        "general",
        false
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news4Id,
        "Campeonato de truco",
        "Se organiza un emocionante campeonato de truco con el objetivo de recaudar fondos en beneficio del plantel de mayores del handball masculino",
        "../../../assets/images/news/truco.jpg",
        "01/08",
        "handball",
        true
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news5Id,
        "Finalizó la 79° vuelta ciclista del Uruguay",
        "Una gran experiencia para todos los que participaron en cada uno de sus roles.",
        "../../../assets/images/news/ciclismo.jpg",
        "24/07",
        "ciclismo",
        false
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news6Id,
        "¡Uruguay campeón del mundo en bochas!",
        "Por primera vez en la historia, nuestro país ha logrado conquistar una medalla de oro en Bochas",
        "../../../assets/images/news/bochas.jpg",
        "21/07",
        "bochas",
        true
    }
);

migrationBuilder.InsertData(
    table: "News",
    columns: new[] { "Id", "Title", "Description", "ImageUrl", "Date", "Topic", "VerticalImage" },
    values: new object[]
    {
        news7Id,
        "Ciclismo: premios del Bingo",
        "Se efectivizaron los vuelos en helicóptero, premios del bingo del ciclismo.",
        "../../../assets/images/news/vuelo.jpg",
        "29/06",
        "ciclismo",
        false
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "Este 30 de agosto, los equipos de Progreso y Enfoque se verán las caras en un emocionante " +
        "encuentro correspondiente a la 13ª fecha del torneo Apertura de volleyball. El partido se " +
        "llevará a cabo en el Polideportivo de Las Piedras, donde ambos equipos buscarán sumar puntos " +
        "clave para escalar posiciones en la tabla.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "Progreso llega con la motivación de continuar con su racha positiva, " +
        "mientras que Enfoque intentará sorprender y llevarse la victoria en un terreno que no " +
        "será fácil. Con ambos equipos mostrando un nivel competitivo en sus últimos encuentros, " +
        "se espera un partido lleno de emoción y lucha en cada punto.",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "No te pierdas este gran enfrentamiento, que además será transmitido en vivo por " +
        "las plataformas oficiales del Club Social Progreso. ¡Vamos Progreso!",
        3
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "🕜 Fecha y hora: 30 de agosto - 18:30",
        4
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "📍 Lugar: Polideportivo de Las Piedras",
        5
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news1Id,
        "🎥 Transmisión en vivo: @CSPVolleyMasculino",
        6
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news2Id,
        "En una jornada donde la humedad amenazaba con suspender la jornada, Progreso se alzó " +
        "con el título del Torneo Apertura de la Super Liga Masculina (SLM), reafirmándose como " +
        "uno de los equipos más destacados del handball ACB. La competencia inicial de la SLM contó " +
        "con la participación de siete equipos que se enfrentaron en un formato de todos contra " +
        "todos, culminando en semifinales y finales disputadas por los cuatro mejores clasificados.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news2Id,
        "Los equipos que lograron llegar a las semifinales fueron Malvin, Progreso, Seminario " +
        "y Maldonado. Tras emocionantes encuentros, el equipo de la playa y el equipo canario " +
        "lograron el triunfo, asegurando su pase a la final del torneo.",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news2Id,
        "El partido decisivo se llevó a cabo el pasado 22 de junio en la cancha del Colegio " +
        "Clara Jackson. Fue un encuentro de alta intensidad, donde ambos equipos desplegaron sus " +
        "mejores tácticas y habilidades sobre el campo de juego. Progreso logró imponerse con un " +
        "marcador de 22-17, sumando así una nueva copa a su historia en el handball.",
        3
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news3Id,
        "El Club Social Progreso ha dado un paso más hacia la modernización al renovar su fachada " +
        "con una nueva y vibrante capa de pintura. La actualización, que ya ha captado la atención " +
        "de los miembros y visitantes, refleja el compromiso del club con la mejora continua de sus " +
        "instalaciones.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news3Id,
        "La elección de colores vibrantes no solo revitaliza la apariencia del club, " +
        "sino que también simboliza el espíritu dinámico y la energía de su comunidad. " +
        "Esta renovación es parte de una serie de mejoras que el club ha estado implementando " +
        "para ofrecer un ambiente más acogedor y moderno a todos sus socios.",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news3Id,
        "Con esta nueva imagen, el Club Social Progreso sigue consolidándose como un punto " +
        "de encuentro clave en la comunidad, donde el deporte, la recreación y el compañerismo " +
        "se entrelazan en un espacio que ahora luce mejor que nunca.",
        3
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news3Id,
        "¡Invitamos a todos a pasar por el club y disfrutar de esta renovada fachada que marca " +
        "un nuevo capítulo en nuestra historia!",
        4
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "El Club Social Progreso organiza un emocionante campeonato de truco con el objetivo de " +
        "recaudar fondos en beneficio del plantel de mayores del handball masculino. El evento, " +
        "que promete ser una jornada de entretenimiento y camaradería, se llevará a cabo el próximo " +
        "fin de semana en las instalaciones del club.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "Con el espíritu de colaboración y apoyo entre los socios, el torneo de truco reunirá a " +
        "jugadores de todas las edades en un ambiente ameno, donde la pasión por el juego y el " +
        "deseo de contribuir al crecimiento del equipo de handball serán los protagonistas. Los " +
        "fondos recaudados durante el evento se destinarán a mejorar el equipamiento y a cubrir los " +
        "gastos necesarios para la próxima temporada.",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "La inscripción está abierta para todos aquellos que deseen participar y contribuir a esta " +
        "noble causa. Además, habrá premios para las parejas ganadoras y sorteos entre todos los " +
        "presentes, lo que añade un extra de emoción al evento.",
        3
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "No pierdas la oportunidad de ser parte de esta iniciativa que fortalece el vínculo entre " +
        "los socios y apoya a nuestros deportistas. ¡Te esperamos para compartir una jornada de " +
        "truco, risas y solidaridad!",
        4
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "🕜 Fecha y hora: 05 de agosto - 20:30",
        5
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news4Id,
        "📍 Lugar: Club Social Progreso",
        6
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news5Id,
        "La 79ª edición de la Vuelta Ciclista del Uruguay ha llegado a su fin, dejando una huella imborrable en todos aquellos " +
        "que participaron en esta histórica competencia. Desde los ciclistas que demostraron su valentía y destreza en cada etapa, " +
        "hasta los entrenadores, organizadores y aficionados que apoyaron incansablemente, todos vivieron una experiencia " +
        "única y enriquecedora.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news5Id,
        "Durante varias jornadas, los competidores recorrieron cientos de kilómetros a lo largo de las rutas uruguayas, " +
        "enfrentando desafíos tanto físicos como mentales. Cada pedalada fue una muestra de perseverancia y dedicación, lo " +
        "que hizo de esta vuelta un evento memorable. Los paisajes del país fueron el escenario perfecto para una competencia " +
        "repleta de emoción, estrategia y esfuerzo.",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news5Id,
        "La organización del evento, a cargo de la Federación Ciclista Uruguaya, fue impecable, garantizando la seguridad y el " +
        "bienestar de todos los participantes. Además, el apoyo del público en cada localidad fue fundamental, creando una " +
        "atmósfera de celebración y compañerismo que será recordada por mucho tiempo.",
        3
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news5Id,
        "Con la culminación de esta vuelta, los ciclistas no solo se llevan trofeos y reconocimientos, sino también vivencias " +
        "y aprendizajes que trascienden la competencia. La 79ª Vuelta Ciclista del Uruguay no solo reafirma la importancia del " +
        "deporte en la sociedad, sino que también deja una inspiración para futuras generaciones de ciclistas que sueñan con formar " +
        "parte de este legendario evento.",
        4
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news6Id,
        "¡Uruguay ha alcanzado la gloria en el ámbito deportivo internacional! Por primera vez en la historia, nuestro país ha logrado " +
        "conquistar una medalla de oro en Bochas, y no podríamos estar más emocionados. Gonzalo Perdomo, un talentoso atleta uruguayo, " +
        "se ha coronado campeón mundial tras una impresionante victoria en el Mundial Juvenil de Oran, Argelia. En la disciplina de " +
        "Tiro de Precisión estilo Raffa Volo, Perdomo demostró una habilidad y determinación excepcionales, superando al representante " + 
        "de Paraguay en una final que quedará grabada en la memoria de todos los uruguayos.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news6Id,
        "Este logro es el resultado de un esfuerzo colectivo. Queremos extender nuestro más sincero agradecimiento a todos quienes " +
        "hicieron posible este hito: familiares, amigos, comercios, y el Municipio. La comunidad del Club Social Progreso se " +
        "enorgullece de este triunfo y agradece profundamente el apoyo brindado. La victoria de Gonzalo Perdomo es un reflejo del " +
        "esfuerzo, dedicación y espíritu de superación que caracteriza a nuestro país. ¡Gracias a todos, y un fuerte aplauso para " +
        "Gonzalo! ¡Arriba Uruguay!",
        2
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news7Id,
        "El pasado fin de semana, se hicieron realidad los esperados vuelos en helicóptero que habían sido sorteados como " +
        "premios del popular bingo del ciclismo. Los afortunados ganadores disfrutaron de una experiencia única al sobrevolar " +
        "la región, apreciando las impresionantes vistas desde las alturas. Este emocionante evento fue posible gracias al apoyo " +
        "de Progreso Aeroservicios, que no solo proporcionó las aeronaves, sino que también garantizó la seguridad y el disfrute de " +
        "todos los participantes.",
        1
    }
);

migrationBuilder.InsertData(
    table: "NewsContents",
    columns: new[] { "Id", "NewsId", "Paragraph", "Index" },
    values: new object[]
    {
        Guid.NewGuid().ToString(),
        news7Id,
        "La iniciativa del bingo del ciclismo ha demostrado ser un éxito rotundo, combinando la pasión por el deporte con la " +
        "emoción de un sorteo, y culminando en una experiencia inolvidable para los ganadores. Progreso Aeroservicios, comprometido " +
        "con la comunidad, sigue brindando su apoyo a eventos locales que fomentan la participación y el disfrute de actividades saludables.",
        2
    }
);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsContents");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
