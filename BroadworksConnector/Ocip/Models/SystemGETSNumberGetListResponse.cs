using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSNumberGetListRequest.
    /// The table columns are: "Number", "Type" and "Description".
    /// <see cref="SystemGETSNumberGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10940""}]")]
    public class SystemGETSNumberGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _reservedNumberTable;

        [XmlElement(ElementName = "reservedNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10940")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReservedNumberTable
        {
            get => _reservedNumberTable;
            set
            {
                ReservedNumberTableSpecified = true;
                _reservedNumberTable = value;
            }
        }

        [XmlIgnore]
        protected bool ReservedNumberTableSpecified { get; set; }

    }
}
