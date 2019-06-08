using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingNetworkSIPStatusDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
