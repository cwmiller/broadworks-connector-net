using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the performance measurements reporting settings.
    /// The response is either SystemPerformanceMeasurementReportingGetResponse24 or ErrorResponse.
    /// <see cref="SystemPerformanceMeasurementReportingGetResponse24"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14361""}]")]
    public class SystemPerformanceMeasurementReportingGetRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
