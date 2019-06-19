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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14771""}]")]
    public class SystemServerAddressesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
