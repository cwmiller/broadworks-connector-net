using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Service Activation Access Code system parameters.
    /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
        /// <see cref="SystemServiceActivationAccessCodeGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServiceActivationAccessCodeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
