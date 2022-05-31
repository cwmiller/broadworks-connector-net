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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6710""}]")]
    public class ServiceProviderSessionAdmissionControlWhiteListGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _matchDigitPattern = new List<string>();

        [XmlElement(ElementName = "matchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6710")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6710")]
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
