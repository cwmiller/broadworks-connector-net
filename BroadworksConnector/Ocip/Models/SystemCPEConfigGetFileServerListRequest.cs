using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device CPE config file servers.
    /// The response is either SystemCPEConfigGetFileServerListResponse or ErrorResponse.
    /// Replaced By: SystemCPEConfigGetFileServerListRequest14sp6
    /// <see cref="SystemCPEConfigGetFileServerListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCPEConfigGetFileServerListRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25369""}]")]
    public class SystemCPEConfigGetFileServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
