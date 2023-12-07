using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class Periodicidad : SmartEnum<Periodicidad, string>
{
    /// <summary>
    ///     01 - Diario.
    /// </summary>
    public static readonly Periodicidad Diario = new("Diario", "01");

    /// <summary>
    ///     02 - Semanal.
    /// </summary>
    public static readonly Periodicidad Semanal = new("Semanal", "02");

    /// <summary>
    ///     03 - Quincenal.
    /// </summary>
    public static readonly Periodicidad Quincenal = new("Quincenal", "03");

    /// <summary>
    ///     04 - Mensual.
    /// </summary>
    public static readonly Periodicidad Mensual = new("Mensual", "04");

    /// <summary>
    ///     05 - Bimestral.
    /// </summary>
    public static readonly Periodicidad Bimestral = new("Bimestral", "05");

    private Periodicidad(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
