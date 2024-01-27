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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28016""}]")]
    public class SystemLocationBasedCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

        [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28016")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:28016")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:28016")]
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
