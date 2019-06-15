using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Emergency Zones.
    /// The response is either a SystemEmergencyZonesGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemEmergencyZonesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEmergencyZonesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
