using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Mail system parameters.
    /// The response is either SystemMailParametersGetResponse22 or ErrorResponse.
        /// <see cref="SystemMailParametersGetResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMailParametersGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
