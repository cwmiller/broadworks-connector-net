using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the licensing information.
    /// The response is either SystemLicensingGetResponse14sp3 or ErrorResponse.
        /// <see cref="SystemLicensingGetResponse14sp3"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
