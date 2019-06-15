using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Application Server Registration system parameters.
    /// The response is either SystemASRParametersGetResponse or ErrorResponse.
    /// Replaced By: SystemASRParametersGetRequest14sp5
        /// <see cref="SystemASRParametersGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemASRParametersGetRequest14sp5"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemASRParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
