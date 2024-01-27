using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMccMncHomeNetworkGetListRequest.
    /// The table column is: "Home Networks".
    /// <see cref="SystemMccMncHomeNetworkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4489f4baeefa41b8df0a86def4c05cd8:147""}]")]
    public class SystemMccMncHomeNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _homeNetworksTable;

        [XmlElement(ElementName = "homeNetworksTable", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:147")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HomeNetworksTable
        {
            get => _homeNetworksTable;
            set
            {
                HomeNetworksTableSpecified = true;
                _homeNetworksTable = value;
            }
        }

        [XmlIgnore]
        protected bool HomeNetworksTableSpecified { get; set; }

    }
}
