using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level database schema instances defined for Enhanced Call Logs.
    /// For each instance, the number of actual users (users that have the Enhanced Call Logs service
    /// and are assigned to that schema instance) and the number of potential users are given
    /// (users part of a group or service provider using that schema instance).
    /// The response is either a SystemEnhancedCallLogsSchemaInstanceGetListResponse or an ErrorResponse.
    /// <see cref="SystemEnhancedCallLogsSchemaInstanceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1b5ee40628a3f2b1bcab94a53dec91e7:290""}]")]
    public class SystemEnhancedCallLogsSchemaInstanceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsSchemaInstanceGetListResponse>
    {

    }
}
