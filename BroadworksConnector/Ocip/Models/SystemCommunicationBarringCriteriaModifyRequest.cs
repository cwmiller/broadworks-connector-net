using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCriteriaModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList _matchCallType;

    [XmlElement(ElementName = "matchCallType", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList MatchCallType {
        get => _matchCallType;
        set {
            MatchCallTypeSpecified = true;
            _matchCallType = value;
        }
    }

    [XmlIgnore]
    public bool MatchCallTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList _matchAlternateCallIndicator;

    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList MatchAlternateCallIndicator {
        get => _matchAlternateCallIndicator;
        set {
            MatchAlternateCallIndicatorSpecified = true;
            _matchAlternateCallIndicator = value;
        }
    }

    [XmlIgnore]
    public bool MatchAlternateCallIndicatorSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementVirtualOnNetCallTypeNameList _matchVirtualOnNetCallType;

    [XmlElement(ElementName = "matchVirtualOnNetCallType", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementVirtualOnNetCallTypeNameList MatchVirtualOnNetCallType {
        get => _matchVirtualOnNetCallType;
        set {
            MatchVirtualOnNetCallTypeSpecified = true;
            _matchVirtualOnNetCallType = value;
        }
    }

    [XmlIgnore]
    public bool MatchVirtualOnNetCallTypeSpecified { get; set; }
    private bool _matchPublicNetwork;

    [XmlElement(ElementName = "matchPublicNetwork", IsNullable = false, Namespace = "")]
    public bool MatchPublicNetwork {
        get => _matchPublicNetwork;
        set {
            MatchPublicNetworkSpecified = true;
            _matchPublicNetwork = value;
        }
    }

    [XmlIgnore]
    public bool MatchPublicNetworkSpecified { get; set; }
    private bool _matchPrivateNetwork;

    [XmlElement(ElementName = "matchPrivateNetwork", IsNullable = false, Namespace = "")]
    public bool MatchPrivateNetwork {
        get => _matchPrivateNetwork;
        set {
            MatchPrivateNetworkSpecified = true;
            _matchPrivateNetwork = value;
        }
    }

    [XmlIgnore]
    public bool MatchPrivateNetworkSpecified { get; set; }
    private bool _matchLocalCategory;

    [XmlElement(ElementName = "matchLocalCategory", IsNullable = false, Namespace = "")]
    public bool MatchLocalCategory {
        get => _matchLocalCategory;
        set {
            MatchLocalCategorySpecified = true;
            _matchLocalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchLocalCategorySpecified { get; set; }
    private bool _matchNationalCategory;

    [XmlElement(ElementName = "matchNationalCategory", IsNullable = false, Namespace = "")]
    public bool MatchNationalCategory {
        get => _matchNationalCategory;
        set {
            MatchNationalCategorySpecified = true;
            _matchNationalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchNationalCategorySpecified { get; set; }
    private bool _matchInterlataCategory;

    [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false, Namespace = "")]
    public bool MatchInterlataCategory {
        get => _matchInterlataCategory;
        set {
            MatchInterlataCategorySpecified = true;
            _matchInterlataCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchInterlataCategorySpecified { get; set; }
    private bool _matchIntralataCategory;

    [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false, Namespace = "")]
    public bool MatchIntralataCategory {
        get => _matchIntralataCategory;
        set {
            MatchIntralataCategorySpecified = true;
            _matchIntralataCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchIntralataCategorySpecified { get; set; }
    private bool _matchInternationalCategory;

    [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false, Namespace = "")]
    public bool MatchInternationalCategory {
        get => _matchInternationalCategory;
        set {
            MatchInternationalCategorySpecified = true;
            _matchInternationalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchInternationalCategorySpecified { get; set; }
    private bool _matchPrivateCategory;

    [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false, Namespace = "")]
    public bool MatchPrivateCategory {
        get => _matchPrivateCategory;
        set {
            MatchPrivateCategorySpecified = true;
            _matchPrivateCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchPrivateCategorySpecified { get; set; }
    private bool _matchEmergencyCategory;

    [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false, Namespace = "")]
    public bool MatchEmergencyCategory {
        get => _matchEmergencyCategory;
        set {
            MatchEmergencyCategorySpecified = true;
            _matchEmergencyCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchEmergencyCategorySpecified { get; set; }
    private bool _matchOtherCategory;

    [XmlElement(ElementName = "matchOtherCategory", IsNullable = false, Namespace = "")]
    public bool MatchOtherCategory {
        get => _matchOtherCategory;
        set {
            MatchOtherCategorySpecified = true;
            _matchOtherCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchOtherCategorySpecified { get; set; }
    private bool _matchInterNetwork;

    [XmlElement(ElementName = "matchInterNetwork", IsNullable = false, Namespace = "")]
    public bool MatchInterNetwork {
        get => _matchInterNetwork;
        set {
            MatchInterNetworkSpecified = true;
            _matchInterNetwork = value;
        }
    }

    [XmlIgnore]
    public bool MatchInterNetworkSpecified { get; set; }
    private bool _matchInterHostingNE;

    [XmlElement(ElementName = "matchInterHostingNE", IsNullable = false, Namespace = "")]
    public bool MatchInterHostingNE {
        get => _matchInterHostingNE;
        set {
            MatchInterHostingNESpecified = true;
            _matchInterHostingNE = value;
        }
    }

    [XmlIgnore]
    public bool MatchInterHostingNESpecified { get; set; }
    private bool _matchInterAS;

    [XmlElement(ElementName = "matchInterAS", IsNullable = false, Namespace = "")]
    public bool MatchInterAS {
        get => _matchInterAS;
        set {
            MatchInterASSpecified = true;
            _matchInterAS = value;
        }
    }

    [XmlIgnore]
    public bool MatchInterASSpecified { get; set; }
    private bool _matchIntraAS;

    [XmlElement(ElementName = "matchIntraAS", IsNullable = false, Namespace = "")]
    public bool MatchIntraAS {
        get => _matchIntraAS;
        set {
            MatchIntraASSpecified = true;
            _matchIntraAS = value;
        }
    }

    [XmlIgnore]
    public bool MatchIntraASSpecified { get; set; }
    private bool _matchChargeCalls;

    [XmlElement(ElementName = "matchChargeCalls", IsNullable = false, Namespace = "")]
    public bool MatchChargeCalls {
        get => _matchChargeCalls;
        set {
            MatchChargeCallsSpecified = true;
            _matchChargeCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchChargeCallsSpecified { get; set; }
    private bool _matchNoChargeCalls;

    [XmlElement(ElementName = "matchNoChargeCalls", IsNullable = false, Namespace = "")]
    public bool MatchNoChargeCalls {
        get => _matchNoChargeCalls;
        set {
            MatchNoChargeCallsSpecified = true;
            _matchNoChargeCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchNoChargeCallsSpecified { get; set; }
    private bool _matchGroupCalls;

    [XmlElement(ElementName = "matchGroupCalls", IsNullable = false, Namespace = "")]
    public bool MatchGroupCalls {
        get => _matchGroupCalls;
        set {
            MatchGroupCallsSpecified = true;
            _matchGroupCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchGroupCallsSpecified { get; set; }
    private bool _matchEnterpriseCalls;

    [XmlElement(ElementName = "matchEnterpriseCalls", IsNullable = false, Namespace = "")]
    public bool MatchEnterpriseCalls {
        get => _matchEnterpriseCalls;
        set {
            MatchEnterpriseCallsSpecified = true;
            _matchEnterpriseCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchEnterpriseCallsSpecified { get; set; }
    private bool _matchNetworkCalls;

    [XmlElement(ElementName = "matchNetworkCalls", IsNullable = false, Namespace = "")]
    public bool MatchNetworkCalls {
        get => _matchNetworkCalls;
        set {
            MatchNetworkCallsSpecified = true;
            _matchNetworkCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchNetworkCallsSpecified { get; set; }
    private bool _matchNetworkURLCalls;

    [XmlElement(ElementName = "matchNetworkURLCalls", IsNullable = false, Namespace = "")]
    public bool MatchNetworkURLCalls {
        get => _matchNetworkURLCalls;
        set {
            MatchNetworkURLCallsSpecified = true;
            _matchNetworkURLCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchNetworkURLCallsSpecified { get; set; }
    private bool _matchRepairCalls;

    [XmlElement(ElementName = "matchRepairCalls", IsNullable = false, Namespace = "")]
    public bool MatchRepairCalls {
        get => _matchRepairCalls;
        set {
            MatchRepairCallsSpecified = true;
            _matchRepairCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchRepairCallsSpecified { get; set; }
    private bool _matchEmergencyCalls;

    [XmlElement(ElementName = "matchEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool MatchEmergencyCalls {
        get => _matchEmergencyCalls;
        set {
            MatchEmergencyCallsSpecified = true;
            _matchEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchEmergencyCallsSpecified { get; set; }
    private bool _matchInternalCalls;

    [XmlElement(ElementName = "matchInternalCalls", IsNullable = false, Namespace = "")]
    public bool MatchInternalCalls {
        get => _matchInternalCalls;
        set {
            MatchInternalCallsSpecified = true;
            _matchInternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool MatchInternalCallsSpecified { get; set; }
    private bool _matchOtherGETSGets;

    [XmlElement(ElementName = "matchOtherGETSGets", IsNullable = false, Namespace = "")]
    public bool MatchOtherGETSGets {
        get => _matchOtherGETSGets;
        set {
            MatchOtherGETSGetsSpecified = true;
            _matchOtherGETSGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchOtherGETSGetsSpecified { get; set; }
    private bool _matchNotGETSGets;

    [XmlElement(ElementName = "matchNotGETSGets", IsNullable = false, Namespace = "")]
    public bool MatchNotGETSGets {
        get => _matchNotGETSGets;
        set {
            MatchNotGETSGetsSpecified = true;
            _matchNotGETSGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchNotGETSGetsSpecified { get; set; }
    private bool _matchGETSANGets;

    [XmlElement(ElementName = "matchGETSANGets", IsNullable = false, Namespace = "")]
    public bool MatchGETSANGets {
        get => _matchGETSANGets;
        set {
            MatchGETSANGetsSpecified = true;
            _matchGETSANGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchGETSANGetsSpecified { get; set; }
    private bool _matchGETSNTGets;

    [XmlElement(ElementName = "matchGETSNTGets", IsNullable = false, Namespace = "")]
    public bool MatchGETSNTGets {
        get => _matchGETSNTGets;
        set {
            MatchGETSNTGetsSpecified = true;
            _matchGETSNTGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchGETSNTGetsSpecified { get; set; }
    private bool _matchGETSFCGets;

    [XmlElement(ElementName = "matchGETSFCGets", IsNullable = false, Namespace = "")]
    public bool MatchGETSFCGets {
        get => _matchGETSFCGets;
        set {
            MatchGETSFCGetsSpecified = true;
            _matchGETSFCGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchGETSFCGetsSpecified { get; set; }
    private bool _matchGETSFCANGets;

    [XmlElement(ElementName = "matchGETSFCANGets", IsNullable = false, Namespace = "")]
    public bool MatchGETSFCANGets {
        get => _matchGETSFCANGets;
        set {
            MatchGETSFCANGetsSpecified = true;
            _matchGETSFCANGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchGETSFCANGetsSpecified { get; set; }
    private bool _matchGETSFCNTGets;

    [XmlElement(ElementName = "matchGETSFCNTGets", IsNullable = false, Namespace = "")]
    public bool MatchGETSFCNTGets {
        get => _matchGETSFCNTGets;
        set {
            MatchGETSFCNTGetsSpecified = true;
            _matchGETSFCNTGets = value;
        }
    }

    [XmlIgnore]
    public bool MatchGETSFCNTGetsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LocationCriteria _matchLocation;

    [XmlElement(ElementName = "matchLocation", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LocationCriteria MatchLocation {
        get => _matchLocation;
        set {
            MatchLocationSpecified = true;
            _matchLocation = value;
        }
    }

    [XmlIgnore]
    public bool MatchLocationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.RoamingCriteria _matchRoaming;

    [XmlElement(ElementName = "matchRoaming", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.RoamingCriteria MatchRoaming {
        get => _matchRoaming;
        set {
            MatchRoamingSpecified = true;
            _matchRoaming = value;
        }
    }

    [XmlIgnore]
    public bool MatchRoamingSpecified { get; set; }
    private string _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
    public string TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
    private string _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
    public string HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList _matchNumberPortabilityStatus;

    [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList MatchNumberPortabilityStatus {
        get => _matchNumberPortabilityStatus;
        set {
            MatchNumberPortabilityStatusSpecified = true;
            _matchNumberPortabilityStatus = value;
        }
    }

    [XmlIgnore]
    public bool MatchNumberPortabilityStatusSpecified { get; set; }
}
}
