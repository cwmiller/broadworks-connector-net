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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10743""}]")]
    public class SystemNetworkServerSyncParametersGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNetworkServerSyncParametersGetResponse17sp4>
    {

    }
}
