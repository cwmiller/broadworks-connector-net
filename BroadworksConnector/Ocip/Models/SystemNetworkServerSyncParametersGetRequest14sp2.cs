using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse14sp2 or ErrorResponse.
    /// Replaced By: SystemNetworkServerSyncParametersGetRequest16
    /// <see cref="SystemNetworkServerSyncParametersGetResponse14sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkServerSyncParametersGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27841""}]")]
    public class SystemNetworkServerSyncParametersGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNetworkServerSyncParametersGetResponse14sp2>
    {

    }
}
