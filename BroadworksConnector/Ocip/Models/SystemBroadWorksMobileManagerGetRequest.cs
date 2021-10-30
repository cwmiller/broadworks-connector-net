using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the BroadWorks Mobile Manager service system settings.
    /// The response is either SystemBroadWorksMobileManagerGetResponse or ErrorResponse.
    /// <see cref="SystemBroadWorksMobileManagerGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2561""}]")]
    public class SystemBroadWorksMobileManagerGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobileManagerGetResponse>
    {

    }
}
