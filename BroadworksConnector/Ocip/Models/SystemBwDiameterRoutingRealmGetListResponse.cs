using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 4 column table with column headings 'Instance', 'Realm', 'ApplicationID', and 'Default'.  One row is present for each Diameter routing realm.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2986""}]")]
    public class SystemBwDiameterRoutingRealmGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _routingRealmTable;

        [XmlElement(ElementName = "routingRealmTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2986")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutingRealmTable
        {
            get => _routingRealmTable;
            set
            {
                RoutingRealmTableSpecified = true;
                _routingRealmTable = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingRealmTableSpecified { get; set; }

    }
}
