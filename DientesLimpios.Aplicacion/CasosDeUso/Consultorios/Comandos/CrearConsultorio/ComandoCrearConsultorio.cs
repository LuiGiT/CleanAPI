using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Comandos.CrearConsultorio
{
    public class ComandoCrearConsultorio : IRequest<Guid>
    {
        public required string Nombre { get; set; }
    }
}
