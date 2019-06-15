using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the broadworks mobility system parameters.
    /// The response is either a SystemBroadWorksMobilityGetResponse22 or an ErrorResponse.
    /// 
    /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
        /// <see cref="SystemBroadWorksMobilityGetResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityGetRequest22V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
