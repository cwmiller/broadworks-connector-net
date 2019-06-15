using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the authentication lockout settings in the system.
    /// The response is either a SystemAuthenticationLockoutSettingsGetResponse or an ErrorResponse.
        /// <see cref="SystemAuthenticationLockoutSettingsGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAuthenticationLockoutSettingsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
