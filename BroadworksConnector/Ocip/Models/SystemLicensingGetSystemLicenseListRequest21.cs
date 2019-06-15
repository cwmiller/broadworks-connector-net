using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21p1.
        /// <see cref="SystemLicensingGetSystemLicenseListResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemLicensingGetSystemLicenseListRequest21p1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
