using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of GETS reserved Numbers.
    /// The response is either SystemGETSNumberGetListResponse or ErrorResponse.
        /// <see cref="SystemGETSNumberGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSNumberGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
