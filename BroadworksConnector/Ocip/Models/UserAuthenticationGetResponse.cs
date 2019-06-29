using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserAuthenticationGetRequest.
    /// <see cref="UserAuthenticationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9db4d5fa1bbf70f2626f52a5d6e3420e:56""}]")]
    public class UserAuthenticationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:56")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UserName
        {
            get => _userName;
            set
            {
                UserNameSpecified = true;
                _userName = value;
            }
        }

        [XmlIgnore]
        protected bool UserNameSpecified { get; set; }

    }
}
