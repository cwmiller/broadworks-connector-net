using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Music On Hold.
    /// The response is either a SystemMusicOnHoldGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemMusicOnHoldGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMusicOnHoldGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
