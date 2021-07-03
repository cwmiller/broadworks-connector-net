using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22 or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6417""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
