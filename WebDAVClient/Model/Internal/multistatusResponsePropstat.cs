using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:")]
    // ReSharper disable once InconsistentNaming
    public class multistatusResponsePropstat
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("prop")]
        public multistatusResponsePropstatProp Prop { get; set; }
    }
}
