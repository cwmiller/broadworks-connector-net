using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Home Networks.
    /// The response is either a SystemHomeNetworkGetListResponse or an ErrorResponse.
    /// <see cref="SystemHomeNetworkGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11244""}]")]
    public class SystemHomeNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11244")]
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
        protected bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaHomeMscAddress> _searchCriteriaHomeMscAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaHomeMscAddress>();

        [XmlElement(ElementName = "searchCriteriaHomeMscAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11244")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaHomeMscAddress> SearchCriteriaHomeMscAddress
        {
            get => _searchCriteriaHomeMscAddress;
            set
            {
                SearchCriteriaHomeMscAddressSpecified = true;
                _searchCriteriaHomeMscAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaHomeMscAddressSpecified { get; set; }

    }
}
