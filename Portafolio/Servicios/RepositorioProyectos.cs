using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Quesabirrias el Compadre",
                    Descripcion = "Nada, el otro día compre ahí y me cayó pesado",
                     Link = "https://zelda.fandom.com/es/wiki/Link",
                    ImageURL = "/imagenes/Quesadilla.jpg "
                },

                new Proyecto
                {
                    Titulo = "Tacos Valle Alto",
                    Descripcion = "Ahí estaban buenos los tacos pero mi tío traspaso la taqueria",
                    Link = "https://zelda.fandom.com/es/wiki/Link",
                    ImageURL = "/imagenes/tacos.png "
                },

                new Proyecto
                {
                    Titulo = "DAKI Sushi",
                    Descripcion = "Buen ambiente laboral, me hicieron chivo jajaj",
                    Link = "https://zelda.fandom.com/es/wiki/Link",
                    ImageURL = "/imagenes/sushi.jpg "
                }
            };
        }
    }
}
