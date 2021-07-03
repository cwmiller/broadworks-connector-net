using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Roaming Networks.
    /// The response is either a SystemRoamingNetworkGetListResponse or an ErrorResponse.
    /// <see cref="SystemRoamingNetworkGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14974""}]")]
    public class SystemRoamingNetworkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14974")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress> _searchCriteriaRoamingMscAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress>();

        [XmlElement(ElementName = "searchCriteriaRoamingMscAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14974")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress> SearchCriteriaRoamingMscAddress
        {
            get => _searchCriteriaRoamingMscAddress;
            set
            {
                SearchCriteriaRoamingMscAddressSpecified = true;
                _searchCriteriaRoamingMscAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaRoamingMscAddressSpecified { get; set; }

    }
}
