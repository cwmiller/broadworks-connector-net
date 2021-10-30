using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of allowed push notification applications.
    /// The response is either SystemPushNotificationAllowedApplicationGetListResponse or
    /// ErrorResponse.
    /// <see cref="SystemPushNotificationAllowedApplicationGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14783""}]")]
    public class SystemPushNotificationAllowedApplicationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPushNotificationAllowedApplicationGetListResponse>
    {

    }
}
