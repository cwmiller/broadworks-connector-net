using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of user creation tasks in the system.
    /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// <see cref="SystemTrunkGroupUserCreationTaskGetListResponse14sp4"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTrunkGroupUserCreationTaskGetListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
