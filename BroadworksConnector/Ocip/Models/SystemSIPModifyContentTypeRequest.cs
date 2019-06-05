using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPModifyContentTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SystemSIPSupportedInterface _interface;

    [XmlElement(ElementName = "interface", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemSIPSupportedInterface Interface {
        get => _interface;
        set {
            InterfaceSpecified = true;
            _interface = value;
        }
    }

    [XmlIgnore]
    public bool InterfaceSpecified { get; set; }
}
}
