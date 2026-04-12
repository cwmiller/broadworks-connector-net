using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing Communication Barring Criteria.
    /// The following elements are only used in AS data mode:
    /// matchNumberPortabilityStatus
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// matchOtherGETS
    /// matchNotGETS
    /// matchGETSAN
    /// matchGETSNT
    /// matchGETSFC
    /// matchGETSFCAN
    /// matchGETSFCNT
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5946""}]")]
    public class SystemCommunicationBarringCriteriaModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = (value != null);
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList _matchCallType;

        [XmlElement(ElementName = "matchCallType", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringCallTypeList MatchCallType
        {
            get => _matchCallType;
            set
            {
                MatchCallTypeSpecified = true;
                _matchCallType = value;
            }
        }

        [XmlIgnore]
        protected bool MatchCallTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList _matchAlternateCallIndicator;

        [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.ReplacementCommunicationBarringAlternateCallIndicatorList MatchAlternateCallIndicator
        {
            get => _matchAlternateCallIndicator;
            set
            {
                MatchAlternateCallIndicatorSpecified = true;
                _matchAlternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool MatchAlternateCallIndicatorSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementVirtualOnNetCallTypeNameList _matchVirtualOnNetCallType;

        [XmlElement(ElementName = "matchVirtualOnNetCallType", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.ReplacementVirtualOnNetCallTypeNameList MatchVirtualOnNetCallType
        {
            get => _matchVirtualOnNetCallType;
            set
            {
                MatchVirtualOnNetCallTypeSpecified = true;
                _matchVirtualOnNetCallType = value;
            }
        }

        [XmlIgnore]
        protected bool MatchVirtualOnNetCallTypeSpecified { get; set; }

        protected bool? _matchPublicNetwork;

        [XmlElement(ElementName = "matchPublicNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchPublicNetwork
        {
            get => _matchPublicNetwork;
            set
            {
                MatchPublicNetworkSpecified = (value != null);
                _matchPublicNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool MatchPublicNetworkSpecified { get; set; }

        protected bool? _matchPrivateNetwork;

        [XmlElement(ElementName = "matchPrivateNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchPrivateNetwork
        {
            get => _matchPrivateNetwork;
            set
            {
                MatchPrivateNetworkSpecified = (value != null);
                _matchPrivateNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool MatchPrivateNetworkSpecified { get; set; }

        protected bool? _matchLocalCategory;

        [XmlElement(ElementName = "matchLocalCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchLocalCategory
        {
            get => _matchLocalCategory;
            set
            {
                MatchLocalCategorySpecified = (value != null);
                _matchLocalCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchLocalCategorySpecified { get; set; }

        protected bool? _matchNationalCategory;

        [XmlElement(ElementName = "matchNationalCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchNationalCategory
        {
            get => _matchNationalCategory;
            set
            {
                MatchNationalCategorySpecified = (value != null);
                _matchNationalCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNationalCategorySpecified { get; set; }

        protected bool? _matchInterlataCategory;

        [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInterlataCategory
        {
            get => _matchInterlataCategory;
            set
            {
                MatchInterlataCategorySpecified = (value != null);
                _matchInterlataCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInterlataCategorySpecified { get; set; }

        protected bool? _matchIntralataCategory;

        [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchIntralataCategory
        {
            get => _matchIntralataCategory;
            set
            {
                MatchIntralataCategorySpecified = (value != null);
                _matchIntralataCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchIntralataCategorySpecified { get; set; }

        protected bool? _matchInternationalCategory;

        [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInternationalCategory
        {
            get => _matchInternationalCategory;
            set
            {
                MatchInternationalCategorySpecified = (value != null);
                _matchInternationalCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInternationalCategorySpecified { get; set; }

        protected bool? _matchPrivateCategory;

        [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchPrivateCategory
        {
            get => _matchPrivateCategory;
            set
            {
                MatchPrivateCategorySpecified = (value != null);
                _matchPrivateCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchPrivateCategorySpecified { get; set; }

        protected bool? _matchEmergencyCategory;

        [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchEmergencyCategory
        {
            get => _matchEmergencyCategory;
            set
            {
                MatchEmergencyCategorySpecified = (value != null);
                _matchEmergencyCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchEmergencyCategorySpecified { get; set; }

        protected bool? _matchOtherCategory;

        [XmlElement(ElementName = "matchOtherCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchOtherCategory
        {
            get => _matchOtherCategory;
            set
            {
                MatchOtherCategorySpecified = (value != null);
                _matchOtherCategory = value;
            }
        }

        [XmlIgnore]
        protected bool MatchOtherCategorySpecified { get; set; }

        protected bool? _matchInterNetwork;

        [XmlElement(ElementName = "matchInterNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInterNetwork
        {
            get => _matchInterNetwork;
            set
            {
                MatchInterNetworkSpecified = (value != null);
                _matchInterNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInterNetworkSpecified { get; set; }

        protected bool? _matchInterHostingNE;

        [XmlElement(ElementName = "matchInterHostingNE", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInterHostingNE
        {
            get => _matchInterHostingNE;
            set
            {
                MatchInterHostingNESpecified = (value != null);
                _matchInterHostingNE = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInterHostingNESpecified { get; set; }

        protected bool? _matchInterAS;

        [XmlElement(ElementName = "matchInterAS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInterAS
        {
            get => _matchInterAS;
            set
            {
                MatchInterASSpecified = (value != null);
                _matchInterAS = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInterASSpecified { get; set; }

        protected bool? _matchIntraAS;

        [XmlElement(ElementName = "matchIntraAS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchIntraAS
        {
            get => _matchIntraAS;
            set
            {
                MatchIntraASSpecified = (value != null);
                _matchIntraAS = value;
            }
        }

        [XmlIgnore]
        protected bool MatchIntraASSpecified { get; set; }

        protected bool? _matchChargeCalls;

        [XmlElement(ElementName = "matchChargeCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchChargeCalls
        {
            get => _matchChargeCalls;
            set
            {
                MatchChargeCallsSpecified = (value != null);
                _matchChargeCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchChargeCallsSpecified { get; set; }

        protected bool? _matchNoChargeCalls;

        [XmlElement(ElementName = "matchNoChargeCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchNoChargeCalls
        {
            get => _matchNoChargeCalls;
            set
            {
                MatchNoChargeCallsSpecified = (value != null);
                _matchNoChargeCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNoChargeCallsSpecified { get; set; }

        protected bool? _matchGroupCalls;

        [XmlElement(ElementName = "matchGroupCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGroupCalls
        {
            get => _matchGroupCalls;
            set
            {
                MatchGroupCallsSpecified = (value != null);
                _matchGroupCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGroupCallsSpecified { get; set; }

        protected bool? _matchEnterpriseCalls;

        [XmlElement(ElementName = "matchEnterpriseCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchEnterpriseCalls
        {
            get => _matchEnterpriseCalls;
            set
            {
                MatchEnterpriseCallsSpecified = (value != null);
                _matchEnterpriseCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchEnterpriseCallsSpecified { get; set; }

        protected bool? _matchNetworkCalls;

        [XmlElement(ElementName = "matchNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchNetworkCalls
        {
            get => _matchNetworkCalls;
            set
            {
                MatchNetworkCallsSpecified = (value != null);
                _matchNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNetworkCallsSpecified { get; set; }

        protected bool? _matchNetworkURLCalls;

        [XmlElement(ElementName = "matchNetworkURLCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchNetworkURLCalls
        {
            get => _matchNetworkURLCalls;
            set
            {
                MatchNetworkURLCallsSpecified = (value != null);
                _matchNetworkURLCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNetworkURLCallsSpecified { get; set; }

        protected bool? _matchRepairCalls;

        [XmlElement(ElementName = "matchRepairCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchRepairCalls
        {
            get => _matchRepairCalls;
            set
            {
                MatchRepairCallsSpecified = (value != null);
                _matchRepairCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchRepairCallsSpecified { get; set; }

        protected bool? _matchEmergencyCalls;

        [XmlElement(ElementName = "matchEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchEmergencyCalls
        {
            get => _matchEmergencyCalls;
            set
            {
                MatchEmergencyCallsSpecified = (value != null);
                _matchEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchEmergencyCallsSpecified { get; set; }

        protected bool? _matchInternalCalls;

        [XmlElement(ElementName = "matchInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchInternalCalls
        {
            get => _matchInternalCalls;
            set
            {
                MatchInternalCallsSpecified = (value != null);
                _matchInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MatchInternalCallsSpecified { get; set; }

        protected bool? _matchOtherGETSGets;

        [XmlElement(ElementName = "matchOtherGETSGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchOtherGETSGets
        {
            get => _matchOtherGETSGets;
            set
            {
                MatchOtherGETSGetsSpecified = (value != null);
                _matchOtherGETSGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchOtherGETSGetsSpecified { get; set; }

        protected bool? _matchNotGETSGets;

        [XmlElement(ElementName = "matchNotGETSGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchNotGETSGets
        {
            get => _matchNotGETSGets;
            set
            {
                MatchNotGETSGetsSpecified = (value != null);
                _matchNotGETSGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNotGETSGetsSpecified { get; set; }

        protected bool? _matchGETSANGets;

        [XmlElement(ElementName = "matchGETSANGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGETSANGets
        {
            get => _matchGETSANGets;
            set
            {
                MatchGETSANGetsSpecified = (value != null);
                _matchGETSANGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGETSANGetsSpecified { get; set; }

        protected bool? _matchGETSNTGets;

        [XmlElement(ElementName = "matchGETSNTGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGETSNTGets
        {
            get => _matchGETSNTGets;
            set
            {
                MatchGETSNTGetsSpecified = (value != null);
                _matchGETSNTGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGETSNTGetsSpecified { get; set; }

        protected bool? _matchGETSFCGets;

        [XmlElement(ElementName = "matchGETSFCGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGETSFCGets
        {
            get => _matchGETSFCGets;
            set
            {
                MatchGETSFCGetsSpecified = (value != null);
                _matchGETSFCGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGETSFCGetsSpecified { get; set; }

        protected bool? _matchGETSFCANGets;

        [XmlElement(ElementName = "matchGETSFCANGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGETSFCANGets
        {
            get => _matchGETSFCANGets;
            set
            {
                MatchGETSFCANGetsSpecified = (value != null);
                _matchGETSFCANGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGETSFCANGetsSpecified { get; set; }

        protected bool? _matchGETSFCNTGets;

        [XmlElement(ElementName = "matchGETSFCNTGets", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public bool? MatchGETSFCNTGets
        {
            get => _matchGETSFCNTGets;
            set
            {
                MatchGETSFCNTGetsSpecified = (value != null);
                _matchGETSFCNTGets = value;
            }
        }

        [XmlIgnore]
        protected bool MatchGETSFCNTGetsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LocationCriteria? _matchLocation;

        [XmlElement(ElementName = "matchLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.LocationCriteria? MatchLocation
        {
            get => _matchLocation;
            set
            {
                MatchLocationSpecified = (value != null);
                _matchLocation = value;
            }
        }

        [XmlIgnore]
        protected bool MatchLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RoamingCriteria? _matchRoaming;

        [XmlElement(ElementName = "matchRoaming", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.RoamingCriteria? MatchRoaming
        {
            get => _matchRoaming;
            set
            {
                MatchRoamingSpecified = (value != null);
                _matchRoaming = value;
            }
        }

        [XmlIgnore]
        protected bool MatchRoamingSpecified { get; set; }

        protected string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        protected string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList _matchNumberPortabilityStatus;

        [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5946")]
        public BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList MatchNumberPortabilityStatus
        {
            get => _matchNumberPortabilityStatus;
            set
            {
                MatchNumberPortabilityStatusSpecified = true;
                _matchNumberPortabilityStatus = value;
            }
        }

        [XmlIgnore]
        protected bool MatchNumberPortabilityStatusSpecified { get; set; }

    }
}
