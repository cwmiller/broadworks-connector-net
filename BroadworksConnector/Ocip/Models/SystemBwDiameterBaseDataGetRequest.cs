using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of System Diameter base parameters.
    /// The response is either SystemBwDiameterBaseDataGetResponse or ErrorResponse.
        /// <see cref="SystemBwDiameterBaseDataGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBwDiameterBaseDataGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
