using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGetRegistrationContactListRequest. The table columns are: "Service Provider Id", "Group Id", "User Id", "Line/Port",
    /// "Endpoint Type", "Order", "URI", "Expiration", "Contact", "Device Level", "Device Name", "Public Net Address",
    /// "Public Port", "Private Net Address", "Private Port", "User Agent", "Reseller Id".
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemGetRegistrationContactListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27526""}]")]
    public class SystemGetRegistrationContactListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _registrationTable;

        [XmlElement(ElementName = "registrationTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27526")]
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
