using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system level SIP authentication password rule settings.
    /// The response is either a SystemSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// <see cref="SystemSIPAuthenticationPasswordRulesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPAuthenticationPasswordRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
