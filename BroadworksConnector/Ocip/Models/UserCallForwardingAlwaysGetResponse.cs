using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallForwardingAlwaysGetRequest.
    /// <see cref="UserCallForwardingAlwaysGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c6e8b321b24b0bc38cc20e79ffb96700:59""}]")]
    public class UserCallForwardingAlwaysGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"c6e8b321b24b0bc38cc20e79ffb96700:59")]
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

        protected string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c6e8b321b24b0bc38cc20e79ffb96700:59")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToPhoneNumberSpecified { get; set; }

        protected bool _isRingSplashActive;

        [XmlElement(ElementName = "isRingSplashActive", IsNullable = false, Namespace = "")]
        [Group(@"c6e8b321b24b0bc38cc20e79ffb96700:59")]
        public bool IsRingSplashActive
        {
            get => _isRingSplashActive;
            set
            {
                IsRingSplashActiveSpecified = true;
                _isRingSplashActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsRingSplashActiveSpecified { get; set; }

    }
}
