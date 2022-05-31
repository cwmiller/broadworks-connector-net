using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMDIMessageDeskGetServerRouteListRequest.
    /// The SMDI Server route table column headings are: "Destination" and "SMDI Servers".
    /// <see cref="SystemSMDIMessageDeskGetServerRouteListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:164""}]")]
    public class SystemSMDIMessageDeskGetServerRouteListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _smdiServerRouteTable;

        [XmlElement(ElementName = "smdiServerRouteTable", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:164")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SmdiServerRouteTable
        {
            get => _smdiServerRouteTable;
            set
            {
                SmdiServerRouteTableSpecified = true;
                _smdiServerRouteTable = value;
            }
        }

        [XmlIgnore]
        protected bool SmdiServerRouteTableSpecified { get; set; }

    }
}
