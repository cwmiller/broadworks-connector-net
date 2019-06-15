using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse22V3 or an ErrorResponse.
        /// <see cref="SystemBroadWorksMobilityGetResponse22V3"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
