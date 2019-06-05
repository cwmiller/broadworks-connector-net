using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingAccessSIPStatusDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _sipStatusCode;

    [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
    public int SipStatusCode {
        get => _sipStatusCode;
        set {
            SipStatusCodeSpecified = true;
            _sipStatusCode = value;
        }
    }

    [XmlIgnore]
    public bool SipStatusCodeSpecified { get; set; }
}
}
