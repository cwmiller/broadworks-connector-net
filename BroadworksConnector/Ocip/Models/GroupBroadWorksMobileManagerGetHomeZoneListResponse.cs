using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupBroadWorksMobileManagerGetHomeZoneListRequest.
    /// Contains a table with column headings:
    /// "Home Zone Id", "Domain Name", "Mobile Country Code",
    /// "Mobile Network Code", "Local Area Code" and "Cell Identity".
    /// <see cref="GroupBroadWorksMobileManagerGetHomeZoneListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:2367""}]")]
    public class GroupBroadWorksMobileManagerGetHomeZoneListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _homeZonesTable;

        [XmlElement(ElementName = "homeZonesTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:2367")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HomeZonesTable
        {
            get => _homeZonesTable;
            set
            {
                HomeZonesTableSpecified = true;
                _homeZonesTable = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZonesTableSpecified { get; set; }

    }
}
