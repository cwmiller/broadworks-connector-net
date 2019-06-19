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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1314""}]")]
    public class SystemAccessDeviceTypeGetEnhancedConfigurableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
