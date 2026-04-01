using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Comandos.BorrarDentista
{
    public class ComandoBorrarDentista : IRequest
    {
        public Guid Id { get; set; }
    }
}
