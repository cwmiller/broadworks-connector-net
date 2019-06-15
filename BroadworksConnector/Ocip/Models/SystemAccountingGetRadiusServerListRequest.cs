using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Radius Servers defined in the system.
    /// The response is either a SystemAccountingGetRadiusServerListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemAccountingGetRadiusServerListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingGetRadiusServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
