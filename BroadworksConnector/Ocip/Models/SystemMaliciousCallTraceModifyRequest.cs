using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Malicious Call Trace system parameter.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:136""}]")]
    public class SystemMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:136")]
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
