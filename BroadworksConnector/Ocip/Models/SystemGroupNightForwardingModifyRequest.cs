using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGroupNightForwardingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _nightForwardGroupCallsWithinEnterprise;

    [XmlElement(ElementName = "nightForwardGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
    public bool NightForwardGroupCallsWithinEnterprise {
        get => _nightForwardGroupCallsWithinEnterprise;
        set {
            NightForwardGroupCallsWithinEnterpriseSpecified = true;
            _nightForwardGroupCallsWithinEnterprise = value;
        }
    }

    [XmlIgnore]
    public bool NightForwardGroupCallsWithinEnterpriseSpecified { get; set; }
}
}
