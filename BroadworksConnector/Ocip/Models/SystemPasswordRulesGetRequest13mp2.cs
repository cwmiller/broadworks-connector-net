using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system's password rules setting applicable to
    /// System administrator, Provisioning Administrator,
    /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
    /// The response is either SystemPasswordRulesGetResponse13mp2 or ErrorResponse.
    /// Replaced By : SystemPasswordRulesGetRequest16
        /// <see cref="SystemPasswordRulesGetResponse13mp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPasswordRulesGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPasswordRulesGetRequest13mp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
