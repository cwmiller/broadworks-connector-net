using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserRouteListGetRequest24.
    /// Contains the route list setting and a list of assigned number ranges and number prefixes.
    /// The column headings for assignedNumberRangeTable are "Number Range Start", "Number Range End", "Is Active" and “Extension Length”.
    /// The column headings for assignedNumberPrefixTable are "Number Prefix" ","Is Active", “Extension Range Start” and “Extension Range End”.
    /// <see cref="UserRouteListGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:837""}]")]
    public class UserRouteListGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _treatOriginationsAndPBXRedirectionsAsScreened;

        [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public bool TreatOriginationsAndPBXRedirectionsAsScreened
        {
            get => _treatOriginationsAndPBXRedirectionsAsScreened;
            set
            {
                TreatOriginationsAndPBXRedirectionsAsScreenedSpecified = true;
                _treatOriginationsAndPBXRedirectionsAsScreened = value;
            }
        }

        [XmlIgnore]
        protected bool TreatOriginationsAndPBXRedirectionsAsScreenedSpecified { get; set; }

        protected bool _useRouteListIdentityForNonEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public bool UseRouteListIdentityForNonEmergencyCalls
        {
            get => _useRouteListIdentityForNonEmergencyCalls;
            set
            {
                UseRouteListIdentityForNonEmergencyCallsSpecified = true;
                _useRouteListIdentityForNonEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseRouteListIdentityForNonEmergencyCallsSpecified { get; set; }

        protected bool _useRouteListIdentityForEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public bool UseRouteListIdentityForEmergencyCalls
        {
            get => _useRouteListIdentityForEmergencyCalls;
            set
            {
                UseRouteListIdentityForEmergencyCallsSpecified = true;
                _useRouteListIdentityForEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseRouteListIdentityForEmergencyCallsSpecified { get; set; }

        protected bool _ignoreCallingNameForCallProcessing;

        [XmlElement(ElementName = "ignoreCallingNameForCallProcessing", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public bool IgnoreCallingNameForCallProcessing
        {
            get => _ignoreCallingNameForCallProcessing;
            set
            {
                IgnoreCallingNameForCallProcessingSpecified = true;
                _ignoreCallingNameForCallProcessing = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreCallingNameForCallProcessingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assignedNumberRangeTable;

        [XmlElement(ElementName = "assignedNumberRangeTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AssignedNumberRangeTable
        {
            get => _assignedNumberRangeTable;
            set
            {
                AssignedNumberRangeTableSpecified = true;
                _assignedNumberRangeTable = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedNumberRangeTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assignedNumberPrefixTable;

        [XmlElement(ElementName = "assignedNumberPrefixTable", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:837")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AssignedNumberPrefixTable
        {
            get => _assignedNumberPrefixTable;
            set
            {
                AssignedNumberPrefixTableSpecified = true;
                _assignedNumberPrefixTable = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedNumberPrefixTableSpecified { get; set; }

    }
}
