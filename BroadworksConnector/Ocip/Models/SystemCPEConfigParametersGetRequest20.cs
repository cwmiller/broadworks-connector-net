using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of CPE Config system parameters.
    /// The response is either SystemCPEConfigParametersGetResponse20 or ErrorResponse.
    /// 
    /// Replaced by: SystemCPEConfigParametersGetRequest21
        /// <see cref="SystemCPEConfigParametersGetResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCPEConfigParametersGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
