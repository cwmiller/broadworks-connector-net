using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level database schema instances defined for Enhanced Call Logs.
    /// For each instance, the number of actual users (users that have the Enhanced Call Logs service,
    /// are assigned to that schema instance and have recorded call logs on the NDS) are given.
    /// The response is either a SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse or an ErrorResponse.
    /// <see cref="SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:207""}]")]
    public class SystemEnhancedCallLogsActiveSchemaInstanceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse>
    {

    }
}
