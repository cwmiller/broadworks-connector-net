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
    /// Replaced by: SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest25.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21446""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22>
    {

    }
}
