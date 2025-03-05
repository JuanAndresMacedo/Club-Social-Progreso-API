using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.NewsFolder.Entities
{
    public static class NewsData
    {
        private static readonly string News1Id = Guid.NewGuid().ToString();
        private static readonly string News2Id = Guid.NewGuid().ToString();
        private static readonly string News3Id = Guid.NewGuid().ToString();
        private static readonly string News4Id = Guid.NewGuid().ToString();
        private static readonly string News5Id = Guid.NewGuid().ToString();
        private static readonly string News6Id = Guid.NewGuid().ToString();
        private static readonly string News7Id = Guid.NewGuid().ToString();

        public static List<News> NewsList = new List<News>
        {
            new News
            {
                Id = News1Id,
                Title = "Volleyball: se juega la 13a fecha del apertura",
                Description = "Se jugara en el polideportivo de las piedras contra el equipo de Enfoque.",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/partidoVolley.jpg",
                Date = "27/08",
                Topic = "volleyball",
                VerticalImage = true,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "Este 30 de agosto, los equipos de Progreso y Enfoque se verán las caras en un emocionante encuentro correspondiente a la 13ª fecha del torneo Apertura de volleyball. El partido se llevará a cabo en el Polideportivo de Las Piedras, donde ambos equipos buscarán sumar puntos clave para escalar posiciones en la tabla.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "Progreso llega con la motivación de continuar con su racha positiva, mientras que Enfoque intentará sorprender y llevarse la victoria en un terreno que no será fácil. Con ambos equipos mostrando un nivel competitivo en sus últimos encuentros, se espera un partido lleno de emoción y lucha en cada punto.",
                        Index = 2 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "No te pierdas este gran enfrentamiento, que además será transmitido en vivo por las plataformas oficiales del Club Social Progreso. ¡Vamos Progreso!",
                        Index = 3 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "🕜 Fecha y hora: 30 de agosto - 18:30",
                        Index = 4 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "📍 Lugar: Polideportivo de Las Piedras",
                        Index = 5 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News1Id,
                        Paragraph = "🎥 Transmisión en vivo: @CSPVolleyMasculino",
                        Index = 6 }
                }
            },
            new News
            {
                Id = News2Id,
                Title = "¡Campeones del apertura!",
                Description = "Progreso logró el campeonato apertura del torneo ACB",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/mayores.webp",
                Date = "20/08",
                Topic = "handball",
                VerticalImage = false,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News2Id,
                        Paragraph = "En una jornada donde la humedad amenazaba con suspender la jornada, Progreso se alzó con el título del Torneo Apertura de la Super Liga Masculina (SLM), reafirmándose como uno de los equipos más destacados del handball ACB. La competencia inicial de la SLM contó con la participación de siete equipos que se enfrentaron en un formato de todos contra todos, culminando en semifinales y finales disputadas por los cuatro mejores clasificados.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News2Id,
                        Paragraph = "Los equipos que lograron llegar a las semifinales fueron Malvin, Progreso, Seminario y Maldonado. Tras emocionantes encuentros, el equipo de la playa y el equipo canario lograron el triunfo, asegurando su pase a la final del torneo.",
                        Index = 2 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News2Id,
                        Paragraph = "El partido decisivo se llevó a cabo el pasado 22 de junio en la cancha del Colegio Clara Jackson. Fue un encuentro de alta intensidad, donde ambos equipos desplegaron sus mejores tácticas y habilidades sobre el campo de juego. Progreso logró imponerse con un marcador de 22-17, sumando así una nueva copa a su historia en el handball.",
                        Index = 3 }
                }
            },
            new News
            {
                Id = News3Id,
                Title = "Remodelación del club",
                Description = "El club ha renovado su fachada con una nueva capa de pintura vibrante.",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/clubImages/club.webp",
                Date = "12/08",
                Topic = "general",
                VerticalImage = false,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News3Id,
                        Paragraph = "El Club Social Progreso ha dado un paso más hacia la modernización al renovar su fachada con una nueva y vibrante capa de pintura. La actualización, que ya ha captado la atención de los miembros y visitantes, refleja el compromiso del club con la mejora continua de sus instalaciones.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News3Id,
                        Paragraph = "La elección de colores vibrantes no solo revitaliza la apariencia del club, sino que también simboliza el espíritu dinámico y la energía de su comunidad. Esta renovación es parte de una serie de mejoras que el club ha estado implementando para ofrecer un ambiente más acogedor y moderno a todos sus socios.",
                        Index = 2 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News3Id,
                        Paragraph = "Con esta nueva imagen, el Club Social Progreso sigue consolidándose como un punto de encuentro clave en la comunidad, donde el deporte, la recreación y el compañerismo se entrelazan en un espacio que ahora luce mejor que nunca.",
                        Index = 3 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News3Id,
                        Paragraph = "¡Invitamos a todos a pasar por el club y disfrutar de esta renovada fachada que marca un nuevo capítulo en nuestra historia!",
                        Index = 4 }
                }
            },
            new News
            {
                Id = News4Id,
                Title = "Campeonato de truco",
                Description = "Se organiza un emocionante campeonato de truco con el objetivo de recaudar fondos en beneficio del plantel de mayores del handball masculino",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/truco.webp",
                Date = "01/08",
                Topic = "handball",
                VerticalImage = true,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "El Club Social Progreso organiza un emocionante campeonato de truco con el objetivo de recaudar fondos en beneficio del plantel de mayores del handball masculino. El evento, que promete ser una jornada de entretenimiento y camaradería, se llevará a cabo el próximo fin de semana en las instalaciones del club.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "Con el espíritu de colaboración y apoyo entre los socios, el torneo de truco reunirá a jugadores de todas las edades en un ambiente ameno, donde la pasión por el juego y el deseo de contribuir al crecimiento del equipo de handball serán los protagonistas. Los fondos recaudados durante el evento se destinarán a mejorar el equipamiento y a cubrir los gastos necesarios para la próxima temporada.",
                        Index = 2 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "La inscripción está abierta para todos aquellos que deseen participar y contribuir a esta noble causa. Además, habrá premios para las parejas ganadoras y sorteos entre todos los presentes, lo que añade un extra de emoción al evento.",
                        Index = 3 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "No pierdas la oportunidad de ser parte de esta iniciativa que fortalece el vínculo entre los socios y apoya a nuestros deportistas. ¡Te esperamos para compartir una jornada de truco, risas y solidaridad!",
                        Index = 4 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "🕜 Fecha y hora: 05 de agosto - 20:30",
                        Index = 5 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News4Id,
                        Paragraph = "📍 Lugar: Club Social Progreso",
                        Index = 6 }
                }
            },
            new News
            {
                Id = News5Id,
                Title = "Finalizó la 79° vuelta ciclista del Uruguay",
                Description = "Una gran experiencia para todos los que participaron en cada uno de sus roles.",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/ciclismo.webp",
                Date = "24/07",
                Topic = "ciclismo",
                VerticalImage = false,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News5Id,
                        Paragraph = "La 79ª edición de la Vuelta Ciclista del Uruguay ha llegado a su fin, dejando una huella imborrable en todos aquellos que participaron en esta histórica competencia. Desde los ciclistas que demostraron su valentía y destreza en cada etapa, hasta los entrenadores, organizadores y aficionados que apoyaron incansablemente, todos vivieron una experiencia única y enriquecedora.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News5Id,
                        Paragraph = "Durante varias jornadas, los competidores recorrieron cientos de kilómetros a lo largo de las rutas uruguayas, enfrentando desafíos tanto físicos como mentales. Cada pedalada fue una muestra de perseverancia y dedicación, lo que hizo de esta vuelta un evento memorable. Los paisajes del país fueron el escenario perfecto para una competencia repleta de emoción, estrategia y esfuerzo.",
                        Index = 2 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News5Id,
                        Paragraph = "La organización del evento, a cargo de la Federación Ciclista Uruguaya, fue impecable, garantizando la seguridad y el bienestar de todos los participantes. Además, el apoyo del público en cada localidad fue fundamental, creando una atmósfera de celebración y compañerismo que será recordada por mucho tiempo.",
                        Index = 3 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News5Id,
                        Paragraph = "Con la culminación de esta vuelta, los ciclistas no solo se llevan trofeos y reconocimientos, sino también vivencias y aprendizajes que trascienden la competencia. La 79ª Vuelta Ciclista del Uruguay no solo reafirma la importancia del deporte en la sociedad, sino que también deja una inspiración para futuras generaciones de ciclistas que sueñan con formar parte de este legendario evento.",
                        Index = 4 }
                }
            },
            new News
            {
                Id = News6Id,
                Title = "¡Uruguay campeón del mundo en bochas!",
                Description = "Por primera vez en la historia, nuestro país ha logrado conquistar una medalla de oro en Bochas",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/bochas.jpg",
                Date = "21/07",
                Topic = "bochas",
                VerticalImage = true,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News6Id,
                        Paragraph = "¡Uruguay ha alcanzado la gloria en el ámbito deportivo internacional! Por primera vez en la historia, nuestro país ha logrado conquistar una medalla de oro en Bochas, y no podríamos estar más emocionados. Gonzalo Perdomo, un talentoso atleta uruguayo, se ha coronado campeón mundial tras una impresionante victoria en el Mundial Juvenil de Oran, Argelia. En la disciplina de Tiro de Precisión estilo Raffa Volo, Perdomo demostró una habilidad y determinación excepcionales, superando al representante de Paraguay en una final que quedará grabada en la memoria de todos los uruguayos.",
                        Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News6Id,
                        Paragraph = "Este logro es el resultado de un esfuerzo colectivo. Queremos extender nuestro más sincero agradecimiento a todos quienes hicieron posible este hito: familiares, amigos, comercios, y el Municipio. La comunidad del Club Social Progreso se enorgullece de este triunfo y agradece profundamente el apoyo brindado. La victoria de Gonzalo Perdomo es un reflejo del esfuerzo, dedicación y espíritu de superación que caracteriza a nuestro país. ¡Gracias a todos, y un fuerte aplauso para Gonzalo! ¡Arriba Uruguay!",
                        Index = 2 }
                }
            },
             new News
            {
                Id = News7Id,
                Title = "Ciclismo: premios del Bingo",
                Description = "Se efectivizaron los vuelos en helicóptero, premios del bingo del ciclismo.",
                ImageUrl = "https://csp-images-bucket.s3.us-east-1.amazonaws.com/assets/news/vuelo.webp",
                Date = "29/06",
                Topic = "ciclismo",
                VerticalImage = false,
                Content = new List<NewsContent>
                {
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News7Id,
                        Paragraph = "El pasado fin de semana, se hicieron realidad los esperados vuelos en helicóptero que habían sido sorteados como premios del popular bingo del ciclismo. Los afortunados ganadores disfrutaron de una experiencia única al sobrevolar la región, apreciando las impresionantes vistas desde las alturas. Este emocionante evento fue posible gracias al apoyo de Progreso Aeroservicios, que no solo proporcionó las aeronaves, sino que también garantizó la seguridad y el disfrute de todos los participantes.", Index = 1 },
                    new NewsContent {
                        Id = Guid.NewGuid().ToString(),
                        NewsId = News7Id,
                        Paragraph = "La iniciativa del bingo del ciclismo ha demostrado ser un éxito rotundo, combinando la pasión por el deporte con la emoción de un sorteo, y culminando en una experiencia inolvidable para los ganadores. Progreso Aeroservicios, comprometido con la comunidad, sigue brindando su apoyo a eventos locales que fomentan la participación y el disfrute de actividades saludables.", Index = 2 }
                }
            }
        };
    }
}
