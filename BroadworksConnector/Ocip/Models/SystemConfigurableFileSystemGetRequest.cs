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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9621""}]")]
    public class SystemConfigurableFileSystemGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse>
    {

    }
}
