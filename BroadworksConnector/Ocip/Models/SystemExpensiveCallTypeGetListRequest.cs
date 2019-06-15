using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of expensive alternate call indicators in the system.
    /// The response is either a SystemExpensiveCallTypeGetListResponse or an ErrorResponse.
    /// Replaced by: SystemExpensiveCallTypeGetListRequest16sp1
        /// <see cref="SystemExpensiveCallTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemExpensiveCallTypeGetListRequest16sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExpensiveCallTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
