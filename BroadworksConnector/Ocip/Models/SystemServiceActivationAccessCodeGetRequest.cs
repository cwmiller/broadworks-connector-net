using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Service Activation Access Code system parameters.
    /// The response is either a SystemServiceActivationAccessCodeGetResponse or an ErrorResponse.
    /// <see cref="SystemServiceActivationAccessCodeGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16187""}]")]
    public class SystemServiceActivationAccessCodeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemServiceActivationAccessCodeGetResponse>
    {

    }
}
