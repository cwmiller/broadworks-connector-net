using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of OCIReporting system parameters.
    /// The response is either SystemOCIReportingParametersGetResponse or ErrorResponse.
    /// <see cref="SystemOCIReportingParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5355""}]")]
    public class SystemOCIReportingParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
