using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileUserProfileGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _callProcessingPolicyProfileName;

    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
    public string CallProcessingPolicyProfileName {
        get => _callProcessingPolicyProfileName;
        set {
            CallProcessingPolicyProfileNameSpecified = true;
            _callProcessingPolicyProfileName = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingPolicyProfileNameSpecified { get; set; }
}
}
