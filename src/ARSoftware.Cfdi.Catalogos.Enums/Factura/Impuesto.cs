using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

/// <summary>
///     Catálogo de impuestos.
/// </summary>
public sealed class Impuesto : SmartEnum<Impuesto, string>
{
    /// <summary>
    ///     001 - ISR.
    /// </summary>
    public static readonly Impuesto ISR = new("ISR", "001");

    /// <summary>
    ///     002 - IVA.
    /// </summary>
    public static readonly Impuesto IVA = new("IVA", "002");

    /// <summary>
    ///     003 - IEPS.
    /// </summary>
    public static readonly Impuesto IEPS = new("IEPS", "003");

    private Impuesto(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
