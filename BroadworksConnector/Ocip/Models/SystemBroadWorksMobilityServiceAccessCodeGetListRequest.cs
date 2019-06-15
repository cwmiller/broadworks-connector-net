using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of system service access codes.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse or ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeGetListRequest21.
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityServiceAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
