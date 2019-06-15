using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Query the provisioning server to verify the session is authorized. Most
    /// applications should not need this command, because the provisioning server
    /// verifies the session is authorized for all commands.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class VerifySessionIsValidRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
