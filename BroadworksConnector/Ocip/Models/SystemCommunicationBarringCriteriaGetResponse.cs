using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringCriteriaGetRequest.
    /// The response contains the Communication Barring Criteria information.
    /// Replaced by: SystemCommunicationBarringCriteriaGetResponse17
    /// <see cref="SystemCommunicationBarringCriteriaGetRequest"/>
    /// <see cref="SystemCommunicationBarringCriteriaGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15142""}]")]
    public class SystemCommunicationBarringCriteriaGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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

        private List<string> _matchCallType = new List<string>();

        [XmlElement(ElementName = "matchCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchCallTypeSpecified { get; set; }

        private List<string> _matchAlternateCallIndicator = new List<string>();

        [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchAlternateCallIndicatorSpecified { get; set; }

        private bool _matchPublicNetwork;

        [XmlElement(ElementName = "matchPublicNetwork", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchPublicNetworkSpecified { get; set; }

        private bool _matchPrivateNetwork;

        [XmlElement(ElementName = "matchPrivateNetwork", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchPrivateNetworkSpecified { get; set; }

        private bool _matchLocalCategory;

        [XmlElement(ElementName = "matchLocalCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchLocalCategorySpecified { get; set; }

        private bool _matchNationalCategory;

        [XmlElement(ElementName = "matchNationalCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchNationalCategorySpecified { get; set; }

        private bool _matchInterlataCategory;

        [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInterlataCategorySpecified { get; set; }

        private bool _matchIntralataCategory;

        [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchIntralataCategorySpecified { get; set; }

        private bool _matchInternationalCategory;

        [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInternationalCategorySpecified { get; set; }

        private bool _matchPrivateCategory;

        [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchPrivateCategorySpecified { get; set; }

        private bool _matchEmergencyCategory;

        [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchEmergencyCategorySpecified { get; set; }

        private bool _matchOtherCategory;

        [XmlElement(ElementName = "matchOtherCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchOtherCategorySpecified { get; set; }

        private bool _matchInterNetwork;

        [XmlElement(ElementName = "matchInterNetwork", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInterNetworkSpecified { get; set; }

        private bool _matchInterHostingNE;

        [XmlElement(ElementName = "matchInterHostingNE", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInterHostingNESpecified { get; set; }

        private bool _matchInterAS;

        [XmlElement(ElementName = "matchInterAS", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInterASSpecified { get; set; }

        private bool _matchIntraAS;

        [XmlElement(ElementName = "matchIntraAS", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchIntraASSpecified { get; set; }

        private bool _matchChargeCalls;

        [XmlElement(ElementName = "matchChargeCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchChargeCallsSpecified { get; set; }

        private bool _matchNoChargeCalls;

        [XmlElement(ElementName = "matchNoChargeCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchNoChargeCallsSpecified { get; set; }

        private bool _matchGroupCalls;

        [XmlElement(ElementName = "matchGroupCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchGroupCallsSpecified { get; set; }

        private bool _matchEnterpriseCalls;

        [XmlElement(ElementName = "matchEnterpriseCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchEnterpriseCallsSpecified { get; set; }

        private bool _matchNetworkCalls;

        [XmlElement(ElementName = "matchNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchNetworkCallsSpecified { get; set; }

        private bool _matchNetworkURLCalls;

        [XmlElement(ElementName = "matchNetworkURLCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchNetworkURLCallsSpecified { get; set; }

        private bool _matchRepairCalls;

        [XmlElement(ElementName = "matchRepairCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchRepairCallsSpecified { get; set; }

        private bool _matchEmergencyCalls;

        [XmlElement(ElementName = "matchEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchEmergencyCallsSpecified { get; set; }

        private bool _matchInternalCalls;

        [XmlElement(ElementName = "matchInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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
        protected bool MatchInternalCallsSpecified { get; set; }

        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15142")]
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

    }
}
