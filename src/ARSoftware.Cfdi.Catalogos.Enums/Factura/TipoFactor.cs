using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class TipoFactor : SmartEnum<TipoFactor, string>
{
    /// <summary>
    ///     Tasa.
    /// </summary>
    public static readonly TipoFactor Tasa = new("Tasa", "Tasa");

    /// <summary>
    ///     Cuota.
    /// </summary>
    public static readonly TipoFactor Cuota = new("Cuota", "Cuota");

    /// <summary>
    ///     Exento.
    /// </summary>
    public static readonly TipoFactor Exento = new("Exento", "Exento");

    private TipoFactor(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
