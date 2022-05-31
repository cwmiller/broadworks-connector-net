using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLocationBasedCallingRestrictionsGetRequest17sp3.
    /// <see cref="SystemLocationBasedCallingRestrictionsGetRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7770900887d4397dd29272c7b9c55bc4:56""}]")]
    public class SystemLocationBasedCallingRestrictionsGetResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

        [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:56")]
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

        protected bool _enforceMscValidation;

        [XmlElement(ElementName = "enforceMscValidation", IsNullable = false, Namespace = "")]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:56")]
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

        protected bool _enableOfficeZoneAnnouncement;

        [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:56")]
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

        protected bool _enhanceOfficeZone;

        [XmlElement(ElementName = "enhanceOfficeZone", IsNullable = false, Namespace = "")]
        [Group(@"7770900887d4397dd29272c7b9c55bc4:56")]
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
