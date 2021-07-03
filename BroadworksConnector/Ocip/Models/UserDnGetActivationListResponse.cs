using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDnGetActivationListRequest.
    /// The response contains a table with columns: "Phone Number", and "Activated".
    /// The "Phone Number" column contains a single DN.
    /// The "Activated" column indicates if the phone number is activated or not.
    /// <see cref="UserDnGetActivationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1706""}]")]
    public class UserDnGetActivationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1706")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnTableSpecified { get; set; }

    }
}
