using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Allows or disallows various types of incoming calls for a user or group -- not any particular department.
    /// For use when modifing settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3dd296d55b56269ae23d86a934b8b35c:211""}]")]
    public class IncomingCallingPlanPermissionsModify
    {

        private bool _allowFromWithinGroup;

        [XmlElement(ElementName = "allowFromWithinGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:211")]
        public bool AllowFromWithinGroup
        {
            get => _allowFromWithinGroup;
            set
            {
                AllowFromWithinGroupSpecified = true;
                _allowFromWithinGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AllowFromWithinGroupSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission _allowFromOutsideGroup;

        [XmlElement(ElementName = "allowFromOutsideGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:211")]
        public BroadWorksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission AllowFromOutsideGroup
        {
            get => _allowFromOutsideGroup;
            set
            {
                AllowFromOutsideGroupSpecified = true;
                _allowFromOutsideGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AllowFromOutsideGroupSpecified { get; set; }

        private bool _allowCollectCalls;

        [XmlElement(ElementName = "allowCollectCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:211")]
        public bool AllowCollectCalls
        {
            get => _allowCollectCalls;
            set
            {
                AllowCollectCallsSpecified = true;
                _allowCollectCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCollectCallsSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> _digitPatternPermission = new List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission>();

        [XmlElement(ElementName = "digitPatternPermission", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3dd296d55b56269ae23d86a934b8b35c:211")]
        public List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> DigitPatternPermission
        {
            get => _digitPatternPermission;
            set
            {
                DigitPatternPermissionSpecified = true;
                _digitPatternPermission = value;
            }
        }

        [XmlIgnore]
        protected bool DigitPatternPermissionSpecified { get; set; }

    }
}
