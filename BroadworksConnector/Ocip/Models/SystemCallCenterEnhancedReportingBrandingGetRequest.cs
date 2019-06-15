using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system branding information.
    /// The response is either SystemCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
        /// <see cref="SystemCallCenterEnhancedReportingBrandingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingBrandingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
