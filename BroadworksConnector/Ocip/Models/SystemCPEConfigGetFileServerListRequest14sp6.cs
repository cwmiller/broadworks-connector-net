using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device CPE config file servers.
    /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
        /// <see cref="SystemCPEConfigGetFileServerListResponse14sp6"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigGetFileServerListRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
