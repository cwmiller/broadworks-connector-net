using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneCallingRestrictionsZoneGetListRequest.
    /// Contains a table of all the zones in the system. The column headings are "Zone Name" , "Physical Location".
    /// Replaced by: SystemZoneGetListResponse
    /// <see cref="SystemZoneCallingRestrictionsZoneGetListRequest"/>
    /// <see cref="SystemZoneGetListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39252""}]")]
    public class SystemZoneCallingRestrictionsZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _zoneTable;

        [XmlElement(ElementName = "zoneTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39252")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ZoneTable
        {
            get => _zoneTable;
            set
            {
                ZoneTableSpecified = true;
                _zoneTable = value;
            }
        }

        [XmlIgnore]
        protected bool ZoneTableSpecified { get; set; }

    }
}
