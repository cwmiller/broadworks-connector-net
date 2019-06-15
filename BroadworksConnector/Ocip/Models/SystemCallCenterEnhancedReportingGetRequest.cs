using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the call center enhanced reporting system settings.
    /// The response is either a SystemCallCenterEnhancedReportingGetResponse or an ErrorResponse.
        /// <see cref="SystemCallCenterEnhancedReportingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
