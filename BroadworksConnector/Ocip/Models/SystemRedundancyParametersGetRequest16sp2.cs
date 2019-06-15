using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Redundancy system parameters.
    /// The response is either SystemRedundancyParametersGetResponse16sp2 or ErrorResponse.
        /// <see cref="SystemRedundancyParametersGetResponse16sp2"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRedundancyParametersGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
