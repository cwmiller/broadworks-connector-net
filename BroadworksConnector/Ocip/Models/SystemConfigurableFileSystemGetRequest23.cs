using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
    /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
    /// <see cref="SystemConfigurableFileSystemGetResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7783""}]")]
    public class SystemConfigurableFileSystemGetRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23>
    {

    }
}
