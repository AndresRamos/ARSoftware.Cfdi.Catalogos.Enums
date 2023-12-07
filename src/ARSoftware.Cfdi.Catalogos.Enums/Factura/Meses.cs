using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

/// <summary>
///     Catálogo de meses.
/// </summary>
public sealed class Meses : SmartEnum<Meses, string>
{
    /// <summary>
    ///     01 - Enero.
    /// </summary>
    public static readonly Meses Enero = new("Enero", "01");

    /// <summary>
    ///     02 - Febrero.
    /// </summary>
    public static readonly Meses Febrero = new("Febrero", "02");

    /// <summary>
    ///     03 - Marzo.
    /// </summary>
    public static readonly Meses Marzo = new("Marzo", "03");

    /// <summary>
    ///     04 - Abril.
    /// </summary>
    public static readonly Meses Abril = new("Abril", "04");

    /// <summary>
    ///     05 - Mayo.
    /// </summary>
    public static readonly Meses Mayo = new("Mayo", "05");

    /// <summary>
    ///     06 - Junio.
    /// </summary>
    public static readonly Meses Junio = new("Junio", "06");

    /// <summary>
    ///     07 - Julio.
    /// </summary>
    public static readonly Meses Julio = new("Julio", "07");

    /// <summary>
    ///     08 - Agosto.
    /// </summary>
    public static readonly Meses Agosto = new("Agosto", "08");

    /// <summary>
    ///     09 - Septiembre.
    /// </summary>
    public static readonly Meses Septiembre = new("Septiembre", "09");

    /// <summary>
    ///     10 - Octubre.
    /// </summary>
    public static readonly Meses Octubre = new("Octubre", "10");

    /// <summary>
    ///     11 - Noviembre.
    /// </summary>
    public static readonly Meses Noviembre = new("Noviembre", "11");

    /// <summary>
    ///     12 - Diciembre.
    /// </summary>
    public static readonly Meses Diciembre = new("Diciembre", "12");

    /// <summary>
    ///     13 - Enero-Febrero.
    /// </summary>
    public static readonly Meses EneroFebrero = new("Enero-Febrero", "13");

    /// <summary>
    ///     14 - Marzo-Abril.
    /// </summary>
    public static readonly Meses MarzoAbril = new("Marzo-Abril", "14");

    /// <summary>
    ///     15 - Mayo-Junio.
    /// </summary>
    public static readonly Meses MayoJunio = new("Mayo-Junio", "15");

    /// <summary>
    ///     16 - Julio-Agosto.
    /// </summary>
    public static readonly Meses JulioAgosto = new("Julio-Agosto", "16");

    /// <summary>
    ///     17 - Septiembre-Octubre.
    /// </summary>
    public static readonly Meses SeptiembreOctubre = new("Septiembre-Octubre", "17");

    /// <summary>
    ///     18 - Noviembre-Diciembre.
    /// </summary>
    public static readonly Meses NoviembreDiciembre = new("Noviembre-Diciembre", "18");

    private Meses(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
