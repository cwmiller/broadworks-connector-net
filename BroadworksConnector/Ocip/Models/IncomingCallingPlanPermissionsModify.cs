using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IncomingCallingPlanPermissionsModify 
{
    private bool _allowFromWithinGroup;

    [XmlElement(ElementName = "allowFromWithinGroup", IsNullable = false, Namespace = "")]
    public bool AllowFromWithinGroup {
        get => _allowFromWithinGroup;
        set {
            AllowFromWithinGroupSpecified = true;
            _allowFromWithinGroup = value;
        }
    }

    [XmlIgnore]
    public bool AllowFromWithinGroupSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission _allowFromOutsideGroup;

    [XmlElement(ElementName = "allowFromOutsideGroup", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission AllowFromOutsideGroup {
        get => _allowFromOutsideGroup;
        set {
            AllowFromOutsideGroupSpecified = true;
            _allowFromOutsideGroup = value;
        }
    }

    [XmlIgnore]
    public bool AllowFromOutsideGroupSpecified { get; set; }
    private bool _allowCollectCalls;

    [XmlElement(ElementName = "allowCollectCalls", IsNullable = false, Namespace = "")]
    public bool AllowCollectCalls {
        get => _allowCollectCalls;
        set {
            AllowCollectCallsSpecified = true;
            _allowCollectCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowCollectCallsSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> _digitPatternPermission;

    [XmlElement(ElementName = "digitPatternPermission", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> DigitPatternPermission {
        get => _digitPatternPermission;
        set {
            DigitPatternPermissionSpecified = true;
            _digitPatternPermission = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternPermissionSpecified { get; set; }
}
}
