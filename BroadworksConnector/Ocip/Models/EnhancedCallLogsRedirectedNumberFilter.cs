using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on the transferred/forwarded number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48471"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48472""}]}]")]
    public class EnhancedCallLogsRedirectedNumberFilter
    {

        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedCallSelection _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedCallSelection RedirectedCall
        {
            get => _redirectedCall;
            set
            {
                RedirectedCallSpecified = true;
                _redirectedCall = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectedCallSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.BasicCallType> _includeServiceInvocationBasicCallType = new List<BroadWorksConnector.Ocip.Models.BasicCallType>();

        [XmlElement(ElementName = "includeServiceInvocationBasicCallType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallType> IncludeServiceInvocationBasicCallType
        {
            get => _includeServiceInvocationBasicCallType;
            set
            {
                IncludeServiceInvocationBasicCallTypeSpecified = true;
                _includeServiceInvocationBasicCallType = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeServiceInvocationBasicCallTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallCategory> _includeServiceInvocationCallCategory = new List<BroadWorksConnector.Ocip.Models.CallCategory>();

        [XmlElement(ElementName = "includeServiceInvocationCallCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public List<BroadWorksConnector.Ocip.Models.CallCategory> IncludeServiceInvocationCallCategory
        {
            get => _includeServiceInvocationCallCategory;
            set
            {
                IncludeServiceInvocationCallCategorySpecified = true;
                _includeServiceInvocationCallCategory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeServiceInvocationCallCategorySpecified { get; set; }

        private List<string> _includeServiceInvocationConfigurableCallType = new List<string>();

        [XmlElement(ElementName = "includeServiceInvocationConfigurableCallType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> IncludeServiceInvocationConfigurableCallType
        {
            get => _includeServiceInvocationConfigurableCallType;
            set
            {
                IncludeServiceInvocationConfigurableCallTypeSpecified = true;
                _includeServiceInvocationConfigurableCallType = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeServiceInvocationConfigurableCallTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationDialedNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaServiceInvocationDialedNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationDialedNumber
        {
            get => _searchCriteriaServiceInvocationDialedNumber;
            set
            {
                SearchCriteriaServiceInvocationDialedNumberSpecified = true;
                _searchCriteriaServiceInvocationDialedNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceInvocationDialedNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationCalledNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaServiceInvocationCalledNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationCalledNumber
        {
            get => _searchCriteriaServiceInvocationCalledNumber;
            set
            {
                SearchCriteriaServiceInvocationCalledNumberSpecified = true;
                _searchCriteriaServiceInvocationCalledNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceInvocationCalledNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationNetworkTranslatedNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaServiceInvocationNetworkTranslatedNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48472")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationNetworkTranslatedNumber
        {
            get => _searchCriteriaServiceInvocationNetworkTranslatedNumber;
            set
            {
                SearchCriteriaServiceInvocationNetworkTranslatedNumberSpecified = true;
                _searchCriteriaServiceInvocationNetworkTranslatedNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceInvocationNetworkTranslatedNumberSpecified { get; set; }

    }
}
