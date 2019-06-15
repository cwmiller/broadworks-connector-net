using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of OCIReporting system parameters.
    /// The response is either SystemOCIReportingParametersGetResponse14sp1 or
    /// ErrorResponse.
        /// <see cref="SystemOCIReportingParametersGetResponse14sp1"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIReportingParametersGetRequest14sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
