using System.Threading.Tasks;

namespace QuentameBlazor.Repositories
{
    public interface IRepositoryWrapper
    {
        //IUserRepository User { get; }
        ITercerosRepository Tercero { get; }
        ITipoTerceroRepository TipoTercero { get; }
        IDptoRepository Dpto { get; }
        ICiudadRepository Ciudad { get; }
        IPaisRepository Pais { get; }
        ITipoDocRepository TipoDoc { get; }
        ITipoRegimenRepository TipoReg { get; }
        IInventarioRepository Inventario { get; }
        IInvAgrupRepository InvAgrup { get; }
        IInvClasifImptoRepository InvClasifImpto { get; }
        IInvTiposRepository InvTipos { get; }
        IInvUnidadesRepository InvUnidades { get; }
        IInvListasRepository InvListas { get; }
        IEncabezadoRepository Encabezado { get; }
        IEncabezadoMovRepository EncabezadoMov { get; }
        IFormasPagoRepository FormaPago { get; }
        IMonedasRepository Moneda { get; }
        IInvKardexRepository InvKardex { get; }
        IArqueoRepository Arqueo { get; }
        IUserRepository Usuario { get; }
        IEmpresaRepository Empresa { get; }
        IInvFormulaRepository Formula { get; }
        IResolucionRepository Resolucion { get; }
        IUsuarioSystemConfigRepository UsuarioSystemConfig { get; }
        int Save();
        Task SaveAsync();
    }
}