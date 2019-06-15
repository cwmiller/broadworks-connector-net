using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of SMDI Servers routes in the system.
    /// The response is either a SystemSMDIMessageDeskGetServerRouteListResponse or an ErrorResponse.
        /// <see cref="SystemSMDIMessageDeskGetServerRouteListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIMessageDeskGetServerRouteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
