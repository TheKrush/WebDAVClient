using System.Xml.Serialization;

namespace WebDAVClient.Model.Internal
{
    [XmlType(AnonymousType = true, Namespace = "DAV:")]
    // ReSharper disable once InconsistentNaming
    public class multistatusResponsePropstatProp
    {
        [XmlElement("getcontentlength")]
        public LongProperty ContentLength { get; set; }

        [XmlElement("creationdate")]
        public DateProperty CreationDate { get; set; }

        [XmlElement("displayname")]
        public string DisplayName { get; set; }

        [XmlElement("getetag")]
        public string Etag { get; set; }

        [XmlElement("getlastmodified")]
        public StringProperty LastModified { get; set; }

        [XmlElement("resourcetype")]
        public multistatusResponsePropstatPropResourcetype ResourceType { get; set; }

        [XmlElement("ishidden")]
        public BooleanProperty IsHidden { get; set; }

        [XmlElement("iscollection")]
        public BooleanProperty IsCollection { get; set; }

        [XmlElement("getcontenttype")]
        public string ContentType { get; set; }

        [XmlElement("quota-used-bytes")]
        public LongProperty QuotaUsedBytes { get; set; }

        [XmlElement("quota-available-bytes")]
        public LongProperty QuotaAvailableBytes { get; set; }
    }
}
