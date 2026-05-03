using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the software version of the Application Server.
    /// The response is either SystemSoftwareVersionGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemSoftwareVersionGetRequestRI in AS data mode
    /// <see cref="SystemSoftwareVersionGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16545""}]")]
    public class SystemSoftwareVersionGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSoftwareVersionGetResponse>
    {

    }
}
