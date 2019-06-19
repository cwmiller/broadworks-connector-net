using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of ThirdPartyVoiceMailSupport User DN's defined in the system.
    /// The response is either a SystemThirdPartyVoiceMailSupportGetDnListResponse or an ErrorResponse.
    /// The search can be done using multiple criterion.
    /// <see cref="SystemThirdPartyVoiceMailSupportGetDnListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:139""}]")]
    public class SystemThirdPartyVoiceMailSupportGetDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:139")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> _searchCriteriaSystemServiceDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn>();

        [XmlElement(ElementName = "searchCriteriaSystemServiceDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:139")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> SearchCriteriaSystemServiceDn
        {
            get => _searchCriteriaSystemServiceDn;
            set
            {
                SearchCriteriaSystemServiceDnSpecified = true;
                _searchCriteriaSystemServiceDn = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaSystemServiceDnSpecified { get; set; }

    }
}
