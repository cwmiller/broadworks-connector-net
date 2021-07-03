using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the
    /// EnterpriseBroadWorksMobileManagerGetHomeZoneListRequest.
    /// Contains a table with column headings:
    /// "Home Zone Id", "Domain Name", "Mobile Country Code",
    /// "Mobile Network Code", "Local Area Code" and "Cell Identity".
    /// <see cref="EnterpriseBroadWorksMobileManagerGetHomeZoneListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:258""}]")]
    public class EnterpriseBroadWorksMobileManagerGetHomeZoneListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _homeZonesTable;

        [XmlElement(ElementName = "homeZonesTable", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:258")]
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
