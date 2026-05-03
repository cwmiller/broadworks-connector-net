using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMWIDeliveryToMobileEndpointGetRequest23.
    /// <see cref="UserMWIDeliveryToMobileEndpointGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:380""}]")]
    public class UserMWIDeliveryToMobileEndpointGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:380")]
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

        protected string _mobilePhoneNumber;

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:380")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobilePhoneNumber
        {
            get => _mobilePhoneNumber;
            set
            {
                MobilePhoneNumberSpecified = (value != null);
                _mobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobilePhoneNumberSpecified { get; set; }

        protected bool _sendMissedCallAlert;

        [XmlElement(ElementName = "sendMissedCallAlert", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:380")]
        public bool SendMissedCallAlert
        {
            get => _sendMissedCallAlert;
            set
            {
                SendMissedCallAlertSpecified = true;
                _sendMissedCallAlert = value;
            }
        }

        [XmlIgnore]
        protected bool SendMissedCallAlertSpecified { get; set; }

    }
}
