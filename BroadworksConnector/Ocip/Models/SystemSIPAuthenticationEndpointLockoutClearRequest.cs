using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to clear sip authentication endpoint lockouts in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16753""}]")]
    public class SystemSIPAuthenticationEndpointLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.UserEndpointKey> _userEndpointKey = new List<BroadWorksConnector.Ocip.Models.UserEndpointKey>();

        [XmlElement(ElementName = "userEndpointKey", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16753")]
        public List<BroadWorksConnector.Ocip.Models.UserEndpointKey> UserEndpointKey
        {
            get => _userEndpointKey;
            set
            {
                UserEndpointKeySpecified = true;
                _userEndpointKey = value;
            }
        }

        [XmlIgnore]
        protected bool UserEndpointKeySpecified { get; set; }

    }
}
