using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallForwardingAlwaysSecondaryGetRequest.
    /// <see cref="UserCallForwardingAlwaysSecondaryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e085a89bb45835a6ffd3de9dd7df0e49:59""}]")]
    public class UserCallForwardingAlwaysSecondaryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"e085a89bb45835a6ffd3de9dd7df0e49:59")]
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
        [Group(@"e085a89bb45835a6ffd3de9dd7df0e49:59")]
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
        [Group(@"e085a89bb45835a6ffd3de9dd7df0e49:59")]
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
