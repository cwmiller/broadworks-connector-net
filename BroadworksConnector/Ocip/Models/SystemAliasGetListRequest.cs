using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all system-level Application Server aliases.
    /// The response is either SystemAliasGetListResponse or ErrorResponse.
        /// <see cref="SystemAliasGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAliasGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
