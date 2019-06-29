using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPrivacyGetRequest13mp17.  The
    /// permittedMonitorUserIdTable contains the members of
    /// the enterprise or group allowed to monitor the phone
    /// status of the user specified in the request.  Members
    /// of this table are allowed to monitor the user even if
    /// enablePhoneStatusPrivacy is set to true.  The table
    /// contains column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "IMP Id".
    /// <see cref="UserPrivacyGetRequest13mp17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b87b6355d5858fdbeb8c1eb05dc1651a:167""}]")]
    public class UserPrivacyGetResponse13mp17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:167")]
        public bool EnableDirectoryPrivacy
        {
            get => _enableDirectoryPrivacy;
            set
            {
                EnableDirectoryPrivacySpecified = true;
                _enableDirectoryPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDirectoryPrivacySpecified { get; set; }

        private bool _enableAutoAttendantExtensionDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:167")]
        public bool EnableAutoAttendantExtensionDialingPrivacy
        {
            get => _enableAutoAttendantExtensionDialingPrivacy;
            set
            {
                EnableAutoAttendantExtensionDialingPrivacySpecified = true;
                _enableAutoAttendantExtensionDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoAttendantExtensionDialingPrivacySpecified { get; set; }

        private bool _enableAutoAttendantNameDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:167")]
        public bool EnableAutoAttendantNameDialingPrivacy
        {
            get => _enableAutoAttendantNameDialingPrivacy;
            set
            {
                EnableAutoAttendantNameDialingPrivacySpecified = true;
                _enableAutoAttendantNameDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoAttendantNameDialingPrivacySpecified { get; set; }

        private bool _enablePhoneStatusPrivacy;

        [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:167")]
        public bool EnablePhoneStatusPrivacy
        {
            get => _enablePhoneStatusPrivacy;
            set
            {
                EnablePhoneStatusPrivacySpecified = true;
                _enablePhoneStatusPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool EnablePhoneStatusPrivacySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _permittedMonitorUserIdTable;

        [XmlElement(ElementName = "permittedMonitorUserIdTable", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:167")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PermittedMonitorUserIdTable
        {
            get => _permittedMonitorUserIdTable;
            set
            {
                PermittedMonitorUserIdTableSpecified = true;
                _permittedMonitorUserIdTable = value;
            }
        }

        [XmlIgnore]
        protected bool PermittedMonitorUserIdTableSpecified { get; set; }

    }
}
