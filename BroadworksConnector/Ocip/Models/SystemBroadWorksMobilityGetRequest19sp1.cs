using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityGetRequest21
        /// <see cref="SystemBroadWorksMobilityGetResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
