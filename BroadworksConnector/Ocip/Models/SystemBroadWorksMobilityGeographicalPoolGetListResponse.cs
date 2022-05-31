using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemBroadWorksMobilityGeographicalPoolGetListRequest.
    /// Contains a table with column headings: “Pool”, "Country Code", "Is Default", “Description”.
    /// <see cref="SystemBroadWorksMobilityGeographicalPoolGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:795""}]")]
    public class SystemBroadWorksMobilityGeographicalPoolGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _geographicalPoolTable;

        [XmlElement(ElementName = "geographicalPoolTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:795")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GeographicalPoolTable
        {
            get => _geographicalPoolTable;
            set
            {
                GeographicalPoolTableSpecified = true;
                _geographicalPoolTable = value;
            }
        }

        [XmlIgnore]
        protected bool GeographicalPoolTableSpecified { get; set; }

    }
}
