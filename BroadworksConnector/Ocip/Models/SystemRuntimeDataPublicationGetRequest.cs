using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call admission control parameters.
    /// The response is either a SystemRuntimeDataPublicationGetResponse or an ErrorResponse.
        /// <see cref="SystemRuntimeDataPublicationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRuntimeDataPublicationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
