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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:80""}]")]
    public class ServiceProviderMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:80")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected bool _useSystemPlayMCTWarningAnnouncement;

        [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:80")]
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
        protected bool UseSystemPlayMCTWarningAnnouncementSpecified { get; set; }

        protected bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:80")]
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
        protected bool PlayMCTWarningAnnouncementSpecified { get; set; }

    }
}
