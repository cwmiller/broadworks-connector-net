using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the public cluster fully qualified domain name (FQDN).
    /// The response is either a PublicClusterGetFullyQualifiedDomainNameResponse or an ErrorResponse.
    /// <see cref="PublicClusterGetFullyQualifiedDomainNameResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:508""}]")]
    public class PublicClusterGetFullyQualifiedDomainNameRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.PublicClusterGetFullyQualifiedDomainNameResponse>
    {

    }
}
