using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system level Service Pack Migration parameters.
    /// The response is either a SystemServicePackMigrationGetResponse or an ErrorResponse.
        /// <see cref="SystemServicePackMigrationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServicePackMigrationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
