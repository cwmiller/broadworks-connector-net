using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list performance measurements reporting ftp servers.
    /// The response is either SystemPerformanceMeasurementReportingGetFileServerListResponse or ErrorResponse.
        /// <see cref="SystemPerformanceMeasurementReportingGetFileServerListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingGetFileServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
