using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of migrated users.
    /// The response is either SystemMigratedUsersGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemMigratedUsersGetListRequest22 in AS data mode
        /// <see cref="SystemMigratedUsersGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemMigratedUsersGetListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMigratedUsersGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
