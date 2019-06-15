using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system settings for the call center enhanced reporting scheduling tasks.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse or an ErrorResponse.
        /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
