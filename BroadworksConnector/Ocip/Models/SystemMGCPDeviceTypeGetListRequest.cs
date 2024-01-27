using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of mgcp device types in the system.
    /// See Also: SystemDeviceTypeGetAvailableListRequest14sp3.
    /// The response is either SystemMGCPDeviceTypeGetListResponse or ErrorResponse.
    /// <see cref="SystemDeviceTypeGetAvailableListRequest14sp3"/>
    /// <see cref="SystemMGCPDeviceTypeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12293""}]")]
    public class SystemMGCPDeviceTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMGCPDeviceTypeGetListResponse>
    {

    }
}
