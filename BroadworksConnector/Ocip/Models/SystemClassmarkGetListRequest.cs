using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Class Mark in system.
    /// The response is either a SystemClassmarkGetListResponse or an ErrorResponse.
        /// <see cref="SystemClassmarkGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClassmarkGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
