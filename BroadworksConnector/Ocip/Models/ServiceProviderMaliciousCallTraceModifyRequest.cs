using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider's Malicious Call Trace settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0da7c658f240cdc10c3f9cb328db57d8:80""}]")]
    public class ServiceProviderMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:80")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private bool _useSystemPlayMCTWarningAnnouncement;

        [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:80")]
        public bool UseSystemPlayMCTWarningAnnouncement
        {
            get => _useSystemPlayMCTWarningAnnouncement;
            set
            {
                UseSystemPlayMCTWarningAnnouncementSpecified = true;
                _useSystemPlayMCTWarningAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool UseSystemPlayMCTWarningAnnouncementSpecified { get; set; }

        private bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:80")]
        public bool PlayMCTWarningAnnouncement
        {
            get => _playMCTWarningAnnouncement;
            set
            {
                PlayMCTWarningAnnouncementSpecified = true;
                _playMCTWarningAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool PlayMCTWarningAnnouncementSpecified { get; set; }

    }
}
