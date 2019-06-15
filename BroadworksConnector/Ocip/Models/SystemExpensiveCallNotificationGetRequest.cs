using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the expensive call notification service parameters.
    /// The response is either a SystemExpensiveCallNotificationGetResponse or an ErrorResponse.
        /// <see cref="SystemExpensiveCallNotificationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExpensiveCallNotificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
