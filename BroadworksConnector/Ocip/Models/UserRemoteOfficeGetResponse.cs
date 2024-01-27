using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserRemoteOfficeGetRequest.
    /// <see cref="UserRemoteOfficeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dbef84b1c59b67471031e429db8fd980:56""}]")]
    public class UserRemoteOfficeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"dbef84b1c59b67471031e429db8fd980:56")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected string _remoteOfficePhoneNumber;

        [XmlElement(ElementName = "remoteOfficePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"dbef84b1c59b67471031e429db8fd980:56")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RemoteOfficePhoneNumber
        {
            get => _remoteOfficePhoneNumber;
            set
            {
                RemoteOfficePhoneNumberSpecified = true;
                _remoteOfficePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool RemoteOfficePhoneNumberSpecified { get; set; }

    }
}
