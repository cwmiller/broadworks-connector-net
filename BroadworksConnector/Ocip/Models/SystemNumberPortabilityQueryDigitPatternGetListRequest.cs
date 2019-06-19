using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the System Number Portability Query Digit Pattern List information.
    /// The response is either a SystemNumberPortabilityQueryDigitPatternGetListResponse or an ErrorResponse.
    /// <see cref="SystemNumberPortabilityQueryDigitPatternGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11947""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> _searchCriteriaNumberPortabilityQueryDigitPattern = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern>();

        [XmlElement(ElementName = "searchCriteriaNumberPortabilityQueryDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11947")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> SearchCriteriaNumberPortabilityQueryDigitPattern
        {
            get => _searchCriteriaNumberPortabilityQueryDigitPattern;
            set
            {
                SearchCriteriaNumberPortabilityQueryDigitPatternSpecified = true;
                _searchCriteriaNumberPortabilityQueryDigitPattern = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaNumberPortabilityQueryDigitPatternSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> _searchCriteriaNumberPortabilityStatus = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus>();

        [XmlElement(ElementName = "searchCriteriaNumberPortabilityStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11947")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> SearchCriteriaNumberPortabilityStatus
        {
            get => _searchCriteriaNumberPortabilityStatus;
            set
            {
                SearchCriteriaNumberPortabilityStatusSpecified = true;
                _searchCriteriaNumberPortabilityStatus = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaNumberPortabilityStatusSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11947")]
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

    }
}
