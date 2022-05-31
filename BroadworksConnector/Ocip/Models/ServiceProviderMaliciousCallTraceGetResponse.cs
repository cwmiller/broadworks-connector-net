using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderMaliciousCallTraceGetRequest.
    /// The response contains the service provider Malicious Call Trace
    /// settings.
    /// <see cref="ServiceProviderMaliciousCallTraceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0da7c658f240cdc10c3f9cb328db57d8:63""}]")]
    public class ServiceProviderMaliciousCallTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useSystemPlayMCTWarningAnnouncement;

        [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:63")]
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
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:63")]
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
