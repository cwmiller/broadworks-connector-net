using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Digit Pattern Criteria.
    /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// <see cref="ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
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
        
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        public int ResponseSizeLimit {
            get => _responseSizeLimit;
            set {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> _searchCriteriaDigitPattern;

        [XmlElement(ElementName = "searchCriteriaDigitPattern", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> SearchCriteriaDigitPattern {
            get => _searchCriteriaDigitPattern;
            set {
                SearchCriteriaDigitPatternSpecified = true;
                _searchCriteriaDigitPattern = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDigitPatternSpecified { get; set; }
        
    }
}
