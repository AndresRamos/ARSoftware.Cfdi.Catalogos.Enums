using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

/// <summary>
///     Catálogo de formas de pago.
/// </summary>
public sealed class FormaPago : SmartEnum<FormaPago, string>
{
    /// <summary>
    ///     01 - Efectivo.
    /// </summary>
    public static readonly FormaPago Efectivo = new("Efectivo", "01");

    /// <summary>
    ///     02 - Cheque nominativo.
    /// </summary>
    public static readonly FormaPago ChequeNominativo = new("Cheque nominativo", "02");

    /// <summary>
    ///     03 - Transferencia electrónica de fondos.
    /// </summary>
    public static readonly FormaPago TransferenciaElectronica = new("Transferencia electrónica de fondos", "03");

    /// <summary>
    ///     04 - Tarjeta de crédito.
    /// </summary>
    public static readonly FormaPago TarjetaDeCredito = new("Tarjeta de crédito", "04");

    /// <summary>
    ///     05 - Monedero electrónico.
    /// </summary>
    public static readonly FormaPago MonederoElectronico = new("Monedero electrónico", "05");

    /// <summary>
    ///     06 - Dinero electrónico.
    /// </summary>
    public static readonly FormaPago DineroElectronico = new("Dinero electrónico", "06");

    /// <summary>
    ///     08 - Vales de despensa.
    /// </summary>
    public static readonly FormaPago ValesDeDespensa = new("Vales de despensa", "08");

    /// <summary>
    ///     12 - Dación en pago.
    /// </summary>
    public static readonly FormaPago DacionEnPago = new("Dación en pago", "12");

    /// <summary>
    ///     13 - Pago por subrogación.
    /// </summary>
    public static readonly FormaPago PagoPorSubrogacion = new("Pago por subrogación", "13");

    /// <summary>
    ///     14 - Pago por consignación.
    /// </summary>
    public static readonly FormaPago PagoPorConsignacion = new("Pago por consignación", "14");

    /// <summary>
    ///     15 - Condonación.
    /// </summary>
    public static readonly FormaPago Condonacion = new("Condonación", "15");

    /// <summary>
    ///     17 - Compensación.
    /// </summary>
    public static readonly FormaPago Compensacion = new("Compensación", "17");

    /// <summary>
    ///     23 - Novación.
    /// </summary>
    public static readonly FormaPago Novacion = new("Novación", "23");

    /// <summary>
    ///     24 - Confusión.
    /// </summary>
    public static readonly FormaPago Confusion = new("Confusión", "24");

    /// <summary>
    ///     25 - Remisión de deuda.
    /// </summary>
    public static readonly FormaPago RemisionDeDeuda = new("Remisión de deuda", "25");

    /// <summary>
    ///     26 - Prescripción o caducidad.
    /// </summary>
    public static readonly FormaPago PrescripcionOCaducidad = new("Prescripción o caducidad", "26");

    /// <summary>
    ///     27 - A satisfacción del acreedor.
    /// </summary>
    public static readonly FormaPago ASatisfaccionDelAcreedor = new("A satisfacción del acreedor", "27");

    /// <summary>
    ///     28 - Tarjeta de débito.
    /// </summary>
    public static readonly FormaPago TarjetaDeDebito = new("Tarjeta de débito", "28");

    /// <summary>
    ///     29 - Tarjeta de servicios.
    /// </summary>
    public static readonly FormaPago TarjetaDeServicios = new("Tarjeta de servicios", "29");

    /// <summary>
    ///     30 - Aplicación de anticipos.
    /// </summary>
    public static readonly FormaPago AplicacionDeAnticipos = new("Aplicación de anticipos", "30");

    /// <summary>
    ///     31 - Intermediario pagos.
    /// </summary>
    public static readonly FormaPago IntermediarioPagos = new("Intermediario pagos", "31");

    /// <summary>
    ///     99 - Por definir.
    /// </summary>
    public static readonly FormaPago PorDefinir = new("Por definir", "99");

    private FormaPago(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
