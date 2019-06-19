using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a new Communication Barring Criteria.
    /// The following elements are only used in AS data mode:
    /// matchNumberPortabilityStatus
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5359""}]")]
    public class SystemCommunicationBarringCriteriaAddRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
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
        public bool NameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
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
        public bool DescriptionSpecified { get; set; }

        private List<string> _matchCallType = new List<string>();

        [XmlElement(ElementName = "matchCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> MatchCallType
        {
            get => _matchCallType;
            set
            {
                MatchCallTypeSpecified = true;
                _matchCallType = value;
            }
        }

        [XmlIgnore]
        public bool MatchCallTypeSpecified { get; set; }

        private List<string> _matchAlternateCallIndicator = new List<string>();

        [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> MatchAlternateCallIndicator
        {
            get => _matchAlternateCallIndicator;
            set
            {
                MatchAlternateCallIndicatorSpecified = true;
                _matchAlternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool MatchAlternateCallIndicatorSpecified { get; set; }

        private List<string> _matchVirtualOnNetCallType = new List<string>();

        [XmlElement(ElementName = "matchVirtualOnNetCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> MatchVirtualOnNetCallType
        {
            get => _matchVirtualOnNetCallType;
            set
            {
                MatchVirtualOnNetCallTypeSpecified = true;
                _matchVirtualOnNetCallType = value;
            }
        }

        [XmlIgnore]
        public bool MatchVirtualOnNetCallTypeSpecified { get; set; }

        private bool _matchPublicNetwork;

        [XmlElement(ElementName = "matchPublicNetwork", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchPublicNetwork
        {
            get => _matchPublicNetwork;
            set
            {
                MatchPublicNetworkSpecified = true;
                _matchPublicNetwork = value;
            }
        }

        [XmlIgnore]
        public bool MatchPublicNetworkSpecified { get; set; }

        private bool _matchPrivateNetwork;

        [XmlElement(ElementName = "matchPrivateNetwork", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchPrivateNetwork
        {
            get => _matchPrivateNetwork;
            set
            {
                MatchPrivateNetworkSpecified = true;
                _matchPrivateNetwork = value;
            }
        }

        [XmlIgnore]
        public bool MatchPrivateNetworkSpecified { get; set; }

        private bool _matchLocalCategory;

        [XmlElement(ElementName = "matchLocalCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchLocalCategory
        {
            get => _matchLocalCategory;
            set
            {
                MatchLocalCategorySpecified = true;
                _matchLocalCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchLocalCategorySpecified { get; set; }

        private bool _matchNationalCategory;

        [XmlElement(ElementName = "matchNationalCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchNationalCategory
        {
            get => _matchNationalCategory;
            set
            {
                MatchNationalCategorySpecified = true;
                _matchNationalCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchNationalCategorySpecified { get; set; }

        private bool _matchInterlataCategory;

        [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInterlataCategory
        {
            get => _matchInterlataCategory;
            set
            {
                MatchInterlataCategorySpecified = true;
                _matchInterlataCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchInterlataCategorySpecified { get; set; }

        private bool _matchIntralataCategory;

        [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchIntralataCategory
        {
            get => _matchIntralataCategory;
            set
            {
                MatchIntralataCategorySpecified = true;
                _matchIntralataCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchIntralataCategorySpecified { get; set; }

        private bool _matchInternationalCategory;

        [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInternationalCategory
        {
            get => _matchInternationalCategory;
            set
            {
                MatchInternationalCategorySpecified = true;
                _matchInternationalCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchInternationalCategorySpecified { get; set; }

        private bool _matchPrivateCategory;

        [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchPrivateCategory
        {
            get => _matchPrivateCategory;
            set
            {
                MatchPrivateCategorySpecified = true;
                _matchPrivateCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchPrivateCategorySpecified { get; set; }

        private bool _matchEmergencyCategory;

        [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchEmergencyCategory
        {
            get => _matchEmergencyCategory;
            set
            {
                MatchEmergencyCategorySpecified = true;
                _matchEmergencyCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchEmergencyCategorySpecified { get; set; }

        private bool _matchOtherCategory;

        [XmlElement(ElementName = "matchOtherCategory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchOtherCategory
        {
            get => _matchOtherCategory;
            set
            {
                MatchOtherCategorySpecified = true;
                _matchOtherCategory = value;
            }
        }

        [XmlIgnore]
        public bool MatchOtherCategorySpecified { get; set; }

        private bool _matchInterNetwork;

        [XmlElement(ElementName = "matchInterNetwork", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInterNetwork
        {
            get => _matchInterNetwork;
            set
            {
                MatchInterNetworkSpecified = true;
                _matchInterNetwork = value;
            }
        }

        [XmlIgnore]
        public bool MatchInterNetworkSpecified { get; set; }

        private bool _matchInterHostingNE;

        [XmlElement(ElementName = "matchInterHostingNE", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInterHostingNE
        {
            get => _matchInterHostingNE;
            set
            {
                MatchInterHostingNESpecified = true;
                _matchInterHostingNE = value;
            }
        }

        [XmlIgnore]
        public bool MatchInterHostingNESpecified { get; set; }

        private bool _matchInterAS;

        [XmlElement(ElementName = "matchInterAS", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInterAS
        {
            get => _matchInterAS;
            set
            {
                MatchInterASSpecified = true;
                _matchInterAS = value;
            }
        }

        [XmlIgnore]
        public bool MatchInterASSpecified { get; set; }

        private bool _matchIntraAS;

        [XmlElement(ElementName = "matchIntraAS", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchIntraAS
        {
            get => _matchIntraAS;
            set
            {
                MatchIntraASSpecified = true;
                _matchIntraAS = value;
            }
        }

        [XmlIgnore]
        public bool MatchIntraASSpecified { get; set; }

        private bool _matchChargeCalls;

        [XmlElement(ElementName = "matchChargeCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchChargeCalls
        {
            get => _matchChargeCalls;
            set
            {
                MatchChargeCallsSpecified = true;
                _matchChargeCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchChargeCallsSpecified { get; set; }

        private bool _matchNoChargeCalls;

        [XmlElement(ElementName = "matchNoChargeCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchNoChargeCalls
        {
            get => _matchNoChargeCalls;
            set
            {
                MatchNoChargeCallsSpecified = true;
                _matchNoChargeCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchNoChargeCallsSpecified { get; set; }

        private bool _matchGroupCalls;

        [XmlElement(ElementName = "matchGroupCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchGroupCalls
        {
            get => _matchGroupCalls;
            set
            {
                MatchGroupCallsSpecified = true;
                _matchGroupCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchGroupCallsSpecified { get; set; }

        private bool _matchEnterpriseCalls;

        [XmlElement(ElementName = "matchEnterpriseCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchEnterpriseCalls
        {
            get => _matchEnterpriseCalls;
            set
            {
                MatchEnterpriseCallsSpecified = true;
                _matchEnterpriseCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchEnterpriseCallsSpecified { get; set; }

        private bool _matchNetworkCalls;

        [XmlElement(ElementName = "matchNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchNetworkCalls
        {
            get => _matchNetworkCalls;
            set
            {
                MatchNetworkCallsSpecified = true;
                _matchNetworkCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchNetworkCallsSpecified { get; set; }

        private bool _matchNetworkURLCalls;

        [XmlElement(ElementName = "matchNetworkURLCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchNetworkURLCalls
        {
            get => _matchNetworkURLCalls;
            set
            {
                MatchNetworkURLCallsSpecified = true;
                _matchNetworkURLCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchNetworkURLCallsSpecified { get; set; }

        private bool _matchRepairCalls;

        [XmlElement(ElementName = "matchRepairCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchRepairCalls
        {
            get => _matchRepairCalls;
            set
            {
                MatchRepairCallsSpecified = true;
                _matchRepairCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchRepairCallsSpecified { get; set; }

        private bool _matchEmergencyCalls;

        [XmlElement(ElementName = "matchEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchEmergencyCalls
        {
            get => _matchEmergencyCalls;
            set
            {
                MatchEmergencyCallsSpecified = true;
                _matchEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchEmergencyCallsSpecified { get; set; }

        private bool _matchInternalCalls;

        [XmlElement(ElementName = "matchInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public bool MatchInternalCalls
        {
            get => _matchInternalCalls;
            set
            {
                MatchInternalCallsSpecified = true;
                _matchInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool MatchInternalCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LocationCriteria _matchLocation;

        [XmlElement(ElementName = "matchLocation", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public BroadWorksConnector.Ocip.Models.LocationCriteria MatchLocation
        {
            get => _matchLocation;
            set
            {
                MatchLocationSpecified = true;
                _matchLocation = value;
            }
        }

        [XmlIgnore]
        public bool MatchLocationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RoamingCriteria _matchRoaming;

        [XmlElement(ElementName = "matchRoaming", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        public BroadWorksConnector.Ocip.Models.RoamingCriteria MatchRoaming
        {
            get => _matchRoaming;
            set
            {
                MatchRoamingSpecified = true;
                _matchRoaming = value;
            }
        }

        [XmlIgnore]
        public bool MatchRoamingSpecified { get; set; }

        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
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
        public bool TimeScheduleSpecified { get; set; }

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
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
        public bool HolidayScheduleSpecified { get; set; }

        private List<string> _matchNumberPortabilityStatus = new List<string>();

        [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5359")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> MatchNumberPortabilityStatus
        {
            get => _matchNumberPortabilityStatus;
            set
            {
                MatchNumberPortabilityStatusSpecified = true;
                _matchNumberPortabilityStatus = value;
            }
        }

        [XmlIgnore]
        public bool MatchNumberPortabilityStatusSpecified { get; set; }

    }
}
