using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Client Session (web and CLI) system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5456""}]")]
    public class SystemClientSessionParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableInactivityTimeout;

        [XmlElement(ElementName = "enableInactivityTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5456")]
        public bool EnableInactivityTimeout
        {
            get => _enableInactivityTimeout;
            set
            {
                EnableInactivityTimeoutSpecified = true;
                _enableInactivityTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool EnableInactivityTimeoutSpecified { get; set; }

        protected int _inactivityTimeoutMinutes;

        [XmlElement(ElementName = "inactivityTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5456")]
        [MinInclusive(10)]
        [MaxInclusive(360)]
        public int InactivityTimeoutMinutes
        {
            get => _inactivityTimeoutMinutes;
            set
            {
                InactivityTimeoutMinutesSpecified = true;
                _inactivityTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool InactivityTimeoutMinutesSpecified { get; set; }

    }
}
