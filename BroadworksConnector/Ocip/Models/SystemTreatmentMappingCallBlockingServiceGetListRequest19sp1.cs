using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a table of all the existing Call Blocking Service Mappings in the system.
    /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest22
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTreatmentMappingCallBlockingServiceGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35727""}]")]
    public class SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1>
    {

    }
}
