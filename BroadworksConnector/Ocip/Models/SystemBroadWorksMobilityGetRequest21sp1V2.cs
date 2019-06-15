using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse21sp1V2 or an ErrorResponse.
    /// 
    /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
        /// <see cref="SystemBroadWorksMobilityGetResponse21sp1V2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityGetRequest22V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetRequest21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
