using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI entries from the Broadworks Common Communication Transport (BCCT) protocol to interface
    /// mapping list.
    /// The response is SystemBCCTGetOCIInterfaceAddressListResponse or ErrorResponse.
        /// <see cref="SystemBCCTGetOCIInterfaceAddressListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBCCTGetOCIInterfaceAddressListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
