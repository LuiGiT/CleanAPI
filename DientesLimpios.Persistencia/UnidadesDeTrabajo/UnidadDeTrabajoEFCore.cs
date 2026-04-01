using DientesLimpios.Aplicacion.Contratos.Persistencia;


namespace DientesLimpios.Persistencia.UnidadesDeTrabajo
{
    public class UnidadDeTrabajoEFCore : IUnidadDeTrabajo
    {
        private readonly DientesLimpiosDbContext context;

        public UnidadDeTrabajoEFCore(DientesLimpiosDbContext context)
        {
            this.context = context;
        }

        public async Task Persistir()
        {
            await context.SaveChangesAsync();
        }

        public async Task Reversar()
        {
            await Task.CompletedTask;
        }
    }
}
