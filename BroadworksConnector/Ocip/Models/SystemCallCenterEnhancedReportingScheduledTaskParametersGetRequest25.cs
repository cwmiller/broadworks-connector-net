using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25 or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6413""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest25 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25>
    {

    }
}
