using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the Sh Interface system parameters.
    /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// <see cref="SystemShInterfaceParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemShInterfaceParametersGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
