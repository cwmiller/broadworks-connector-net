using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Number Activation state.
    /// The response is either SystemNumberActivationGetResponse or ErrorResponse.
        /// <see cref="SystemNumberActivationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberActivationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
