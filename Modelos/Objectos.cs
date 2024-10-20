using System;
using System.ComponentModel.DataAnnotations;


    public class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Inicialización
        public string Desarrollador { get; set; } = string.Empty; // Inicialización
        public int PlataformaId { get; set; }
        public string Genero { get; set; } = string.Empty; // Inicialización
        public DateTime FechaLanzamiento { get; set; }
        public string ImagenPortada { get; set; } = string.Empty; // Inicialización
        public string Descripcion { get; set; } = string.Empty; // Inicialización

        // Propiedad de navegación
        public Plataforma Plataforma { get; set; } = null!;
    }

    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Inicialización
        public string Alias { get; set; } = string.Empty; // Inicialización
        public string Rol { get; set; } = string.Empty; // Inicialización
        public string HabilidadEspecial { get; set; } = string.Empty; // Inicialización
        public string ArmaFavorita { get; set; } = string.Empty; // Inicialización
        public int NivelDePoder { get; set; }
        public string ImagenPersonaje { get; set; } = string.Empty; // Inicialización
        public int VideojuegoId { get; set; }

        // Propiedad de navegación
        public Videojuego Videojuego { get; set; } = null!;
    }
    

    public class Plataforma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la plataforma es obligatorio.")]
        public string Nombre { get; set; } = string.Empty; // Inicializa el campo

        public bool Estado { get; set; } // Puedes considerar si necesitas inicializar esto también
    }
