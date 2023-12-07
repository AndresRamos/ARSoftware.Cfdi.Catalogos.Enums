using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

/// <summary>
///     Catálogo de exportación.
/// </summary>
public sealed class Exportacion : SmartEnum<Exportacion, string>
{
    /// <summary>
    ///     01 - No aplica.
    /// </summary>
    public static readonly Exportacion NoAplica = new("No aplica", "01");

    /// <summary>
    ///     02 - Definitiva con clave A1.
    /// </summary>
    public static readonly Exportacion DefinitivaConClaveA1 = new("Definitiva con clave A1", "02");

    /// <summary>
    ///     03 - Temporal.
    /// </summary>
    public static readonly Exportacion Temporal = new("Temporal", "03");

    /// <summary>
    ///     04 - Definitiva con clave distinta a A1 o cuando no existe enajenación en términos del CFF.
    /// </summary>
    public static readonly Exportacion DefinitivaConClaveDistintaAA1 =
        new("Definitiva con clave distinta a A1 o cuando no existe enajenación en términos del CFF", "04");

    private Exportacion(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
