using QuentameBlazor.Context;
using System.Threading.Tasks;

namespace QuentameBlazor.Server.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AppDbContext _dbContext;
        private ITercerosRepository tercero;
        private ITipoTerceroRepository tipotercero;
        private IDptoRepository dpto;
        private ICiudadRepository ciudad;
        private IPaisRepository pais;
        private ITipoDocRepository tipodoc;
        private ITipoRegimenRepository tiporeg;
        private IInventarioRepository inventario;
        private IInvAgrupRepository invagrup;
        private IInvClasifImptoRepository invclasifimpto;
        private IInvTiposRepository invtipos;
        private IInvUnidadesRepository invunidades;
        private IInvListasRepository invlistas;
        private IEncabezadoRepository encabezado;
        private IEncabezadoMovRepository encabezadomov;
        private IInvPreciosRepository precios;
        private IFormasPagoRepository formapago;
        private IMonedasRepository moneda;
        private IInvKardexRepository invkardex;
        private IArqueoRepository arqueo;
        private IUserRepository usuario;
        private IEmpresaRepository empresa;
        private IInvFormulaRepository formula;
        private IResolucionRepository resolucion;
        private IUsuarioSystemConfigRepository usuarioconfigsystem;

        public ITercerosRepository Tercero
        {
            get
            {
                if (tercero == null)
                {
                    tercero = new TercerosRepository(_dbContext);
                }

                return tercero;
            }
        }

        public ITipoTerceroRepository TipoTercero
        {
            get
            {
                if (tipotercero == null)
                {
                    tipotercero = new TipoTerceroRepository(_dbContext);
                }

                return tipotercero;
            }
        }

        public IDptoRepository Dpto
        {
            get
            {
                if (dpto == null)
                {
                    dpto = new DptoRepository(_dbContext);
                }

                return dpto;
            }
        }

        public ICiudadRepository Ciudad
        {
            get
            {
                if (ciudad == null)
                {
                    ciudad = new CiudadRepository(_dbContext);
                }

                return ciudad;
            }
        }

        public IPaisRepository Pais
        {
            get
            {
                if (pais == null)
                {
                    pais = new PaisRepository(_dbContext);
                }

                return pais;
            }
        }

        public ITipoDocRepository TipoDoc
        {
            get
            {
                if (tipodoc == null)
                {
                    tipodoc = new TipoDocRepository(_dbContext);
                }

                return tipodoc;
            }
        }

        public ITipoRegimenRepository TipoReg
        {
            get
            {
                if (tiporeg == null)
                {
                    tiporeg = new TipoRegimenRepository(_dbContext);
                }

                return tiporeg;
            }
        }

        public IInventarioRepository Inventario
        {
            get
            {
                if (inventario == null)
                {
                    inventario = new InventarioRepository(_dbContext);
                }

                return inventario;
            }
        }

        public IInvAgrupRepository InvAgrup
        {
            get
            {
                if (invagrup == null)
                {
                    invagrup = new InvAgrupRepository(_dbContext);
                }

                return invagrup;
            }
        }

        public IInvClasifImptoRepository InvClasifImpto
        {
            get
            {
                if (invclasifimpto == null)
                {
                    invclasifimpto = new InvClasifImptoRepository(_dbContext);
                }

                return invclasifimpto;
            }
        }

        public IInvTiposRepository InvTipos
        {
            get
            {
                if (invtipos == null)
                {
                    invtipos = new InvTiposRepository(_dbContext);
                }

                return invtipos;
            }
        }

        public IInvUnidadesRepository InvUnidades
        {
            get
            {
                if (invunidades == null)
                {
                    invunidades = new InvUnidadesRepository(_dbContext);
                }

                return invunidades;
            }
        }

        public IInvListasRepository InvListas
        {
            get
            {
                if (invlistas == null)
                {
                    invlistas = new InvListasRepository(_dbContext);
                }

                return invlistas;
            }
        }

        public IEncabezadoRepository Encabezado
        {
            get
            {
                if (encabezado == null)
                {
                    encabezado = new EncabezadoRepository(_dbContext);
                }

                return encabezado;
            }
        }

        public IEncabezadoMovRepository EncabezadoMov
        {
            get
            {
                if (encabezadomov == null)
                {
                    encabezadomov = new EncabezadoMovRepository(_dbContext);
                }

                return encabezadomov;
            }
        }

        public IInvPreciosRepository Precios
        {
            get
            {
                if (precios == null)
                {
                    precios = new InvPreciosRepository(_dbContext);
                }

                return precios;
            }
        }

        public IFormasPagoRepository FormaPago
        {
            get
            {
                if (formapago == null)
                {
                    formapago = new FormasPagoRepository(_dbContext);
                }

                return formapago;
            }
        }

        public IMonedasRepository Moneda
        {
            get
            {
                if (moneda == null)
                {
                    moneda = new MonedasRepository(_dbContext);
                }

                return moneda;
            }
        }

        public IInvKardexRepository InvKardex
        {
            get
            {
                if (invkardex == null)
                {
                    invkardex = new InvKardexRepository(_dbContext);
                }

                return invkardex;
            }
        }

        public IArqueoRepository Arqueo
        {
            get
            {
                if (arqueo == null)
                {
                    arqueo = new ArqueoRepository(_dbContext);
                }

                return arqueo;
            }
        }

        public IUserRepository Usuario
        {
            get
            {
                if (usuario == null)
                {
                    usuario = new UserRepository(_dbContext);
                }

                return usuario;
            }
        }

        public IEmpresaRepository Empresa
        {
            get
            {
                if (empresa == null)
                {
                    empresa = new EmpresaRepository(_dbContext);
                }

                return empresa;
            }
        }

        public IInvFormulaRepository Formula
        {
            get
            {
                if (formula == null)
                {
                    formula = new InvFormulaRepository(_dbContext);
                }

                return formula;
            }
        }

        public IResolucionRepository Resolucion
        {
            get
            {
                if (resolucion == null)
                {
                    resolucion = new ResolucionRepository(_dbContext);
                }

                return resolucion;
            }
        }

        public IUsuarioSystemConfigRepository UsuarioSystemConfig
        {
            get
            {
                if (usuarioconfigsystem == null)
                {
                    usuarioconfigsystem = new UsuarioSystemConfigRepository(_dbContext);
                }

                return usuarioconfigsystem;
            }
        }

        public RepositoryWrapper(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}