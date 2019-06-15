using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of ChargingFunctionElementServers defined in the system.
    /// The response is either a SystemAccountingGetChargingFunctionElementServerListResponse
    /// or an ErrorResponse.
        /// <see cref="SystemAccountingGetChargingFunctionElementServerListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingGetChargingFunctionElementServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
