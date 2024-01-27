using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserOutgoingCallingPlanAuthorizationCodeGetRequest.
    /// <see cref="UserOutgoingCallingPlanAuthorizationCodeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1647""}]")]
    public class UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1647")]
        [MinLength(2)]
        [MaxLength(14)]
        public string Code
        {
            get => _code;
            set
            {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        protected bool CodeSpecified { get; set; }

    }
}
