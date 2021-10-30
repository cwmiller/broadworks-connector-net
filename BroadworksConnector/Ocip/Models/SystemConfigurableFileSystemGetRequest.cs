using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
    /// Replaced by: SystemConfigurableFileSystemGetRequest23
    /// <see cref="SystemConfigurableFileSystemGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemConfigurableFileSystemGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7754""}]")]
    public class SystemConfigurableFileSystemGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse>
    {

    }
}
