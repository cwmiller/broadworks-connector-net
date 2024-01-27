using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the File System parameters.
    /// The response is either SystemConfigurableFileSystemGetResponse23V2 or ErrorResponse.
    /// <see cref="SystemConfigurableFileSystemGetResponse23V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6683""}]")]
    public class SystemConfigurableFileSystemGetRequest23V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23V2>
    {

    }
}
