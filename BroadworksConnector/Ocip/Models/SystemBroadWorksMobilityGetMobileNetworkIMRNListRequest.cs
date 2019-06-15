using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of BroadWorks Mobility IMRN numbers from a Mobile Network.
    /// The response is either a SystemBroadWorksMobilityGetMobileNetworkIMRNListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemBroadWorksMobilityGetMobileNetworkIMRNListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetMobileNetworkIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        public string MobileNetworkName {
            get => _mobileNetworkName;
            set {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        public bool MobileNetworkNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN;

        [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN {
            get => _searchCriteriaIMRN;
            set {
                SearchCriteriaIMRNSpecified = true;
                _searchCriteriaIMRN = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaIMRNSpecified { get; set; }
        
    }
}
