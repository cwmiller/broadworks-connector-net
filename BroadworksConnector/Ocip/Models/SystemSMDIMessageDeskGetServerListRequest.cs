using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of SMDI Servers defined in the system.
    /// The response is either a SystemSMDIMessageDeskGetServerListResponse or an ErrorResponse.
        /// <see cref="SystemSMDIMessageDeskGetServerListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIMessageDeskGetServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
