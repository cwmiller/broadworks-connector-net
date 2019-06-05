using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _attributeValuePairCode;

    [XmlElement(ElementName = "attributeValuePairCode", IsNullable = false, Namespace = "")]
    public int AttributeValuePairCode {
        get => _attributeValuePairCode;
        set {
            AttributeValuePairCodeSpecified = true;
            _attributeValuePairCode = value;
        }
    }

    [XmlIgnore]
    public bool AttributeValuePairCodeSpecified { get; set; }
    private int _vendorId;

    [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
    public int VendorId {
        get => _vendorId;
        set {
            VendorIdSpecified = true;
            _vendorId = value;
        }
    }

    [XmlIgnore]
    public bool VendorIdSpecified { get; set; }
}
}
