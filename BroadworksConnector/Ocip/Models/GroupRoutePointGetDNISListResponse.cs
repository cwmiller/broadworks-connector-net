using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointGetDNISListRequest.
    /// Contains a table with column headings: "Name", "Phone Number", "Extension".
    /// <see cref="GroupRoutePointGetDNISListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e474d11df9a1d1d1041e589793e40de8:468""}]")]
    public class GroupRoutePointGetDNISListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _displayDNISNumber;

        [XmlElement(ElementName = "displayDNISNumber", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:468")]
        public bool DisplayDNISNumber
        {
            get => _displayDNISNumber;
            set
            {
                DisplayDNISNumberSpecified = true;
                _displayDNISNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayDNISNumberSpecified { get; set; }

        protected bool _displayDNISName;

        [XmlElement(ElementName = "displayDNISName", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:468")]
        public bool DisplayDNISName
        {
            get => _displayDNISName;
            set
            {
                DisplayDNISNameSpecified = true;
                _displayDNISName = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayDNISNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnisTable;

        [XmlElement(ElementName = "dnisTable", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:468")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnisTable
        {
            get => _dnisTable;
            set
            {
                DnisTableSpecified = true;
                _dnisTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnisTableSpecified { get; set; }

    }
}
