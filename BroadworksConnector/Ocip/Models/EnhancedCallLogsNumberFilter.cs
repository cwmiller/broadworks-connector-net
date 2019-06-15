using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on the called number or number called.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsNumberFilter 
    {

        
        private List<BroadWorksConnector.Ocip.Models.BasicCallType> _includeBasicCallType;

        [XmlElement(ElementName = "includeBasicCallType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallType> IncludeBasicCallType {
            get => _includeBasicCallType;
            set {
                IncludeBasicCallTypeSpecified = true;
                _includeBasicCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeBasicCallTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallCategory> _includeCallCategory;

        [XmlElement(ElementName = "includeCallCategory", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCategory> IncludeCallCategory {
            get => _includeCallCategory;
            set {
                IncludeCallCategorySpecified = true;
                _includeCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool IncludeCallCategorySpecified { get; set; }
        
        private List<string> _includeConfigurableCallType;

        [XmlElement(ElementName = "includeConfigurableCallType", IsNullable = false, Namespace = "")]
        public List<string> IncludeConfigurableCallType {
            get => _includeConfigurableCallType;
            set {
                IncludeConfigurableCallTypeSpecified = true;
                _includeConfigurableCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeConfigurableCallTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaDialedNumber;

        [XmlElement(ElementName = "searchCriteriaDialedNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaDialedNumber {
            get => _searchCriteriaDialedNumber;
            set {
                SearchCriteriaDialedNumberSpecified = true;
                _searchCriteriaDialedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDialedNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaCalledNumber;

        [XmlElement(ElementName = "searchCriteriaCalledNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCalledNumber {
            get => _searchCriteriaCalledNumber;
            set {
                SearchCriteriaCalledNumberSpecified = true;
                _searchCriteriaCalledNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCalledNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaNetworkTranslatedNumber;

        [XmlElement(ElementName = "searchCriteriaNetworkTranslatedNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaNetworkTranslatedNumber {
            get => _searchCriteriaNetworkTranslatedNumber;
            set {
                SearchCriteriaNetworkTranslatedNumberSpecified = true;
                _searchCriteriaNetworkTranslatedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaNetworkTranslatedNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaCallingPresentationNumber;

        [XmlElement(ElementName = "searchCriteriaCallingPresentationNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCallingPresentationNumber {
            get => _searchCriteriaCallingPresentationNumber;
            set {
                SearchCriteriaCallingPresentationNumberSpecified = true;
                _searchCriteriaCallingPresentationNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallingPresentationNumberSpecified { get; set; }
        
    }
}
