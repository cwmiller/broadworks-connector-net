using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device types supporting enhanced configuration.
    /// The response is either SystemAccessDeviceTypeGetEnhancedConfigurableListResponse
    /// or ErrorResponse.
    /// <see cref="SystemAccessDeviceTypeGetEnhancedConfigurableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1777""}]")]
    public class SystemAccessDeviceTypeGetEnhancedConfigurableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceTypeGetEnhancedConfigurableListResponse>
    {

    }
}
