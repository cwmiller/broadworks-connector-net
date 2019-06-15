using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of CPE Config system parameters.
    /// The response is either SystemCPEConfigParametersGetResponse or ErrorResponse.
    /// Replaced By: SystemCPEConfigParametersGetRequest14sp6
        /// <see cref="SystemCPEConfigParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCPEConfigParametersGetRequest14sp6"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
