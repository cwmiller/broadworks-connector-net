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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7119""}]")]
    public class SystemCPEConfigGetFileServerListRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCPEConfigGetFileServerListResponse14sp6>
    {

    }
}
