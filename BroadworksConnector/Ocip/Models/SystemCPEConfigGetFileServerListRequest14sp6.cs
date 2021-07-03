using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device CPE config file servers.
    /// The response is either SystemCPEConfigGetFileServerListResponse14sp6 or ErrorResponse.
    /// <see cref="SystemCPEConfigGetFileServerListResponse14sp6"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7006""}]")]
    public class SystemCPEConfigGetFileServerListRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
