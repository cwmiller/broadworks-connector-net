using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system level device profile authentication password rule settings.
    /// The response is either a SystemDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// <see cref="SystemDeviceProfileAuthenticationPasswordRulesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceProfileAuthenticationPasswordRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
