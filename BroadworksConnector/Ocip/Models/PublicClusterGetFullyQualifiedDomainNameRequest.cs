using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the public cluster fully qualified domain name (FQDN).
    /// The response is either a PublicClusterGetFullyQualifiedDomainNameResponse
    /// or an ErrorResponse.
        /// <see cref="PublicClusterGetFullyQualifiedDomainNameResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class PublicClusterGetFullyQualifiedDomainNameRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
