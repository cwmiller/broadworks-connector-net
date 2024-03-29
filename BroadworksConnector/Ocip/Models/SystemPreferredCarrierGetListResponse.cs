using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemPreferredCarrierGetListRequest. Contains a table with one row per carrier.
    /// The table columns are: "Carrier", "Country Code", "CIC", "Is Intra-Lata", "Is Inter-Lata", "Is International".
    /// The value in the "Is Intra-Lata", "Is Inter-Lata", and "Is International" columns is one of "true" or "false".
    /// <see cref="SystemPreferredCarrierGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:416""}]")]
    public class SystemPreferredCarrierGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _systemCarrierTable;

        [XmlElement(ElementName = "systemCarrierTable", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:416")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemCarrierTable
        {
            get => _systemCarrierTable;
            set
            {
                SystemCarrierTableSpecified = true;
                _systemCarrierTable = value;
            }
        }

        [XmlIgnore]
        protected bool SystemCarrierTableSpecified { get; set; }

    }
}
