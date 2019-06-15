using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Server Addresses.
    /// The response is either SystemServerAddressesGetResponse or ErrorResponse.
    /// See also:
    /// PrimaryInfoGetRequest
    /// PublicClusterGetFullyQualifiedDomainNameRequest
        /// <see cref="SystemServerAddressesGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="PrimaryInfoGetRequest"/>
        /// <see cref="PublicClusterGetFullyQualifiedDomainNameRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemServerAddressesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
