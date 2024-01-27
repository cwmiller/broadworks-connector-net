using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of OCI request prefixes including if they trigger DM
    /// automatic rebuild event or not.
    /// The response is either a SystemDeviceManagementAutoRebuildConfigGetListResponse or an ErrorResponse.
    /// <see cref="SystemDeviceManagementAutoRebuildConfigGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7764""}]")]
    public class SystemDeviceManagementAutoRebuildConfigGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceManagementAutoRebuildConfigGetListResponse>
    {

    }
}
