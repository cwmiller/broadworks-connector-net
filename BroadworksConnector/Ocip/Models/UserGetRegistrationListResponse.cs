using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetRegistrationListRequest.
    /// 
    /// The registrationTable table column headings are:
    /// "Device Level", "Device Name", "Order", "URI", "Expiration", "Line/Port", "Endpoint Type", "Public Net Address", "Public Port", "Private Net Address", "Private Port", "User Agent", "Lockout Started", "Lockout Expires", "Lockout Count", "Access Info",
    /// "Private Identity", "SIP Instance ID", "Supports Only CS Media", "Feature Parameters", "Supports Voice Over PS", "Path Header", "Registration Active"
    /// The following columns are only used in AS and Amplify data modes:
    /// "Order", "Public Net Address", "Public Port", "Private Net Address", "Private Port", "Lockout Started", "Lockout Expires", "Lockout Count", "Path Header".
    /// The following columns are only used in XS data mode:
    /// "Private Identity", "SIP Instance ID", "Supports Only CS Media", "Feature Parameters", "Supports Voice Over PS".
    /// The following columns are only used in AS data mode:
    /// "Registration Active".
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// The expiration column will be empty when the registration is static. In XS data mode, its value will be 0 when the registration is dynamic regardless of the registration's actual expiration date.
    /// The Endpoint Type column contains one of the enumerated EndpointType values.
    /// The Endpoint Type is empty when the registration is against a TELURI.
    /// The table is sorted by: telURI (after SIPURI), Line/Port, static (after dynamic), order.
    /// Lockout times are shown in GMT offset. When a permanent lockout is shown, the "Lockout Expires" column is empty and the "Lockout Count" column contains the word Permanent.
    /// <see cref="UserGetRegistrationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2104""}]")]
    public class UserGetRegistrationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _registrationTable;

        [XmlElement(ElementName = "registrationTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2104")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RegistrationTable
        {
            get => _registrationTable;
            set
            {
                RegistrationTableSpecified = true;
                _registrationTable = value;
            }
        }

        [XmlIgnore]
        protected bool RegistrationTableSpecified { get; set; }

    }
}
