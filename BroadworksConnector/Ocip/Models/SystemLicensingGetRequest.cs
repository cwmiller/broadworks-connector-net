using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the licensing information.
    /// The response is either SystemLicensingGetResponse or ErrorResponse.
    /// Replaced By: SystemLicensingGetRequest14sp3
        /// <see cref="SystemLicensingGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemLicensingGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
