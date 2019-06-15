using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Broadworks Anywhere system parameters.
    /// The response is either a SystemBroadWorksAnywhereGetResponse or an ErrorResponse.
        /// <see cref="SystemBroadWorksAnywhereGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksAnywhereGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
