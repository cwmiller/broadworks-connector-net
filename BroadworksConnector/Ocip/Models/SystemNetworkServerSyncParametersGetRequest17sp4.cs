using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Network Server Sync system parameters.
    /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
    /// 
    /// Replaced by: SystemNetworkServerSyncParametersGetRequest24
    /// <see cref="SystemNetworkServerSyncParametersGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkServerSyncParametersGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8619""}]")]
    public class SystemNetworkServerSyncParametersGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
