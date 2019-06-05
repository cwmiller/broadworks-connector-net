using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLocationBasedCallingRestrictionsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

    [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.PhysicalLocationIndicator PhysicalLocationIndicator {
        get => _physicalLocationIndicator;
        set {
            PhysicalLocationIndicatorSpecified = true;
            _physicalLocationIndicator = value;
        }
    }

    [XmlIgnore]
    public bool PhysicalLocationIndicatorSpecified { get; set; }
    private bool _enforceMscValidation;

    [XmlElement(ElementName = "enforceMscValidation", IsNullable = false, Namespace = "")]
    public bool EnforceMscValidation {
        get => _enforceMscValidation;
        set {
            EnforceMscValidationSpecified = true;
            _enforceMscValidation = value;
        }
    }

    [XmlIgnore]
    public bool EnforceMscValidationSpecified { get; set; }
    private bool _enableOfficeZoneAnnouncement;

    [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false, Namespace = "")]
    public bool EnableOfficeZoneAnnouncement {
        get => _enableOfficeZoneAnnouncement;
        set {
            EnableOfficeZoneAnnouncementSpecified = true;
            _enableOfficeZoneAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool EnableOfficeZoneAnnouncementSpecified { get; set; }
    private bool _enhanceOfficeZone;

    [XmlElement(ElementName = "enhanceOfficeZone", IsNullable = false, Namespace = "")]
    public bool EnhanceOfficeZone {
        get => _enhanceOfficeZone;
        set {
            EnhanceOfficeZoneSpecified = true;
            _enhanceOfficeZone = value;
        }
    }

    [XmlIgnore]
    public bool EnhanceOfficeZoneSpecified { get; set; }
}
}
