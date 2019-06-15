using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Inventory Report.
    /// The response is either a SystemInventoryReportGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemInventoryReportGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInventoryReportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
