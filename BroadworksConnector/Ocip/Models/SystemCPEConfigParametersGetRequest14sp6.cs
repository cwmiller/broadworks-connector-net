using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of CPE Config system parameters.
    /// The response is either SystemCPEConfigParametersGetResponse14sp6 or ErrorResponse.
    /// 
    /// Replaced by: SystemCPEConfigParametersGetRequest20
        /// <see cref="SystemCPEConfigParametersGetResponse14sp6"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCPEConfigParametersGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersGetRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
