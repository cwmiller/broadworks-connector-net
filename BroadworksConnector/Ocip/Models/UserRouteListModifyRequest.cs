using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRouteListModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _treatOriginationsAndPBXRedirectionsAsScreened;

    [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false, Namespace = "")]
    public bool TreatOriginationsAndPBXRedirectionsAsScreened {
        get => _treatOriginationsAndPBXRedirectionsAsScreened;
        set {
            TreatOriginationsAndPBXRedirectionsAsScreenedSpecified = true;
            _treatOriginationsAndPBXRedirectionsAsScreened = value;
        }
    }

    [XmlIgnore]
    public bool TreatOriginationsAndPBXRedirectionsAsScreenedSpecified { get; set; }
    private bool _useRouteListIdentityForNonEmergencyCalls;

    [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool UseRouteListIdentityForNonEmergencyCalls {
        get => _useRouteListIdentityForNonEmergencyCalls;
        set {
            UseRouteListIdentityForNonEmergencyCallsSpecified = true;
            _useRouteListIdentityForNonEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseRouteListIdentityForNonEmergencyCallsSpecified { get; set; }
    private bool _useRouteListIdentityForEmergencyCalls;

    [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool UseRouteListIdentityForEmergencyCalls {
        get => _useRouteListIdentityForEmergencyCalls;
        set {
            UseRouteListIdentityForEmergencyCallsSpecified = true;
            _useRouteListIdentityForEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseRouteListIdentityForEmergencyCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementDNList _assignedNumberRangeStartList;

    [XmlElement(ElementName = "assignedNumberRangeStartList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementDNList AssignedNumberRangeStartList {
        get => _assignedNumberRangeStartList;
        set {
            AssignedNumberRangeStartListSpecified = true;
            _assignedNumberRangeStartList = value;
        }
    }

    [XmlIgnore]
    public bool AssignedNumberRangeStartListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList _assignedNumberPrefixList;

    [XmlElement(ElementName = "assignedNumberPrefixList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList AssignedNumberPrefixList {
        get => _assignedNumberPrefixList;
        set {
            AssignedNumberPrefixListSpecified = true;
            _assignedNumberPrefixList = value;
        }
    }

    [XmlIgnore]
    public bool AssignedNumberPrefixListSpecified { get; set; }
}
}
