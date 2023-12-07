using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class TipoComprobante : SmartEnum<TipoComprobante, string>
{
    /// <summary>
    ///     I - Ingreso.
    /// </summary>
    public static readonly TipoComprobante Ingreso = new("Ingreso", "I");

    /// <summary>
    ///     E - Egreso.
    /// </summary>
    public static readonly TipoComprobante Egreso = new("Egreso", "E");

    /// <summary>
    ///     T - Traslado.
    /// </summary>
    public static readonly TipoComprobante Traslado = new("Traslado", "T");

    /// <summary>
    ///     N - Nómina.
    /// </summary>
    public static readonly TipoComprobante Nomina = new("Nómina", "N");

    /// <summary>
    ///     P - Pago.
    /// </summary>
    public static readonly TipoComprobante Pago = new("Pago", "P");

    private TipoComprobante(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
