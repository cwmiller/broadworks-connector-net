using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Communication Barring Alternate Call Indicator.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5678""}]")]
    public class SystemCommunicationBarringAlternateCallIndicatorModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5678")]
        [MinLength(1)]
        [MaxLength(40)]
        public string AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCallIndicatorSpecified { get; set; }

        protected string _networkServerAlternateCallIndicator;

        [XmlElement(ElementName = "networkServerAlternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5678")]
        [MinLength(1)]
        [MaxLength(64)]
        public string NetworkServerAlternateCallIndicator
        {
            get => _networkServerAlternateCallIndicator;
            set
            {
                NetworkServerAlternateCallIndicatorSpecified = true;
                _networkServerAlternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkServerAlternateCallIndicatorSpecified { get; set; }

    }
}
