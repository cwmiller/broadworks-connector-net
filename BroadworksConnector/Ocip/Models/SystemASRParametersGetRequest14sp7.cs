using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// <see cref="SystemASRParametersGetResponse14sp7"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemASRParametersGetRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
