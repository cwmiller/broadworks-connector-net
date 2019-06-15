using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrieves the status of the system refresh task on the local Application Server node.
    /// The response is either a SystemShInterfaceRefreshTaskGetResponse or an ErrorResponse.
        /// <see cref="SystemShInterfaceRefreshTaskGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemShInterfaceRefreshTaskGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
