using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get system level call center report template list.
    /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
        /// <see cref="SystemCallCenterEnhancedReportingReportTemplateGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingReportTemplateGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
