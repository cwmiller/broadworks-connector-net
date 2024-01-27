using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserSingleSignOnCreateDeviceTokenRequest.
    /// <see cref="UserSingleSignOnCreateDeviceTokenRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:612""}]")]
    public class UserSingleSignOnCreateDeviceTokenResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _deviceToken;

        [XmlElement(ElementName = "deviceToken", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:612")]
        [MinLength(1)]
        public string DeviceToken
        {
            get => _deviceToken;
            set
            {
                DeviceTokenSpecified = true;
                _deviceToken = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTokenSpecified { get; set; }

    }
}
