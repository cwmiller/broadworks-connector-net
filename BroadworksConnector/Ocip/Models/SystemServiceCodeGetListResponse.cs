using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemServiceCodeGetListRequest.
    /// Contains a table of defined service codes
    /// The column headings are: "Service Code", and "Description".
    /// <see cref="SystemServiceCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14984""}]")]
    public class SystemServiceCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceCodeTable;

        [XmlElement(ElementName = "serviceCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14984")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceCodeTable
        {
            get => _serviceCodeTable;
            set
            {
                ServiceCodeTableSpecified = true;
                _serviceCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceCodeTableSpecified { get; set; }

    }
}
