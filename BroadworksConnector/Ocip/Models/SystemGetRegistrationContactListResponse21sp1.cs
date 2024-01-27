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
    /// "Public Port", "Private Net Address", "Private Port", "User Agent", "Reseller Id", "Path Header".
    /// The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
    /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="SystemGetRegistrationContactListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10881""}]")]
    public class SystemGetRegistrationContactListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _registrationTable;

        [XmlElement(ElementName = "registrationTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10881")]
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
