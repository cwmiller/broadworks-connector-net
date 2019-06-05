using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDialPlanPolicyGetAccessCodeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _accessCode;

    [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
    public string AccessCode {
        get => _accessCode;
        set {
            AccessCodeSpecified = true;
            _accessCode = value;
        }
    }

    [XmlIgnore]
    public bool AccessCodeSpecified { get; set; }
}
}
