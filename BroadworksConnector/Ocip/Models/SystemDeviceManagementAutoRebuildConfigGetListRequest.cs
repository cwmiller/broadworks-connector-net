using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of OCI request prefixes including if they trigger DM
    /// automatic rebuild event or not.
    /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
        /// <see cref="SystemDeviceManagementAutoRebuildConfigGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceManagementAutoRebuildConfigGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
