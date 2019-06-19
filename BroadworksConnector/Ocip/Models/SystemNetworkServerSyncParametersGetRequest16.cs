using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse16 or ErrorResponse.
    /// Replaced By: SystemNetworkServerSyncParametersGetRequest17sp4
    /// <see cref="SystemNetworkServerSyncParametersGetResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkServerSyncParametersGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21834""}]")]
    public class SystemNetworkServerSyncParametersGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
