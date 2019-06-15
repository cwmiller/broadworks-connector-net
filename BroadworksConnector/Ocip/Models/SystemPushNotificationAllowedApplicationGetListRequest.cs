using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of allowed push notification applications.
    /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
    /// ErrorResponse.
        /// <see cref="SystemPushNotificationAllowedApplicationGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPushNotificationAllowedApplicationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
