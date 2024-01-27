using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The common push notification event elements.
    /// The mobileNumber element is only returned for MOBILE_CALL_INFO events.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4021""}]")]
    public class PushNotificationEventData23
    {

        protected string _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4021")]
        [MinLength(1)]
        [MaxLength(128)]
        public string EventName
        {
            get => _eventName;
            set
            {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        protected bool EventNameSpecified { get; set; }

        protected bool _silent;

        [XmlElement(ElementName = "silent", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4021")]
        public bool Silent
        {
            get => _silent;
            set
            {
                SilentSpecified = true;
                _silent = value;
            }
        }

        [XmlIgnore]
        protected bool SilentSpecified { get; set; }

        protected bool _mutableContent;

        [XmlElement(ElementName = "mutableContent", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4021")]
        public bool MutableContent
        {
            get => _mutableContent;
            set
            {
                MutableContentSpecified = true;
                _mutableContent = value;
            }
        }

        [XmlIgnore]
        protected bool MutableContentSpecified { get; set; }

        protected string _pushNotificationEventParameters;

        [XmlElement(ElementName = "pushNotificationEventParameters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4021")]
        [MinLength(1)]
        [MaxLength(5899)]
        public string PushNotificationEventParameters
        {
            get => _pushNotificationEventParameters;
            set
            {
                PushNotificationEventParametersSpecified = true;
                _pushNotificationEventParameters = value;
            }
        }

        [XmlIgnore]
        protected bool PushNotificationEventParametersSpecified { get; set; }

        protected string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4021")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumberSpecified { get; set; }

    }
}
