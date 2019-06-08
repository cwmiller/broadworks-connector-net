using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTerminatingAlternateTrunkIdentityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _terminatingTrunkIdentity;

    [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = false, Namespace = "")]
    public string TerminatingTrunkIdentity {
        get => _terminatingTrunkIdentity;
        set {
            TerminatingTrunkIdentitySpecified = true;
            _terminatingTrunkIdentity = value;
        }
    }

    [XmlIgnore]
    public bool TerminatingTrunkIdentitySpecified { get; set; }
}
}
