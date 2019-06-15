using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Me Now service.
    /// The response is either a SystemCallMeNowGetResponse or an ErrorResponse.
        /// <see cref="SystemCallMeNowGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallMeNowGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
