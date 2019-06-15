using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of System Diameter base parameters.
    /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
        /// <see cref="SystemBwDiameterBaseDataGetResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBwDiameterBaseDataGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
