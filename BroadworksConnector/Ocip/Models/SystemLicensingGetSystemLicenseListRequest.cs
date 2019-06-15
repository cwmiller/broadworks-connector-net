using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
        /// <see cref="SystemLicensingGetSystemLicenseListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemLicensingGetSystemLicenseListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
