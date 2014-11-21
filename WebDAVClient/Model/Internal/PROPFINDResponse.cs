using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:"),
     XmlRoot(Namespace = "DAV:", IsNullable = false, ElementName = "multistatus")]
    // ReSharper disable once InconsistentNaming
    public class PROPFINDResponse
    {
        [XmlElement("response")]
        public PROPFINDItem[] Response { get; set; }
    }
}
