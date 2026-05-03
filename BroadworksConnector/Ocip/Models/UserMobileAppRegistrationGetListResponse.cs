using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMobileAppRegistrationGetListRequest. The response contains a table with all the registrations
    /// per user or with only one row if the request is for a specific registration.  The table column headings are:
    /// "Registration ID", "Application ID", "Application Version", "Device Identifier", "Device OS Type", "Notification Mechanism", "Expiration Date".
    /// 
    /// Expiration Date uses the format "yyyy-MM-dd'T'HH:mm:ss.SSSZ" in the time zone of the requested user.
    /// Example: 2010-10-01T09:30:00:000-0400.
    /// <see cref="UserMobileAppRegistrationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2567""}]")]
    public class UserMobileAppRegistrationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2567")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mobileAppRegistrationTable;

        [XmlElement(ElementName = "mobileAppRegistrationTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2567")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileAppRegistrationTable
        {
            get => _mobileAppRegistrationTable;
            set
            {
                MobileAppRegistrationTableSpecified = true;
                _mobileAppRegistrationTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileAppRegistrationTableSpecified { get; set; }

    }
}
