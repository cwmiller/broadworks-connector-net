using System;
using System.Xml.Serialization;
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
     
    public class SystemSIPAuthenticationEndpointLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.UserEndpointKey> _userEndpointKey;

        [XmlElement(ElementName = "userEndpointKey", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.UserEndpointKey> UserEndpointKey {
            get => _userEndpointKey;
            set {
                UserEndpointKeySpecified = true;
                _userEndpointKey = value;
            }
        }

        [XmlIgnore]
        public bool UserEndpointKeySpecified { get; set; }
        
    }
}
