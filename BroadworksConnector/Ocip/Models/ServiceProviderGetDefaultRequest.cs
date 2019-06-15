using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the default profile for a service provider or enterprise.
    /// The response is either a ServiceProviderGetDefaultResponse or an ErrorResponse.
        /// <see cref="ServiceProviderGetDefaultResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderGetDefaultRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
