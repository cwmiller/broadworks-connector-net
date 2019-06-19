using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNetworkClassOfServiceGetListRequest.
    /// The response contains a table of all Network Classes of Service
    /// in the system. The column headings are "Name" and "Description"
    /// <see cref="SystemNetworkClassOfServiceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11431""}]")]
    public class SystemNetworkClassOfServiceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

        [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11431")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable
        {
            get => _networkClassOfServiceTable;
            set
            {
                NetworkClassOfServiceTableSpecified = true;
                _networkClassOfServiceTable = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceTableSpecified { get; set; }

    }
}
