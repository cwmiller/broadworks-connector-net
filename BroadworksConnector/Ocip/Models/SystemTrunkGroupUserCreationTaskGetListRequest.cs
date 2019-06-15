using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of user creation tasks in the system.
    /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse or ErrorResponse.
        /// <see cref="SystemTrunkGroupUserCreationTaskGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupUserCreationTaskGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
