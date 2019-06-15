using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of monitored device types.
    /// The response is either a SystemAccessDeviceMonitorGetDeviceTypeListResponse or an ErrorResponse.
        /// <see cref="SystemAccessDeviceMonitorGetDeviceTypeListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceMonitorGetDeviceTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
