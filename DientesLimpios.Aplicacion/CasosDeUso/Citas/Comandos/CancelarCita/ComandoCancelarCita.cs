using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Citas.Comandos.CancelarCita
{
    public class ComandoCancelarCita: IRequest
    {
        public required Guid Id { get; set; }
    }
}
