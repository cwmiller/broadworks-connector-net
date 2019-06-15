using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Emergency Call Notification.
    /// The response is either a SystemEmergencyCallNotificationGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemEmergencyCallNotificationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEmergencyCallNotificationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
