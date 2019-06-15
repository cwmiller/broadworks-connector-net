using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on the transferred/forwarded number.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsRedirectedNumberFilter21sp1 
    {

        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedCallSelection21sp1 _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedCallSelection21sp1 RedirectedCall {
            get => _redirectedCall;
            set {
                RedirectedCallSpecified = true;
                _redirectedCall = value;
            }
        }

        [XmlIgnore]
        public bool RedirectedCallSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.BasicCallType> _includeServiceInvocationBasicCallType;

        [XmlElement(ElementName = "includeServiceInvocationBasicCallType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallType> IncludeServiceInvocationBasicCallType {
            get => _includeServiceInvocationBasicCallType;
            set {
                IncludeServiceInvocationBasicCallTypeSpecified = true;
                _includeServiceInvocationBasicCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeServiceInvocationBasicCallTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallCategory> _includeServiceInvocationCallCategory;

        [XmlElement(ElementName = "includeServiceInvocationCallCategory", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCategory> IncludeServiceInvocationCallCategory {
            get => _includeServiceInvocationCallCategory;
            set {
                IncludeServiceInvocationCallCategorySpecified = true;
                _includeServiceInvocationCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool IncludeServiceInvocationCallCategorySpecified { get; set; }
        
        private List<string> _includeServiceInvocationConfigurableCallType;

        [XmlElement(ElementName = "includeServiceInvocationConfigurableCallType", IsNullable = false, Namespace = "")]
        public List<string> IncludeServiceInvocationConfigurableCallType {
            get => _includeServiceInvocationConfigurableCallType;
            set {
                IncludeServiceInvocationConfigurableCallTypeSpecified = true;
                _includeServiceInvocationConfigurableCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeServiceInvocationConfigurableCallTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationDialedNumber;

        [XmlElement(ElementName = "searchCriteriaServiceInvocationDialedNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationDialedNumber {
            get => _searchCriteriaServiceInvocationDialedNumber;
            set {
                SearchCriteriaServiceInvocationDialedNumberSpecified = true;
                _searchCriteriaServiceInvocationDialedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceInvocationDialedNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationCalledNumber;

        [XmlElement(ElementName = "searchCriteriaServiceInvocationCalledNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationCalledNumber {
            get => _searchCriteriaServiceInvocationCalledNumber;
            set {
                SearchCriteriaServiceInvocationCalledNumberSpecified = true;
                _searchCriteriaServiceInvocationCalledNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceInvocationCalledNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaServiceInvocationNetworkTranslatedNumber;

        [XmlElement(ElementName = "searchCriteriaServiceInvocationNetworkTranslatedNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationNetworkTranslatedNumber {
            get => _searchCriteriaServiceInvocationNetworkTranslatedNumber;
            set {
                SearchCriteriaServiceInvocationNetworkTranslatedNumberSpecified = true;
                _searchCriteriaServiceInvocationNetworkTranslatedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceInvocationNetworkTranslatedNumberSpecified { get; set; }
        
    }
}
