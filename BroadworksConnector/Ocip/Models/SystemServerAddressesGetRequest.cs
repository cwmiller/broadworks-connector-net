using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16129""}]")]
    public class SystemServerAddressesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemServerAddressesGetResponse>
    {

    }
}
