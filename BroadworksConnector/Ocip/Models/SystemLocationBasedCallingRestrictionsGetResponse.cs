using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLocationBasedCallingRestrictionsGetRequest.
    /// 
    /// Replaced by: SystemLocationBasedCallingRestrictionsGetResponse17sp3
    /// <see cref="SystemLocationBasedCallingRestrictionsGetRequest"/>
    /// <see cref="SystemLocationBasedCallingRestrictionsGetResponse17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27518""}]")]
    public class SystemLocationBasedCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

        [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27518")]
        public BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator PhysicalLocationIndicator
        {
            get => _physicalLocationIndicator;
            set
            {
                PhysicalLocationIndicatorSpecified = true;
                _physicalLocationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationIndicatorSpecified { get; set; }

        private bool _enforceMscValidation;

        [XmlElement(ElementName = "enforceMscValidation", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27518")]
        public bool EnforceMscValidation
        {
            get => _enforceMscValidation;
            set
            {
                EnforceMscValidationSpecified = true;
                _enforceMscValidation = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceMscValidationSpecified { get; set; }

        private bool _enableOfficeZoneAnnouncement;

        [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27518")]
        public bool EnableOfficeZoneAnnouncement
        {
            get => _enableOfficeZoneAnnouncement;
            set
            {
                EnableOfficeZoneAnnouncementSpecified = true;
                _enableOfficeZoneAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableOfficeZoneAnnouncementSpecified { get; set; }

    }
}
