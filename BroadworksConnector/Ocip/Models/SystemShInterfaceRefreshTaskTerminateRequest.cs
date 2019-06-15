using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Terminates the system refresh task in progress on the local Application Server node.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemShInterfaceRefreshTaskTerminateRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
