using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the Sh Interface system parameters.
    /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemShInterfaceParametersGetRequest17
        /// <see cref="SystemShInterfaceParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemShInterfaceParametersGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemShInterfaceParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
