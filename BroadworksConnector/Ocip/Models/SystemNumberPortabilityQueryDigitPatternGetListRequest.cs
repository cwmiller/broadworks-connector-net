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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13244""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNumberPortabilityQueryDigitPatternGetListResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> _searchCriteriaNumberPortabilityQueryDigitPattern = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern>();

        [XmlElement(ElementName = "searchCriteriaNumberPortabilityQueryDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13244")]
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
        protected bool SearchCriteriaNumberPortabilityQueryDigitPatternSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> _searchCriteriaNumberPortabilityStatus = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus>();

        [XmlElement(ElementName = "searchCriteriaNumberPortabilityStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13244")]
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
        protected bool SearchCriteriaNumberPortabilityStatusSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13244")]
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

    }
}
