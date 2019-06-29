using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRoutingGetTranslationListRequest. The column headings are "Routing Digits"
    /// and "Route".
    /// <see cref="SystemRoutingGetTranslationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14321""}]")]
    public class SystemRoutingGetTranslationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _routingTable;

        [XmlElement(ElementName = "routingTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14321")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutingTable
        {
            get => _routingTable;
            set
            {
                RoutingTableSpecified = true;
                _routingTable = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingTableSpecified { get; set; }

    }
}
