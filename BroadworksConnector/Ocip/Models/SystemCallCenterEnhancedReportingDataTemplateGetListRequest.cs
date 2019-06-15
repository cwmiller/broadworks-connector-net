using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of data template and the corresponding information in the system.
    /// The response is either a SystemCallCenterEnhancedReportingDataTemplateGetListResponse or an ErrorResponse.
        /// <see cref="SystemCallCenterEnhancedReportingDataTemplateGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingDataTemplateGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
