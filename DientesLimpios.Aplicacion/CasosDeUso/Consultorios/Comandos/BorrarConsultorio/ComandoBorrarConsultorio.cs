using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Consultorios.Comandos.BorrarConsultorio
{
    public class ComandoBorrarConsultorio : IRequest
    {
        public Guid Id { get; set; }
    }
}
