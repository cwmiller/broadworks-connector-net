using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of provisioned prefixes in the system.
    /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
        /// <see cref="SystemCLIDDeliveryPrefixGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCLIDDeliveryPrefixGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
