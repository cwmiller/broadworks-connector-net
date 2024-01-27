using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPushNotificationRegistrationGetListRequest.
    /// 
    /// A registration has more than one row in the response when the registration includes more than one token.
    /// 
    /// Registration Date uses the format "yyyy-MM-dd'T'HH:mm:ss.SSSZ" in the time zone of the requested user.
    /// Example: 2010-10-01T09:30:00:000-0400.
    /// 
    /// Contains a table with a row for each registration and token with column headings :
    /// "User Id",  "Registration Id",  "Application Id",  "Application Version",  "Device Os Type",
    /// "Device Os Version",  "Registration Date",  "Token",  "Events"
    /// 
    /// Replaced by: UserPushNotificationRegistrationGetListResponse21sp1
    /// <see cref="UserPushNotificationRegistrationGetListRequest"/>
    /// <see cref="UserPushNotificationRegistrationGetListResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:46490""}]")]
    public class UserPushNotificationRegistrationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _registrationsTable;

        [XmlElement(ElementName = "registrationsTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:46490")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RegistrationsTable
        {
            get => _registrationsTable;
            set
            {
                RegistrationsTableSpecified = true;
                _registrationsTable = value;
            }
        }

        [XmlIgnore]
        protected bool RegistrationsTableSpecified { get; set; }

    }
}
