using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeleteContentTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _contentType;

    [XmlElement(ElementName = "contentType", IsNullable = false, Namespace = "")]
    public string ContentType {
        get => _contentType;
        set {
            ContentTypeSpecified = true;
            _contentType = value;
        }
    }

    [XmlIgnore]
    public bool ContentTypeSpecified { get; set; }
}
}
