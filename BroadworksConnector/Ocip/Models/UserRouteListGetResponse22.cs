using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRouteListGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadWorksConnector.Ocip.Models.C.OCITable _assignedNumberRangeTable;

    [XmlElement(ElementName = "assignedNumberRangeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AssignedNumberRangeTable {
        get => _assignedNumberRangeTable;
        set {
            AssignedNumberRangeTableSpecified = true;
            _assignedNumberRangeTable = value;
        }
    }

    [XmlIgnore]
    public bool AssignedNumberRangeTableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _assignedNumberPrefixTable;

    [XmlElement(ElementName = "assignedNumberPrefixTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AssignedNumberPrefixTable {
        get => _assignedNumberPrefixTable;
        set {
            AssignedNumberPrefixTableSpecified = true;
            _assignedNumberPrefixTable = value;
        }
    }

    [XmlIgnore]
    public bool AssignedNumberPrefixTableSpecified { get; set; }
}
}
