using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Allows or disallows various types of incoming calls for a specified department.
    /// For use when modifing settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""22e19489d2787693c01f531be4452169:169""}]")]
    public class IncomingCallingPlanDepartmentPermissionsModify
    {

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"22e19489d2787693c01f531be4452169:169")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentKeySpecified { get; set; }

        protected bool _allowFromWithinGroup;

        [XmlElement(ElementName = "allowFromWithinGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22e19489d2787693c01f531be4452169:169")]
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

        protected BroadWorksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission _allowFromOutsideGroup;

        [XmlElement(ElementName = "allowFromOutsideGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22e19489d2787693c01f531be4452169:169")]
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

        protected bool _allowCollectCalls;

        [XmlElement(ElementName = "allowCollectCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22e19489d2787693c01f531be4452169:169")]
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

        protected List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> _digitPatternPermission = new List<BroadWorksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission>();

        [XmlElement(ElementName = "digitPatternPermission", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"22e19489d2787693c01f531be4452169:169")]
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
