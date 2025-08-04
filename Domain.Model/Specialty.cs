namespace Domain.Model
{
    public class Specialty : BusinessEntity
    {
        public string Descripcion { get; private set; }

        public Specialty(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }
    }
}