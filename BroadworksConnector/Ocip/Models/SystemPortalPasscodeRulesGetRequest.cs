using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system passcode rules setting.
    /// The response is either SystemPortalPasscodeRulesGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemPortalPasscodeRulesGetRequest19
    /// <see cref="SystemPortalPasscodeRulesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPortalPasscodeRulesGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:29458""}]")]
    public class SystemPortalPasscodeRulesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemPortalPasscodeRulesGetResponse>
    {

    }
}
