using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the performance measurements reporting settings.
    /// The response is either SystemPerformanceMeasurementReportingGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemPerformanceMeasurementReportingGetRequest22
        /// <see cref="SystemPerformanceMeasurementReportingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemPerformanceMeasurementReportingGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
