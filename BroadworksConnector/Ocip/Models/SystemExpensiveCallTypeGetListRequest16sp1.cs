using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of expensive alternate call indicators in the system.
    /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
    /// or an ErrorResponse.
        /// <see cref="SystemExpensiveCallTypeGetListResponse16sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExpensiveCallTypeGetListRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
