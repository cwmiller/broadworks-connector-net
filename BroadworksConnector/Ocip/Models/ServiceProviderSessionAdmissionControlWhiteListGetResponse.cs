using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderSessionAdmissionControlWhiteListGetRequest.
    /// The response contains the White List information.
    /// <see cref="ServiceProviderSessionAdmissionControlWhiteListGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6778""}]")]
    public class ServiceProviderSessionAdmissionControlWhiteListGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _matchDigitPattern = new List<string>();

        [XmlElement(ElementName = "matchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6778")]
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

        protected bool _enableWhiteList;

        [XmlElement(ElementName = "enableWhiteList", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6778")]
        public bool EnableWhiteList
        {
            get => _enableWhiteList;
            set
            {
                EnableWhiteListSpecified = true;
                _enableWhiteList = value;
            }
        }

        [XmlIgnore]
        protected bool EnableWhiteListSpecified { get; set; }

    }
}
