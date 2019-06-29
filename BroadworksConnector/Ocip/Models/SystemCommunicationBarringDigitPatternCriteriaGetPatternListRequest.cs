using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Digit Pattern Criteria.
    /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5648""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5648")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5648")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> _searchCriteriaDigitPattern = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern>();

        [XmlElement(ElementName = "searchCriteriaDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5648")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDigitPattern> SearchCriteriaDigitPattern
        {
            get => _searchCriteriaDigitPattern;
            set
            {
                SearchCriteriaDigitPatternSpecified = true;
                _searchCriteriaDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDigitPatternSpecified { get; set; }

    }
}
