using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerDetalleDentista
{
    public class ConsultaObtenerDetalleDentista : IRequest<DentistaDTO>
    {
        public required Guid Id { get; set; }
    }
}
