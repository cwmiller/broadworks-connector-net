using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Two Stage Dialing dns defined in the system.
    /// The response is either a SystemTwoStageDialingGetDnListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemTwoStageDialingGetDnListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTwoStageDialingGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
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
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> _searchCriteriaSystemServiceDn;

        [XmlElement(ElementName = "searchCriteriaSystemServiceDn", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> SearchCriteriaSystemServiceDn {
            get => _searchCriteriaSystemServiceDn;
            set {
                SearchCriteriaSystemServiceDnSpecified = true;
                _searchCriteriaSystemServiceDn = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaSystemServiceDnSpecified { get; set; }
        
    }
}
