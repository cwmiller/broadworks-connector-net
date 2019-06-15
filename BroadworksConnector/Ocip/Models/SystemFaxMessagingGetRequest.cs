using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Fax Messaging.
    /// The response is either a SystemFaxMessagingGetResponse or an ErrorResponse.
        /// <see cref="SystemFaxMessagingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFaxMessagingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
