using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Broadworks Anywhere system parameters.
    /// The response is either a SystemBroadWorksAnywhereGetResponse or an ErrorResponse.
    /// <see cref="SystemBroadWorksAnywhereGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:218""}]")]
    public class SystemBroadWorksAnywhereGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
