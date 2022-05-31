using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAttendantConsoleGetRequest.
    /// <see cref="UserAttendantConsoleGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39558""}]")]
    public class UserAttendantConsoleGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _launchOnLogin;

        [XmlElement(ElementName = "launchOnLogin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39558")]
        public bool LaunchOnLogin
        {
            get => _launchOnLogin;
            set
            {
                LaunchOnLoginSpecified = true;
                _launchOnLogin = value;
            }
        }

        [XmlIgnore]
        protected bool LaunchOnLoginSpecified { get; set; }

        protected bool _allowUserConfigCallDetails;

        [XmlElement(ElementName = "allowUserConfigCallDetails", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39558")]
        public bool AllowUserConfigCallDetails
        {
            get => _allowUserConfigCallDetails;
            set
            {
                AllowUserConfigCallDetailsSpecified = true;
                _allowUserConfigCallDetails = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUserConfigCallDetailsSpecified { get; set; }

        protected bool _allowUserViewCallDetails;

        [XmlElement(ElementName = "allowUserViewCallDetails", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39558")]
        public bool AllowUserViewCallDetails
        {
            get => _allowUserViewCallDetails;
            set
            {
                AllowUserViewCallDetailsSpecified = true;
                _allowUserViewCallDetails = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUserViewCallDetailsSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AttendantConsoleDisplayColumn> _displayColumn = new List<BroadWorksConnector.Ocip.Models.AttendantConsoleDisplayColumn>();

        [XmlElement(ElementName = "displayColumn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39558")]
        public List<BroadWorksConnector.Ocip.Models.AttendantConsoleDisplayColumn> DisplayColumn
        {
            get => _displayColumn;
            set
            {
                DisplayColumnSpecified = true;
                _displayColumn = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayColumnSpecified { get; set; }

    }
}
