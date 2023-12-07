using Ardalis.SmartEnum;

namespace ARSoftware.Cfdi.Catalogos.Enums.Factura;

public sealed class TipoRelacion : SmartEnum<TipoRelacion, string>
{
    /// <summary>
    ///     01 - Nota de crédito de los documentos relacionados.
    /// </summary>
    public static readonly TipoRelacion NotaDeCreditoDeLosDocumentosRelacionados =
        new("Nota de crédito de los documentos relacionados", "01");

    /// <summary>
    ///     02 - Nota de débito de los documentos relacionados.
    /// </summary>
    public static readonly TipoRelacion NotaDeDebitoDeLosDocumentosRelacionados =
        new("Nota de débito de los documentos relacionados", "02");

    /// <summary>
    ///     03 - Devolución de mercancía sobre facturas o traslados previos.
    /// </summary>
    public static readonly TipoRelacion DevolucionDeMercanciaSobreFacturasOTrasladosPrevios =
        new("Devolución de mercancía sobre facturas o traslados previos", "03");

    /// <summary>
    ///     04 - Sustitución de los CFDI previos.
    /// </summary>
    public static readonly TipoRelacion SustitucionDeLosCfdiPrevios = new("Sustitución de los CFDI previos", "04");

    /// <summary>
    ///     05 - Traslados de mercancias facturados previamente.
    /// </summary>
    public static readonly TipoRelacion TrasladosDeMercanciasFacturadosPreviamente =
        new("Traslados de mercancias facturados previamente", "05");

    /// <summary>
    ///     06 - Factura generada por los traslados previos.
    /// </summary>
    public static readonly TipoRelacion FacturaGeneradaPorLosTrasladosPrevios = new("Factura generada por los traslados previos", "06");

    /// <summary>
    ///     07 - CFDI por aplicación de anticipo.
    /// </summary>
    public static readonly TipoRelacion CfdiPorAplicacionDeAnticipo = new("CFDI por aplicación de anticipo", "07");

    private TipoRelacion(string descripcion, string clave) : base(descripcion, clave)
    {
    }
}
