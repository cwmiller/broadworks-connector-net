using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions 
{
    private List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermission> _digitPatternPermissions;

    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermission> DigitPatternPermissions {
        get => _digitPatternPermissions;
        set {
            DigitPatternPermissionsSpecified = true;
            _digitPatternPermissions = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternPermissionsSpecified { get; set; }
}
}
