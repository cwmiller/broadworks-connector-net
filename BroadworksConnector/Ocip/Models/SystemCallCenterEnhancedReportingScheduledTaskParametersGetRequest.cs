using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21431""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse>
    {

    }
}
