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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1648""}]")]
    public class UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1648")]
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
