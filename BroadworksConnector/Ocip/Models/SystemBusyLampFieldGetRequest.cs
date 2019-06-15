using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Busy Lamp
    /// Field service. The response is either a SystemBusyLampFieldGetResponse or an ErrorResponse.
        /// <see cref="SystemBusyLampFieldGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBusyLampFieldGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
