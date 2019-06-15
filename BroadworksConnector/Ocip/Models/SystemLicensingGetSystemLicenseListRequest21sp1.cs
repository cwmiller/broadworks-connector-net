using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse21sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest22.
        /// <see cref="SystemLicensingGetSystemLicenseListResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemLicensingGetSystemLicenseListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
