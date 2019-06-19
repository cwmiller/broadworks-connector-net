using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSReservedFeatureAccessCodeGetListRequest.
    /// The table columns are: "Code" and "Description".
    /// <see cref="SystemGETSReservedFeatureAccessCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9981""}]")]
    public class SystemGETSReservedFeatureAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _reservedCodeTable;

        [XmlElement(ElementName = "reservedCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9981")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReservedCodeTable
        {
            get => _reservedCodeTable;
            set
            {
                ReservedCodeTableSpecified = true;
                _reservedCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool ReservedCodeTableSpecified { get; set; }

    }
}
