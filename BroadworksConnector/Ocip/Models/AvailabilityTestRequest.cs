using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// AvailabilityTestRequest is for high-availability support. The response is either SuccessResponse
    /// or ErrorResponse.
        /// <see cref="AvailabilityTestRequest"/>
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AvailabilityTestRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
