using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse22 or ErrorResponse.
    /// 
    /// Replaced by: SystemNetworkServerSyncParametersGetRequest24V2 in AS data mode.
    /// <see cref="SystemNetworkServerSyncParametersGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkServerSyncParametersGetRequest24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8635""}]")]
    public class SystemNetworkServerSyncParametersGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
