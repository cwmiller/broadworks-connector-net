using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of GETS AVP Code Maps at the system level.
    /// The response is either SystemGETSAvpCodeMapGetListResponse or ErrorResponse.
        /// <see cref="SystemGETSAvpCodeMapGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSAvpCodeMapGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
