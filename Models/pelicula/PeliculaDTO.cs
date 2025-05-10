using UCompensarPeliculas.Models.comentario;
using UCompensarPeliculas.Models.genero;

namespace UCompensarPeliculas.Models.pelicula
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<GeneroDTO> Generos { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string UrlPoster { get; set; }
        public List<string> Reparto { get; set; }
        public string Sinopsis { get; set; }
        public List<ComentarioDTO> Comentarios { get; set; }
    }
}
