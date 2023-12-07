using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class UsoCfdi : SmartEnum<UsoCfdi, string>
{
    /// <summary>
    ///     G01 - Adquisición de mercancías.
    /// </summary>
    public static readonly UsoCfdi AdquisicionDeMercancias = new("Adquisición de mercancías", "G01",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     G02 - Devoluciones, descuentos o bonificaciones.
    /// </summary>
    public static readonly UsoCfdi DevolucionesDescuentosOBonificaciones = new("Devoluciones, descuentos o bonificaciones", "G02",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     G03 - Gastos en general.
    /// </summary>
    public static readonly UsoCfdi GastosEnGeneral = new("Gastos en general", "G03",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I01 - Construcciones.
    /// </summary>
    public static readonly UsoCfdi Construcciones = new("Construcciones", "I01",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I02 - Mobiliario y equipo de oficina por inversiones.
    /// </summary>
    public static readonly UsoCfdi MobiliarioYEquipoDeOficinaPorInversiones = new("Mobiliario y equipo de oficina por inversiones", "I02",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I03 - Equipo de transporte.
    /// </summary>
    public static readonly UsoCfdi EquipoDeTransporte = new("Equipo de transporte", "I03",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I04 - Equipo de computo y accesorios.
    /// </summary>
    public static readonly UsoCfdi EquipoDeComputoYAccesorios = new("Equipo de computo y accesorios", "I04",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I05 - Dados, troqueles, moldes, matrices y herramental.
    /// </summary>
    public static readonly UsoCfdi DadosTroquelesMoldesMatricesYHerramental = new("Dados, troqueles, moldes, matrices y herramental", "I05",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I06 - Comunicaciones telefónicas.
    /// </summary>
    public static readonly UsoCfdi ComunicacionesTelefonicas = new("Comunicaciones telefónicas", "I06",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I07 - Comunicaciones satelitales.
    /// </summary>
    public static readonly UsoCfdi ComunicacionesSatelitales = new("Comunicaciones satelitales", "I07",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I08 - Otra maquinaria y equipo.
    /// </summary>
    public static readonly UsoCfdi OtraMaquinariaYEquipo = new("Otra maquinaria y equipo", "I08",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     D01 - Honorarios médicos, dentales y gastos hospitalarios.
    /// </summary>
    public static readonly UsoCfdi HonorariosMedicosDentalesYGastosHospitalarios = new(
        "Honorarios médicos, dentales y gastos hospitalarios", "D01",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D02 - Gastos médicos por incapacidad o discapacidad.
    /// </summary>
    public static readonly UsoCfdi GastosMedicosPorIncapacidadODiscapacidad = new("Gastos médicos por incapacidad o discapacidad", "D02",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D03 - Gastos funerales.
    /// </summary>
    public static readonly UsoCfdi GastosFunerales = new("Gastos funerales", "D03",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D04 - Donativos.
    /// </summary>
    public static readonly UsoCfdi Donativos = new("Donativos", "D04",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D05 - Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).
    /// </summary>
    public static readonly UsoCfdi InteresesRealesEfectivamentePagadosPorCreditosHipotecarios = new(
        "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)", "D05",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D06 - Aportaciones voluntarias al SAR.
    /// </summary>
    public static readonly UsoCfdi AportacionesVoluntariasAlSAR = new("Aportaciones voluntarias al SAR", "D06",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D07 - Primas por seguros de gastos médicos.
    /// </summary>
    public static readonly UsoCfdi PrimasPorSegurosDeGastosMedicos = new("Primas por seguros de gastos médicos", "D07",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D08 - Gastos de transportación escolar obligatoria.
    /// </summary>
    public static readonly UsoCfdi GastosDeTransportacionEscolarObligatoria = new("Gastos de transportación escolar obligatoria", "D08",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D09 - Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.
    /// </summary>
    public static readonly UsoCfdi DepósitosEnCuentasParaElAhorro =
        new("Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones", "D09",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D10 - Pagos por servicios educativos (colegiaturas).
    /// </summary>
    public static readonly UsoCfdi PagosPorServiciosEducativos = new("Pagos por servicios educativos (colegiaturas)", "D10",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     S01 - Sin efectos fiscales.
    /// </summary>
    public static readonly UsoCfdi SinEfectosFiscales = new("Sin efectos fiscales", "S01",
        new[] { "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626" });

    /// <summary>
    ///     CP01 - Pagos.
    /// </summary>
    public static readonly UsoCfdi Pagos = new("Pagos", "CP01",
        new[] { "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626" });

    /// <summary>
    ///     CN01 - Nómina.
    /// </summary>
    public static readonly UsoCfdi Nomina = new("Nómina", "CN01", new[] { "605" });

    /// <summary>
    ///     P01 - Por definir.
    /// </summary>
    public static readonly UsoCfdi PorDefinir = new("Por definir", "P01", new List<string>());

    private UsoCfdi(string descripcion, string clave, IEnumerable<string> regimenesFiscales) : base(descripcion, clave)
    {
        foreach (var regimen in regimenesFiscales)
            RegimenesFiscales.Add(RegimenFiscal.TryFromValue(regimen, out var regimenResult)
                ? regimenResult
                : throw new InvalidOperationException($"El regimen fiscal {regimen} no es valido."));
    }

    public List<RegimenFiscal> RegimenesFiscales { get; } = new();
}
