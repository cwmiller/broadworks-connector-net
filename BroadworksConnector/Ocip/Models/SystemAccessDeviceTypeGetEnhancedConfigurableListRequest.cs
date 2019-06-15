using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device types supporting enhanced configuration.
    /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
    /// or ErrorResponse.
        /// <see cref="SystemAccessDeviceTypeGetEnhancedConfigurableListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceTypeGetEnhancedConfigurableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
