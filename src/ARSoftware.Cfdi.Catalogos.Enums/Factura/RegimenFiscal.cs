using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class RegimenFiscal : SmartEnum<RegimenFiscal, string>
{
    /// <summary>
    ///     601 - General de Ley Personas Morales.
    /// </summary>
    public static readonly RegimenFiscal GeneralDeLeyPersonasMorales = new("General de Ley Personas Morales", "601");

    /// <summary>
    ///     603 - Personas Morales con Fines no Lucrativos.
    /// </summary>
    public static readonly RegimenFiscal PersonasMoralesConFinesNoLucrativos = new("Personas Morales con Fines no Lucrativos", "603");

    /// <summary>
    ///     605 - Sueldos y Salarios e Ingresos Asimilados a Salarios.
    /// </summary>
    public static readonly RegimenFiscal SueldosYSalariosEIngresosAsimiladosASalarios =
        new("Sueldos y Salarios e Ingresos Asimilados a Salarios", "605");

    /// <summary>
    ///     606 - Arrendamiento.
    /// </summary>
    public static readonly RegimenFiscal Arrendamiento = new("Arrendamiento", "606");

    /// <summary>
    ///     607 - Régimen de Enajenación o Adquisición de Bienes.
    /// </summary>
    public static readonly RegimenFiscal RegimenDeEnajenacionOAdquisicionDeBienes =
        new("Régimen de Enajenación o Adquisición de Bienes", "607");

    /// <summary>
    ///     608 - Demás ingresos.
    /// </summary>
    public static readonly RegimenFiscal DemasIngresos = new("Demás ingresos", "608");

    /// <summary>
    ///     610 - Residentes en el Extranjero sin Establecimiento Permanente en México.
    /// </summary>
    public static readonly RegimenFiscal ResidentesEnElExtranjeroSinEstablecimientoPermanenteEnMexico =
        new("Residentes en el Extranjero sin Establecimiento Permanente en México", "610");

    /// <summary>
    ///     611 - Ingresos por Dividendos (socios y accionistas).
    /// </summary>
    public static readonly RegimenFiscal IngresosPorDividendos = new("Ingresos por Dividendos (socios y accionistas)", "611");

    /// <summary>
    ///     612 - Personas Físicas con Actividades Empresariales y Profesionales.
    /// </summary>
    public static readonly RegimenFiscal PersonasFisicasConActividadesEmpresarialesYProfesionales =
        new("Personas Físicas con Actividades Empresariales y Profesionales", "612");

    /// <summary>
    ///     614 - Ingresos por intereses.
    /// </summary>
    public static readonly RegimenFiscal IngresosPorIntereses = new("Ingresos por intereses", "614");

    /// <summary>
    ///     615 - Régimen de los ingresos por obtención de premios.
    /// </summary>
    public static readonly RegimenFiscal RegimenDeLosIngresosPorObtencionDePremios =
        new("Régimen de los ingresos por obtención de premios", "615");

    /// <summary>
    ///     616 - Sin obligaciones fiscales.
    /// </summary>
    public static readonly RegimenFiscal SinObligacionesFiscales = new("Sin obligaciones fiscales", "616");

    /// <summary>
    ///     620 - Sociedades Cooperativas de Producción que optan por diferir sus ingresos.
    /// </summary>
    public static readonly RegimenFiscal SociedadesCooperativasDeProduccionQueOptanPorDiferirSusIngresos =
        new("Sociedades Cooperativas de Producción que optan por diferir sus ingresos", "620");

    /// <summary>
    ///     621 - Incorporación Fiscal.
    /// </summary>
    public static readonly RegimenFiscal IncorporacionFiscal = new("Incorporación Fiscal", "621");

    /// <summary>
    ///     622 - Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras.
    /// </summary>
    public static readonly RegimenFiscal ActividadesAgricolasGanaderasSilvicolasYPesqueras =
        new("Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras", "622");

    /// <summary>
    ///     623 - Opcional para Grupos de Sociedades.
    /// </summary>
    public static readonly RegimenFiscal OpcionalParaGruposDeSociedades = new("Opcional para Grupos de Sociedades", "623");

    /// <summary>
    ///     624 - Coordinados.
    /// </summary>
    public static readonly RegimenFiscal Coordinados = new("Coordinados", "624");

    /// <summary>
    ///     625 - Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas.
    /// </summary>
    public static readonly RegimenFiscal RegimenDeLasActividadesEmpresarialesConIngresosATravesDePlataformasTecnologicas =
        new("Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas", "625");

    /// <summary>
    ///     626 - Régimen Simplificado de Confianza.
    /// </summary>
    public static readonly RegimenFiscal RegimenSimplificadoDeConfianza = new("Régimen Simplificado de Confianza", "626");

    private RegimenFiscal(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
