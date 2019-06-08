using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IncomingCallingPlanPermissions 
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
    private BroadWorksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission _allowFromOutsideGroup;

    [XmlElement(ElementName = "allowFromOutsideGroup", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission AllowFromOutsideGroup {
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
    private List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> _digitPatternPermission;

    [XmlElement(ElementName = "digitPatternPermission", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> DigitPatternPermission {
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
