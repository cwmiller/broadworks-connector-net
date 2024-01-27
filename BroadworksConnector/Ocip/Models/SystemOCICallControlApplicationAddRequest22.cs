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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13540""}]")]
    public class SystemOCICallControlApplicationAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
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
        protected bool ApplicationIdSpecified { get; set; }

        protected bool _enableSystemWide;

        [XmlElement(ElementName = "enableSystemWide", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
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
        protected bool EnableSystemWideSpecified { get; set; }

        protected int _notificationTimeoutSeconds;

        [XmlElement(ElementName = "notificationTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
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
        protected bool NotificationTimeoutSecondsSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
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
        protected bool DescriptionSpecified { get; set; }

        protected int _maxEventChannelsPerSet;

        [XmlElement(ElementName = "maxEventChannelsPerSet", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
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
        protected bool MaxEventChannelsPerSetSpecified { get; set; }

        protected int _unresponsiveChannelSetGracePeriodSeconds;

        [XmlElement(ElementName = "unresponsiveChannelSetGracePeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13540")]
        [MinInclusive(0)]
        [MaxInclusive(30)]
        public int UnresponsiveChannelSetGracePeriodSeconds
        {
            get => _unresponsiveChannelSetGracePeriodSeconds;
            set
            {
                UnresponsiveChannelSetGracePeriodSecondsSpecified = true;
                _unresponsiveChannelSetGracePeriodSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool UnresponsiveChannelSetGracePeriodSecondsSpecified { get; set; }

    }
}
