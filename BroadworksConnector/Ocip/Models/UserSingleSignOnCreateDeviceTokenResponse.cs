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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:732""}]")]
    public class UserSingleSignOnCreateDeviceTokenResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _deviceToken;

        [XmlElement(ElementName = "deviceToken", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:732")]
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
