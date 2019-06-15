using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Emergency Call DDos Protection configurations.
    /// The response is either SystemEmergencyCallDDoSProtectionGetResponse or ErrorResponse.
        /// <see cref="SystemEmergencyCallDDoSProtectionGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEmergencyCallDDoSProtectionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
