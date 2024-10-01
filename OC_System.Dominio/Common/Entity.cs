namespace OC_System.Dominio.Common
{
    /// <summary>
    /// Clase base para todas las entidades en el soporte de datos.
    /// </summary>

    public abstract class Entity
    {
        #region
        /// <summary>
        /// Identificador del objeto
        /// </summary>
        public Guid Id { get; set; }
        #endregion

        /// <summary>
        /// Constructor por defecto de objeto tipo Entity
        /// </summary>
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Modela un objeto tipo Entity
        /// </summary>
        /// <param name="id"></param>
        protected Entity(Guid id)
        {
            Id = id;
        }
    } 
}
