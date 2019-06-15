using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system Domain parameters.
    /// The response is either SystemDomainParametersGetResponse or ErrorResponse.
        /// <see cref="SystemDomainParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
