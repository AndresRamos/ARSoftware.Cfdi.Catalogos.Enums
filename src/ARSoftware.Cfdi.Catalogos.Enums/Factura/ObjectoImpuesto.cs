using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class ObjectoImpuesto : SmartEnum<ObjectoImpuesto, string>
{
    /// <summary>
    ///     01 - No objeto de impuesto.
    /// </summary>
    public static readonly ObjectoImpuesto NoObjectoDeImpuesto = new("No objeto de impuesto", "01");

    /// <summary>
    ///     02 - Si objeto de impuesto.
    /// </summary>
    public static readonly ObjectoImpuesto SiObjectoDeImpuesto = new("Si objeto de impuesto", "02");

    /// <summary>
    ///     03 - Sí objeto del impuesto y no obligado al desglose.
    /// </summary>
    public static readonly ObjectoImpuesto SiObjectoDelImpuestoYNoObligadoAlDesglose =
        new("Sí objeto del impuesto y no obligado al desglose", "03");

    /// <summary>
    ///     04 - Sí objeto del impuesto y no causa impuesto.
    /// </summary>
    public static readonly ObjectoImpuesto SiObjectoDelImpuestoYNoCausaImpuesto = new("Sí objeto del impuesto y no causa impuesto", "04");

    private ObjectoImpuesto(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
