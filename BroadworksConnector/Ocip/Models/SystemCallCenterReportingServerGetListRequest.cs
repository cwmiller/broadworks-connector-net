using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Call Center Reporting Server.
    /// The response is either SystemCallCenterReportingServerGetListResponse or ErrorResponse.
        /// <see cref="SystemCallCenterReportingServerGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterReportingServerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
