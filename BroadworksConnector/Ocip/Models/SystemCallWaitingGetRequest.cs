using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Waiting.
    /// The response is either a SystemCallWaitingGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemCallWaitingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallWaitingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
