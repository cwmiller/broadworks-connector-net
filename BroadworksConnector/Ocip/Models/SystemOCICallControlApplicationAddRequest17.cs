using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an application to the OCI call control application list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemOCICallControlApplicationAddRequest22
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemOCICallControlApplicationAddRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6316""}]")]
    public class SystemOCICallControlApplicationAddRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6316")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationIdSpecified { get; set; }

        private bool _enableSystemWide;

        [XmlElement(ElementName = "enableSystemWide", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6316")]
        public bool EnableSystemWide
        {
            get => _enableSystemWide;
            set
            {
                EnableSystemWideSpecified = true;
                _enableSystemWide = value;
            }
        }

        [XmlIgnore]
        public bool EnableSystemWideSpecified { get; set; }

        private int _notificationTimeoutSeconds;

        [XmlElement(ElementName = "notificationTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6316")]
        [MinInclusive(2)]
        [MaxInclusive(30)]
        public int NotificationTimeoutSeconds
        {
            get => _notificationTimeoutSeconds;
            set
            {
                NotificationTimeoutSecondsSpecified = true;
                _notificationTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool NotificationTimeoutSecondsSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6316")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private int _maxEventChannelsPerSet;

        [XmlElement(ElementName = "maxEventChannelsPerSet", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6316")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaxEventChannelsPerSet
        {
            get => _maxEventChannelsPerSet;
            set
            {
                MaxEventChannelsPerSetSpecified = true;
                _maxEventChannelsPerSet = value;
            }
        }

        [XmlIgnore]
        public bool MaxEventChannelsPerSetSpecified { get; set; }

    }
}
