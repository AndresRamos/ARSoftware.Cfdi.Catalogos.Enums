using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class MetodoPago : SmartEnum<MetodoPago, string>
{
    /// <summary>
    ///     PUE - Pago en una sola exhibición.
    /// </summary>
    public static readonly MetodoPago PagoEnUnaSolaExhibicion = new("Pago en una sola exhibición", "PUE");

    /// <summary>
    ///     PPD - Pago en parcialidades o diferido.
    /// </summary>
    public static readonly MetodoPago PagoEnParcialidadesODiferido = new("Pago en parcialidades o diferido", "PPD");

    private MetodoPago(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
