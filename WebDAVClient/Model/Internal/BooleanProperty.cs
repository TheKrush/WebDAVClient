using System.Xml.Schema;
using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:")]
    public class BooleanProperty
    {
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "urn:uuid:c2f41010-65b3-11d1-a29f-00aa00c14882/")]
        // ReSharper disable once InconsistentNaming
        public string dt { get; set; }

        [XmlText]
        public byte Value { get; set; }
    }
}
