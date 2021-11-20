using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system level Location Based Calling Restriction attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7770900887d4397dd29272c7b9c55bc4:75""}]")]
    public class SystemLocationBasedCallingRestrictionsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

        [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:75")]
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
        [Optional]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:75")]
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
        [Optional]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:75")]
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

        private bool _enhanceOfficeZone;

        [XmlElement(ElementName = "enhanceOfficeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:75")]
        public bool EnhanceOfficeZone
        {
            get => _enhanceOfficeZone;
            set
            {
                EnhanceOfficeZoneSpecified = true;
                _enhanceOfficeZone = value;
            }
        }

        [XmlIgnore]
        protected bool EnhanceOfficeZoneSpecified { get; set; }

    }
}
