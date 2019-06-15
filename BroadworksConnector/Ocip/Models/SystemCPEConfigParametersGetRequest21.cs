using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of CPE Config system parameters.
    /// The response is either SystemCPEConfigParametersGetResponse21 or ErrorResponse.
        /// <see cref="SystemCPEConfigParametersGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
