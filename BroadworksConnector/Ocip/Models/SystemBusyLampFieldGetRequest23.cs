using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Busy Lamp
    /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// <see cref="SystemBusyLampFieldGetResponse23"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBusyLampFieldGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
