using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of OCIReporting system parameters.
    /// The response is either SystemOCIReportingParametersGetResponse or ErrorResponse.
        /// <see cref="SystemOCIReportingParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIReportingParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
