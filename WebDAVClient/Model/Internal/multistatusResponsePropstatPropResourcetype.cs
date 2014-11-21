using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:")]
    // ReSharper disable once InconsistentNaming
    public class multistatusResponsePropstatPropResourcetype
    {
        public object Collection { get; set; }
    }
}
