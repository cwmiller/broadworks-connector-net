using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// The response is either SystemConfigurableFileSystemGetResponse22 or ErrorResponse.
    /// <see cref="SystemConfigurableFileSystemGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7768""}]")]
    public class SystemConfigurableFileSystemGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
