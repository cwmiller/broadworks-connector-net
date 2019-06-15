using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the GETS system settings.
    /// The response is either SystemGETSGetResponse or ErrorResponse.
        /// <see cref="SystemGETSGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
