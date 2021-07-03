using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest.
    /// The response contains the Digit Pattern Criteria information.
    /// <see cref="SystemCommunicationBarringDigitPatternCriteriaGetPatternListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6004""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _matchDigitPattern = new List<string>();

        [XmlElement(ElementName = "matchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6004")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> MatchDigitPattern
        {
            get => _matchDigitPattern;
            set
            {
                MatchDigitPatternSpecified = true;
                _matchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool MatchDigitPatternSpecified { get; set; }

    }
}
