using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the software version of the Application Server.
    /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
        /// <see cref="SystemSoftwareVersionGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSoftwareVersionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
