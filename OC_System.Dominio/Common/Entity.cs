namespace OC_System.Dominio.Common
{
    /// <summary>
    /// Clase base para todas las entidades en el soporte de datos.
    /// </summary>

    public abstract class Entity
    {


        public Guid Id { get; set; }
        protected Entity() { }

        protected Entity(Guid id)
        {
            Id = id;
        }


    }
}
