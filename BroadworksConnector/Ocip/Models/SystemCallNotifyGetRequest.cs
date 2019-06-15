using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Notify.
    /// The response is either a SystemCallNotifyGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemCallNotifyGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallNotifyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
