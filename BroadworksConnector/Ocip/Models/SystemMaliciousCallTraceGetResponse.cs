using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemMaliciousCallTraceGetRequest.
    /// The response contains the Malicious Call Trace system parameters and the list of users
    /// that use the Malicious Call Trace feature.
    /// 
    /// The column headings are "Service Provider Id",
    /// "Group Id", "User Id", "Last Name", "First Name", "Phone Number", "Trace Type", "Status",
    /// "Hiragana Last Name" and "Hiragana First Name", "Extension", "Department", "Email Address".
    /// <see cref="SystemMaliciousCallTraceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:119""}]")]
    public class SystemMaliciousCallTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playMCTWarningAnnouncement;

        [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:119")]
        public bool PlayMCTWarningAnnouncement
        {
            get => _playMCTWarningAnnouncement;
            set
            {
                PlayMCTWarningAnnouncementSpecified = true;
                _playMCTWarningAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMCTWarningAnnouncementSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:119")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}
