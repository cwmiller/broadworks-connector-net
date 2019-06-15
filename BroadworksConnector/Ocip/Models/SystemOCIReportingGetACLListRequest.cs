using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI Reporting Access Control List.
    /// The response is either a SystemOCIReportingGetACLListResponse or an ErrorResponse.
        /// <see cref="SystemOCIReportingGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIReportingGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
