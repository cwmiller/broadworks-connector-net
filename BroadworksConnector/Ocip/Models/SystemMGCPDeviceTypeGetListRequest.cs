using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of mgcp device types in the system.
    /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
    /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
        /// <see cref="SystemDeviceTypeGetAvailableListRequest14sp3"/>
        /// <see cref="SystemMGCPDeviceTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMGCPDeviceTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
