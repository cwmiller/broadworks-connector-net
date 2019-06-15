using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of custom configuration tag sets managed by the Device Management System.
    /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
    /// 
    /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
        /// <see cref="SystemDeviceManagementTagSetGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemDeviceManagementTagSetGetListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceManagementTagSetGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
