using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ExternalAuthenticationCreateLoginTokenRequest.
    /// <see cref="ExternalAuthenticationCreateLoginTokenRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:336""}]")]
    public class ExternalAuthenticationCreateLoginTokenResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _loginToken;

        [XmlElement(ElementName = "loginToken", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:336")]
        [MinLength(1)]
        public string LoginToken
        {
            get => _loginToken;
            set
            {
                LoginTokenSpecified = true;
                _loginToken = value;
            }
        }

        [XmlIgnore]
        public bool LoginTokenSpecified { get; set; }

    }
}
