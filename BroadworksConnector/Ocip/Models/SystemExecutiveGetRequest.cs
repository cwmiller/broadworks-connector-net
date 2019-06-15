using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Executive system parameters.
    /// The response is either SystemExecutiveGetResponse or ErrorResponse.
        /// <see cref="SystemExecutiveGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExecutiveGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
