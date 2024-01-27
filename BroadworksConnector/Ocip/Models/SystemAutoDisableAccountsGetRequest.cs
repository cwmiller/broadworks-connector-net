using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get Auto Disable Accounts system parameters.
    /// The response is either SystemAutoDisableAccountsGetResponse or ErrorResponse.
    /// <see cref="SystemAutoDisableAccountsGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemAutoDisableAccountsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAutoDisableAccountsGetResponse>
    {

    }
}
