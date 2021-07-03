using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28327""}]")]
    public class SystemPerformanceMeasurementReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
