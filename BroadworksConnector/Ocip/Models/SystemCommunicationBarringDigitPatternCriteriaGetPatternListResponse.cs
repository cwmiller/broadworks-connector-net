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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6084""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaGetPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _matchDigitPattern = new List<string>();

        [XmlElement(ElementName = "matchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:6084")]
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
