using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Meet-Me Conferencing functions.
    /// The response is either a SystemMeetMeConferencingGetResponse19 or an ErrorResponse.
        /// <see cref="SystemMeetMeConferencingGetResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMeetMeConferencingGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
