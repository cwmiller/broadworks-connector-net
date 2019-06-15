using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAttendantConsoleGetRequest.
        /// <see cref="UserAttendantConsoleGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAttendantConsoleGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _launchOnLogin;

        [XmlElement(ElementName = "launchOnLogin", IsNullable = false, Namespace = "")]
        public bool LaunchOnLogin {
            get => _launchOnLogin;
            set {
                LaunchOnLoginSpecified = true;
                _launchOnLogin = value;
            }
        }

        [XmlIgnore]
        public bool LaunchOnLoginSpecified { get; set; }
        
        private bool _allowUserConfigCallDetails;

        [XmlElement(ElementName = "allowUserConfigCallDetails", IsNullable = false, Namespace = "")]
        public bool AllowUserConfigCallDetails {
            get => _allowUserConfigCallDetails;
            set {
                AllowUserConfigCallDetailsSpecified = true;
                _allowUserConfigCallDetails = value;
            }
        }

        [XmlIgnore]
        public bool AllowUserConfigCallDetailsSpecified { get; set; }
        
        private bool _allowUserViewCallDetails;

        [XmlElement(ElementName = "allowUserViewCallDetails", IsNullable = false, Namespace = "")]
        public bool AllowUserViewCallDetails {
            get => _allowUserViewCallDetails;
            set {
                AllowUserViewCallDetailsSpecified = true;
                _allowUserViewCallDetails = value;
            }
        }

        [XmlIgnore]
        public bool AllowUserViewCallDetailsSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.AttendantConsoleDisplayColumn> _displayColumn;

        [XmlElement(ElementName = "displayColumn", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AttendantConsoleDisplayColumn> DisplayColumn {
            get => _displayColumn;
            set {
                DisplayColumnSpecified = true;
                _displayColumn = value;
            }
        }

        [XmlIgnore]
        public bool DisplayColumnSpecified { get; set; }
        
    }
}
