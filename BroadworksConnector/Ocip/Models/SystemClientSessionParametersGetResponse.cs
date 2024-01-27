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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5519""}]")]
    public class SystemClientSessionParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableInactivityTimeout;

        [XmlElement(ElementName = "enableInactivityTimeout", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5519")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:5519")]
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
