using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:")]
    // ReSharper disable once InconsistentNaming
    public class PROPFINDItem
    {
        public string Href { get; set; }

        public multistatusResponsePropstat Propstat { get; set; }
    }
}
