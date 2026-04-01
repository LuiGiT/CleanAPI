using DientesLimpios.Aplicacion.Utilidades.Comunes;
using DientesLimpios.Aplicacion.Utilidades.Mediator;


namespace DientesLimpios.Aplicacion.CasosDeUso.Dentistas.Consultas.ObtenerListadoDentistas
{
    public class ConsultaObtenerListadoDentistas : FiltroDentistasDTO, IRequest<PaginadoDTO<DentistaListadoDTO>>
    {
    }
}
