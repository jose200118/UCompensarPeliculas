using Microsoft.AspNetCore.Mvc;
using UCompensarPeliculas.Models.comentario;
using UCompensarPeliculas.Models.genero;
using UCompensarPeliculas.Models.pelicula;

namespace UCompensarPeliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly List<PeliculaDTO> _peliculas = [
            new() {
                Id = 1,
                Titulo = "Intensamente 2",
                Descripcion = "La secuela de Intensamente con nuevas emociones.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 1, Nombre = "Animación" }
                },
                FechaEstreno = new DateTime(2024, 6, 14),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/f/f7/Inside_Out_2_poster.jpg",
                Reparto = new List<string> { "Amy Poehler", "Maya Hawke", "Kensington Tallman" },
                Sinopsis = "Alegría y sus amigas enfrentan nuevas emociones cuando Riley entra a la adolescencia.",
                Comentarios = new List<ComentarioDTO> { 
                    new() { 
                        Usuario = "Camila", 
                        Texto = "Hermosa película para todas las edades.",
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 2,
                Titulo = "Oppenheimer",
                Descripcion = "Biografía de J. Robert Oppenheimer, el padre de la bomba atómica.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 2, Nombre = "Drama" },
                    new() { Id = 3, Nombre = "Historia" }
                },
                FechaEstreno = new DateTime(2023, 7, 21),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/4/4a/Oppenheimer_%28film%29.jpg",
                Reparto = new List<string> { "Cillian Murphy", "Emily Blunt", "Matt Damon" },
                Sinopsis = "La historia del físico teórico J. Robert Oppenheimer y su rol en el Proyecto Manhattan.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Luis", 
                        Texto = "Excelente dirección y actuaciones.", 
                        FechaComentario = DateTime.Now 
                    },
                }
            },
            new() {
                Id = 3,
                Titulo = "Barbie",
                Descripcion = "Una historia sobre autodescubrimiento en un mundo de plástico.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 4, Nombre = "Comedia" },
                    new() { Id = 5, Nombre = "Fantasía" }
                },
                FechaEstreno = new DateTime(2023, 7, 21),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/0/0b/Barbie_2023_poster.jpg",
                Reparto = new List<string> { "Margot Robbie", "Ryan Gosling" },
                Sinopsis = "Barbie empieza a cuestionar su mundo perfecto y busca respuestas en el mundo real.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Laura", 
                        Texto = "Divertida y sorprendentemente profunda.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 4,
                Titulo = "The Batman",
                Descripcion = "El caballero oscuro regresa en una nueva versión.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 6, Nombre = "Acción" },
                    new() { Id = 7, Nombre = "Thriller" }
                },
                FechaEstreno = new DateTime(2022, 3, 4),
                UrlPoster = "",
                Reparto = new List<string> { "Robert Pattinson", "Zoë Kravitz", "Paul Dano" },
                Sinopsis = "Batman investiga una serie de asesinatos conectados con la corrupción de Gotham.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Juan",
                        Texto = "La mejor versión de Batman desde Nolan.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 5,
                Titulo = "Dune: Parte Dos",
                Descripcion = "La épica continúa con Paul Atreides y los Fremen.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 8, Nombre = "Ciencia Ficción" },
                    new() { Id = 9, Nombre = "Aventura" }
                },
                FechaEstreno = new DateTime(2024, 3, 1),
                UrlPoster = "https://preview.redd.it/new-poster-for-dune-2-v0-5938pz4qcsic1.jpeg?width=1080&crop=smart&auto=webp&s=06203326d6c67ee4d54950109cd9cc4b67dca6c3",
                Reparto = new List<string> { "Timothée Chalamet", "Zendaya", "Florence Pugh" },
                Sinopsis = "Paul busca venganza mientras lidera la revolución en Arrakis.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Pedro",
                        Texto = "Una obra visualmente impresionante.",
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 6,
                Titulo = "Avatar: El sentido del agua",
                Descripcion = "Regreso al mundo de Pandora en una nueva aventura acuática.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 8, Nombre = "Ciencia Ficción" },
                    new() { Id = 9, Nombre = "Aventura" }
                },
                FechaEstreno = new DateTime(2022, 12, 16),
                UrlPoster = "https://pics.filmaffinity.com/avatar_the_way_of_water-722646748-large.jpg",
                Reparto = new List<string> { "Sam Worthington", "Zoe Saldaña", "Sigourney Weaver" },
                Sinopsis = "Jake Sully y Neytiri enfrentan nuevas amenazas para su familia en los océanos de Pandora.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Andrea", 
                        Texto = "Visualmente asombrosa, vale cada minuto.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 7,
                Titulo = "Super Mario Bros. La Película",
                Descripcion = "Mario y Luigi viajan por el Reino Champiñón.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 1, Nombre = "Animación" },
                    new() { Id = 9, Nombre = "Aventura" }
                },
                FechaEstreno = new DateTime(2023, 4, 5),
                UrlPoster = "https://i.blogs.es/617177/super-mario-bros-pelicula-mario/450_1000.webp",
                Reparto = new List<string> { "Chris Pratt", "Anya Taylor-Joy", "Jack Black" },
                Sinopsis = "Mario y Luigi deben salvar el Reino Champiñón del malvado Bowser.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "David", 
                        Texto = "Muy divertida para los fans del videojuego.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 8,
                Titulo = "Top Gun: Maverick",
                Descripcion = "El regreso de un piloto legendario.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 6, Nombre = "Acción" },
                    new() { Id = 2, Nombre = "Drama" }
                },
                FechaEstreno = new DateTime(2022, 5, 27),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/1/13/Top_Gun_Maverick_Poster.jpg",
                Reparto = new List<string> { "Tom Cruise", "Miles Teller", "Jennifer Connelly" },
                Sinopsis = "Maverick debe entrenar a una nueva generación de pilotos para una peligrosa misión.",
                Comentarios = new List<ComentarioDTO> {
                    new() {
                        Usuario = "Miguel", 
                        Texto = "Acción intensa y muy bien lograda.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new()
            {
                Id = 9,
                Titulo = "Spider-Man: No Way Home",
                Descripcion = "Tres Spider-Man, un mismo universo.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 6, Nombre = "Acción" },
                    new() { Id = 9, Nombre = "Aventura" }
                },
                FechaEstreno = new DateTime(2021, 12, 17),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                Reparto = new List<string> { "Tom Holland", "Andrew Garfield", "Tobey Maguire" },
                Sinopsis = "Peter Parker rompe el multiverso y se encuentra con versiones alternativas de sí mismo.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Sofía", 
                        Texto = "Nostalgia y emoción en una sola película.",
                        FechaComentario = DateTime.Now
                    }
                }
            },
            new() {
                Id = 10,
                Titulo = "Matrix Resurrecciones",
                Descripcion = "Neo regresa al mundo virtual en busca de respuestas.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 8, Nombre = "Ciencia Ficción" },
                    new() { Id = 6, Nombre = "Acción" }
                },
                FechaEstreno = new DateTime(2021, 12, 22),
                UrlPoster = "https://mir-s3-cdn-cf.behance.net/project_modules/source/69148f105575139.62dd8574d5c7b.jpg",
                Reparto = new List<string> { "Keanu Reeves", "Carrie-Anne Moss", "Yahya Abdul-Mateen II" },
                Sinopsis = "En un nuevo Matrix, Neo busca liberar su mente nuevamente.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Daniel",
                        Texto = "Para los fanáticos de la saga original, aunque algo confusa.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 11,
                Titulo = "El curioso caso de Benjamin Button",
                Descripcion = "Un hombre nace con la apariencia de un anciano y rejuvenece con el paso del tiempo.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 1, Nombre = "Drama" },
                    new() { Id = 3, Nombre = "Romántica" }
                },
                FechaEstreno = new DateTime(2008, 12, 25),
                UrlPoster = "https://pics.filmaffinity.com/the_curious_case_of_benjamin_button-553974725-large.jpg",
                Reparto = new List<string> { "Brad Pitt", "Cate Blanchett", "Tilda Swinton" },
                Sinopsis = "Benjamin Button vive su vida al revés, envejece de manera inusual mientras busca el amor y la comprensión.",
                Comentarios = new List<ComentarioDTO> {
                    new() {
                        Usuario = "Ana",
                        Texto = "Una historia emotiva y única sobre la vida y el amor.",
                        FechaComentario = DateTime.Now
                    }
                }
            },
            new() {
                Id = 12,
                Titulo = "Titanic",
                Descripcion = "Una joven pareja se enamora a bordo del lujoso y fatal viaje del RMS Titanic.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 2, Nombre = "Drama" },
                    new() { Id = 3, Nombre = "Romántica" },
                    new() { Id = 4, Nombre = "Aventura" }
                },
                FechaEstreno = new DateTime(1997, 12, 19),
                UrlPoster = "https://pics.filmaffinity.com/titanic-321994924-large.jpg",
                Reparto = new List<string> { "Leonardo DiCaprio", "Kate Winslet", "Billy Zane" },
                Sinopsis = "El amor florece entre dos personas de clases sociales diferentes a bordo del fatídico Titanic.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Carlos",
                        Texto = "Una de las historias de amor más épicas de la historia del cine.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            },
            new() {
                Id = 13,
                Titulo = "Inception",
                Descripcion = "Un ladrón especializado en robar secretos a través del subconsciente de las personas recibe una tarea aún más compleja.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 8, Nombre = "Ciencia Ficción" },
                    new() { Id = 6, Nombre = "Acción" },
                    new() { Id = 7, Nombre = "Suspenso" }
                },
                FechaEstreno = new DateTime(2010, 07, 16),
                UrlPoster = "https://pics.filmaffinity.com/inception-652954101-large.jpg",
                Reparto = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" },
                Sinopsis = "Un experto en la extracción de secretos debe realizar un 'inception': plantar una idea en la mente de una persona.",
                Comentarios = null
            },
            new() {
                Id = 14,
                Titulo = "The Shawshank Redemption",
                Descripcion = "La historia de un hombre condenado injustamente a cadena perpetua y su lucha por encontrar esperanza en prisión.",
                Generos = new List<GeneroDTO> {
                    new() { Id = 2, Nombre = "Drama" }
                },
                FechaEstreno = new DateTime(1994, 09, 23),
                UrlPoster = "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg",
                Reparto = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                Sinopsis = "Un hombre enfrenta la dura realidad de la vida en prisión mientras busca un escape hacia la libertad.",
                Comentarios = new List<ComentarioDTO> {
                    new() { 
                        Usuario = "Miguel",
                        Texto = "Una de las películas más poderosas sobre la esperanza y la redención.", 
                        FechaComentario = DateTime.Now 
                    }
                }
            }
        ];

        private readonly List<GeneroDTO> _generos = [
            new() { Id = 1, Nombre = "Animación" },
            new() { Id = 2, Nombre = "Drama" },
            new() { Id = 3, Nombre = "Historia" },
            new() { Id = 4, Nombre = "Comedia" },
            new() { Id = 5, Nombre = "Fantasía" },
            new() { Id = 6, Nombre = "Acción" },
            new() { Id = 7, Nombre = "Thriller" },
            new() { Id = 8, Nombre = "Ciencia Ficción" },
            new() { Id = 9, Nombre = "Aventura" }
        ];


        [HttpGet("/")]
        [HttpGet("/Peliculas")]
        //[HttpGet()]
        public ActionResult Index(int genero, string buscar)
        {
            var peliculas = _peliculas.Where(p => p.Generos.Any(g => g.Id == genero)).ToList();
            if (genero == 0)
            {
                peliculas = _peliculas;
            }

            if (!string.IsNullOrEmpty(buscar))
            {
                peliculas = peliculas.Where(p => p.Titulo.ToLower().Contains(buscar.ToLower())).ToList();
            }
            peliculas = [.. peliculas.OrderByDescending(p => p.FechaEstreno)];

            ViewBag.Generos = _generos;
            return View(peliculas);
        }

        [HttpGet("[controller]/detalle/{id}")]
        public ActionResult Details(int id)
        {
            var detellePelicula = _peliculas.FirstOrDefault(p => p.Id == id);
            return View(detellePelicula);
        }

        // POST: PeliculasController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
