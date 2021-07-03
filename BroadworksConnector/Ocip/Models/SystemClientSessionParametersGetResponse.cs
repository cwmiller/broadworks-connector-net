using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClientSessionParametersGetRequest.
    /// Contains a list of system Client Session (web and CLI) parameters.
    /// <see cref="SystemClientSessionParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5439""}]")]
    public class SystemClientSessionParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableInactivityTimeout;

        [XmlElement(ElementName = "enableInactivityTimeout", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5439")]
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

        private int _inactivityTimeoutMinutes;

        [XmlElement(ElementName = "inactivityTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5439")]
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
