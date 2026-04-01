using DientesLimpios.Aplicacion.Utilidades.Comunes;
using DientesLimpios.Aplicacion.Utilidades.Mediator;

namespace DientesLimpios.Aplicacion.CasosDeUso.Pacientes.Consultas.ObtenerListadoPacientes
{
    public class ConsultaObtenerListadoPacientes: FiltroPacienteDTO, IRequest<PaginadoDTO<PacienteListadoDTO>>
    {

    }
}
