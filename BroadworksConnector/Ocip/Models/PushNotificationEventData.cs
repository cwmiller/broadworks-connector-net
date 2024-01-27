using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The common push notification event elements.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:50213""}]")]
    public class PushNotificationEventData
    {

        protected string _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:50213")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:50213")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:50213")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:50213")]
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

    }
}
